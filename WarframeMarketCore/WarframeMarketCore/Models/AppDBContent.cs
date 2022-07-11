using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarframeMarketCore.Models
{
    public class AppDBContent : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Person> Person { get; set; }

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
