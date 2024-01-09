using ColonyReviewsBlazorWebApp.Models;
using System.Net.Http.Json;

namespace ColonyReviewsBlazorWebApp.Services
{
    public class GetAmplifiers : IGetAmplifiers
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private List<Amplifier>? amplifiers = new List<Amplifier>();
        private string url = "https://localhost:7222/api/Amplifier";

        public List<Amplifier> GetData()
        {
            if (amplifiers == null)
            {
                return new List<Amplifier>();
            }
            return amplifiers;
        }

        public async Task LoadDataAsync()
        {
            try
            {
                amplifiers = await httpClient.GetFromJsonAsync<List<Amplifier>>(url);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
