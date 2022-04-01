using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using YouthAndFamilyDB.Shared;

namespace YouthAndFamilyDB.Server.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HouseChurch>().HasData(
                new HouseChurch { Id = 1, Name = "Kinzer" },
                new HouseChurch { Id = 2, Name = "Ammon" },
                new HouseChurch { Id = 3, Name = "Rodriguez" }
            );

            modelBuilder.Entity<Teen>().HasData(
                new Teen { Id = 1, FirstName = "Peter", LastName = "Parker", GradeLevel = 3, HouseChurchId = 2 },
                new Teen { Id = 2, FirstName = "Damion", LastName = "Wayne", GradeLevel = 4, HouseChurchId = 1 }
            );
        }

        public DbSet<Teen> Teens { get; set; }
        public DbSet<HouseChurch> HouseChurches { get; set; }
    }
}
