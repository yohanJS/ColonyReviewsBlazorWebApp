using ColonyReviewsBlazorWebApp.Models;

namespace ColonyReviewsBlazorWebApp.Services
{
    public interface IGetAllBlogsService
    {
        Task LoadDataAsync();
        List<BlogModel> GetData();
    }
}
