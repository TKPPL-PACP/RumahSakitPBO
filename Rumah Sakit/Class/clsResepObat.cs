
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsResepObat
    {
        public int id { set; get; }
        public List<clsObatDibeli> lstObatDibeli;
        //pasien yang menerima
        public int idPasien { set; get; }
        //dokter yang kasih resep
        public int idPegawai { set; get; }
        
        public clsResepObat()
        { }

        public clsResepObat(int idPasien, int idPegawai)
        {
            this.idPasien = idPasien;
            this.idPegawai = idPegawai;
            this.lstObatDibeli = new List<clsObatDibeli> { };
        }

        public static List<clsResepObat> cariResepObatByIdPasien(int idPasien)
        {
            List<clsResepObat> lstResepObatDicari = new List<clsResepObat> { };
            //proses-proses ke database cari berdasarkan idPasien
            //dari setiap data yang didapatkan masukkan ke dalam list
            return lstResepObatDicari;
        }

        public static List<clsResepObat> cariResepObatByIdDokter(int idDokter)
        {
            List<clsResepObat> lstResepObatDicari = new List<clsResepObat> { };
            //proses-proses ke database cari berdasarkan idDokter
            //dari setiap data yang didapatkan masukkan ke dalam list
            return lstResepObatDicari;
        }

        public static clsResepObat cariResepObatById(int id)
        {
            clsResepObat resepObatDicari = new clsResepObat();
            //proses-proses ke database cari berdasarkan id lalu masukkan ke variable resepObatDicari
            return resepObatDicari;
        }

        public int cariObat(int idObat)
        {
            return this.lstObatDibeli.FindIndex(x => x.idObat == idObat);
        }
        
        public void tambahObat(int idObat, int kuantitas, string deskripsi)
        {
            this.lstObatDibeli.Add(new clsObatDibeli(idObat, kuantitas, deskripsi));
        }

        public void deleteObat(int idObat)
        {
            int ind = this.cariObat(idObat);
            if(ind > -1)
            {
                this.lstObatDibeli.RemoveAt(ind);
            }
        }

        public void tebusResepObat()
        {
            foreach(clsObatDibeli obatDibeli in this.lstObatDibeli)
            {
                //lakukan proses pengurangan obat pada database dari setiap list obat yang ada
            }
        }
    }
}
