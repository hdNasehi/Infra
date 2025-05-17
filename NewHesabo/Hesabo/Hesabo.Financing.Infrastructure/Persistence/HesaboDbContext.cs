using Microsoft.EntityFrameworkCore;

namespace Hesabo.Financing.Infrastructure.Persistence;

public class HesaboDbContext : DbContext
{
    public HesaboDbContext(DbContextOptions<HesaboDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Apply all configurations in the assembly
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HesaboDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}