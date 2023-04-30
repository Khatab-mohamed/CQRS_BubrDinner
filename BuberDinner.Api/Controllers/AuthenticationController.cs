using BuberDinner.Api.Filters;
using BuberDinner.Application.Services.Authentication;

namespace BuberDinner.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[ErrorHandlingFilter]
public class AuthenticationController : ControllerBase
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        _authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authenticationResult = _authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        return Ok(authenticationResult);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authenticationResult = _authenticationService.Login(request.Email, request.Password);
        return Ok(authenticationResult);
    }
}