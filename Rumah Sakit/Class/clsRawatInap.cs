using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsRawatInap
    {
        public int id { private set; get; }
        public int idKamar { set; get; }
        public int idPasien { set; get; }
        public int idPembayaran { set; get; }
        public DateTime tanggalMasuk { set; get; }
        public DateTime tanggalKeluar { set; get; }

        public clsRawatInap()
        { }
        public clsRawatInap(int id, int idKamar, int idPasien, 
                            DateTime tanggalMasuk,DateTime tanggalKeluar)
        {
            this.id = id;
            this.idKamar = idKamar;
            this.idPasien = idPasien;
            this.tanggalMasuk = tanggalMasuk;
            this.tanggalKeluar = tanggalKeluar;
        }
        public void InsertRawatInap()
        {
            clsKamar kamar = clsKamar.cariKamarById(this.idKamar);
            if(kamar.isKamarFull() == false)
            {
                //insert data kedalam database rawat inap

                kamar.terisi++;
                kamar.updateKamar();
            }
        }
        public void UpdateRawatInap()
        {
            //update this pada database berdasarkan this.id
        }
        public void CheckIn()
        {
            this.tanggalMasuk = DateTime.Now;
            this.UpdateRawatInap();
        }
        public void CheckOut()
        {
            clsPembayaran pembayaran = new clsPembayaran();

            this.tanggalKeluar = DateTime.Now;
            pembayaran.jumlahPembayaran = this.tanggalKeluar.Subtract(this.tanggalMasuk).TotalDays - 1;
            pembayaran.statusPembayaran = true;
            pembayaran.tanggalPembayaran = DateTime.Now;
            pembayaran.insertPembayaran();
            this.idPembayaran = pembayaran.id;
            this.UpdateRawatInap();
        }
        public void PindahKamar(int idKamarTujuan)
        {
            clsKamar kamar = clsKamar.cariKamarById(idKamarTujuan);
            clsKamar kamarSekarang = clsKamar.cariKamarById(this.idKamar);
            if(kamar.isKamarFull() == false)
            {
                //insert data kedalam database rawat inap

                kamar.terisi++;
                kamar.updateKamar();
                kamarSekarang.terisi--;
                kamarSekarang.updateKamar();
                this.idKamar = idKamarTujuan;
                this.UpdateRawatInap();
            }
        }
    }
}
