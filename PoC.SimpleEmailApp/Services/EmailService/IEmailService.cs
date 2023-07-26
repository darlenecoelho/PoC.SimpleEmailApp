using PoC.SimpleEmailApp.Models;

namespace PoC.SimpleEmailApp.Services.EmailService;
public interface IEmailService
{
    void SendEmail(EmailDto request);
}
