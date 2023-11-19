using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoAukcionas.Data.DTOs.Auth;
using AutoAukcionas.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AutoAukcionas.Data
{
    public class AuctionContext : IdentityDbContext<AuctionUser>
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<Car> Car { get; set; }
        public DbSet<Bet> Bet { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;TrustServerCertificate=True;Initial Catalog=AutoAuction;");
            optionsBuilder.UseSqlServer("Server=tcp:autoaukcionasserver.database.windows.net,1433;Initial Catalog=autoaukcionasdb;Encrypt=True;Persist Security Info=False;Connection Timeout=30;User ID=edgaras;Password=SaitynasAutoAukcionas2023;MultipleActiveResultSets=False;TrustServerCertificate=False;");
            //optionsBuilder.UseSqlServer("Server=tcp:autoaukcionasdbserver.database.windows.net,1433;Initial Catalog=AutoAukcionas_db;Encrypt=True;Persist Security Info=False;Connection Timeout=30;User ID=justas;Password=SuperDuperSeceretPassword123;MultipleActiveResultSets=False;TrustServerCertificate=False;");
        }
    }
}