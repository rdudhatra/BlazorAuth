using BlazorAuth.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BlazorAuth.Data;

public class BlazorAuthContext : IdentityDbContext<IdentityUser>
{
    public BlazorAuthContext(DbContextOptions<BlazorAuthContext> options)
        : base(options)
    {
    }

    public DbSet<Person> Person { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
}
