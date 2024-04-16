using Erm.Auth;
using Erm.Repositories;
using Erm.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Erm.Services;

public static class ServiceCollectionExtensions
{
    public static void AddMyServices(this IServiceCollection service)
    {
        service.AddScoped<AuthService>();
        service.AddScoped<IRiskService, RiskService>();
        service.AddScoped(typeof(ISQLRepository<>), typeof(SQLRepository<>));
    }
}