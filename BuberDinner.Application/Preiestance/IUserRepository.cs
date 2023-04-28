namespace BuberDinner.Application.Preiestance;

public interface IUserRepository
{
    User? GetUserByEmail(string email);

    void AddUser(User user);

    void UpdateUser(User user);

    void DeleteUser(User user);
}