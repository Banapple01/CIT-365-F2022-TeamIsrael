using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Anderson
{
    public class DeskQuote
    {
        public Desk Desk = new Desk();

        public string Material { get; set; }
        public int NumDrawers { get; set; }
        public int Depth { get; set; }
        public int Width { get; set; }
        public int Rush { get; set; }
        public int Total = 0;
        public string CustName { get; set; }
        public DateTime Date = DateTime.Now;

        public DeskQuote()
        {
            
        }

        public int CalcTotal()
        {

            Total += Desk.BASEPRICE;
            return Total;
        }
    }
}
