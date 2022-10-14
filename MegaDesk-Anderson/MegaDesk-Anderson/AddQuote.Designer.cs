namespace MegaDesk_Anderson
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthBox = new System.Windows.Forms.TextBox();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.DepthBox = new System.Windows.Forms.TextBox();
            this.DrawerLabel = new System.Windows.Forms.Label();
            this.MatLabel = new System.Windows.Forms.Label();
            this.ShipLabel = new System.Windows.Forms.Label();
            this.SubmitQuoteButton = new System.Windows.Forms.Button();
            this.backAddQuote = new System.Windows.Forms.Button();
            this.WidthRange = new System.Windows.Forms.Label();
            this.DepthRange = new System.Windows.Forms.Label();
            this.DrawersBox = new System.Windows.Forms.ComboBox();
            this.MatBox = new System.Windows.Forms.ComboBox();
            this.ShipBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(85, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(137, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Enter full name:";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(299, 45);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 1;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(85, 76);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(104, 21);
            this.WidthLabel.TabIndex = 2;
            this.WidthLabel.Text = "Desk width:";
            // 
            // WidthBox
            // 
            this.WidthBox.Location = new System.Drawing.Point(299, 77);
            this.WidthBox.Name = "WidthBox";
            this.WidthBox.Size = new System.Drawing.Size(100, 20);
            this.WidthBox.TabIndex = 3;
            this.WidthBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidWidth_Validating);
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthLabel.Location = new System.Drawing.Point(84, 112);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(104, 21);
            this.DepthLabel.TabIndex = 4;
            this.DepthLabel.Text = "Desk depth:";
            // 
            // DepthBox
            // 
            this.DepthBox.Location = new System.Drawing.Point(299, 113);
            this.DepthBox.Name = "DepthBox";
            this.DepthBox.Size = new System.Drawing.Size(100, 20);
            this.DepthBox.TabIndex = 5;
            this.DepthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Depth_KeyPress);
            // 
            // DrawerLabel
            // 
            this.DrawerLabel.AutoSize = true;
            this.DrawerLabel.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawerLabel.Location = new System.Drawing.Point(86, 148);
            this.DrawerLabel.Name = "DrawerLabel";
            this.DrawerLabel.Size = new System.Drawing.Size(151, 18);
            this.DrawerLabel.TabIndex = 6;
            this.DrawerLabel.Text = "Number of Drawers:";
            // 
            // MatLabel
            // 
            this.MatLabel.AutoSize = true;
            this.MatLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatLabel.Location = new System.Drawing.Point(84, 184);
            this.MatLabel.Name = "MatLabel";
            this.MatLabel.Size = new System.Drawing.Size(82, 21);
            this.MatLabel.TabIndex = 9;
            this.MatLabel.Text = "Material:";
            // 
            // ShipLabel
            // 
            this.ShipLabel.AutoSize = true;
            this.ShipLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShipLabel.Location = new System.Drawing.Point(85, 222);
            this.ShipLabel.Name = "ShipLabel";
            this.ShipLabel.Size = new System.Drawing.Size(85, 21);
            this.ShipLabel.TabIndex = 11;
            this.ShipLabel.Text = "Shipping:";
            // 
            // SubmitQuoteButton
            // 
            this.SubmitQuoteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SubmitQuoteButton.FlatAppearance.BorderSize = 2;
            this.SubmitQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitQuoteButton.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitQuoteButton.Location = new System.Drawing.Point(198, 285);
            this.SubmitQuoteButton.Name = "SubmitQuoteButton";
            this.SubmitQuoteButton.Size = new System.Drawing.Size(80, 80);
            this.SubmitQuoteButton.TabIndex = 12;
            this.SubmitQuoteButton.Text = "Submit Quote";
            this.SubmitQuoteButton.UseVisualStyleBackColor = true;
            this.SubmitQuoteButton.Click += new System.EventHandler(this.SubmitQuoteButton_Click);
            // 
            // backAddQuote
            // 
            this.backAddQuote.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.backAddQuote.FlatAppearance.BorderSize = 2;
            this.backAddQuote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backAddQuote.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backAddQuote.Location = new System.Drawing.Point(88, 285);
            this.backAddQuote.Name = "backAddQuote";
            this.backAddQuote.Size = new System.Drawing.Size(80, 80);
            this.backAddQuote.TabIndex = 13;
            this.backAddQuote.Text = "Back";
            this.backAddQuote.UseVisualStyleBackColor = true;
            this.backAddQuote.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // WidthRange
            // 
            this.WidthRange.AutoSize = true;
            this.WidthRange.Location = new System.Drawing.Point(186, 81);
            this.WidthRange.Name = "WidthRange";
            this.WidthRange.Size = new System.Drawing.Size(74, 13);
            this.WidthRange.TabIndex = 14;
            this.WidthRange.Text = "24 - 96 inches";
            // 
            // DepthRange
            // 
            this.DepthRange.AutoSize = true;
            this.DepthRange.Location = new System.Drawing.Point(185, 116);
            this.DepthRange.Name = "DepthRange";
            this.DepthRange.Size = new System.Drawing.Size(74, 13);
            this.DepthRange.TabIndex = 15;
            this.DepthRange.Text = "12 - 48 inches";
            this.DepthRange.UseMnemonic = false;
            // 
            // DrawersBox
            // 
            this.DrawersBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DrawersBox.FormattingEnabled = true;
            this.DrawersBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.DrawersBox.Location = new System.Drawing.Point(299, 149);
            this.DrawersBox.Name = "DrawersBox";
            this.DrawersBox.Size = new System.Drawing.Size(100, 21);
            this.DrawersBox.TabIndex = 24;
            // 
            // MatBox
            // 
            this.MatBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatBox.FormattingEnabled = true;
            this.MatBox.Items.AddRange(new object[] {
            "Pine",
            "Laminate",
            "Redwood",
            "Oak",
            "Veneer"});
            this.MatBox.Location = new System.Drawing.Point(299, 187);
            this.MatBox.Name = "MatBox";
            this.MatBox.Size = new System.Drawing.Size(100, 21);
            this.MatBox.TabIndex = 25;
            // 
            // ShipBox
            // 
            this.ShipBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShipBox.FormattingEnabled = true;
            this.ShipBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7",
            "14"});
            this.ShipBox.Location = new System.Drawing.Point(299, 225);
            this.ShipBox.Name = "ShipBox";
            this.ShipBox.Size = new System.Drawing.Size(100, 21);
            this.ShipBox.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "(14 day free shipping)";
            this.label1.UseMnemonic = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShipBox);
            this.Controls.Add(this.MatBox);
            this.Controls.Add(this.DrawersBox);
            this.Controls.Add(this.DepthRange);
            this.Controls.Add(this.WidthRange);
            this.Controls.Add(this.backAddQuote);
            this.Controls.Add(this.SubmitQuoteButton);
            this.Controls.Add(this.ShipLabel);
            this.Controls.Add(this.MatLabel);
            this.Controls.Add(this.DrawerLabel);
            this.Controls.Add(this.DepthBox);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox WidthBox;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.TextBox DepthBox;
        private System.Windows.Forms.Label DrawerLabel;
        private System.Windows.Forms.Label MatLabel;
        private System.Windows.Forms.Label ShipLabel;
        private System.Windows.Forms.Button SubmitQuoteButton;
        private System.Windows.Forms.Button backAddQuote;
        private System.Windows.Forms.Label WidthRange;
        private System.Windows.Forms.Label DepthRange;
        private System.Windows.Forms.ComboBox DrawersBox;
        private System.Windows.Forms.ComboBox MatBox;
        private System.Windows.Forms.ComboBox ShipBox;
        private System.Windows.Forms.Label label1;
    }
}