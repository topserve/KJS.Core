using System;
using Api.Models;

namespace Api.Repositry.Interface;
public interface IUserRepository
{
    Task<IEnumerable<User>> ListUser();
    Task<User> SelectUser(long userId);
    void InsertUser(User user);
    void UpdateUser(User user);
    void DeleteUser(User user);
    Task<bool> SaveChangesAsync();
}