using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMart_LIB
{
    public class Order
    {
        private int id;
        private DateTime tanggal_waktu;
        private string alamat_tujuan;
        private float ongkos_kirim;
        private float total_bayar;
        private string cara_bayar;
        private Cabang cabang;
        private Kurir kurir;
        private Konsumen konsumen;
        private Promo promo;
        
    }
}
