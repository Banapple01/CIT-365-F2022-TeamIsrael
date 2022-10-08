using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Collections;

namespace MegaDesk_Anderson
{
    public partial class SearchQuotes : Form
    {

        public SearchQuotes()
        {
            InitializeComponent();
        }

        //Read in json file to List of objects
        /*private List<object> ReadFile(string filename)
        {
            var orderData= new List<object>();
            File.WriteAllText(filename, JsonConvert.SerializeObject(orderData));
            return orderData;
        }*/
        // ***** this function is where i need help !!!!!
        //filters through orders returning a List<string> with only the material type

        private void FilterList(List<DeskQuote> orders, string material)
        {
            /* trying to use a query to select and check if the Material matches the
             * material the user selected. if it matches put it into the filterred */
            //List<DeskQuote> filtered = from order in orders where /* select Material */ == material select /* ordered material */  ; 

            List<DeskQuote> filtered = new List<DeskQuote>();

            foreach (DeskQuote i in orders)
            {
                if (i.Desk.Material.Equals(material))
                {
                    filtered.Add(i);
                }
            }

            if (filtered.Count > 0)
            {
                ViewAllQuotes viewAllQuotes = new ViewAllQuotes(filtered, "search");
                viewAllQuotes.Tag = this;
                viewAllQuotes.Show(this);
                this.Hide();
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // set filename of the json file where all orders are saved
            //string filename = "jsconfig1.json";
            //List<object> Orders = ReadFile(filename);


            string mat = MatBox.GetItemText(MatBox.SelectedItem);
            /* filteredOrders holds all orders that match slected material
             * this List<object> would need to be sent to another windows form that 
             * will display the List<object> */

            MainMenu main = new MainMenu();
            List<DeskQuote> q = main.returnQuoteList();

            FilterList(q, mat);
        }
    }
}
