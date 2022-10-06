using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Anderson
{
    public class Desk
    {
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public string Material { get; set; }

        //Declare variables and constants
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
