namespace MegaDesk_Anderson
{
    partial class SearchQuotes
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
            this.BackToHome = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.MatBox = new System.Windows.Forms.ComboBox();
            this.MatLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BackToHome
            // 
            this.BackToHome.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BackToHome.FlatAppearance.BorderSize = 2;
            this.BackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHome.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHome.Location = new System.Drawing.Point(28, 111);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(80, 80);
            this.BackToHome.TabIndex = 0;
            this.BackToHome.Text = "Back";
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SearchButton.FlatAppearance.BorderSize = 2;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(147, 111);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 80);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MatBox
            // 
            this.MatBox.FormattingEnabled = true;
            this.MatBox.Items.AddRange(new object[] {
            "Oak",
            "Pine",
            "Veneer",
            "Laminate",
            "Redwood"});
            this.MatBox.Location = new System.Drawing.Point(127, 56);
            this.MatBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MatBox.Name = "MatBox";
            this.MatBox.Size = new System.Drawing.Size(100, 21);
            this.MatBox.TabIndex = 2;
            this.MatBox.Text = "Select Material";
            // 
            // MatLabel
            // 
            this.MatLabel.AutoSize = true;
            this.MatLabel.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatLabel.Location = new System.Drawing.Point(26, 53);
            this.MatLabel.Name = "MatLabel";
            this.MatLabel.Size = new System.Drawing.Size(82, 21);
            this.MatLabel.TabIndex = 24;
            this.MatLabel.Text = "Material:";
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 208);
            this.Controls.Add(this.MatLabel);
            this.Controls.Add(this.MatBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.BackToHome);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToHome;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ComboBox MatBox;
        private System.Windows.Forms.Label MatLabel;
    }
}