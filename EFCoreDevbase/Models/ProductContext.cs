using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreDevbase.Models
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=OSMANDURMUS; Database=DevbaseDatabaseChallenge; Trusted_Connection=True");
        }

        public DbSet<Product> Products { get; set; }

    }
}
