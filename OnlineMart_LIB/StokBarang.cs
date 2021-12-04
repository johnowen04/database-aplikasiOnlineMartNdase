using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class StokBarang
    {
        private Barang barang;
        private int stok;

        public StokBarang()
        {
            Barang = null;
            Stok = 0;
        }

        public StokBarang(Barang barang, int stok)
        {
            Barang = barang;
            Stok = stok;
        }

        public Barang Barang { get => barang; set => barang = value; }
        public int Stok { get => stok; set => stok = value; }

        public Boolean UpdateStok(string jenisTransaki, int cabang_id, int barang_id, int quantity)
        {
            string sql = "update cabangs_barang set stok=";

            if (jenisTransaki == "pembelian")
                sql += "stok+" + quantity;
            else
                sql += "stok-" + quantity;

            sql += " where cabangs_id=;" + cabang_id + "' and barangs_id='" + barang_id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

    }
}
