using BuberDinner.Infrastructure.Presistance;

namespace BuberDinner.Infrasturcture;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrasturcture(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettigs>(configuration.GetSection(JwtSettigs.SectionName));
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        #region Repositories

        services.AddScoped<IUserRepository, UserRepository>();

        #endregion Repositories

        return services;
    }
}