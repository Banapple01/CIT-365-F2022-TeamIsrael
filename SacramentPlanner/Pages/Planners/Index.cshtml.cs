using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacramentPlanner.Data;
using SacramentPlanner.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;

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
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? PlannerDate { get; set; }

        public string? SortString { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? Conducting { get; set; }
        [BindProperty(SupportsGet = true)]
        public string? Presiding { get; set; }

        public async Task OnGetAsync()
        {
            //if (_context.Planner != null)
            //{
            //    Planner = await _context.Planner.ToListAsync();
            //}

            var plans = from s in _context.Planner
                         select s;
            if(!string.IsNullOrEmpty(SortString)){

                switch (SortString)
                {
                    case "Conducting":
                        plans = plans.OrderBy(s => s.Conducting);
                        break;
                    case "Date":
                        plans = plans.OrderBy(s => s.PlannerDate);
                        break;
                    case "Presiding":
                        plans = plans.OrderBy(s => s.Presiding);
                        break;
                    default:
                        plans = plans.OrderBy(s => s.PlannerDate);
                        break;
                }
            }

            if (!string.IsNullOrEmpty(SearchString))
            {
                plans = plans.Where(s => s.PlannerDate.ToString().Contains(SearchString));
            }

            Planner = await plans.AsNoTracking().ToListAsync();
        }
    }
}
