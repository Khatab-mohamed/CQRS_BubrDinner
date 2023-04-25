namespace BuberDinner.Infrasturcture;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrasturcture(this IServiceCollection services)
    {
        services.AddSingleton<IJWTTokenGenerator, JWTTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DateTimeProvider>();

        return services;
    }
}