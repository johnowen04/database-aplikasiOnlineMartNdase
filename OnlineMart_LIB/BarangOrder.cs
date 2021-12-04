using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMart_LIB
{
    public class BarangOrder
    {
        private Barang barang;
        private int jumlah;
        private float harga;

        public BarangOrder()
        {
            Barang = null;
            Jumlah = 0;
            Harga = 0.0f;
        }

        public BarangOrder(Barang barang, int jumlah, float harga)
        {
            Barang = barang;
            Jumlah = jumlah;
            Harga = harga;
        }

        public Barang Barang { get => barang; set => barang = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public float Harga { get => harga; set => harga = value; }
    }
}
