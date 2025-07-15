using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChargeStationApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace ChargeStationApp.Infrastructure.Context
{
    public class ChargeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             optionsBuilder.UseMySql(
            "Server=localhost;Database=ChargeDb;User=root;Password=Ulusoy12;",
            new MySqlServerVersion(new Version(8, 0, 23))
           );
        }
        public DbSet<ChargeStation> ChargeStations { get; set; }
        public DbSet<User> Users { get; set; }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnConfiguring(modelBuilder);
        }*/
    }
}