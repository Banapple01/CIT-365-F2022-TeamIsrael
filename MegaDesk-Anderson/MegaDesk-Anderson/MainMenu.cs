using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Anderson
{
    public partial class MainMenu : Form
    {

        public static List<DeskQuote> QuoteList = new List<DeskQuote>();

        public MainMenu()
        {
            InitializeComponent();
            writeToJson();
        }

        public static void writeToJson()
        {

            var filePath = "jsconfig1.json";
            // Read existing json data
            var jsonData = File.ReadAllText(filePath);
            Console.WriteLine(jsonData);
            // De-serialize to object or create new list
            var quote_List = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData)
                               ?? new List<DeskQuote>();

            // Add any new employees
            foreach (var q in QuoteList)
            {
                quote_List.Add(q);
            }

            QuoteList = new List<DeskQuote>();

                // Update json data string
            jsonData = JsonConvert.SerializeObject(quote_List);
            File.WriteAllText(filePath, jsonData);
        }
        public static void readFromJson()
        {

            var filePath = "jsconfig1.json";
            // Read existing json data
            var jsonData = File.ReadAllText(filePath);
            Console.WriteLine(jsonData);
            // De-serialize to object or create new list
            var quote_List = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData)
                             ?? new List<DeskQuote>();

            // Add any new employees
            foreach (var q in quote_List)
            {
                QuoteList.Add(q);
            }
            
        }

        public List<DeskQuote> returnQuoteList()
        {
            readFromJson();
            return QuoteList;
        }

        public static void addToQuoteList(DeskQuote quote)
        {
            QuoteList.Add(quote);
            writeToJson();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Close form for main menu
            Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes viewSearch = new SearchQuotes();
            viewSearch.Tag = this;
            viewSearch.Show(this);
            this.Hide();
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            readFromJson();
            ViewAllQuotes viewQuotes = new ViewAllQuotes(QuoteList, "main");
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            this.Hide();
        }

        private void AddQuote_Click(object sender, EventArgs e)
        {
            AddQuote addQuote = new AddQuote();
            addQuote.Tag = this;
            addQuote.Show(this);
            this.Hide();
        }
    }
}
