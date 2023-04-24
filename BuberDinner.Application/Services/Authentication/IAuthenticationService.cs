namespace BuberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Register(
        string FirstName,
        string LastName,
        string Email,
        string password);
    AuthenticationResult Login(
        string Email,
        string password);
}
