using BMS.Work.Menus.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace BMS.Work.Menus.IServices
{
    public interface IMenuAppService:ICrudAppService<MenuDto,Guid,GetListMenuDto,CreateUpdateMenuDto>
    {
        Task<List<string>> GetListClientId();
    }
}
