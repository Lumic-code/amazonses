using AmazonSESDemo.Models;

namespace AmazonSESDemo.Service
{
    public interface IMailService
    {
        Task SendEmailAsync(MailRequest mailRequest);
    }
}
