namespace BuberDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jWTGenerator;
    private readonly IUserRepository _userRepository;

    public AuthenticationService(IJwtTokenGenerator jWTGenerator,
        IUserRepository userRepository)
    {
        _jWTGenerator = jWTGenerator;
        _userRepository = userRepository;
    }

    public AuthenticationResult Register(string firstName, string lastName, string email, string password)
    {
        // 1. Validate the User doesn't exist

        if (_userRepository.GetUserByEmail(email) is not null)
            throw new Exception("User with given email already exists");

        // 2. Create User (Generate unique ID) & Presistance to DB;

        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Password = password
        };

        _userRepository.AddUser(user);

        // 3. Create Jwt Token

        var token = _jWTGenerator.GenerateToken(user);

        return new AuthenticationResult(
            user,
            token
            );
    }

    public AuthenticationResult Login(string email, string password)
    {
        // 1. Validate the user exists.

        if (_userRepository.GetUserByEmail(email) is not User user)
            throw new Exception("User with given email does not exists.");

        // 2. Validate the password is correct

        if (user.Password != password)
            throw new Exception("Invalid Password");

        // 3. Create Jwt Token

        var token = _jWTGenerator.GenerateToken(user);

        return new AuthenticationResult(
           user,
           token
           );
    }
}