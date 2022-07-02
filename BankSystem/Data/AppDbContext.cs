using BankSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace BankSystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Score> Scores { get; set; }
}