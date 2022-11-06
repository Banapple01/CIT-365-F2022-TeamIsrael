using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Data;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Pages.Quotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDeskRazorPages.Data.MegaDeskRazorPagesContext _context;

        public IndexModel(MegaDeskRazorPages.Data.MegaDeskRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Quote> Quote { get;set; } = default!;
        [BindProperty(SupportsGet = true)]
        public string ? SearchString { get; set; }
        public SelectList ? CustNames { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ? CustomerName { get; set; }

        public string DateSort { get; set; }
        public string NameSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            // Search Feature
            var quotes = from q in _context.Quote
                         select q;

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.CustName.Contains(SearchString));
            }

            Quote = await quotes.ToListAsync();
            
            // Sort Feature
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";

            IQueryable<Quote> quoteIQ = from s in _context.Quote
                                        select s;
            
            switch (sortOrder)
            {
                case "name_desc":
                    quoteIQ = quoteIQ.OrderByDescending(s => s.CustName);
                    break;
                case "Date":
                    quoteIQ = quoteIQ.OrderBy(s => s.QuoteDate);
                    break;
                case "date_desc":
                    quoteIQ = quoteIQ.OrderByDescending(s => s.QuoteDate);
                    break;
                default:
                    quoteIQ = quoteIQ.OrderBy(s => s.CustName);
                    break;
            }
            Quote = await quoteIQ.AsNoTracking().ToListAsync();
        }
    }
}
