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
            optionsBuilder.UseSqlServer(@"Server=muguremre\sqlexpress;Database=NetixProject;Trusted_Connection=true");
        }

        DbSet<Computer> Computers { get; set; }
        DbSet<Owner> Owners { get; set; }

    }
}
