using ColonyReviewsBlazorWebApp.Models;

namespace ColonyReviewsBlazorWebApp.Services
{
    public class PublishBlog : IPublishBlog
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public async Task CreateBlogAsync(BlogModel blog)
        {
            try
            {
                // Send the blog data to the API for creation
                await httpClient.PostAsJsonAsync("https://localhost:7011/BlogPost", blog);
            }
            catch (Exception)
            {
                throw; // Handle the exception as needed
            }
        }
    }
}
