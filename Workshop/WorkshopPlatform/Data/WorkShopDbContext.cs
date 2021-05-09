using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Models;
using Microsoft.AspNetCore.Identity;

namespace WorkshopPlatform.Models
{
    public class WorkShopDbContext : IdentityDbContext
    {
        public WorkShopDbContext(DbContextOptions<WorkShopDbContext> options) : base(options)
        {
        }

        public DbSet<Confirmations> Confirmations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<WorkShop> WorkShops { get; set; }
        public DbSet<WorkshopRate> WorkshopRates { get; set; }
        public DbSet<WorkshopServices> WorkshopServices { get; set; }
        public DbSet<WorkshopImages> WorkshopImages { get; set; }
        public DbSet<UserServices> UserServices { get; set; }
        public DbSet<Government> Governments { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<Messages> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkshopRate>(e =>
            {
                e.HasKey(p => new { p.UserProfileId, p.WorkShopId });

                e.HasIndex(p => new { p.UserProfileId, p.WorkShopId }).IsUnique();

                e.HasOne(p => p.UserProfile).WithMany(p => p.WorkshopRates).HasForeignKey(p => p.UserProfileId);

                e.HasOne(p => p.WorkShop).WithMany(p => p.WorkshopRates).HasForeignKey(p => p.WorkShopId);
            });
            modelBuilder.Entity<Service>(e =>
            {
                e.HasOne(p => p.WorkShop).WithMany(p => p.Services).HasForeignKey(p => p.WorkShopId).OnDelete(DeleteBehavior.Restrict);
            });
            modelBuilder.Entity<UserProfile>(e =>
            {
                e.HasIndex(p => p.UserId).IsUnique();
            });
            modelBuilder.Entity<WorkShop>(e =>
            {
                e.HasIndex(p => p.UserId).IsUnique();
            });

            modelBuilder.Entity<IdentityUser>(e =>
            {
                e.HasIndex(p => p.UserName).IsUnique();
                e.Property(p => p.UserName).IsRequired();
                e.HasIndex(p => p.Email).IsUnique();
                e.Property(p => p.Email).IsRequired();
            });
            modelBuilder.Entity<UserServices>(e =>
            {
                e.HasIndex("ServiceId", "UserId").IsUnique();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}