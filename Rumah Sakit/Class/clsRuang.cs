using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    public enum jenisRuang
    {
        VVIP = 1,
        VIP = 2,
        Reguler = 3
    }
    class clsRuang
    {
        private int id;
        public int nomorRuangan { set; get; }
        public int lantai { set; get; }
        public jenisRuang jenisRuangan { set; get; } 
        public clsRuang()
        { }
        public clsRuang(int nomor, int jenis, int lantai)
        {
            this.nomorRuangan = nomor;
            this.jenisRuangan = (jenisRuang) jenis;
            this.lantai = lantai;
        }
    }
}
