using AutoMapper;
using BMS.Work.Menus.Dtos;
using BMS.Work.Menus;

namespace BMS.Work;

public class WorkApplicationAutoMapperProfile : Profile
{
    public WorkApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Menu, MenuDto>();
        CreateMap<CreateUpdateMenuDto, Menu>();
    }
}
