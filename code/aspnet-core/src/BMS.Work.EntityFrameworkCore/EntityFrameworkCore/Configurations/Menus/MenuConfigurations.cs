using BMS.Work.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace BMS.Work.EntityFrameworkCore.Configurations.Menus
{
    public class MenuConfigurations : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable(WorkConsts.DbTablePrefix + "Menus");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Label).IsRequired().HasMaxLength(128);
            builder.Property(x => x.RouterLink).HasMaxLength(128);
            builder.Property(x => x.Url).HasMaxLength(128);
            builder.Property(x => x.Iconclass).HasMaxLength(128);
            builder.Property(x => x.RequiredPolicy).HasMaxLength(128);
            builder.Property(x => x.Layout).HasMaxLength(128);
            builder.Property(x => x.ClientId).HasMaxLength(128);
            builder.HasIndex(x => x.TenantId);
            builder.HasIndex(x => x.ParentId);
            builder.HasIndex(x => x.ClientId);
            builder.ConfigureByConvention();
        }
    }
}
