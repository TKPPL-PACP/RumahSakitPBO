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
        // Pembayaran untuk idPasien berikut
        public int idPasien { private set; get; }
        public clsPembayaran()
        { }
        public clsPembayaran(int idPasien,
                             bool statusPembayaran,
                             double jumlahPembayaran,
                             DateTime tanggalPembayaran)
        {
            // this.id generate dari database
            this.statusPembayaran = statusPembayaran;
            this.jumlahPembayaran = jumlahPembayaran;
            this.tanggalPembayaran = tanggalPembayaran;
            this.idPasien = idPasien;
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
            //ambil id masukkan ke this.id
        }
        public void updatePembayaran()
        {
            //update this berdasarkan this.id
        }
    }
}
