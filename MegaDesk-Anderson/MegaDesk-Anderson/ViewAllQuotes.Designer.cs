namespace MegaDesk_Anderson
{
    partial class ViewAllQuotes
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
            this.backViewQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backViewQuotes
            // 
            this.backViewQuotes.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.backViewQuotes.FlatAppearance.BorderSize = 2;
            this.backViewQuotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backViewQuotes.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backViewQuotes.Location = new System.Drawing.Point(289, 323);
            this.backViewQuotes.Name = "backViewQuotes";
            this.backViewQuotes.Size = new System.Drawing.Size(80, 80);
            this.backViewQuotes.TabIndex = 0;
            this.backViewQuotes.Text = "Back";
            this.backViewQuotes.UseVisualStyleBackColor = true;
            this.backViewQuotes.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backViewQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backViewQuotes;
    }
}