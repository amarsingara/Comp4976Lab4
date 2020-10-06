using System;
using System.Collections.Generic;
using System.Text;
using Lab4_1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab4_1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<City>().Property(m => m.ProvinceCode).IsRequired();
            // builder.Entity<Province>().ToTable("Province");
            builder.Entity<City>().ToTable("City");
            builder.Seed();
        }

        public DbSet<Province> Province { get; set; }
        public DbSet<City> City { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
