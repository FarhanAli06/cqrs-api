using SH.LeaveManagement.Application.Models;

namespace SH.LeaveManagement.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
