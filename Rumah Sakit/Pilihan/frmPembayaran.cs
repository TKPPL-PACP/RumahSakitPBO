using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumah_Sakit.Pilihan
{
    public partial class frmPembayaran : Form
    {
        public frmPembayaran()
        {
            InitializeComponent();
        }
        Class.clsPembayaran bayar;
        private void button1_Click(object sender, EventArgs e)
        {
            int idPasien = int.Parse(txtIdPasien.Text);
            double jlh = double.Parse(txtJumlah.Text);
            DateTime tgl = dateTimePicker1.Value;
            bayar = new Class.clsPembayaran(idPasien,true,jlh,tgl);
            txtStatus.Text = "Lunas";
        }

        private void frmPembayaran_Load(object sender, EventArgs e)
        {
            txtStatus.Text = "Belum Bayar";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form showForm = new Pilihan.frmDetailPembayaran();
            showForm.Show();
        }
    }
}
