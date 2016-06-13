namespace Rumah_Sakit.Pilihan
{
    partial class frmDetailPembayaran
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
            this.dgvDetailPembayaran = new System.Windows.Forms.DataGridView();
            this.indeks_pembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_pembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHarga_pembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembayaran)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetailPembayaran
            // 
            this.dgvDetailPembayaran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailPembayaran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indeks_pembayaran,
            this.nama_pembayaran,
            this.jumlah_pembayaran,
            this.totalHarga_pembayaran});
            this.dgvDetailPembayaran.Location = new System.Drawing.Point(0, 0);
            this.dgvDetailPembayaran.Name = "dgvDetailPembayaran";
            this.dgvDetailPembayaran.Size = new System.Drawing.Size(674, 344);
            this.dgvDetailPembayaran.TabIndex = 0;
            // 
            // indeks_pembayaran
            // 
            this.indeks_pembayaran.HeaderText = "No.";
            this.indeks_pembayaran.Name = "indeks_pembayaran";
            this.indeks_pembayaran.Width = 35;
            // 
            // nama_pembayaran
            // 
            this.nama_pembayaran.HeaderText = "Nama";
            this.nama_pembayaran.Name = "nama_pembayaran";
            this.nama_pembayaran.Width = 350;
            // 
            // jumlah_pembayaran
            // 
            this.jumlah_pembayaran.HeaderText = "Jumlah";
            this.jumlah_pembayaran.Name = "jumlah_pembayaran";
            // 
            // totalHarga_pembayaran
            // 
            this.totalHarga_pembayaran.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalHarga_pembayaran.HeaderText = "Total Harga";
            this.totalHarga_pembayaran.Name = "totalHarga_pembayaran";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(569, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDetailPembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 396);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvDetailPembayaran);
            this.Name = "frmDetailPembayaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetailPembayaran";
            this.Load += new System.EventHandler(this.frmDetailPembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailPembayaran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetailPembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn indeks_pembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_pembayaran;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalHarga_pembayaran;
        private System.Windows.Forms.Button button1;
    }
}