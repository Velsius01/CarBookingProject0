using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

public class IdentityNoOpEmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        // This is a no-op email sender. It does nothing.
        return Task.CompletedTask;
    }
}
