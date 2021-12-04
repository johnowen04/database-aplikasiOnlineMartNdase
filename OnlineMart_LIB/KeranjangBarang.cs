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
        private Konsumen konsumen;
        private Cabang cabang;
        private Barang barang;
        private int quantity;

        public KeranjangBarang()
        {
            Konsumen = null;
            Cabang = null;
            Barang = null;
            Quantity = 0;
        }

        public KeranjangBarang(Konsumen konsumen, Cabang cabang, Barang barang, int quantity)
        {
            Konsumen = konsumen;
            Cabang = cabang;
            Barang = barang;
            Quantity = quantity;
        }

        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Barang Barang { get => barang; set => barang = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public static Boolean CreateData(KeranjangBarang kb)
        {
            string sql = "insert into keranjangs_barangs (pelanggans_id, cabangs_id, barangs_id, quantity) " 
                + "values('" + kb.Konsumen.Id + "','" + kb.Cabang.Id + "', '" + kb.Barang.Id + "', " + kb.Quantity + ")";
            return Koneksi.JalankanPerintahDML(sql) != 0;
        }
        public static Boolean CheckDuplicate(KeranjangBarang kb)
        {
            string sql = "select * from keranjangs_barangs "
                + "where pelanggans_id= '" + kb.Konsumen.Id + "' and cabangs_id='" + kb.Cabang.Id + "' and barangs_id='" + kb.Barang.Id + "'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                return true;
            }

            return false;
        }


        public static Boolean UpdateQuantity(KeranjangBarang kb)
        {
            string sql = "update keranjangs_barangs set quantity=" + kb.quantity 
                + " where pelanggans_id= " + kb.Konsumen.Id + " and cabangs_id=" + kb.Cabang.Id + " and barangs_id=" + kb.Barang.Id;

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }
    }
}
