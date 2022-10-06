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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }



        private void SubmitQuoteButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text == "" || WidthBox.Text == "" ||
                DepthBox.Text == "" || DrawersBox.Text == "" ||
                MatBox.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                //Create an instance of desk quote
                DeskQuote quote = new DeskQuote();
                
                if (ShipBox.Text == "")
                {
                    quote.Rush = 14;
                }
                else
                {
                    quote.Rush = Convert.ToInt32(ShipBox.Text);
                }
                
                quote.CustName = NameBox.Text;
                quote.Desk.Width = Convert.ToInt32(WidthBox.Text);
                quote.Desk.Depth = Convert.ToInt32(DepthBox.Text);
                quote.Desk.NumDrawers = Convert.ToInt32(DrawersBox.Text);
                quote.Desk.Material = MatBox.Text;

                DisplayQuote quoteView = new DisplayQuote(quote);
                quoteView.Tag = this;
                quoteView.Show(this);
                this.Hide();
            }
            
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void ValidWidth_Validating(object sender, CancelEventArgs e)
        {

            foreach (char x in WidthBox.Text)
            {
                if (!Char.IsNumber(x))
                {
                    WidthBox.Text = String.Empty;
                    WidthBox.BackColor = Color.LightCoral;
                    WidthBox.Focus();
                }
                else
                {
                    WidthBox.ResetBackColor();
                }
            }

            try
            {
                int num = Int32.Parse(WidthBox.Text);
                if (num < 24 || num > 96)
                {
                    WidthBox.Text = String.Empty;
                    WidthBox.BackColor = Color.LightCoral;
                    WidthBox.Focus();
                }
            
            }
            catch
            {
                MessageBox.Show("Enter an integer between 24 and 96.");
            }

        }
        private void Depth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DepthBox.ResetBackColor();
            }
            else
            {
                DepthBox.BackColor = Color.LightCoral;
                DepthBox.Focus();
                MessageBox.Show("Enter an integer between 12 and 48.");
            }

        }

        private void Material_Validating(object sender, CancelEventArgs e)
        {
            string Mat = MatBox.Text.ToLower();
            if (!Mat.Equals("oak") && !Mat.Equals("laminate") && !Mat.Equals("redwood")
                && !Mat.Equals("veneer") && !Mat.Equals("pine")) {
                MatBox.Text = String.Empty;
                MatBox.BackColor = Color.LightCoral;
                MatBox.Focus();
                MessageBox.Show("Please enter a valid material type. (See list)");
            }
            else
            {
                MatBox.ResetBackColor();
            }
        }

        private void Drawers_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                int num = Int32.Parse(DrawersBox.Text);
                if (num < 0 || num > 7)
                {
                    DrawersBox.Text = String.Empty;
                    DrawersBox.BackColor = Color.LightCoral;
                    DrawersBox.Focus();
                    MessageBox.Show("Enter an integer between 0 and 7.");
                }
                else
                {
                    DrawersBox.ResetBackColor();
                }

            }
            catch
            {
                MessageBox.Show("Enter an integer between 0 and 7.");
            }
        }

        private void ShipBox_Validating(object sender, CancelEventArgs e)
        {

            try
            {
                int num = Int32.Parse(ShipBox.Text);
                if (!(num == 3) && !(num == 5) && !(num == 7))
                {
                    ShipBox.Text = String.Empty;
                    ShipBox.BackColor = Color.LightCoral;
                    ShipBox.Focus();
                }
                else
                {
                    ShipBox.ResetBackColor();
                }

            }
            catch
            {
                MessageBox.Show("Enter 3, 5, or 7.");
            }

        }

        private void Depth_Validating(object sender, CancelEventArgs e)
        {

        }

    }
}
