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
    public partial class frmTransaksiObat : Form
    {
        public frmTransaksiObat()
        {
            InitializeComponent();
        }

        private void frmTransaksiObat_Load(object sender, EventArgs e)
        {
            dgvObat.Rows.Add("Panadol", "2", "10.000", "20.000");
            dgvObat.Rows.Add("Vitacimin", "5", "1.000", "5.000");
            dgvObat.Rows.Add("Antibiotik", "6", "5.000", "30.000");
            dgvObat.AllowUserToAddRows = false;
        }
    }
}
