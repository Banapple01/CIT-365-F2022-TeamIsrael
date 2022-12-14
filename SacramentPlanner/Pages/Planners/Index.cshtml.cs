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
    public class IndexModel : PageModel
    {
        private readonly SacramentPlanner.Data.SacramentPlannerContext _context;

        public IndexModel(SacramentPlanner.Data.SacramentPlannerContext context)
        {
            _context = context;
        }

        public IList<Planner> Planner { get;set; } = default!;

        public async Task OnGetAsync()
        {
            var plans = from s in _context.Planner
                         select s;

            if (!string.IsNullOrEmpty(SearchString))
            {
                Planner = await _context.Planner.ToListAsync();
            }
        }
    }
}
