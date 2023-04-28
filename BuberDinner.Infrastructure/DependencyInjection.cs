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

        return services;
    }
}