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
    public partial class frmAppointment : Form
    {
        Class.clsPegawai peg = new Class.clsPegawai();
        Class.clsJanjiDokter janji = new Class.clsJanjiDokter();

        public frmAppointment()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            peg.id = Convert.ToInt16(txtIdDokter.Text);
            

            
        }
    }
}
