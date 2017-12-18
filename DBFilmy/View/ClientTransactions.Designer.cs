namespace DBFilmy.View
{
    partial class ClientTransactions
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxRefresh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.ClientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Returned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientID,
            this.MovieID,
            this.Client,
            this.Title,
            this.Returned,
            this.Cost});
            this.dataGridView1.Location = new System.Drawing.Point(105, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(647, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBoxRefresh
            // 
            this.textBoxRefresh.Location = new System.Drawing.Point(-1, 24);
            this.textBoxRefresh.Name = "textBoxRefresh";
            this.textBoxRefresh.Size = new System.Drawing.Size(100, 20);
            this.textBoxRefresh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Klienta:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(-1, 50);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(100, 23);
            this.buttonRefresh.TabIndex = 3;
            this.buttonRefresh.Text = "Odśwież";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // ClientID
            // 
            this.ClientID.HeaderText = "ID klienta";
            this.ClientID.Name = "ClientID";
            this.ClientID.ReadOnly = true;
            // 
            // MovieID
            // 
            this.MovieID.HeaderText = "ID Filmu";
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            // 
            // Client
            // 
            this.Client.HeaderText = "Klient";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Film";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Returned
            // 
            this.Returned.HeaderText = "Zwrócono";
            this.Returned.Name = "Returned";
            this.Returned.ReadOnly = true;
            // 
            // Cost
            // 
            this.Cost.HeaderText = "Aktualny Koszt";
            this.Cost.Name = "Cost";
            this.Cost.ReadOnly = true;
            // 
            // ClientTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 260);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxRefresh);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientTransactions";
            this.Text = "Transakcje Klienta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Returned;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cost;
    }
}