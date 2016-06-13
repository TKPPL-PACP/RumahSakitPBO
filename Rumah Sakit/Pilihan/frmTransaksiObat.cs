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
            dgvObat.Rows.Add("Panadol", "2", "10000", "20000");
            dgvObat.Rows.Add("Vitacimin", "5", "1000", "5000");
            dgvObat.Rows.Add("Antibiotik", "6", "5000", "30000");
            dgvObat.AllowUserToAddRows = false;
            //MessageBox.Show((dgvObat.Rows[0].Cells[2].Value+ dgvObat.Rows[0].Cells[2].Value).toString());
        }

        private void txtJumlahHarga_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            double hasil = 0;
            for (int i = 0; i < dgvObat.Rows.Count; i++)
            {
                hasil += Convert.ToDouble(dgvObat.Rows[i].Cells[3].Value);
            }
            string kata = string.Format("Rp. {0:N2}", hasil);
            txtJumlahHarga.Text = kata;
        }
    }
}
