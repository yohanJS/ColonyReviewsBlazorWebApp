using ColonyReviewsBlazorWebApp.Models;

namespace ColonyReviewsBlazorWebApp.Services
{
    public interface IPublishBlog
    {
        Task CreateBlogAsync(BlogModel blog);
    }
}
