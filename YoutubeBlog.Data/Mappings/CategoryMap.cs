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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category
                {
                    Id = Guid.Parse("C0E72F21-6B53-440B-8470-F001794EF1E5"),
                    Name = "name2",
                    CreatedBy = "admin test2",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.Parse("F66E52F9-0A94-430B-A949-07A7BE45662A"),
                    Name = "name",
                    CreatedBy = "admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}
