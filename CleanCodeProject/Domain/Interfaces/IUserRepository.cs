using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserRepository
{
    Task CreateUser(User user);
    Task UpdateUser(User user);
    Task<List<User>> GetAllUsers();
    Task<User> GetUserById(Guid id);
}
