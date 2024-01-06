using Microsoft.AspNetCore.Http;

namespace ColonyReviewsBlazorWebApp.Services
{
    public interface IImageService
    {
        Task<byte[]> ConvertFileToByteArrayAsync(IFormFile file);
        string ConvertByteArrayToFile(byte[] fileData, string extension);
    }
}
