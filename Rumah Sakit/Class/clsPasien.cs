
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumah_Sakit.Class
{
    class clsPasien
    {
        public List<clsPasien> pasien = new List<clsPasien>();
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
        public clsPasien(int id, string nama,gender jenisKelamin, string penyakit, 
                         string alamat, DateTime tanggalLahir)
        {
            this.id = id;
            this.nama = nama;
            this.jenisKelamin = (gender) jenisKelamin;
            this.penyakit = penyakit;
            this.alamat = alamat;
            this.tanggalLahir = tanggalLahir;
        }
        public void insertPasien(clsPasien pas)
        {
            //masukkan this ke dalam database
            //manual dengan class vvv
            pasien.Add(pas);
        }
        public void updatePasien()
        {
            //update this berdasarkan this.id
        }
        public static clsPasien cariPasienById(int id)
        {
            clsPasien pasienDicari = new clsPasien();

            // cari pada database dengan id sekian lalu masukan ke pasienDicari

            return pasienDicari;
        }
        public void tampilPasien(DataGridView dgv)
        {
            for (int i = 0; i < pasien.Count; i++)
            {
                dgv.Rows.Add(pasien[i].id);
            }
        }
    }
}
