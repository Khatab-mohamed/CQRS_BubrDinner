namespace BuberDinner.Infrastructure.Presistance;

public class UserRepository : IUserRepository
{
    private static readonly List<User> _users = new();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void DeleteUser(User user)
    {
        throw new NotImplementedException();
    }

    public User? GetUserByEmail(string email)
    {
        return _users.FirstOrDefault(x => x.Email == email);
    }

    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
}