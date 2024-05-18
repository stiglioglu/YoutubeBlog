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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(
                new Image
                {
                    Id = Guid.Parse("76756DAA-E0EF-4ED8-97CD-A9CBC0A9A50A"),
                    FileName = "image/testimage2",
                    FileType = "jpg",
                    CreatedBy = "admin test2",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                },
                new Image
                {
                    Id = Guid.Parse("FC736561-06D2-473E-B4C7-FEA7884A488E"),
                    FileName = "image/testimage",
                    FileType = "jpg",
                    CreatedBy = "admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
                }
            );
        }
    }
}
