using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsPembayaran
    {
        private int idPembayaran { set; get; }
        private int idPasien { set; get; }
        private int idRuang { set; get; }
        private int idObatDibeli { set; get; }

        public clsPembayaran(int idPasien, int idRuang, int idObatDibeli)
        {
            this.idPasien = idPasien;
            this.idRuang = idRuang;
            this.idObatDibeli = idObatDibeli;
        }



    }
}
