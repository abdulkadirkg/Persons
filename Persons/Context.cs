using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Persons;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
        ChangeTracker.AutoDetectChangesEnabled = false;
        
    }
    public DbSet<Person> Persons { get; set; }
}

