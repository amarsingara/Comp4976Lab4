using System;
using System.Collections.Generic;
using System.Text;
using Lab4_1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab4_1.Data
{
    public static class Dummy
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                City.GetCities()
            );
            modelBuilder.Entity<Province>().HasData(
                Province.GetProvinces()
            );
        }
    }
}
