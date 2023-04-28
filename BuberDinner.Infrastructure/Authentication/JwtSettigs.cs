namespace BuberDinner.Infrastructure.Authentication;

public class JwtSettigs
{
    public const string SectionName = "JwtSettings";
    public string Secret { get; init; }
    public int ExpiratinInHours { get; init; }
    public string Issuer { get; init; }
    public string Audience { get; init; }
}