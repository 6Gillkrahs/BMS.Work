using BMS.Work.Menus.Dtos;
using BMS.Work.Menus.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Data;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.MultiTenancy;
using Volo.Abp.OpenIddict.Applications;

namespace BMS.Work.Menus
{
    public class MenuAppService : CrudAppService<Menu, MenuDto, Guid, GetListMenuDto, CreateUpdateMenuDto>, IMenuAppService
    {
        private readonly IOpenIddictApplicationRepository _openIddictApplicationRepository;
        private readonly MenuOptions _menuOptions;
        private readonly IDataFilter dataFilter;
        public MenuAppService(
            IRepository<Menu, Guid> repository,
            IOpenIddictApplicationRepository _openIddictApplicationRepository,
            MenuOptions menuOptions,
            IDataFilter dataFilter
            ) : base(repository)
        {
            this._openIddictApplicationRepository = _openIddictApplicationRepository;
            this._menuOptions = menuOptions;
            this.dataFilter = dataFilter;
        }

        public override async Task<MenuDto> CreateAsync(CreateUpdateMenuDto input)
        {
            if(input.ParentId != null)
            {
                var parentItem = await Repository.GetAsync(input.ParentId.Value);
                if(!parentItem.IsGroup)
                {
                    throw new BusinessException();
                }
            }
            var result = await Repository.InsertAsync(ObjectMapper.Map<CreateUpdateMenuDto, Menu>(input));
            return ObjectMapper.Map<Menu, MenuDto>(result);
        }

        public override async Task<PagedResultDto<MenuDto>> GetListAsync(GetListMenuDto input)
        {
            if (!_menuOptions.MultiTenant)
            {
                using(dataFilter.Disable<IMultiTenant>())
                {
                    var menus = await Repository.GetListAsync(x => x.ClientId == input.ClientId);
                    return new PagedResultDto<MenuDto>
                    {
                        Items = ObjectMapper.Map<List<Menu>, List<MenuDto>>(menus),
                        TotalCount = menus.Count
                    };
                }
            }
            else
            {
                var menus = await Repository.GetListAsync(x => x.ClientId == input.ClientId);
                return new PagedResultDto<MenuDto>
                {
                    Items = ObjectMapper.Map<List<Menu>, List<MenuDto>>(menus),
                    TotalCount = menus.Count
                };
            }
        }

        public override async Task DeleteAsync(Guid id)
        {
            var allMenus = await Repository.GetListAsync();
            var menu = allMenus.FirstOrDefault(x => x.Id == id);
            if(menu != null)
            {
                var children = FindChildren(allMenus, id);
                var ids = children.Select(x => x.Id).ToList();
                ids.Add(id);
                await Repository.DeleteManyAsync(ids);
            }
        }

        private List<Menu> FindChildren(List<Menu> allMenus,Guid parentid)
        {
            List<Menu> children = new List<Menu>();
            for(int i = 0;i< allMenus.Count;i++)
            {
                if(allMenus[i].ParentId == parentid)
                {
                    children.Add(allMenus[i]);
                    var grandChildMenu = FindChildren(allMenus, allMenus[i].Id);
                    children.AddRange(grandChildMenu);
                }
            }
            return children;
        }

        public async Task<List<string>> GetListClientId()
        {
            var clients = await _openIddictApplicationRepository.GetListAsync();
            return clients.Select(x => x.ClientId).ToList();
        }
    }
}
