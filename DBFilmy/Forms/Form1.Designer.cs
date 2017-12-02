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
            this.buttonListOfUsers = new System.Windows.Forms.Button();
            this.buttonStats = new System.Windows.Forms.Button();
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
            this.buttonListOfMovies.Location = new System.Drawing.Point(243, 13);
            this.buttonListOfMovies.Name = "buttonListOfMovies";
            this.buttonListOfMovies.Size = new System.Drawing.Size(134, 23);
            this.buttonListOfMovies.TabIndex = 2;
            this.buttonListOfMovies.Text = "Lista Filmów";
            this.buttonListOfMovies.UseVisualStyleBackColor = true;
            this.buttonListOfMovies.Click += new System.EventHandler(this.buttonListOfMovies_Click);
            // 
            // buttonListOfUsers
            // 
            this.buttonListOfUsers.Location = new System.Drawing.Point(243, 43);
            this.buttonListOfUsers.Name = "buttonListOfUsers";
            this.buttonListOfUsers.Size = new System.Drawing.Size(134, 23);
            this.buttonListOfUsers.TabIndex = 3;
            this.buttonListOfUsers.Text = "Lista Klientów";
            this.buttonListOfUsers.UseVisualStyleBackColor = true;
            // 
            // buttonStats
            // 
            this.buttonStats.Location = new System.Drawing.Point(243, 72);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(134, 23);
            this.buttonStats.TabIndex = 4;
            this.buttonStats.Text = "Statystyki";
            this.buttonStats.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 277);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.buttonListOfUsers);
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
        private System.Windows.Forms.Button buttonListOfUsers;
        private System.Windows.Forms.Button buttonStats;
    }
}

