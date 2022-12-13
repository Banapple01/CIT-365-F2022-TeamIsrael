using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using SacramentPlanner.Models;

namespace SacramentPlanner.Pages.Planners
{
    public class DeleteModel : PageModel
    {
        private readonly SacramentPlanner.Data.SacramentPlannerContext _context;

        public DeleteModel(SacramentPlanner.Data.SacramentPlannerContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Planner Planner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Planner == null)
            {
                return NotFound();
            }

            var planner = await _context.Planner.FirstOrDefaultAsync(m => m.PlannerId == id);

            if (planner == null)
            {
                return NotFound();
            }
            else 
            {
                Planner = planner;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Planner == null)
            {
                return NotFound();
            }
            var planner = await _context.Planner.FindAsync(id);

            if (planner != null)
            {
                Planner = planner;
                _context.Planner.Remove(Planner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
