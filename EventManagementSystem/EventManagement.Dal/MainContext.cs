using EventManagement.Dal.Entity;
using EventManagement.Dal.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace EventManagement.Dal;

public class MainContext : DbContext
{
    public DbSet<Event> Events { get; set; }
    public DbSet<FeedBack> FeedBacks { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<User> Users { get; set; }

    public MainContext(DbContextOptions<MainContext> options)
       : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new EventConfiguration());
        modelBuilder.ApplyConfiguration(new FeedBackConfiguration());
        modelBuilder.ApplyConfiguration(new PaymentConfiguration());
        modelBuilder.ApplyConfiguration(new TickrtConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}
