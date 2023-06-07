using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookingAppData
{
    public class CarBookingAppDbContext : DbContext
    {
        public CarBookingAppDbContext(DbContextOptions<CarBookingAppDbContext> options) : base(options)
        {
            
        }
        public DbSet<car> cars { get; set; }
    }
}
