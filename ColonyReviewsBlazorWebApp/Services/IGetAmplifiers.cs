using ColonyReviewsBlazorWebApp.Models;

namespace ColonyReviewsBlazorWebApp.Services
{
    public interface IGetAmplifiers
    {
        Task LoadDataAsync();
        List<Amplifier> GetData();
    }
}
