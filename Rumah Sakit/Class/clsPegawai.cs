using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsPegawai
    {
        public enum gender 
        {
            Wanita = 0,
            Pria = 1
        }
        public enum job
        {
            Dokter = 0,
            Perawat = 1,
            Administrator = 2,
            Janitor = 3
        }
        private int id;
        private string nip;
        public string nama { set; get; }
        public gender jenisKelamin { set; get; }
        public string alamat { set; get; }
        public double gaji { set; get; }
        public DateTime tanggalMasuk { set; get; }
        public job profesi { set; get; }
        public clsPegawai()
        { }

        public clsPegawai(int id, string nama, int jenisKelamin, string alamat, 
                          double gaji, DateTime tanggalMasuk, int profesi)
        {
            this.id = id;
            this.nama = nama;
            this.jenisKelamin = (gender) jenisKelamin;
            this.alamat = alamat;
            this.gaji = gaji;
            this.tanggalMasuk = tanggalMasuk;
            this.profesi = (job)profesi;
        }

        public static clsPegawai cariPegawaiById(int id)
        {
            clsPegawai pegawaiDicari = new clsPegawai();

            //cari pada database id dari pegawai yang akan dicari 
            //kemudian di masukkan kedalam variable pegawai dicari

            return pegawaiDicari;
        }
    }
}
