﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    public enum jenisKamar
    {
        VVIP = 1,
        VIP = 2,
        Reguler = 3
    }

    class clsKamar
    {
        public int id { set; get; }
        public int nomorKamar { set; get; }
        public int lantai { set; get; }
        public jenisKamar jenisKamar { set; get; }
        public double biaya { set; get; }
        public int kapasitas { set; get; }
        public int terisi { set; get; } 
        public clsKamar()
        { }
        public clsKamar(int nomor, int jenis, int biaya, int lantai, int kapasitas, int terisi)
        {
            this.nomorKamar = nomor;
            this.jenisKamar = (jenisKamar) jenis;
            this.lantai = lantai;
            this.kapasitas = kapasitas;
            this.terisi = terisi;
        }

        public List<clsKamar> cariKamarKosong()
        {
            List<clsKamar> lstKamar = new List<clsKamar> { };

            //dalam database cari kamar yang kapasitasnya lebih besar dari terisinya

            return lstKamar;
        }
        
        public bool isKamarFull()
        {
            return kapasitas == terisi;
        }

        public void insertKamar()
        {
            //masukkan this kedalam database
        }

        public void updateKamar()
        {
            //update this pada database berdasarkan this.id
        }
        public static clsKamar cariKamarById(int id)
        {
            clsKamar kamarDicari = new clsKamar();

            //hasil dari database set ke variable kamarDicari

            return kamarDicari;
        }
    }
}
