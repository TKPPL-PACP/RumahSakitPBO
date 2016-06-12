namespace Rumah_Sakit.Pilihan
{
    partial class frmCariPasien
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
            this.chkStatusPembayaran = new System.Windows.Forms.CheckBox();
            this.cboStatusPembayaran = new System.Windows.Forms.ComboBox();
            this.chkTanggalMasuk = new System.Windows.Forms.CheckBox();
            this.chkTanggalKeluar = new System.Windows.Forms.CheckBox();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.dtpTanggalKeluar = new System.Windows.Forms.DateTimePicker();
            this.chkTanggalPembayaran = new System.Windows.Forms.CheckBox();
            this.dtpTanggalPembayaran = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.dgvPasien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTampil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).BeginInit();
            this.SuspendLayout();
            // 
            // chkStatusPembayaran
            // 
            this.chkStatusPembayaran.AutoSize = true;
            this.chkStatusPembayaran.Location = new System.Drawing.Point(12, 23);
            this.chkStatusPembayaran.Name = "chkStatusPembayaran";
            this.chkStatusPembayaran.Size = new System.Drawing.Size(118, 17);
            this.chkStatusPembayaran.TabIndex = 0;
            this.chkStatusPembayaran.Text = "Status Pembayaran";
            this.chkStatusPembayaran.UseVisualStyleBackColor = true;
            this.chkStatusPembayaran.CheckedChanged += new System.EventHandler(this.chkStatusPembayaran_CheckedChanged);
            // 
            // cboStatusPembayaran
            // 
            this.cboStatusPembayaran.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusPembayaran.Enabled = false;
            this.cboStatusPembayaran.FormattingEnabled = true;
            this.cboStatusPembayaran.Items.AddRange(new object[] {
            "Lunas",
            "Belum Lunas"});
            this.cboStatusPembayaran.Location = new System.Drawing.Point(202, 23);
            this.cboStatusPembayaran.Name = "cboStatusPembayaran";
            this.cboStatusPembayaran.Size = new System.Drawing.Size(121, 21);
            this.cboStatusPembayaran.TabIndex = 1;
            // 
            // chkTanggalMasuk
            // 
            this.chkTanggalMasuk.AutoSize = true;
            this.chkTanggalMasuk.Location = new System.Drawing.Point(12, 50);
            this.chkTanggalMasuk.Name = "chkTanggalMasuk";
            this.chkTanggalMasuk.Size = new System.Drawing.Size(100, 17);
            this.chkTanggalMasuk.TabIndex = 4;
            this.chkTanggalMasuk.Text = "Tanggal Masuk";
            this.chkTanggalMasuk.UseVisualStyleBackColor = true;
            this.chkTanggalMasuk.CheckedChanged += new System.EventHandler(this.chkTanggalMasuk_CheckedChanged);
            // 
            // chkTanggalKeluar
            // 
            this.chkTanggalKeluar.AutoSize = true;
            this.chkTanggalKeluar.Location = new System.Drawing.Point(12, 79);
            this.chkTanggalKeluar.Name = "chkTanggalKeluar";
            this.chkTanggalKeluar.Size = new System.Drawing.Size(98, 17);
            this.chkTanggalKeluar.TabIndex = 5;
            this.chkTanggalKeluar.Text = "Tanggal Keluar";
            this.chkTanggalKeluar.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Enabled = false;
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(202, 50);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalMasuk.TabIndex = 3;
            // 
            // dtpTanggalKeluar
            // 
            this.dtpTanggalKeluar.Enabled = false;
            this.dtpTanggalKeluar.Location = new System.Drawing.Point(202, 79);
            this.dtpTanggalKeluar.Name = "dtpTanggalKeluar";
            this.dtpTanggalKeluar.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalKeluar.TabIndex = 6;
            // 
            // chkTanggalPembayaran
            // 
            this.chkTanggalPembayaran.AutoSize = true;
            this.chkTanggalPembayaran.Location = new System.Drawing.Point(12, 112);
            this.chkTanggalPembayaran.Name = "chkTanggalPembayaran";
            this.chkTanggalPembayaran.Size = new System.Drawing.Size(127, 17);
            this.chkTanggalPembayaran.TabIndex = 7;
            this.chkTanggalPembayaran.Text = "Tanggal Pembayaran";
            this.chkTanggalPembayaran.UseVisualStyleBackColor = true;
            // 
            // dtpTanggalPembayaran
            // 
            this.dtpTanggalPembayaran.Enabled = false;
            this.dtpTanggalPembayaran.Location = new System.Drawing.Point(202, 112);
            this.dtpTanggalPembayaran.Name = "dtpTanggalPembayaran";
            this.dtpTanggalPembayaran.Size = new System.Drawing.Size(200, 20);
            this.dtpTanggalPembayaran.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nama";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(202, 141);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(200, 20);
            this.txtCari.TabIndex = 10;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // dgvPasien
            // 
            this.dgvPasien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column10,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvPasien.Location = new System.Drawing.Point(12, 194);
            this.dgvPasien.Name = "dgvPasien";
            this.dgvPasien.Size = new System.Drawing.Size(729, 173);
            this.dgvPasien.TabIndex = 11;
            this.dgvPasien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasien_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Pasien";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Alamat";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tanggal Lahir";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Jenis Kelamin";
            this.Column5.Name = "Column5";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Kamar";
            this.Column10.Name = "Column10";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status Pembayaran";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tanggal Masuk";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tanggal Keluar";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Tanggal Pembayaran";
            this.Column9.Name = "Column9";
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(202, 167);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 12;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // frmCariPasien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 379);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.dgvPasien);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpTanggalPembayaran);
            this.Controls.Add(this.chkTanggalPembayaran);
            this.Controls.Add(this.dtpTanggalKeluar);
            this.Controls.Add(this.chkTanggalKeluar);
            this.Controls.Add(this.chkTanggalMasuk);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.cboStatusPembayaran);
            this.Controls.Add(this.chkStatusPembayaran);
            this.Name = "frmCariPasien";
            this.Text = "frmPasien";
            this.Load += new System.EventHandler(this.frmPasien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkStatusPembayaran;
        private System.Windows.Forms.ComboBox cboStatusPembayaran;
        private System.Windows.Forms.CheckBox chkTanggalMasuk;
        private System.Windows.Forms.CheckBox chkTanggalKeluar;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.DateTimePicker dtpTanggalKeluar;
        private System.Windows.Forms.CheckBox chkTanggalPembayaran;
        private System.Windows.Forms.DateTimePicker dtpTanggalPembayaran;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridView dgvPasien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Button btnTampil;
    }
}