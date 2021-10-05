using System.Threading.Tasks;

namespace DatingService.Service.Interfaces
{
    public interface IEmailService
    {
        Task SendAsync(string name, string email, string subject, string htmlMessage);
    }
}
