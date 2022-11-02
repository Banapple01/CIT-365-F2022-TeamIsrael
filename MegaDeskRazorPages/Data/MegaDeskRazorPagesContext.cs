using Microsoft.EntityFrameworkCore;
using MegaDeskRazorPages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskRazorPages.Data
{
    public class MegaDeskRazorPagesContext : DbContext
    {

        public MegaDeskRazorPagesContext(DbContextOptions<MegaDeskRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<MegaDeskRazorPages.Models.Quote> Quote { get; set; } = default!;

    }
}
