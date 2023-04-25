namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJWTTokenGenerator _jWTGenerator;

    public AuthenticationService(IJWTTokenGenerator jWTGenerator)
    {
        _jWTGenerator = jWTGenerator;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // Check if user already exists

        // Create user

        // Create JWT Token
        var userId = Guid.NewGuid();
        var token = _jWTGenerator.GenerateToken(userId, firstName, lastName);
        return new AuthenticationResult(
            Guid.NewGuid(),
            firstName,
            lastName,
            email,
            token
            );
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
           Guid.NewGuid(),
           "firstName",
           "lastName",
           email,
           "token"
           );
    }
}