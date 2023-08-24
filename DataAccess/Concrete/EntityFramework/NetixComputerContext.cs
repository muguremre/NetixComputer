using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class NetixComputerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=muguremre;Database=NetixProject;Trusted_Connection=true; TrustServerCertificate=true");
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Owner> Owners { get; set; }

    }
}
