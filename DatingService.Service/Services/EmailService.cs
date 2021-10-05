using DatingService.Domain.Options;
using DatingService.Service.Interfaces;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Threading.Tasks;

namespace DatingService.Service.Services
{
    public class EmailService : IEmailService
    {
        private readonly EmailOptions _emailOptions;
        private readonly SmtpOptions _smtpOptions;
        private readonly ILogger<EmailService> _logger;


        public EmailService(EmailOptions emailOptions, SmtpOptions smtpOptions, ILogger<EmailService> logger)
        {
            _emailOptions = emailOptions ?? throw new ArgumentNullException(nameof(emailOptions));
            _smtpOptions = smtpOptions ?? throw new ArgumentNullException(nameof(smtpOptions));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
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
