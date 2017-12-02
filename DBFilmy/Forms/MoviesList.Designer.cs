namespace DBFilmy.Forms
{
    partial class MoviesList
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
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearLimitation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Copies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelCrit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AllowUserToAddRows = false;
            this.dataGridViewMovies.AllowUserToDeleteRows = false;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Director,
            this.ReleaseDate,
            this.YearLimitation,
            this.Category,
            this.Price,
            this.Penalty,
            this.Copies,
            this.Modify,
            this.DeleteRow});
            this.dataGridViewMovies.Location = new System.Drawing.Point(206, 0);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.ShowEditingIcon = false;
            this.dataGridViewMovies.Size = new System.Drawing.Size(964, 291);
            this.dataGridViewMovies.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.HeaderText = "Tytuł";
            this.Title.Name = "Title";
            // 
            // Director
            // 
            this.Director.HeaderText = "Reżyser";
            this.Director.Name = "Director";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.HeaderText = "Data premiery";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // YearLimitation
            // 
            this.YearLimitation.HeaderText = "Klasyfikacja Wiekowa";
            this.YearLimitation.Name = "YearLimitation";
            // 
            // Category
            // 
            this.Category.HeaderText = "Kategoria";
            this.Category.Name = "Category";
            // 
            // Price
            // 
            this.Price.HeaderText = "Cena";
            this.Price.Name = "Price";
            // 
            // Penalty
            // 
            this.Penalty.HeaderText = "Kara za przetrzymanie";
            this.Penalty.Name = "Penalty";
            // 
            // Copies
            // 
            this.Copies.HeaderText = "Dostępność [szt]";
            this.Copies.Name = "Copies";
            // 
            // Modify
            // 
            this.Modify.HeaderText = "Modyfikuj";
            this.Modify.Name = "Modify";
            this.Modify.Text = "Modyfikuj";
            this.Modify.Width = 60;
            // 
            // DeleteRow
            // 
            this.DeleteRow.HeaderText = "Usuń";
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Width = 60;
            // 
            // labelCrit
            // 
            this.labelCrit.AutoSize = true;
            this.labelCrit.Location = new System.Drawing.Point(0, 0);
            this.labelCrit.Name = "labelCrit";
            this.labelCrit.Size = new System.Drawing.Size(100, 13);
            this.labelCrit.TabIndex = 1;
            this.labelCrit.Text = "Kryteria wyszukania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reżyser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tytuł";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Kategoria";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(0, 35);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 7;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(0, 81);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(100, 20);
            this.textBoxDirector.TabIndex = 8;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(-5, 153);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 12;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(0, 127);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(100, 20);
            this.textBoxCategory.TabIndex = 10;
            // 
            // MoviesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 519);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCrit);
            this.Controls.Add(this.dataGridViewMovies);
            this.Name = "MoviesList";
            this.Text = "Lista Filmów";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Director;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearLimitation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Penalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Copies;
        private System.Windows.Forms.DataGridViewButtonColumn Modify;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteRow;
        private System.Windows.Forms.Label labelCrit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TextBox textBoxCategory;
    }
}