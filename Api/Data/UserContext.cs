using Microsoft.EntityFrameworkCore;
using Api.Models;

namespace Api.Data;

public class UserContext : DbContext
{
    public UserContext(DbContextOptions<UserContext> options) : base(options)
    {
        
    }
    public DbSet<NewUserAccount> NewUserAccounts { get; set;}
    public DbSet<User> Users { get; set;}
    public DbSet<Account> Accounts { get; set;}
    public DbSet<UserAccount> UserAccounts {get; set;}

}
