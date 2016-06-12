namespace Rumah_Sakit.Pilihan
{
    partial class frmCariPegawai
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
            this.chkIdPegawai = new System.Windows.Forms.CheckBox();
            this.txtIdPegawai = new System.Windows.Forms.TextBox();
            this.chkJob = new System.Windows.Forms.CheckBox();
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.btnTampil = new System.Windows.Forms.Button();
            this.dgvCariPegawai = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkNip = new System.Windows.Forms.CheckBox();
            this.txtNip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariPegawai)).BeginInit();
            this.SuspendLayout();
            // 
            // chkIdPegawai
            // 
            this.chkIdPegawai.AutoSize = true;
            this.chkIdPegawai.Location = new System.Drawing.Point(12, 21);
            this.chkIdPegawai.Name = "chkIdPegawai";
            this.chkIdPegawai.Size = new System.Drawing.Size(81, 17);
            this.chkIdPegawai.TabIndex = 0;
            this.chkIdPegawai.Text = "ID Pegawai";
            this.chkIdPegawai.UseVisualStyleBackColor = true;
            this.chkIdPegawai.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtIdPegawai
            // 
            this.txtIdPegawai.Enabled = false;
            this.txtIdPegawai.Location = new System.Drawing.Point(173, 19);
            this.txtIdPegawai.Name = "txtIdPegawai";
            this.txtIdPegawai.Size = new System.Drawing.Size(135, 20);
            this.txtIdPegawai.TabIndex = 1;
            // 
            // chkJob
            // 
            this.chkJob.AutoSize = true;
            this.chkJob.Location = new System.Drawing.Point(12, 56);
            this.chkJob.Name = "chkJob";
            this.chkJob.Size = new System.Drawing.Size(43, 17);
            this.chkJob.TabIndex = 2;
            this.chkJob.Text = "Job";
            this.chkJob.UseVisualStyleBackColor = true;
            this.chkJob.CheckedChanged += new System.EventHandler(this.chkJob_CheckedChanged);
            // 
            // cboJob
            // 
            this.cboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboJob.Enabled = false;
            this.cboJob.FormattingEnabled = true;
            this.cboJob.Items.AddRange(new object[] {
            "Dokter",
            "Perawat",
            "Administrator",
            "Janitor"});
            this.cboJob.Location = new System.Drawing.Point(173, 56);
            this.cboJob.Name = "cboJob";
            this.cboJob.Size = new System.Drawing.Size(135, 21);
            this.cboJob.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(173, 119);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(135, 20);
            this.txtNama.TabIndex = 5;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // btnTampil
            // 
            this.btnTampil.Location = new System.Drawing.Point(173, 149);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(75, 23);
            this.btnTampil.TabIndex = 13;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // dgvCariPegawai
            // 
            this.dgvCariPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCariPegawai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvCariPegawai.Location = new System.Drawing.Point(12, 199);
            this.dgvCariPegawai.Name = "dgvCariPegawai";
            this.dgvCariPegawai.Size = new System.Drawing.Size(696, 259);
            this.dgvCariPegawai.TabIndex = 14;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Profesi";
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
            // Column6
            // 
            this.Column6.HeaderText = "Alamat";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Gaji";
            this.Column7.Name = "Column7";
            // 
            // chkNip
            // 
            this.chkNip.AutoSize = true;
            this.chkNip.Location = new System.Drawing.Point(12, 89);
            this.chkNip.Name = "chkNip";
            this.chkNip.Size = new System.Drawing.Size(44, 17);
            this.chkNip.TabIndex = 15;
            this.chkNip.Text = "NIP";
            this.chkNip.UseVisualStyleBackColor = true;
            this.chkNip.CheckedChanged += new System.EventHandler(this.chkNip_CheckedChanged);
            // 
            // txtNip
            // 
            this.txtNip.Enabled = false;
            this.txtNip.Location = new System.Drawing.Point(173, 93);
            this.txtNip.Name = "txtNip";
            this.txtNip.Size = new System.Drawing.Size(135, 20);
            this.txtNip.TabIndex = 16;
            // 
            // frmCariPegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 470);
            this.Controls.Add(this.txtNip);
            this.Controls.Add(this.chkNip);
            this.Controls.Add(this.dgvCariPegawai);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboJob);
            this.Controls.Add(this.chkJob);
            this.Controls.Add(this.txtIdPegawai);
            this.Controls.Add(this.chkIdPegawai);
            this.Name = "frmCariPegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPegawai";
            this.Load += new System.EventHandler(this.frmCariPegawai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCariPegawai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkIdPegawai;
        private System.Windows.Forms.TextBox txtIdPegawai;
        private System.Windows.Forms.CheckBox chkJob;
        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.DataGridView dgvCariPegawai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.CheckBox chkNip;
        private System.Windows.Forms.TextBox txtNip;
    }
}