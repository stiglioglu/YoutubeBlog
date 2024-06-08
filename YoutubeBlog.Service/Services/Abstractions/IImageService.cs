using YoutubeBlog.Entity.Entities;

namespace YoutubeBlog.Service.Services.Abstractions
{
    public interface IImageService
    {
        Task<Image> GetImageByArticleId(Guid articleId);
    }
}
