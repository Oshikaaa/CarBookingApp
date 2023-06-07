  using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarBookingAppData;

namespace CarBookingApp.Pages.cars
{
    public class IndexModel : PageModel
    {
        private readonly CarBookingAppData.CarBookingAppContext _context;

        public IndexModel(CarBookingAppData.CarBookingAppContext context)
        {
            _context = context;
        }

        public IList<car> car { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.car != null)
            {
                car = await _context.car.ToListAsync();
            }
        }
    }
} 
