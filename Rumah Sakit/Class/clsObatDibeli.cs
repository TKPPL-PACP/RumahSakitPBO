﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumah_Sakit.Class
{
    class clsObatDibeli
    {
        public int idObat { private set; get; }
        public double kuantitas { private set; get; }

        public string deskripsi { private set; get; }
        public clsObatDibeli(int idObat, double kuantitas, string deskripsi)
        {
            this.idObat = idObat;
            this.kuantitas = kuantitas;
            this.deskripsi = deskripsi;
        }
    }
}
