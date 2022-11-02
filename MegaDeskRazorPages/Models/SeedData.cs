using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MegaDeskRazorPages.Data;
using System;
using System.Linq;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskRazorPagesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MegaDeskRazorPagesContext>>()))
            {
                // Look for any Quotes.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }

                context.Quote.AddRange(
                    new Quote
                    {
                        QuoteDate = DateTime.Now,
                        CustName = "John Smith",
                        Material = "Pine",
                        Rush = 3,
                        Width = 24,
                        Depth = 24,
                        Drawers = 2
                    },

                    new Quote
                    {
                        QuoteDate = DateTime.Now,
                        CustName = "John Doe",
                        Material = "oak",
                        Rush = 3,
                        Width = 46,
                        Depth = 28,
                        Drawers = 7
                    },

                    new Quote
                    {
                        QuoteDate = DateTime.Now,
                        CustName = "John Appleseed",
                        Material = "veneer",
                        Rush = 7,
                        Width = 24,
                        Depth = 48,
                        Drawers = 4
                    },

                    new Quote
                    {
                        QuoteDate = DateTime.Now,
                        CustName = "John Hancock",
                        Material = "Pine",
                        Rush = 5,
                        Width = 46,
                        Depth = 44,
                        Drawers = 4
                    }
                );
                context.SaveChanges();
            }
        }
    }
}