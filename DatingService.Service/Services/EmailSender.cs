using DatingService.Domain.Options;
using DatingService.Service.Interfaces;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Threading.Tasks;

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
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(_emailOptions.Name, _emailOptions.Email));
                message.To.Add(new MailboxAddress(name, email));
                message.Subject = subject;
                message.Body = new TextPart()
                {
                    Text = htmlMessage
                };

                using var client = new SmtpClient();
                await client.ConnectAsync(_smtpOptions.Host, _smtpOptions.Port, _smtpOptions.UseSsl);
                await client.AuthenticateAsync(_emailOptions.Email, _emailOptions.Password);
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
            catch(Exception e)
            {
                _logger.LogError(e.Message);
            }
        }
    }
}
