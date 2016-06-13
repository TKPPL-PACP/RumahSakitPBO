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
    public partial class frmDetailPembayaran : Form
    {
        public frmDetailPembayaran()
        {
            InitializeComponent();
        }

        private void frmDetailPembayaran_Load(object sender, EventArgs e)
        {
            dgvDetailPembayaran.Rows.Add("1", "Panadol", "2", "20000");
            dgvDetailPembayaran.Rows.Add("2", "Vitacimin", "5", "5000");
            dgvDetailPembayaran.Rows.Add("3", "Antibiotik", "6", "30000");
            dgvDetailPembayaran.Rows.Add("4", "Kamar VIP", "1", "1500000");
            dgvDetailPembayaran.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Print akan disesuaikan dengan format dan print melalu crystal report");
        }
    }
}
