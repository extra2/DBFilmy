namespace DBFilmy
{
    partial class ReturnMovie
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
            this.buttonReturnMovie = new System.Windows.Forms.Button();
            this.textBoxMovieID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculateBill = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReturnMovie
            // 
            this.buttonReturnMovie.Location = new System.Drawing.Point(9, 80);
            this.buttonReturnMovie.Name = "buttonReturnMovie";
            this.buttonReturnMovie.Size = new System.Drawing.Size(168, 23);
            this.buttonReturnMovie.TabIndex = 0;
            this.buttonReturnMovie.Text = "Zwrot filmu";
            this.buttonReturnMovie.UseVisualStyleBackColor = true;
            this.buttonReturnMovie.Click += new System.EventHandler(this.buttonReturnMovie_Click);
            // 
            // textBoxMovieID
            // 
            this.textBoxMovieID.Location = new System.Drawing.Point(12, 25);
            this.textBoxMovieID.Name = "textBoxMovieID";
            this.textBoxMovieID.Size = new System.Drawing.Size(165, 20);
            this.textBoxMovieID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID filmu";
            // 
            // buttonCalculateBill
            // 
            this.buttonCalculateBill.Location = new System.Drawing.Point(12, 51);
            this.buttonCalculateBill.Name = "buttonCalculateBill";
            this.buttonCalculateBill.Size = new System.Drawing.Size(168, 23);
            this.buttonCalculateBill.TabIndex = 3;
            this.buttonCalculateBill.Text = "Oblicz Rachunek";
            this.buttonCalculateBill.UseVisualStyleBackColor = true;
            this.buttonCalculateBill.Click += new System.EventHandler(this.buttonCalculateBill_Click);
            // 
            // ReturnMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 115);
            this.Controls.Add(this.buttonCalculateBill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMovieID);
            this.Controls.Add(this.buttonReturnMovie);
            this.Name = "ReturnMovie";
            this.Text = "Zwrot filmu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturnMovie;
        private System.Windows.Forms.TextBox textBoxMovieID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculateBill;
    }
}