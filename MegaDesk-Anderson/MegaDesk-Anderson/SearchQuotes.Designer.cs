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
            this.SuspendLayout();
            // 
            // BackToHome
            // 
            this.BackToHome.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BackToHome.FlatAppearance.BorderSize = 2;
            this.BackToHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackToHome.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToHome.Location = new System.Drawing.Point(287, 305);
            this.BackToHome.Name = "BackToHome";
            this.BackToHome.Size = new System.Drawing.Size(80, 80);
            this.BackToHome.TabIndex = 0;
            this.BackToHome.Text = "Back";
            this.BackToHome.UseVisualStyleBackColor = true;
            this.BackToHome.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackToHome);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackToHome;
    }
}