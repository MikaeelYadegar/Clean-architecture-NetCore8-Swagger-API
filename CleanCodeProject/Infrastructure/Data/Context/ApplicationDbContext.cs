using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }
    /// <summary>
    //Auto Property //////////
    // public DbSet<User> Users { get; set; }
    //  public DbSet<Role> Roles { get; set; }
    //public DbSet<UserRole> UserRoles { get; set; }
    /// </summary>
    /// //// Computed Property//////
    public DbSet<User>Users=>Set<User>();
    public DbSet<Role>Roles=>Set<Role>();
    public DbSet<UserRole>UserRoles=>Set<UserRole>();
}
