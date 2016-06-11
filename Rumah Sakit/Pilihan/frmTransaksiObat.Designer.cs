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
            this.label3 = new System.Windows.Forms.Label();
            this.txtJumlahHarga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaSatuan_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargatotalsatuan_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Pasien :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama Pasien :";
            // 
            // txtIdPasien
            // 
            this.txtIdPasien.Location = new System.Drawing.Point(201, 17);
            this.txtIdPasien.Name = "txtIdPasien";
            this.txtIdPasien.Size = new System.Drawing.Size(151, 20);
            this.txtIdPasien.TabIndex = 1;
            // 
            // txtNamaPasien
            // 
            this.txtNamaPasien.Location = new System.Drawing.Point(201, 43);
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
            this.dgvObat.Location = new System.Drawing.Point(23, 77);
            this.dgvObat.Name = "dgvObat";
            this.dgvObat.Size = new System.Drawing.Size(445, 312);
            this.dgvObat.TabIndex = 2;
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
            this.txtJumlahHarga.Text = "Rp. 55.000";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(90, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
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
            // frmTransaksiObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 437);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtJumlahHarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvObat);
            this.Controls.Add(this.txtNamaPasien);
            this.Controls.Add(this.txtIdPasien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTransaksiObat";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaSatuan_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargatotalsatuan_obat;
    }
}