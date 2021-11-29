using DatingService.Domain.Options;
using DatingService.Service.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace DatingService.Service.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailOptions _emailOptions;
        private readonly SmtpOptions _smtpOptions;
        private readonly ILogger<EmailSender> _logger;

        public EmailSender(IOptions<EmailOptions> emailOptions, IOptions<SmtpOptions> smtpOptions, ILogger<EmailSender> logger)
        {
            _emailOptions = emailOptions.Value;
            _smtpOptions = smtpOptions.Value;
            _logger = logger;
        }

        public async Task SendAsync(string name, string email, string subject, string htmlMessage)
        {
            try
            {
                MailMessage message = new MailMessage
                {
                    From = new MailAddress(_emailOptions.Email, _emailOptions.Name),
                    Subject = subject,
                    Body = htmlMessage
                };
                message.To.Add(email);

                using SmtpClient smtpClient = new(_smtpOptions.Host)
                {
                    Credentials = new NetworkCredential(_emailOptions.Email, _emailOptions.Password),
                    Port = _smtpOptions.Port,
                    EnableSsl = _smtpOptions.UseSsl
                };

                await smtpClient.SendMailAsync(message);

            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
        }
    }
}