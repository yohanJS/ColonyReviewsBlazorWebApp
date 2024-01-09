using ColonyReviewsBlazorWebApp.Models;
using Microsoft.Identity.Client;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;

namespace ColonyReviewsBlazorWebApp.Services
{
    public class BlogsService : IBlogsService
    {
        private static readonly HttpClient httpClient = new HttpClient();

        private readonly IImageService _imageService;

        private List<BlogModel>? allBlogs = new List<BlogModel>();
        private string url = "https://localhost:7011/api/BlogPost";

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
                allBlogs = await httpClient.GetFromJsonAsync<List<BlogModel>>(url);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task PublishData(BlogModel blog)
        {

            // Converting the object to a json string.
            string json = JsonConvert.SerializeObject(blog);

            // Setting up the body of the request
            StringContent data = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                // Process and store images
                if (blog.ImageFile != null)
                {
                    blog.ImageData = _imageService.ConvertFileToByteArrayAsync(blog.ImageFile).Result;
                    blog.ImageType = blog.ImageFile.ContentType;
                }

                var url = "https://localhost:7011/api/BlogPost";
                using var client = new HttpClient();

                var response = await client.PostAsync(url, data);

                // Ensure the request was successful (status code 2xx)
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
