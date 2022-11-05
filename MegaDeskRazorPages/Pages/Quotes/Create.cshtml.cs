using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MegaDeskRazorPages.Data;
using MegaDeskRazorPages.Models;
using System.Drawing;

namespace MegaDeskRazorPages.Pages.Quotes
{
    public class CreateModel : PageModel
    {
        private readonly MegaDeskRazorPages.Data.MegaDeskRazorPagesContext _context;

        public CreateModel(MegaDeskRazorPages.Data.MegaDeskRazorPagesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Quote Quote { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }
            Quote.Total = CalcTotal();
            _context.Quote.Add(Quote);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

        //Calculation Functions
        public int CalcTotal()
        {
            int total = 200;

            total += CalcMatPrice();
            total += CalcShipPrice();
            total += CalcDrawerPrice();
            total += CalcSizePrice();

            return total;
        }

        public int CalcShipPrice()
        {
            int ShipPrice = 0;

            switch (Quote.Rush)
            {
                case 3:
                    if (Quote.Width * Quote.Depth < 1000)
                    {
                        ShipPrice += 60;
                    }
                    else if ((Quote.Width * Quote.Depth >= 1000) && (Quote.Width * Quote.Depth < 2000))
                    {
                        ShipPrice += 70;
                    }
                    else if (Quote.Width * Quote.Depth >= 2000)
                    {
                        ShipPrice += 80;
                    }
                    break;
                case 5:
                    if (Quote.Width * Quote.Depth < 1000)
                    {
                        ShipPrice += 40;
                    }
                    else if ((Quote.Width * Quote.Depth >= 1000) && (Quote.Width * Quote.Depth < 2000))
                    {
                        ShipPrice += 50;
                    }
                    else if (Quote.Width * Quote.Depth >= 2000)
                    {
                        ShipPrice += 60;
                    }
                    break;
                case 7:
                    if (Quote.Width * Quote.Depth < 1000)
                    {
                        ShipPrice += 30;
                    }
                    else if ((Quote.Width * Quote.Depth >= 1000) && (Quote.Width * Quote.Depth < 2000))
                    {
                        ShipPrice += 35;
                    }
                    else if (Quote.Width * Quote.Depth >= 2000)
                    {
                        ShipPrice += 40;
                    }
                    break;
                case 14:
                    ShipPrice += 0;
                    break;
            }

            return ShipPrice;
        }

        public int CalcMatPrice()
        {
            int MatPrice = 0;

            switch (Quote.Material.ToLower())
            {
                case "oak":
                    MatPrice += 200;
                    break;
                case "laminate":
                    MatPrice += 100;
                    break;
                case "pine":
                    MatPrice += 50;
                    break;
                case "rosewood":
                    MatPrice += 300;
                    break;
                case "veneer":
                    MatPrice += 125;
                    break;
            }

            return MatPrice;
        }

        public int CalcDrawerPrice()
        {
            int DrawerPrice = Quote.Drawers * Quote.DRAWERPRICE;

            return DrawerPrice;
        }

        public int CalcSizePrice()
        {
            int SizePrice = 0;

            if (Quote.Width * Quote.Depth > 1000)
            {
                SizePrice += (Quote.Width * Quote.Depth) - 1000;
            }

            return SizePrice;
        }



    }
}
