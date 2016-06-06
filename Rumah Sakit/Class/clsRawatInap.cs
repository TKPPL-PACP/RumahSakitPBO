using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsRawatInap
    {
        public int id { private set; get; }
        public int idKamar { private set; get; }
        public int idPasien { private set; get; }
        public DateTime tanggalMasuk { set; get; }        
       
        public clsRawatInap()
        { }
        public clsRawatInap(int id, int idKamar, int idPasien, DateTime tanggalMasuk)
        {
            this.id = id;
            this.idKamar = idKamar;
            this.idPasien = idPasien;
            this.tanggalMasuk = tanggalMasuk;
        }
    }
}
