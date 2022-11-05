using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;
using MegaDeskRazorPages.Data;
using MegaDeskRazorPages.Models;

namespace MegaDeskRazorPages.Models
{
    public class Quote
    {
        public int ID { get; set; }
        public int Rush { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int Drawers { get; set; }

        [Display(Name = "Drawer Price")]
        public int DrawerPrice { get; set; }
        [Display(Name = "Oversize Price")]
        public int SizePrice { get; set; }
        [Display(Name = "Shipping Price")]
        public int ShipPrice { get; set; }
        [Display(Name = "Material Price")]
        public int MatPrice { get; set; }

        [Display(Name = "Customer Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CustName { get; set; }

        //[Display(Name = "Surface Material")]
        //[StringLength(60, MinimumLength = 3)]
        //[Required]
        public string Material { get; set; }

        [Display(Name = "Quote Date")]
        [DataType(DataType.Date)]
        public DateTime QuoteDate { get; set; }

        public int Total { get; set; }
      

        //Declare constants
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;
        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;
        public const int BASEPRICE = 200;
        public const int DRAWERPRICE = 50;

        enum DeskMaterial
        {
            laminate,
            oak,
            rosewood,
            veneer,
            pine
        }
        
        public Quote()
        {

        }

        /*public int CalcTotal()
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

            switch (Rush)
            {
                case 3:
                    if (Width * Depth < 1000)
                    {
                        ShipPrice += 60;
                    }
                    else if ((Width * Depth >= 1000) && (Width * Depth < 2000))
                    {
                        ShipPrice += 70;
                    }
                    else if (Width * Depth >= 2000)
                    {
                        ShipPrice += 80;
                    }
                    break;
                case 5:
                    if (Width * Depth < 1000)
                    {
                        ShipPrice += 40;
                    }
                    else if ((Width * Depth >= 1000) && (Width * Depth < 2000))
                    {
                        ShipPrice += 50;
                    }
                    else if (Width * Depth >= 2000)
                    {
                        ShipPrice += 60;
                    }
                    break;
                case 7:
                    if (Width * Depth < 1000)
                    {
                        ShipPrice += 30;
                    }
                    else if ((Width * Depth >= 1000) && (Width * Depth < 2000))
                    {
                        ShipPrice += 35;
                    }
                    else if (Width * Depth >= 2000)
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

            switch (Material.ToLower())
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
            int DrawerPrice = Drawers * DRAWERPRICE;

            return DrawerPrice;
        }

        public int CalcSizePrice()
        {
            int SizePrice = 0;

            if (Width * Depth > 1000)
            {
                SizePrice += (Width * Depth) - 1000;
            }

            return SizePrice;
        }*/

    }
        
    
}