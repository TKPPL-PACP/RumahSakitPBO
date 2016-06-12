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
    public partial class frmCariPegawai : Form
    {
        Class.modulFungsi func = new Class.modulFungsi();
        public frmCariPegawai()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtIdPegawai.Enabled = chkIdPegawai.Checked;
        }

        private void frmCariPegawai_Load(object sender, EventArgs e)
        {

        }

        private void chkJob_CheckedChanged(object sender, EventArgs e)
        {
            cboJob.Enabled = chkJob.Checked;
        }

        private void btnTampil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cari pada database");
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            string filter = func.search(txtNama.Text);
            for (int i = 0; i < dgvCariPegawai.Rows.Count; i++)
            {
                if (dgvCariPegawai.Rows[i].Cells[1].Value.ToString().Contains(filter.ToLower()) || dgvCariPegawai.Rows[i].Cells[1].Value.ToString().Contains(filter.ToUpper()))
                    dgvCariPegawai.Rows[i].Visible = true;
                else dgvCariPegawai.Rows[i].Visible = false;
            }
        }

        private void chkNip_CheckedChanged(object sender, EventArgs e)
        {
            txtNip.Enabled = chkNip.Checked;
        }
    }
}
