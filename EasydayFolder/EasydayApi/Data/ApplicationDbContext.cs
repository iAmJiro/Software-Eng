using Microsoft.EntityFrameworkCore;
namespace EasydayApi;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<

        modelBuilder.Entity<Account>()
            .HasOne(a => a.Address)
            .WithOne(i => i.Account)
            .HasForeignKey<Address>(i => i.AddressID)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);

        
    }
}