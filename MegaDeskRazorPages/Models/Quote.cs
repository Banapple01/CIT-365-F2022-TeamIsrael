using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MegaDeskRazorPages.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public int Rush { get; set; }
        public int Total { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }

        [Display(Name = "Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CustName { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Material { get; set; }

        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        public int[,] RushArray = new int[3, 3];

        //Declare constants
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;
        public const int BASEPRICE = 200;
        public const int DRAWERPRICE = 50;

    }

    enum DeskMaterial
    {
        laminate,
        oak,
        rosewood,
        veneer,
        pine
    }
}