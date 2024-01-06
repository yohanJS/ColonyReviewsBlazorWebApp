using ColonyReviewsBlazorWebApp.Models;
using System.Net.Http.Json;

namespace ColonyReviewsBlazorWebApp.Services
{
    public class GetAllBlogsService : IGetAllBlogsService
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private List<BlogModel>? allBlogs = new List<BlogModel>();
        private string devUrl = "https://localhost:7011/BlogPost";
        private string prdUrl = "https://www.bloggyapi.com/blogpost";

        public List<BlogModel> GetData()
        {
            if (allBlogs == null) 
            {
                return new List<BlogModel>();
            }
            return allBlogs;
        }

        public async Task LoadDataAsync()
        {
            try
            {
                allBlogs = await httpClient.GetFromJsonAsync<List<BlogModel>>(devUrl);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
