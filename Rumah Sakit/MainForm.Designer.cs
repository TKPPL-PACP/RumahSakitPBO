namespace Rumah_Sakit
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasienToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawaiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tampilkanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegawaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janjiDokterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahKamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cariKamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailKamarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembayaranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawatInapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.obatToolStripMenuItem,
            this.tampilkanToolStripMenuItem,
            this.janjiDokterToolStripMenuItem,
            this.kamarToolStripMenuItem,
            this.pembayaranToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasienToolStripMenuItem1,
            this.pegawaiToolStripMenuItem1,
            this.rawatInapToolStripMenuItem});
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // pasienToolStripMenuItem1
            // 
            this.pasienToolStripMenuItem1.Name = "pasienToolStripMenuItem1";
            this.pasienToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pasienToolStripMenuItem1.Text = "Pasien";
            this.pasienToolStripMenuItem1.Click += new System.EventHandler(this.pasienToolStripMenuItem1_Click);
            // 
            // pegawaiToolStripMenuItem1
            // 
            this.pegawaiToolStripMenuItem1.Name = "pegawaiToolStripMenuItem1";
            this.pegawaiToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.pegawaiToolStripMenuItem1.Text = "Pegawai";
            this.pegawaiToolStripMenuItem1.Click += new System.EventHandler(this.pegawaiToolStripMenuItem1_Click);
            // 
            // obatToolStripMenuItem
            // 
            this.obatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahObatToolStripMenuItem,
            this.transaksiObatToolStripMenuItem});
            this.obatToolStripMenuItem.Name = "obatToolStripMenuItem";
            this.obatToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.obatToolStripMenuItem.Text = "Obat";
            // 
            // tambahObatToolStripMenuItem
            // 
            this.tambahObatToolStripMenuItem.Name = "tambahObatToolStripMenuItem";
            this.tambahObatToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tambahObatToolStripMenuItem.Text = "Tambah Obat";
            this.tambahObatToolStripMenuItem.Click += new System.EventHandler(this.tambahObatToolStripMenuItem_Click);
            // 
            // transaksiObatToolStripMenuItem
            // 
            this.transaksiObatToolStripMenuItem.Name = "transaksiObatToolStripMenuItem";
            this.transaksiObatToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.transaksiObatToolStripMenuItem.Text = "Transaksi Obat";
            this.transaksiObatToolStripMenuItem.Click += new System.EventHandler(this.transaksiObatToolStripMenuItem_Click);
            // 
            // tampilkanToolStripMenuItem
            // 
            this.tampilkanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasienToolStripMenuItem,
            this.pegawaiToolStripMenuItem});
            this.tampilkanToolStripMenuItem.Name = "tampilkanToolStripMenuItem";
            this.tampilkanToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.tampilkanToolStripMenuItem.Text = "Tampilkan";
            this.tampilkanToolStripMenuItem.Click += new System.EventHandler(this.tampilkanToolStripMenuItem_Click);
            // 
            // pasienToolStripMenuItem
            // 
            this.pasienToolStripMenuItem.Name = "pasienToolStripMenuItem";
            this.pasienToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pasienToolStripMenuItem.Text = "Pasien";
            this.pasienToolStripMenuItem.Click += new System.EventHandler(this.pasienToolStripMenuItem_Click);
            // 
            // pegawaiToolStripMenuItem
            // 
            this.pegawaiToolStripMenuItem.Name = "pegawaiToolStripMenuItem";
            this.pegawaiToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.pegawaiToolStripMenuItem.Text = "Pegawai";
            this.pegawaiToolStripMenuItem.Click += new System.EventHandler(this.pegawaiToolStripMenuItem_Click);
            // 
            // janjiDokterToolStripMenuItem
            // 
            this.janjiDokterToolStripMenuItem.Name = "janjiDokterToolStripMenuItem";
            this.janjiDokterToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.janjiDokterToolStripMenuItem.Text = "Janji Dokter";
            this.janjiDokterToolStripMenuItem.Click += new System.EventHandler(this.janjiDokterToolStripMenuItem_Click);
            // 
            // kamarToolStripMenuItem
            // 
            this.kamarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahKamarToolStripMenuItem,
            this.cariKamarToolStripMenuItem,
            this.detailKamarToolStripMenuItem});
            this.kamarToolStripMenuItem.Name = "kamarToolStripMenuItem";
            this.kamarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.kamarToolStripMenuItem.Text = "Kamar";
            // 
            // tambahKamarToolStripMenuItem
            // 
            this.tambahKamarToolStripMenuItem.Name = "tambahKamarToolStripMenuItem";
            this.tambahKamarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.tambahKamarToolStripMenuItem.Text = "Tambah Kamar";
            this.tambahKamarToolStripMenuItem.Click += new System.EventHandler(this.tambahKamarToolStripMenuItem_Click);
            // 
            // cariKamarToolStripMenuItem
            // 
            this.cariKamarToolStripMenuItem.Name = "cariKamarToolStripMenuItem";
            this.cariKamarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cariKamarToolStripMenuItem.Text = "Cari Kamar";
            this.cariKamarToolStripMenuItem.Click += new System.EventHandler(this.cariKamarToolStripMenuItem_Click);
            // 
            // detailKamarToolStripMenuItem
            // 
            this.detailKamarToolStripMenuItem.Name = "detailKamarToolStripMenuItem";
            this.detailKamarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.detailKamarToolStripMenuItem.Text = "Detail Kamar";
            this.detailKamarToolStripMenuItem.Click += new System.EventHandler(this.detailKamarToolStripMenuItem_Click);
            // 
            // pembayaranToolStripMenuItem
            // 
            this.pembayaranToolStripMenuItem.Name = "pembayaranToolStripMenuItem";
            this.pembayaranToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.pembayaranToolStripMenuItem.Text = "Pembayaran";
            this.pembayaranToolStripMenuItem.Click += new System.EventHandler(this.pembayaranToolStripMenuItem_Click);
            // 
            // rawatInapToolStripMenuItem
            // 
            this.rawatInapToolStripMenuItem.Name = "rawatInapToolStripMenuItem";
            this.rawatInapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rawatInapToolStripMenuItem.Text = "Rawat Inap";
            this.rawatInapToolStripMenuItem.Click += new System.EventHandler(this.rawatInapToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(518, 323);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tampilkanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janjiDokterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahKamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cariKamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailKamarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasienToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pegawaiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pembayaranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawatInapToolStripMenuItem;
    }
}

