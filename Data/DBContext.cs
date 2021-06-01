﻿using AuthDemo.Models;
using GroupProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthDemo.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(p => new { p.UserId, p.RoleId });
        }

        public DbSet<User> Users { get; set; }
     
        public DbSet<Module> Modules { get; set; }
  
        public DbSet<LO> LOs { get; set; }
         public DbSet<Feedback> feedbacks { get; set; }
        public DbSet<PO> POs { get; set; }
        public DbSet<AsComponent> AsComponents { get; set; }
        public object AsCompoments { get; internal set; }
    }

}
