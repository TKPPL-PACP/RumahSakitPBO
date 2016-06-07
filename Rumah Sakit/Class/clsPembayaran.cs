using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsPembayaran
    {
        public int id { private set; get; }
        public bool statusPembayaran { set; get; }
        public double jumlahPembayaran { set; get; }
        public DateTime tanggalPembayaran { set; get; }   
        public clsPembayaran()
        { }
        public clsPembayaran(int id, bool statusPembayaran, 
                             double jumlahPembayaran, DateTime tanggalPembayaran)
        {
            this.id = id;
            this.statusPembayaran = statusPembayaran;
            this.jumlahPembayaran = jumlahPembayaran;
            this.tanggalPembayaran = tanggalPembayaran;
        }
        public static clsPembayaran cariPembayaranById(int id)
        {
            clsPembayaran pembayaranDicari = new clsPembayaran();
            //cari pada database berdasarkan id
            return pembayaranDicari;
        }
        public void insertPembayaran()
        {
            //masukkan this ke dalam database
        }
        public void updatePembayaran
        {
            //update this berdasarkan this.id
        }
    }
}
