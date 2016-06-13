using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

namespace Rumah_Sakit
{

    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void tambahObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new frmObat();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }

        private void transaksiObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new Pilihan.frmTransaksiObat();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }

        private void tampilkanToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void janjiDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new frmAppointment();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }

        private void tambahKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new frmKamar();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }

        private void cariKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new frmCariKamar();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }

        private void detailKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new frmDetailKamar();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }

        private void pasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new Pilihan.frmCariPasien();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new Pilihan.frmCariPegawai();
                showForm.MdiParent = this;
                showForm.Show();
            }
        }

        private void pasienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new frmRegisterPasien();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }

        private void pegawaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new Pilihan.frmRegisterPegawai();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }


        private void rawatInapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                Form showForm = new Pilihan.frmRawatInap();
                showForm.MdiParent = this;
                showForm.Show();
            }
            
        }
    }
}
