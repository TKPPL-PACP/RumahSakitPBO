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
            this.btnRegPasien = new System.Windows.Forms.Button();
            this.btnObat = new System.Windows.Forms.Button();
            this.btnTabel = new System.Windows.Forms.Button();
            this.btnAppn = new System.Windows.Forms.Button();
            this.btnCariKmr = new System.Windows.Forms.Button();
            this.btnDetKmr = new System.Windows.Forms.Button();
            this.btnTbhKmr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegPasien
            // 
            this.btnRegPasien.Location = new System.Drawing.Point(59, 30);
            this.btnRegPasien.Name = "btnRegPasien";
            this.btnRegPasien.Size = new System.Drawing.Size(75, 48);
            this.btnRegPasien.TabIndex = 0;
            this.btnRegPasien.Text = "&Register";
            this.btnRegPasien.UseVisualStyleBackColor = true;
            // 
            // btnObat
            // 
            this.btnObat.Location = new System.Drawing.Point(162, 30);
            this.btnObat.Name = "btnObat";
            this.btnObat.Size = new System.Drawing.Size(75, 48);
            this.btnObat.TabIndex = 1;
            this.btnObat.Text = "Tambah &Obat";
            this.btnObat.UseVisualStyleBackColor = true;
            // 
            // btnTabel
            // 
            this.btnTabel.Location = new System.Drawing.Point(267, 30);
            this.btnTabel.Name = "btnTabel";
            this.btnTabel.Size = new System.Drawing.Size(75, 48);
            this.btnTabel.TabIndex = 2;
            this.btnTabel.Text = "&List Tabel";
            this.btnTabel.UseVisualStyleBackColor = true;
            // 
            // btnAppn
            // 
            this.btnAppn.Location = new System.Drawing.Point(59, 98);
            this.btnAppn.Name = "btnAppn";
            this.btnAppn.Size = new System.Drawing.Size(75, 48);
            this.btnAppn.TabIndex = 3;
            this.btnAppn.Text = "&Appointment";
            this.btnAppn.UseVisualStyleBackColor = true;
            // 
            // btnCariKmr
            // 
            this.btnCariKmr.Location = new System.Drawing.Point(162, 98);
            this.btnCariKmr.Name = "btnCariKmr";
            this.btnCariKmr.Size = new System.Drawing.Size(75, 48);
            this.btnCariKmr.TabIndex = 4;
            this.btnCariKmr.Text = "&Cari Kamar";
            this.btnCariKmr.UseVisualStyleBackColor = true;
            // 
            // btnDetKmr
            // 
            this.btnDetKmr.Location = new System.Drawing.Point(267, 98);
            this.btnDetKmr.Name = "btnDetKmr";
            this.btnDetKmr.Size = new System.Drawing.Size(75, 48);
            this.btnDetKmr.TabIndex = 5;
            this.btnDetKmr.Text = "&Detail Kamar";
            this.btnDetKmr.UseVisualStyleBackColor = true;
            // 
            // btnTbhKmr
            // 
            this.btnTbhKmr.Location = new System.Drawing.Point(59, 167);
            this.btnTbhKmr.Name = "btnTbhKmr";
            this.btnTbhKmr.Size = new System.Drawing.Size(75, 48);
            this.btnTbhKmr.TabIndex = 6;
            this.btnTbhKmr.Text = "&Tambah Kamar";
            this.btnTbhKmr.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 323);
            this.Controls.Add(this.btnTbhKmr);
            this.Controls.Add(this.btnDetKmr);
            this.Controls.Add(this.btnCariKmr);
            this.Controls.Add(this.btnAppn);
            this.Controls.Add(this.btnTabel);
            this.Controls.Add(this.btnObat);
            this.Controls.Add(this.btnRegPasien);
            this.Name = "MainForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegPasien;
        private System.Windows.Forms.Button btnObat;
        private System.Windows.Forms.Button btnTabel;
        private System.Windows.Forms.Button btnAppn;
        private System.Windows.Forms.Button btnCariKmr;
        private System.Windows.Forms.Button btnDetKmr;
        private System.Windows.Forms.Button btnTbhKmr;
    }
}

