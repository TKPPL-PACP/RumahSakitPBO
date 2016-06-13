using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumah_Sakit
{
    public partial class frmRegisterPasien : Form
    {
        Class.clsPasien pas = new Class.clsPasien();
        public frmRegisterPasien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmRegisterPasien();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pas.id = int.Parse(txtIdPasien.Text);
            pas.nama = txtNama.Text;
            pas.tanggalLahir = dtpTanggalLahir.Value.Date;
            pas.penyakit = rtxtKeluhan.Text;
            pas.alamat = txtAlamat.Text;
            if (rdoPria.Checked) pas.jenisKelamin = (Class.clsPasien.gender)1;
            else if (rdoWanita.Checked) pas.jenisKelamin = 0;
            if ((txtIdPasien.Text=="") || (txtNama.Text=="") || (pas.penyakit == "") || (pas.alamat == "") || (!rdoPria.Checked && !rdoWanita.Checked ))
            {
               MessageBox.Show("Warning","Mohon lengkapi data!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                Class.clsPasien m = new Class.clsPasien(pas.id,pas.nama, pas.jenisKelamin,pas.penyakit,pas.alamat,pas.tanggalLahir );
                pas.insertPasien(m);
                MessageBox.Show("Data berhasil di simpan");
        
            }
            Form frm = new frmRegisterPasien();
            frm.Show();
            this.Close();
        }

        private void dtpTanggalLahir_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
