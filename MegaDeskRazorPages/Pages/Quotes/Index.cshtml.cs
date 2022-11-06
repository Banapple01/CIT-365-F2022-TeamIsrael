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

        public SelectList ? DateAdded { get; set; }
        [BindProperty(SupportsGet = true)]
        public DateTime ? QuDate { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<DateTime> dateQuery = from e in _context.Quote
                                             orderby e.QuoteDate
                                             select e.QuoteDate;
            IQueryable<string> nameQuery = from e in _context.Quote
                                           orderby e.CustName
                                           select e.CustName;
            // using System.Linq;
            var quotes = from q in _context.Quote
                         select q;

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(s => s.CustName.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(CustomerName))
            {
                quotes = quotes.Where(x => x.CustName == CustomerName);
            }

            if (DateTime.Equals(QuDate, DateTime.MinValue))
            {
                quotes = quotes.Where(d => d.QuoteDate == QuDate);
            }

            DateAdded = new SelectList(await dateQuery.Distinct().ToListAsync());
            CustNames = new SelectList(await nameQuery.Distinct().ToListAsync());
            Quote = await quotes.ToListAsync();
        }
    }
}
