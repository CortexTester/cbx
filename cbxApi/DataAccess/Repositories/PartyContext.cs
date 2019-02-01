using cbxApi.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions;

namespace cbxApi.DataAccess.Repositories
{
    public class PartyContext : DbContext
    {
        public PartyContext(DbContextOptions<PartyContext> opts) : base(opts) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(Startup.ConnectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Partner>().HasKey(p => new { p.InviterId, p.AccepterId });
            modelBuilder.Entity<Partner>()
            .HasOne<Party>(p => p.Accepter)
            .WithMany(s => s.Partners)
            .HasForeignKey(sc => sc.AccepterId);

            modelBuilder.Entity<Partner>()
           .HasOne<Party>(p => p.Inviter)
           .WithMany(s => s.Partners)
           .HasForeignKey(sc => sc.InviterId);
        }
        public DbSet<Party> Parties { get; set; }
        public DbSet<Partner> Partners { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Attribute> Attributes { get; set; }
    }
}