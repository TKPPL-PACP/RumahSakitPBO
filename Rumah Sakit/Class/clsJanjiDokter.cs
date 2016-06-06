using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsJanjiDokter
    {
        private int id;
        public int idPasien { set; get; }
        public int idDokter { set; get; }
        public DateTime waktuBertemu { set; get; }

        public clsJanjiDokter()
        { }

        public clsJanjiDokter(int id, int idPasien, int idDokter, DateTime waktuBertemu)
        {
            this.id = id;
            this.idPasien = idPasien;
            this.idDokter = idDokter;
            this.waktuBertemu = waktuBertemu;
        }
    }
}
