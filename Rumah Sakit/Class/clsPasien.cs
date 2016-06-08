
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsPasien
    {
        public enum gender 
        {
            Wanita = 0,
            Pria = 1
        }
        public int id { set; get; }
        public string nama { set; get; }
        public gender jenisKelamin { set; get; }
        public string penyakit { set; get; }
        public string alamat { set; get; }
        public DateTime tanggalLahir { set; get; }
        public clsPasien()
        { }
        public clsPasien(int id, string nama,int jenisKelamin, string penyakit, 
                         string alamat, DateTime tanggalLahir)
        {
            this.id = id;
            this.nama = nama;
            this.jenisKelamin = (gender) jenisKelamin;
            this.penyakit = penyakit;
            this.alamat = alamat;
            this.tanggalLahir = tanggalLahir;
        }

        public static clsPasien cariPasien(int id)
        {
            clsPasien pasienDicari = new clsPasien();

            // cari pada database dengan id sekian lalu masukan ke pasienDicari

            return pasienDicari;
        }
    }
}
