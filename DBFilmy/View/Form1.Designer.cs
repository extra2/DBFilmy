namespace DBFilmy
{
    partial class Form1
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
            this.buttonAddNewClient = new System.Windows.Forms.Button();
            this.buttonAddNewMovie = new System.Windows.Forms.Button();
            this.buttonListOfMovies = new System.Windows.Forms.Button();
            this.buttonRent = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddNewClient
            // 
            this.buttonAddNewClient.Location = new System.Drawing.Point(13, 13);
            this.buttonAddNewClient.Name = "buttonAddNewClient";
            this.buttonAddNewClient.Size = new System.Drawing.Size(136, 23);
            this.buttonAddNewClient.TabIndex = 0;
            this.buttonAddNewClient.Text = "Dodaj Klienta";
            this.buttonAddNewClient.UseVisualStyleBackColor = true;
            this.buttonAddNewClient.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // buttonAddNewMovie
            // 
            this.buttonAddNewMovie.Location = new System.Drawing.Point(15, 42);
            this.buttonAddNewMovie.Name = "buttonAddNewMovie";
            this.buttonAddNewMovie.Size = new System.Drawing.Size(134, 24);
            this.buttonAddNewMovie.TabIndex = 1;
            this.buttonAddNewMovie.Text = "Dodaj nowy film do bazy";
            this.buttonAddNewMovie.UseVisualStyleBackColor = true;
            this.buttonAddNewMovie.Click += new System.EventHandler(this.buttonAddNewMovie_Click);
            // 
            // buttonListOfMovies
            // 
            this.buttonListOfMovies.Location = new System.Drawing.Point(15, 72);
            this.buttonListOfMovies.Name = "buttonListOfMovies";
            this.buttonListOfMovies.Size = new System.Drawing.Size(134, 23);
            this.buttonListOfMovies.TabIndex = 2;
            this.buttonListOfMovies.Text = "Lista Filmów";
            this.buttonListOfMovies.UseVisualStyleBackColor = true;
            this.buttonListOfMovies.Click += new System.EventHandler(this.buttonListOfMovies_Click);
            // 
            // buttonRent
            // 
            this.buttonRent.Location = new System.Drawing.Point(12, 101);
            this.buttonRent.Name = "buttonRent";
            this.buttonRent.Size = new System.Drawing.Size(149, 23);
            this.buttonRent.TabIndex = 3;
            this.buttonRent.Text = "Wypożyczenie filmu";
            this.buttonRent.UseVisualStyleBackColor = true;
            this.buttonRent.Click += new System.EventHandler(this.buttonRent_Click);
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(15, 208);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(163, 23);
            this.buttonStats.TabIndex = 4;
            this.buttonStats.Text = "Statystyki -> todo funkcja";
            this.buttonStats.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Zwrot filmu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Transakcje";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 268);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.buttonRent);
            this.Controls.Add(this.buttonListOfMovies);
            this.Controls.Add(this.buttonAddNewMovie);
            this.Controls.Add(this.buttonAddNewClient);
            this.Name = "Form1";
            this.Text = "Wypożyczalnia Filmów";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddNewClient;
        private System.Windows.Forms.Button buttonAddNewMovie;
        private System.Windows.Forms.Button buttonListOfMovies;
        private System.Windows.Forms.Button buttonRent;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

