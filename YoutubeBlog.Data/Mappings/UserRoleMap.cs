using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("93005E5F-433A-4D09-9F3E-5702DF10F77B"),
                RoleId = Guid.Parse("AC59AF34-7F0B-425D-A431-C934D16CC6D2")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("A00EDFC0-6709-4167-8990-7E48B2F8CA9E"),
                RoleId = Guid.Parse("1A830408-FB65-4EF9-94D2-F73D64FCED13")
            }
            );
        }
    }
}
