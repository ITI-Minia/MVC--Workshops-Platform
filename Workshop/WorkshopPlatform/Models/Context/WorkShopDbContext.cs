﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workshop.Models;

namespace WorkshopPlatform.Models
{
    public class WorkShopDbContext: IdentityDbContext
    {
        public WorkShopDbContext(DbContextOptions<WorkShopDbContext> options) : base(options) { }
        public DbSet<Confirmations> Confirmations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<WorkShop> WorkShops { get; set; }
        public DbSet<WorkshopRate> WorkshopRates { get; set; }
        public DbSet<WorkshopServices> workshopServices { get; set; }
      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
      
            modelBuilder.Entity<WorkshopRate>(e =>
            {
                e.HasKey(p => new { p.UserProfileId, p.WorkShopId });

                e.HasIndex(p => new { p.UserProfileId, p.WorkShopId }).IsUnique();

                e.HasOne(p => p.UserProfile).WithMany(p => p.WorkshopRates).HasForeignKey(p=>p.UserProfileId);

                e.HasOne(p => p.WorkShop).WithMany(p => p.WorkshopRates).HasForeignKey(p => p.WorkShopId) ;

            });
            modelBuilder.Entity<Service>(e =>
            {
                e.HasOne(p => p.WorkShop).WithMany(p => p.Services).HasForeignKey(p => p.WorkShopId).OnDelete(DeleteBehavior.Restrict);

            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
