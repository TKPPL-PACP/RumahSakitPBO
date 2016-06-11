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
    public partial class frmPasien : Form
    {
        Class.clsFungsi func = new Class.clsFungsi();
        public frmPasien()
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
                if (dgvPasien.Rows[i].Cells[1].Value.ToString().Contains(filter) )
                    dgvPasien.Rows[i].Visible = true;
                else dgvPasien.Rows[i].Visible = false;
            }
            

        }

        private void frmPasien_Load(object sender, EventArgs e)
        {
            dgvPasien.Rows.Add("3", "Budi");
            dgvPasien.Rows.Add("3", "Astuti");
            dgvPasien.Rows.Add("3", "Deho");
            dgvPasien.AllowUserToAddRows = false;
        }
    }
}
