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
    public partial class MainMenu : Form
    {

        public static List<DeskQuote> QuoteList = new List<DeskQuote>();
        public MainMenu()
        {
            InitializeComponent();
        }

        public static void addToQuoteList(DeskQuote quote)
        {
            QuoteList.Add(quote);
            foreach (var i in QuoteList)
            {
                Console.WriteLine(i.CustName);
            }
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
            ViewAllQuotes viewQuotes = new ViewAllQuotes(QuoteList);
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
