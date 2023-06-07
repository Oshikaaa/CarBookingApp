using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarBookingAppData
{
    public class CarBookingAppContext : DbContext
    {
        public CarBookingAppContext (DbContextOptions<CarBookingAppContext> options)
            : base(options)
        {
        }

        public DbSet<CarBookingAppData.car> car { get; set; } = default!;
    }
}
