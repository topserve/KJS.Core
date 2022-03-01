using Api.Models;
using Api.Repositry.Interface;
using Api.Data;

namespace Api.Repositry;
public class UserRepository : IUserRepository
{
    private readonly UserContext _context;
    public UserRepository(UserContext context)
    {
        _context = context;
    }
    public void InsertUser(User user)
    {
        _context.Add(user);
    }
    public void UpdateUser(User user)
    {
        throw new NotImplementedException();
    }
    public void DeleteUser(User user)
    {
        throw new NotImplementedException();
    }
    public Task<User> SelectUser(long userId)
    {
        throw new NotImplementedException();
    }
    public Task<IEnumerable<User>> ListUser()
    {
        throw new NotImplementedException();
    }
    public async Task<bool> SaveChangesAsync()
    {
        return await _context.SaveChangesAsync() > 0;
    }
}