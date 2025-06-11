using AmazonSPApiTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AmazonSPApiTracker.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sku> Skus { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<SalesHistory> SalesHistories { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<ShipmentItem> ShipmentItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalesHistory>()
                .HasKey(s => new { s.SkuId, s.Date });

            modelBuilder.Entity<ShipmentItem>()
                .HasKey(si => new { si.ShipmentId, si.SkuId });
        }
    }
} 