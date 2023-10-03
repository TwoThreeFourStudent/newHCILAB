using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using assig2.Data;
using assig2.Models;

namespace assig2.Pages.ProvincePages
{
 public class DetailsModel : PageModel
    {
        private readonly Data.ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Province Province { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            try
            {
                if (id == null || _context.Provinces == null)
                {
                    return NotFound();
                }

                var province = await _context.Provinces
                    .Include(p => p.Cities)
                    .FirstOrDefaultAsync(m => m.ProvinceCode == id);

                if (province == null)
                {
                    return NotFound();
                }

                Province = province;
                return Page();
            }
            catch (Exception ex)
            {
                // Log the exception for debugging purposes
                // You can also return an error page or message to the user
                return Content("An error occurred: " + ex.Message);
            }
        }

    }
}
