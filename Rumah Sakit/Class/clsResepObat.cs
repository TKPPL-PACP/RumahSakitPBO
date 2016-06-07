﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsResepObat
    {
        private int id;
        public List<clsObatDibeli> lstObatDibeli;
        //pasien yang menerima
        public int idPasien { set; get; }
        //dokter yang kasih resep
        public int idPegawai { set; get; }
        public int idPembayaran { set; get; }
        public clsResepObat()
        { }

        public clsResepObat(int idPasien, int idPegawai,int idPembayaran)
        {
            this.idPasien = idPasien;
            this.idPegawai = idPegawai;
            this.idPembayaran = idPembayaran;
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

        public int cariObatByIdObat(int idObat)
        {
            return this.lstObatDibeli.FindIndex(x => x.idObat == idObat);
        }
        
        public void tambahObat(int idObat, int kuantitas, string deskripsi)
        {
            this.lstObatDibeli.Add(new clsObatDibeli(idObat, kuantitas, deskripsi));
        }

        public void deleteObat(int idObat)
        {
            int ind = this.cariObatByIdObat(idObat);
            if(ind > -1)
            {
                this.lstObatDibeli.RemoveAt(ind);
            }
        }

        public void InsertResepObat()
        {
            //insert this ke dalam database
        }

        public void UpdateResepObat()
        {
            //update data ke tabel resep obat berdasarkan this.id
        }
        public void tebusResepObat()
        {
            foreach(clsObatDibeli obatDibeli in this.lstObatDibeli)
            {
                //lakukan proses pengurangan obat pada database dari setiap list obat yang ada
            }
            //update status pembayaran by idPembayaran, dan update uang yang terbayarkan.
        }
    }
}
