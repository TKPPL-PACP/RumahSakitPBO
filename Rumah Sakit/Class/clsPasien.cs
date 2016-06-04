
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
        private int id;
        public string nama { set; get; }
        public gender jenisKelamin { set; get; }
        public string penyakit { set; get; }
        public string alamat { set; get; }
        public DateTime tanggalLahir { set; get; }
        public clsPasien()
        { }
        public clsPasien(string nama,int jenisKelamin, string penyakit, 
                         string alamat, DateTime tanggalLahir)
        {
            this.nama = nama;
            this.jenisKelamin = (gender) jenisKelamin;
            this.penyakit = penyakit;
            this.alamat = alamat;
            this.tanggalLahir = tanggalLahir;
        }

        public void tambahPasien()
        {

        }
    }
}
