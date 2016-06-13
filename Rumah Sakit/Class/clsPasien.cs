
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumah_Sakit.Class
{
    public class clsPasien
    {
        public List<clsPasien> pasien;
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
        {
            pasien = new List<clsPasien>();
        }
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
        public void insertPasien(int id, string nama, gender jenisKelamin, string penyakit,
                         string alamat, DateTime tanggalLahir)
        {
            clsPasien pas = new clsPasien(id, nama, jenisKelamin, penyakit, alamat, tanggalLahir);
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
            //MessageBox.Show(pasien.Count.ToString());
            for (int i = 0; i < pasien.Count; i++)
            {
                dgv.Rows.Add(pasien[i].id);
            }
        }
    }
}
