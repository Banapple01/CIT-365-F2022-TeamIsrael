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

        //public string Material { get; set; }
        //public int NumDrawers { get; set; }
        //public int Depth { get; set; }
        //public int Width { get; set; }
        public int Rush { get; set; }
        public int Total = 0;
        public string CustName { get; set; }
        public int[,] RushArray = new int[3,3];
        public DateTime Date = DateTime.Now;

        public DeskQuote()
        {
            GetRushOrder(ref RushArray);
        }

        public int CalcTotal()
        {

            Total += Desk.BASEPRICE;
            return Total;
        }

        public static void GetRushOrder(ref int[,] RushArray)
        {
            try
            {
                int[] ShipList = new int[9];
                StreamReader reader = new StreamReader("rushOrderPrices.txt");
                int count = 0;
                int num = 0;

                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    ShipList[count] = Convert.ToInt32(line);
                    count++;
                }
                reader.Close();

                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        RushArray[x, y] = ShipList[num];
                        num++;
                    }
                }
            }
            catch
            {
                Console.WriteLine("Can't read file rushOrderPrices.txt");
            }
            
        }      
        
    }
}
