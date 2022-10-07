using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        public int[,] RushArray = new int[3,3];
        public DateTime Date = DateTime.Now;

        public DeskQuote()
        {
            
        }

        public int CalcTotal()
        {

            Total += Desk.BASEPRICE;
            return Total;
        }

        /*public static void GetRushOrder()
        {
            //try
            //{
                public int [] list = new int [9];

                //StreamReader reader = new StreamReader("Properties/rushOrderPrices.txt");
                
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    list.add(line);
                }

                print(list);

                public int count = 0;
                for (int x = 0; x < list.count; x++){
                    for (int y = 0; y < 3; y++){
                        RushArray[x, y] = list[count];
                        count++;
                    }
                }

                print(RushArray);
                reader.Close(); 
                return ShipCost;
                Console.WriteLine("Processed");
            
           // }
           // catch ()
           // {
           //
           // }
            

        }*/
    }
}
