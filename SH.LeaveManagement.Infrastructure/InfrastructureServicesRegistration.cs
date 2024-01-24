using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SH.LeaveManagement.Application.Contracts.Infrastructure;
using SH.LeaveManagement.Infrastructure.Mail;
using SH.LeaveManagement.Application.Models;

namespace SH.LeaveManagement.Infrastructure
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailSender, EmailSender>();
            return services;
        }
    }
}
