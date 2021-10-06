using System.Threading.Tasks;

namespace DatingService.Service.Interfaces
{
    public interface IEmailSender
    {
        Task SendAsync(string name, string email, string subject, string htmlMessage);
    }
}
