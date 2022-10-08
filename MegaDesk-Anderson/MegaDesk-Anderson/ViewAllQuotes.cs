using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_Anderson
{
    public partial class ViewAllQuotes : Form
    {

        private DeskQuote _quote;
        private int _quoteIndex = 0;
        public ViewAllQuotes(List<DeskQuote> QuoteList)
        {
            InitializeComponent();
            EnterValues(QuoteList, 0);
        }

        public void EnterValues(List<DeskQuote> QuoteList, int _quoteIndex)
        {
            _quote = QuoteList[_quoteIndex];

            quoteNumber.Text = Convert.ToString(_quoteIndex + 1);
            V_Name.Text = _quote.CustName;
            DateIn.Text = _quote.Date.ToString("dddd MMMM yyyy");
            MatType.Text = _quote.Desk.Material;
            SizeIn.Text = Convert.ToString(_quote.Desk.Width * _quote.Desk.Depth + " sq inch");
            ShipIn.Text = Convert.ToString(_quote.Rush + " day");
            DrawerNum.Text = Convert.ToString(_quote.Rush);
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
            switch (_quote.Rush)
            {
                case 3:
                    if (_quote.Width * _quote.Depth < 1000)
                    {
                        Shipping += 60;
                    }
                    else if ((_quote.Width * _quote.Depth >= 1000) && (_quote.Width * _quote.Depth < 2000))
                    {
                        Shipping += 70;
                    }
                    else if (_quote.Width * _quote.Depth >= 2000)
                    {
                        Shipping += 80;
                    }
                    break;
                case 5:
                    if (_quote.Width * _quote.Depth < 1000)
                    {
                        Shipping += 40;
                    }
                    else if ((_quote.Width * _quote.Depth >= 1000) && (_quote.Width * _quote.Depth < 2000))
                    {
                        Shipping += 50;
                    }
                    else if (_quote.Width * _quote.Depth >= 2000)
                    {
                        Shipping += 60;
                    }
                    break;
                case 7:
                    if (_quote.Width * _quote.Depth < 1000)
                    {
                        Shipping += 30;
                    }
                    else if ((_quote.Width * _quote.Depth >= 1000) && (_quote.Width * _quote.Depth < 2000))
                    {
                        Shipping += 35;
                    }
                    else if (_quote.Width * _quote.Depth >= 2000)
                    {
                        Shipping += 40;
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

            switch (_quote.Desk.Material.ToLower())
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
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            List<DeskQuote> q = main.returnQuoteList();

            if (_quoteIndex < q.Count - 1)
            {
                ++_quoteIndex;
            }
            EnterValues(q, _quoteIndex);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (_quoteIndex > 0)
            {
                --_quoteIndex;
            }

            MainMenu main = new MainMenu();
            List<DeskQuote> q = main.returnQuoteList();
            EnterValues(q, _quoteIndex);
        }

        private void DateIn_Click(object sender, EventArgs e)
        {

        }
    }
}
