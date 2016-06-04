
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsResepObat
    {
        private int id;
        private List<clsObatDibeli> lstObatDibeli;
        //pasien yang menerima
        public int idPasien { set; get; }
        //dokter yang kasih resep
        public int idPegawai { set; get; }
        
        public clsResepObat()
        { }

        public clsResepObat(int idPasien, int idPegawai)
        {
            this.idPasien = idPasien;
            this.idPegawai = idPegawai;
            this.lstObatDibeli = new List<clsObatDibeli> { };
        }

        public void tambahObat(int idObat, int kuantitas, string deskripsi)
        {
            this.lstObatDibeli.Add(new clsObatDibeli(idObat, kuantitas, deskripsi));
        }
    }
}
