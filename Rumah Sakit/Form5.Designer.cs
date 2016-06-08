namespace Rumah_Sakit
{
    partial class Form5
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 339);
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
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 365);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "List Tabel Obat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
    }
}