using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country() { Id = 1, Name = "Turkey", ShortName = "TR" },
                new Country() { Id = 2, Name = "China", ShortName = "CH" },
                new Country() { Id = 3, Name = "Norway", ShortName = "NW" }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel() { Id = 1, Name = "Hotel Turkey", Address = "Antalya", CountryId = 1, Rating = 4.7 },
                new Hotel() { Id = 2, Name = "Hotel China", Address = "Wuhan", CountryId = 2, Rating = 3.7 },
                new Hotel() { Id = 3, Name = "Hotel Norway", Address = "Helsinki", CountryId = 3, Rating = 4.3 }
            );
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }
    }
}
