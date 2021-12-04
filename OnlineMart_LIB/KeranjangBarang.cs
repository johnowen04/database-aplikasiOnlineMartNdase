using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class KeranjangBarang
    {
        private Cabang cabang;
        private Barang barang;
        private int quantity;

        public KeranjangBarang()
        {
            Cabang = null;
            Barang = null;
            Quantity = 0;
        }

        public KeranjangBarang(Cabang cabang, Barang barang, int quantity)
        {
            Cabang = cabang;
            Barang = barang;
            Quantity = quantity;
        }

        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Barang Barang { get => barang; set => barang = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Boolean UpdateQuantity(string jenisTransaki, int quantity)
        {
            string sql = "update keranjangs_barang set quantity=";

            if (jenisTransaki == "tambah")
                sql += "quantity+" + quantity;
            else
                sql += "quantity-" + quantity;

            sql += " where cabangs_id=" + Cabang.Id + " and barangs_id=" + Barang.Id;

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }
    }
}
