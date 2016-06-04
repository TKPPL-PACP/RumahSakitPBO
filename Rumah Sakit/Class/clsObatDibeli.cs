using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsObatDibeli
    {
        private int id;
        private int idObat { set; get; }
        private double kuantitas { set; get; }

        private string deskripsi { set; get; }
        public clsObatDibeli(int idObat, double kuantitas, string deskripsi)
        {
            this.idObat = idObat;
            this.kuantitas = kuantitas;
            this.deskripsi = deskripsi;
        }
    }
}
