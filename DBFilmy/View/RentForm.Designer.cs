namespace DBFilmy
{
    partial class RentForm
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
            this.textBoxIDClient = new System.Windows.Forms.TextBox();
            this.textBoxIDMovie = new System.Windows.Forms.TextBox();
            this.buttonRent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIDClient
            // 
            this.textBoxIDClient.Location = new System.Drawing.Point(12, 25);
            this.textBoxIDClient.Name = "textBoxIDClient";
            this.textBoxIDClient.Size = new System.Drawing.Size(184, 20);
            this.textBoxIDClient.TabIndex = 0;
            // 
            // textBoxIDMovie
            // 
            this.textBoxIDMovie.Location = new System.Drawing.Point(12, 75);
            this.textBoxIDMovie.Name = "textBoxIDMovie";
            this.textBoxIDMovie.Size = new System.Drawing.Size(184, 20);
            this.textBoxIDMovie.TabIndex = 2;
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(12, 110);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(184, 23);
            this.buttonRent.TabIndex = 3;
            this.buttonRent.Text = "Wypożycz";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID Klienta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID Płyty";
            // 
            // RentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 146);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.textBoxIDMovie);
            this.Controls.Add(this.textBoxIDClient);
            this.Name = "RentForm";
            this.Text = "Wypożycz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIDClient;
        private System.Windows.Forms.TextBox textBoxIDMovie;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}