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
            this.DrawerRange = new System.Windows.Forms.Label();
            this.DrawersBox = new System.Windows.Forms.TextBox();
            this.MatBox = new System.Windows.Forms.TextBox();
            this.ShipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.DepthBox.Validating += new System.ComponentModel.CancelEventHandler(this.Depth_Validating);
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
            // DrawerRange
            // 
            this.DrawerRange.AutoSize = true;
            this.DrawerRange.Location = new System.Drawing.Point(235, 152);
            this.DrawerRange.Name = "DrawerRange";
            this.DrawerRange.Size = new System.Drawing.Size(28, 13);
            this.DrawerRange.TabIndex = 16;
            this.DrawerRange.Text = "0 - 7";
            // 
            // DrawersBox
            // 
            this.DrawersBox.Location = new System.Drawing.Point(299, 150);
            this.DrawersBox.Name = "DrawersBox";
            this.DrawersBox.Size = new System.Drawing.Size(100, 20);
            this.DrawersBox.TabIndex = 18;
            this.DrawersBox.Validating += new System.ComponentModel.CancelEventHandler(this.Drawers_Validating);
            // 
            // MatBox
            // 
            this.MatBox.Location = new System.Drawing.Point(299, 186);
            this.MatBox.Name = "MatBox";
            this.MatBox.Size = new System.Drawing.Size(100, 20);
            this.MatBox.TabIndex = 19;
            this.MatBox.Validating += new System.ComponentModel.CancelEventHandler(this.Material_Validating);
            // 
            // ShipBox
            // 
            this.ShipBox.Location = new System.Drawing.Point(299, 224);
            this.ShipBox.Name = "ShipBox";
            this.ShipBox.Size = new System.Drawing.Size(100, 20);
            this.ShipBox.TabIndex = 20;
            this.ShipBox.Validating += new System.ComponentModel.CancelEventHandler(this.ShipBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Laminate, Redwood,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "3, 5, 7, or 14(free) days";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Oak, Pine, Veneer";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShipBox);
            this.Controls.Add(this.MatBox);
            this.Controls.Add(this.DrawersBox);
            this.Controls.Add(this.DrawerRange);
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
            this.Text = "AddQuote";
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
        private System.Windows.Forms.Label DrawerRange;
        private System.Windows.Forms.TextBox DrawersBox;
        private System.Windows.Forms.TextBox MatBox;
        private System.Windows.Forms.TextBox ShipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}