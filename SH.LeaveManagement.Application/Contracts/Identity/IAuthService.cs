using SH.LeaveManagement.Application.Models.Identity;

namespace SH.LeaveManagement.Application.Contracts.Identity
{
    public interface IAuthService
    {
        Task<AuthResponse> Login(AuthRequest request);
        Task<RegistrationResponse> Register(RegistrationRequest request);

    }
}
