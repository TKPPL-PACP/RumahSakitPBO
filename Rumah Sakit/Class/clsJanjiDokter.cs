using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsJanjiDokter
    {
        public int id { set; get; }
        public int idPasien { set; get; }
        public int idDokter { set; get; }
        public DateTime waktuBertemu { set; get; }
        public TimeSpan durasi {set;get}

        public clsJanjiDokter()
        { }

        public clsJanjiDokter(int id, int idPasien, int idDokter, DateTime waktuBertemu, TimeSpan durasi)
        {
            // if(cekLuang())
            // { }
            // Pengecekan apakah ada janji lain di waktu tsb.
            this.id = id;
            this.idPasien = idPasien;
            this.idDokter = idDokter;
            this.waktuBertemu = waktuBertemu;
            this.durasi = durasi;

        }

        public void ubahJanji(int idPasien, int idDokter, DateTime waktuBertemu, TimeSpan durasi)
        {
            this.idPasien = idPasien;
            this.idDokter = idDokter;
            this.waktuBertemu = waktuBertemu;
            this.durasi = durasi;
        }

        /*
        public ubahJanji(DateTime waktuBertemu)
        {
            this.waktuBertemu = waktuBertemu;
        }

        public ubahJanji(int idPasien, int idDokter, DateTime waktuBertemu)
        {
            this.idPasien = idPasien;
            this.idDokter = idDokter;
            this.waktuBertemu = waktuBertemu;
        }
        */

        private bool cekLuang(int idDokter, DateTime waktuBertemu, TimeSpan durasi)
        {

        }



    }
}
