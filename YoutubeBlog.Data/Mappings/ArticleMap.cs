using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article
                { 
                    Id = Guid.NewGuid(),
                    Title = "Title",
                    Content = "Content",
                    ViewCount = 1,
                    CategoryId = Guid.Parse("F66E52F9-0A94-430B-A949-07A7BE45662A"),
                    ImageId = Guid.Parse("FC736561-06D2-473E-B4C7-FEA7884A488E"),
                    CreatedBy = "Admin test",
                    CreatedDate = DateTime.Now,
                    UserId = Guid.Parse("93005E5F-433A-4D09-9F3E-5702DF10F77B")
                },
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Title2",
                    Content = "Content2",
                    ViewCount = 3,
                    CategoryId = Guid.Parse("C0E72F21-6B53-440B-8470-F001794EF1E5"),
                    ImageId = Guid.Parse("76756DAA-E0EF-4ED8-97CD-A9CBC0A9A50A"),
                    CreatedBy = "Admin test2",
                    CreatedDate = DateTime.Now,
                    UserId = Guid.Parse("A00EDFC0-6709-4167-8990-7E48B2F8CA9E")
                }
            );

        }
    }
}
