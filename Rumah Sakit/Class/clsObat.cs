using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsObat
    {
        public int id { set; get; }
        public string nama;
        //untuk dosis pke deskripsi aja deh, rancu :D
        public string deskripsi { set; get; }

        public double harga { set; get; }
        public int stock { set; get; }
        //1 botol , 1 pil , 1 gram bubuk
        public string satuan { set; get; }

        public clsObat()
        { }

        public clsObat(int id, string nama, string deskripsi,double harga, int stock, string satuan)
        {
            this.id = id;
            this.nama = nama;
            this.deskripsi = deskripsi;
            this.harga = harga;
            this.stock = stock;
            this.satuan = satuan;
        }

        public void insertObat()
        {
            //masukkan this ke dalam database
        }
        public void updateObat()
        {
            //update this berdasarkan this.id
        }
        public void hapusObat()
        {
            //hapus this berdasarkan this.id
        }
    }
}
