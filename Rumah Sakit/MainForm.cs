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
            Form showForm = new frmObat();
            showForm.Show();
        }

        private void transaksiObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showForm = new Pilihan.frmTransaksiObat();
            showForm.Show();
        }

        private void tampilkanToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void janjiDokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showForm = new frmAppointment();
            showForm.Show();
        }

        private void tambahKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showForm = new frmKamar();
            showForm.Show();
        }

        private void cariKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showForm = new frmCariKamar();
            showForm.Show();
        }

        private void detailKamarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showForm = new frmDetailKamar();
            showForm.Show();
        }

        private void pasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showForm = new Pilihan.frmCariPasien();
            showForm.Show();
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form showForm = new Pilihan.frmCariPegawai();
            showForm.Show();
        }

        private void pasienToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form showForm = new frmRegisterPasien();
            showForm.Show();
        }

        private void pegawaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form showForm = new Pilihan.frmRegisterPegawai();
            showForm.Show();
        }
    }
}
