using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rumah_Sakit.Pilihan
{
    public partial class frmCariPasien : Form
    {
        Class.modulFungsi func = new Class.modulFungsi();
        Class.clsPasien pas = new Class.clsPasien();
        public frmCariPasien()
        {
            InitializeComponent();
        }

        private void chkStatusPembayaran_CheckedChanged(object sender, EventArgs e)
        {
            cboStatusPembayaran.Enabled = chkStatusPembayaran.Checked;
        }


        private void chkTanggalMasuk_CheckedChanged(object sender, EventArgs e)
        {
            dtpTanggalMasuk.Enabled = chkTanggalMasuk.Checked;
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            string filter = func.search(txtCari.Text);
            for (int i = 0; i < dgvPasien.Rows.Count; i++)
            {
                if (dgvPasien.Rows[i].Cells[1].Value.ToString().Contains(filter.ToLower())|| dgvPasien.Rows[i].Cells[1].Value.ToString().Contains(filter.ToUpper()))
                    dgvPasien.Rows[i].Visible = true;
                else dgvPasien.Rows[i].Visible = false;
            }
        }

        private void frmPasien_Load(object sender, EventArgs e)
        {
            // Ambil data-data pasien yang di database kemudian masukkan ke listPas
            List<Class.clsPasien> listPas = new List<Class.clsPasien>();
            foreach(Class.clsPasien i in listPas)
            {
                dgvPasien.Rows.Add(Convert.ToString(i.id), i.nama, i.alamat, Convert.ToString(i.tanggalLahir), Convert.ToString(i.jenisKelamin));
            }
            dgvPasien.Rows.Add("3", "Budi");
            dgvPasien.Rows.Add("3", "Astuti");
            dgvPasien.Rows.Add("3", "Deho");
            dgvPasien.AllowUserToAddRows = false;
        }

        private void dgvPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cari pada database");
        }
    }
}
