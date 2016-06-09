using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsJanjiDokter
    {
        public int id { set; get; }
        public int idPasien { set; get; }
        public int idDokter { set; get; }
        public DateTime waktuBertemu { set; get; }
        public TimeSpan durasi { set; get; }

        public clsJanjiDokter()
        { }

        public clsJanjiDokter(int id, int idPasien, int idDokter, DateTime waktuBertemu, TimeSpan durasi)
        {
            this.id = id;
            this.idPasien = idPasien;
            this.idDokter = idDokter;
            this.waktuBertemu = waktuBertemu;
            this.durasi = durasi;

        }

        public void InsertJanjiDokter()
        {
            if(this.cekWaktuLuang())
            {
                //insert this kedalam database
            }
        }

        public void UpdateJanjiDokter()
        {
            if(this.cekWaktuLuang())
            {
                //update this pada database berdasarkan this.id
            }
        }

        public bool cekWaktuLuang()
        {
            bool adaWaktu = false;
            //cek ada tidak waktu luang dari dokter berdasarkan this.idDokter, 
            //this.waktubertemu -> this.waktubertemu + durasi
            return adaWaktu;
        }

        public static clsJanjiDokter cariJanjiDokterById(int id)
        {
            clsJanjiDokter janjiDokterDicari = new clsJanjiDokter();
            //cari pada database lalu kembalikan ke variable janjiDokterDicari;
            return janjiDokterDicari;
        }

    }
}
