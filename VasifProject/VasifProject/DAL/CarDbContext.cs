using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VasifProject.Model;

namespace VasifProject.DAL
{
    class CarDbContext : DbContext
    {
        public CarDbContext() : base("CarAppDbContext")
        {
                
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
