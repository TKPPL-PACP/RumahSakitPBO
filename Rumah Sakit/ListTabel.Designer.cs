namespace Rumah_Sakit
{
    partial class ListTabel
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
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
            this.dataGridView1.Size = new System.Drawing.Size(686, 345);
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
            this.tabControl1.Size = new System.Drawing.Size(700, 377);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tabel Kamar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabel Pasien";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(692, 351);
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
            this.tabPage4.Size = new System.Drawing.Size(692, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Tabel Obat";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 427);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form5";
            this.Text = "List Tabel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
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
    }
}