using Microsoft.AspNetCore.Http;

namespace DatingService.Service.Interfaces
{
    public interface IFileService
    {
        void Save(IFormFile file, string path);
        void Delete(string path);
    }
}
