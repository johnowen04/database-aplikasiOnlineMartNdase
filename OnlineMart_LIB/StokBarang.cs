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
        private Cabang cabang;
        private Barang barang;
        private int stok;

        public StokBarang()
        {
            Cabang = null;
            Barang = null;
            Stok = 0;
        }

        public StokBarang(Cabang cabang, Barang barang, int stok)
        {
            Cabang = cabang;
            Barang = barang;
            Stok = stok;
        }

        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Barang Barang { get => barang; set => barang = value; }
        public int Stok { get => stok; set => stok = value; }

        public static Boolean CreateStok(StokBarang sb)
        {
            string sql = "insert into cabangs_barangs (cabangs_id, barangs_id, stok) values('" + sb.Cabang.Id + "', '" + sb.Barang.Id + "', " + sb.Stok + ")";
            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static Boolean CheckDuplicate(StokBarang sb)
        {
            string sql = "select * from cabangs_barangs where cabangs_id='" + sb.Cabang.Id + "' and barangs_id='" + sb.Barang.Id + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                return true;
            }

            return false;
        }

        public static Boolean UpdateStok(StokBarang sb)
        {
            string sql = "update cabangs_barangs set stok=" + sb.Stok 
                + " where cabangs_id='" + sb.Cabang.Id + "' and barangs_id='" + sb.Barang.Id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }
    }
}
