namespace Rumah_Sakit
{
    partial class frmListTabel
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
            this.id_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deskripsi_obat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.id_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglLahir_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jk_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglMasuk_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gaji_pegawai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.id_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tglLahir_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jk_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keluhan_pasien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.id_kamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomor_kamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lt_kamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kapasitas_kamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan_kamar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_obat,
            this.nama_obat,
            this.harga_obat,
            this.stock_obat,
            this.satuan_obat,
            this.deskripsi_obat});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id_obat
            // 
            this.id_obat.FillWeight = 50F;
            this.id_obat.HeaderText = "ID Obat";
            this.id_obat.Name = "id_obat";
            // 
            // nama_obat
            // 
            this.nama_obat.HeaderText = "Nama Obat";
            this.nama_obat.Name = "nama_obat";
            // 
            // harga_obat
            // 
            this.harga_obat.HeaderText = "Harga";
            this.harga_obat.Name = "harga_obat";
            // 
            // stock_obat
            // 
            this.stock_obat.HeaderText = "Stock";
            this.stock_obat.Name = "stock_obat";
            // 
            // satuan_obat
            // 
            this.satuan_obat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.satuan_obat.HeaderText = "Satuan";
            this.satuan_obat.Name = "satuan_obat";
            // 
            // deskripsi_obat
            // 
            this.deskripsi_obat.HeaderText = "Deskripsi";
            this.deskripsi_obat.Name = "deskripsi_obat";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(757, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(749, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabel Kamar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(749, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabel Pasien";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(749, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tabel Pegawai";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(749, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tabel Obat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pegawai,
            this.nama_pegawai,
            this.tglLahir_pegawai,
            this.alamat_pegawai,
            this.jk_pegawai,
            this.tglMasuk_pegawai,
            this.gaji_pegawai});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(743, 345);
            this.dataGridView2.TabIndex = 0;
            // 
            // id_pegawai
            // 
            this.id_pegawai.HeaderText = "No. ID";
            this.id_pegawai.Name = "id_pegawai";
            // 
            // nama_pegawai
            // 
            this.nama_pegawai.HeaderText = "Nama";
            this.nama_pegawai.Name = "nama_pegawai";
            // 
            // tglLahir_pegawai
            // 
            this.tglLahir_pegawai.HeaderText = "Tanggal Lahir";
            this.tglLahir_pegawai.Name = "tglLahir_pegawai";
            // 
            // alamat_pegawai
            // 
            this.alamat_pegawai.HeaderText = "Alamat";
            this.alamat_pegawai.Name = "alamat_pegawai";
            // 
            // jk_pegawai
            // 
            this.jk_pegawai.HeaderText = "Jenis Kelamin";
            this.jk_pegawai.Name = "jk_pegawai";
            // 
            // tglMasuk_pegawai
            // 
            this.tglMasuk_pegawai.HeaderText = "Tanggal Masuk";
            this.tglMasuk_pegawai.Name = "tglMasuk_pegawai";
            // 
            // gaji_pegawai
            // 
            this.gaji_pegawai.HeaderText = "Gaji";
            this.gaji_pegawai.Name = "gaji_pegawai";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_pasien,
            this.nama_pasien,
            this.tglLahir_pasien,
            this.alamat_pasien,
            this.jk_pasien,
            this.keluhan_pasien});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(743, 345);
            this.dataGridView3.TabIndex = 1;
            // 
            // id_pasien
            // 
            this.id_pasien.HeaderText = "No. ID";
            this.id_pasien.Name = "id_pasien";
            // 
            // nama_pasien
            // 
            this.nama_pasien.HeaderText = "Nama ";
            this.nama_pasien.Name = "nama_pasien";
            // 
            // tglLahir_pasien
            // 
            this.tglLahir_pasien.HeaderText = "Tanggal Lahir";
            this.tglLahir_pasien.Name = "tglLahir_pasien";
            // 
            // alamat_pasien
            // 
            this.alamat_pasien.HeaderText = "Alamat";
            this.alamat_pasien.Name = "alamat_pasien";
            // 
            // jk_pasien
            // 
            this.jk_pasien.HeaderText = "Jenis Kelamin";
            this.jk_pasien.Name = "jk_pasien";
            // 
            // keluhan_pasien
            // 
            this.keluhan_pasien.HeaderText = "Keluhan";
            this.keluhan_pasien.Name = "keluhan_pasien";
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kamar,
            this.nomor_kamar,
            this.lt_kamar,
            this.jenis_kamar,
            this.kapasitas_kamar,
            this.keterangan_kamar});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 3);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(743, 345);
            this.dataGridView4.TabIndex = 0;
            // 
            // id_kamar
            // 
            this.id_kamar.HeaderText = "No. ID";
            this.id_kamar.Name = "id_kamar";
            // 
            // nomor_kamar
            // 
            this.nomor_kamar.HeaderText = "No. Kamar";
            this.nomor_kamar.Name = "nomor_kamar";
            // 
            // lt_kamar
            // 
            this.lt_kamar.HeaderText = "Lantai";
            this.lt_kamar.Name = "lt_kamar";
            // 
            // jenis_kamar
            // 
            this.jenis_kamar.HeaderText = "Jenis Kamar";
            this.jenis_kamar.Name = "jenis_kamar";
            // 
            // kapasitas_kamar
            // 
            this.kapasitas_kamar.HeaderText = "Kapasitas";
            this.kapasitas_kamar.Name = "kapasitas_kamar";
            // 
            // keterangan_kamar
            // 
            this.keterangan_kamar.HeaderText = "Keterangan";
            this.keterangan_kamar.Name = "keterangan_kamar";
            // 
            // ListTabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 427);
            this.Controls.Add(this.tabControl1);
            this.Name = "ListTabel";
            this.Text = "List Tabel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan_obat;
        private System.Windows.Forms.DataGridViewTextBoxColumn deskripsi_obat;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglLahir_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn keluhan_pasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglLahir_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn jk_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tglMasuk_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn gaji_pegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomor_kamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn lt_kamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_kamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kapasitas_kamar;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan_kamar;
    }
}