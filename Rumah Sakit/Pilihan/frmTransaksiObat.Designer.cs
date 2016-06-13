namespace Rumah_Sakit.Pilihan
{
    partial class frmTransaksiObat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdPasien = new System.Windows.Forms.TextBox();
            this.txtNamaPasien = new System.Windows.Forms.TextBox();
            this.dgvObat = new System.Windows.Forms.DataGridView();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuan_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargatotalsatuan_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJumlahHarga = new System.Windows.Forms.TextBox();
            this.btnHitung = new System.Windows.Forms.Button();
            this.btnTebus = new System.Windows.Forms.Button();
            this.btnCariResepObat = new System.Windows.Forms.Button();
            this.lblIDResepObat = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pasien :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Pasien :";
            // 
            // txtIdPasien
            // 
            this.txtIdPasien.Location = new System.Drawing.Point(111, 46);
            this.txtIdPasien.Name = "txtIdPasien";
            this.txtIdPasien.Size = new System.Drawing.Size(151, 20);
            this.txtIdPasien.TabIndex = 1;
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Location = new System.Drawing.Point(111, 72);
            this.txtNamaPasien.Name = "txtNamaPasien";
            this.txtNamaPasien.Size = new System.Drawing.Size(151, 20);
            this.txtNamaPasien.TabIndex = 1;
            // 
            // dgvObat
            // 
            this.dgvObat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nama_obat,
            this.jumlah_obat,
            this.hargaSatuan_obat,
            this.hargatotalsatuan_obat});
            this.dgvObat.Location = new System.Drawing.Point(23, 120);
            this.dgvObat.Name = "dgvObat";
            this.dgvObat.Size = new System.Drawing.Size(445, 269);
            this.dgvObat.TabIndex = 2;
            // 
            // nama_obat
            // 
            this.nama_obat.HeaderText = "Nama";
            this.nama_obat.Name = "nama_obat";
            // 
            // jumlah_obat
            // 
            this.jumlah_obat.HeaderText = "Jumlah";
            this.jumlah_obat.Name = "jumlah_obat";
            // 
            // hargaSatuan_obat
            // 
            this.hargaSatuan_obat.HeaderText = "Harga / Satuan";
            this.hargaSatuan_obat.Name = "hargaSatuan_obat";
            // 
            // hargatotalsatuan_obat
            // 
            this.hargatotalsatuan_obat.HeaderText = "Total Harga";
            this.hargatotalsatuan_obat.Name = "hargatotalsatuan_obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jumlah Harga :";
            // 
            // txtJumlahHarga
            // 
            this.txtJumlahHarga.Enabled = false;
            this.txtJumlahHarga.Location = new System.Drawing.Point(347, 404);
            this.txtJumlahHarga.Name = "txtJumlahHarga";
            this.txtJumlahHarga.Size = new System.Drawing.Size(121, 20);
            this.txtJumlahHarga.TabIndex = 4;
            this.txtJumlahHarga.TextChanged += new System.EventHandler(this.txtJumlahHarga_TextChanged);
            // 
            // btnHitung
            // 
            this.btnHitung.Location = new System.Drawing.Point(23, 403);
            this.btnHitung.Name = "btnHitung";
            this.btnHitung.Size = new System.Drawing.Size(75, 22);
            this.btnHitung.TabIndex = 5;
            this.btnHitung.Text = "Hitung";
            this.btnHitung.UseVisualStyleBackColor = true;
            this.btnHitung.Click += new System.EventHandler(this.btnHitung_Click);
            // 
            // btnTebus
            // 
            this.btnTebus.Location = new System.Drawing.Point(111, 404);
            this.btnTebus.Name = "btnTebus";
            this.btnTebus.Size = new System.Drawing.Size(75, 22);
            this.btnTebus.TabIndex = 6;
            this.btnTebus.Text = "Tebus";
            this.btnTebus.UseVisualStyleBackColor = true;
            // 
            // btnCariResepObat
            // 
            this.btnCariResepObat.Location = new System.Drawing.Point(290, 18);
            this.btnCariResepObat.Name = "btnCariResepObat";
            this.btnCariResepObat.Size = new System.Drawing.Size(98, 23);
            this.btnCariResepObat.TabIndex = 7;
            this.btnCariResepObat.Text = "Cari Resep Obat";
            this.btnCariResepObat.UseVisualStyleBackColor = true;
            // 
            // lblIDResepObat
            // 
            this.lblIDResepObat.AutoSize = true;
            this.lblIDResepObat.Location = new System.Drawing.Point(20, 20);
            this.lblIDResepObat.Name = "lblIDResepObat";
            this.lblIDResepObat.Size = new System.Drawing.Size(84, 13);
            this.lblIDResepObat.TabIndex = 8;
            this.lblIDResepObat.Text = "ID Resep Obat :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 9;
            // 
            // frmTransaksiObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 437);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblIDResepObat);
            this.Controls.Add(this.btnCariResepObat);
            this.Controls.Add(this.btnTebus);
            this.Controls.Add(this.btnHitung);
            this.Controls.Add(this.txtJumlahHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvObat);
            this.Controls.Add(this.txtNamaPasien);
            this.Controls.Add(this.txtIdPasien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransaksiObat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransaksiObat";
            this.Load += new System.EventHandler(this.frmTransaksiObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdPasien;
        private System.Windows.Forms.TextBox txtNamaPasien;
        private System.Windows.Forms.DataGridView dgvObat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtJumlahHarga;
        private System.Windows.Forms.Button btnHitung;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuan_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargatotalsatuan_obat;
        private System.Windows.Forms.Button btnTebus;
        private System.Windows.Forms.Button btnCariResepObat;
        private System.Windows.Forms.Label lblIDResepObat;
        private System.Windows.Forms.TextBox textBox1;
    }
}