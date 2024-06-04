using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Guids;

namespace BMS.Work.Menus
{
    public class MenuDataSeedContribute : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Menu,Guid> _menuRepository;
        private readonly IGuidGenerator _guidGenerator;

        public MenuDataSeedContribute(IRepository<Menu, Guid> menuRepository, IGuidGenerator guidGenerator)
        {
            _menuRepository = menuRepository;
            _guidGenerator = guidGenerator;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(await _menuRepository.GetCountAsync() > 0)
            {
                return;
            }
            var menu = await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                IsGroup = true,
                Label = "Menu",
                Order = 1
            });

            await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                Iconclass = "pi pi-arrows-alt",
                IsGroup = false,
                Label = "Quản lí menu",
                Order = 1,
                RouterLink = "/menu-management",
                ParentId = menu.Id
            });

            // Dashboard
            var dashboard = await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                IsGroup = true,
                Label = "Bàn làm việc",
                Order = 2
            });

            await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                Iconclass = "pi pi-calendar",
                IsGroup = false,
                Label = "Lịch",
                Order = 1,
                RouterLink = "/dashboard/calendar",
                ParentId = dashboard.Id
            });

            //

            // Project Management
            var projectManagement = await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                IsGroup = true,
                Label = "Quản lý phòng ban / dự án",
                Order = 3
            });

            await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                Iconclass = "pi pi-box",
                IsGroup = false,
                Label = "Quản lý phòng ban",
                Order = 1,
                RouterLink = "/project-management/department",
                ParentId = projectManagement.Id
            });

            await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                Iconclass = "pi pi-box",
                IsGroup = false,
                Label = "Quản lý dự án",
                Order = 2,
                RouterLink = "/project-management/project",
                ParentId = projectManagement.Id
            });

            await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                Iconclass = "pi pi-box",
                IsGroup = false,
                Label = "Vai trò dự án",
                Order = 3,
                RouterLink = "/project-management/project-role",
                ParentId = projectManagement.Id
            });

            await _menuRepository.InsertAsync(new Menu()
            {
                ClientId = "Work_App",
                Iconclass = "pi pi-box",
                IsGroup = false,
                Label = "Giai đoạn dự án",
                Order = 4,
                RouterLink = "/project-management/project-state",
                ParentId = projectManagement.Id
            });

        }
    }
}
