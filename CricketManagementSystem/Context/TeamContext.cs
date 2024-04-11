using CricketManagementSystem.Data.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketManagementSystem.Data.Context
{
    public class TeamContext : DbContext
    {
        public DbSet<Player> players { get; set; }
        public DbSet<Team> teams { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=EXIACDB5\\SQLEXPRESS;Database=CricketManagementDb;User Id=vampi;Password=123;TrustServerCertificate=true;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
