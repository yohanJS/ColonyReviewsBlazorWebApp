using ColonyReviewsBlazorWebApp.Models;

namespace ColonyReviewsBlazorWebApp.Services
{
    public interface IBlogsService
    {
        Task LoadDataAsync();
        Task PublishData(BlogModel blog);
        List<BlogModel> GetData();
    }
}
