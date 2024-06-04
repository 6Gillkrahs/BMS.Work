using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.MultiTenancy;

namespace BMS.Work.Menus
{
    public class Menu : Entity<Guid> ,IMultiTenant
    {
        public string? RouterLink { get; set; }
        public string? Url { get; set; }
        public string Label { get; set; }
        public int? Order { get; set; }
        public string? Iconclass { get; set; }
        public string? RequiredPolicy { get; set; }
        public string? Layout { get; set; }
        public Guid? ParentId { get; set; }
        public bool IsGroup { get; set; }
        public Guid? TenantId { get; set; }
        public string ClientId { get; set; }
    }
}
