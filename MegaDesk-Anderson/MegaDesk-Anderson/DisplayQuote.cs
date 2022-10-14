using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Anderson
{
    public partial class DisplayQuote : Form
    {

        private DeskQuote _quote;
        public DisplayQuote(DeskQuote quote)
        {
            InitializeComponent();
            _quote = quote;
            EnterValues();
        }

        public void EnterValues()
        {
            Name.Text = _quote.CustName;
            DateIn.Text = _quote.Date.ToString("dd MMMM yyyy");
            MatType.Text = _quote.Desk.Material;
            SizeIn.Text = Convert.ToString(_quote.Desk.Width * _quote.Desk.Depth + " sq inch");
            ShipIn.Text = Convert.ToString(_quote.Rush + " day");
            DrawerNum.Text = Convert.ToString(_quote.Desk.NumDrawers);
            BaseCost.Text = Convert.ToString("$" + Desk.BASEPRICE);
            MatCost.Text = Convert.ToString("$" + CalcMaterial());
            SizeCost.Text = Convert.ToString("$" + CalcSizeCost());
            ShipCost.Text = Convert.ToString("$" + CalcShipping());
            DrawerCost.Text = Convert.ToString("$" + CalcDrawerCost());
            TotalCost.Text = Convert.ToString("$" + CalcTotal());
        }
        
        public int CalcSizeCost()
        {
            if (_quote.Desk.Width * _quote.Desk.Depth > 1000)
            {
                return ((_quote.Desk.Width * _quote.Desk.Depth) - 1000);
            }
            else
            {
                return 0;
            }

        }

        public int CalcShipping()
        {
            int Shipping = 0;
            int width = _quote.Desk.Width;
            int depth = _quote.Desk.Depth;

            switch (_quote.Rush)
            {
                case 3:
                    if (width * depth < 1000)
                    {
                        Shipping += _quote.RushArray[0,0];
                    }
                    else if ((width * depth >= 1000) && (width * depth < 2000))
                    {
                        Shipping += _quote.RushArray[0, 1];
                    }
                    else if (width * depth >= 2000)
                    {
                        Shipping += _quote.RushArray[0, 2];
                    }
                    break;
                case 5:
                    if (width * depth < 1000)
                    {
                        Shipping += _quote.RushArray[1, 0];
                    }
                    else if ((width * depth >= 1000) && (width * depth < 2000))
                    {
                        Shipping += _quote.RushArray[1, 1];
                    }
                    else if (width * depth >= 2000)
                    {
                        Shipping += _quote.RushArray[1, 2];
                    }
                    break;
                case 7:
                    if (width * depth < 1000)
                    {
                        Shipping += _quote.RushArray[2, 0];
                    }
                    else if ((width * depth >= 1000) && (width * depth < 2000))
                    {
                        Shipping += _quote.RushArray[2, 1];
                    }
                    else if (width * depth >= 2000)
                    {
                        Shipping += _quote.RushArray[2, 2];
                    }
                    break;
                case 14:
                    Shipping += 0;
                    break;
            }
            
            return Shipping;
        }

        public int CalcDrawerCost()
        {
            int DrawerCost = _quote.Desk.NumDrawers * Desk.DRAWERPRICE;

            return DrawerCost;
        }

        public int CalcMaterial()
        {
            int MatPrice = 0;

            switch(_quote.Desk.Material.ToLower())
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
                case "redwood":
                    MatPrice += 300;
                    break;
                case "veneer":
                    MatPrice += 125;
                    break;

            }
            
            return MatPrice;
        }

        public int CalcTotal()
        {
            int Total = CalcDrawerCost() + Desk.BASEPRICE + CalcShipping() + CalcSizeCost() + CalcMaterial();
            
            return Total;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = (AddQuote)Tag;
            viewAddQuote.Show();
            Close();
        }
    }
}
