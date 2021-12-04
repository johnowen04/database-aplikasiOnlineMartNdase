using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Barang
    {
        #region FIELDS
        private int id;
        private string nama;
        private string harga;
        private Kategori kategori;
        #endregion

        #region CONSTRUCTORS
        public Barang(int id, string nama, string harga, Kategori kategori)
        {
            Id = id;
            Nama = nama;
            Harga = harga;
            Kategori = kategori;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Harga { get => harga; set => harga = value; }
        public Kategori Kategori { get => kategori; set => kategori = value; }
        #endregion

        #region METHODS
        public static Boolean CreateData(Barang b)
        {
            string sql = "insert into barangs (id, nama, harga, kategoris_id) values ('" + b.Id + "','" +
                b.Nama.Replace("'", "\\'") + "','" + b.Harga + "','" + b.Kategori.Id + "')";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static List<Barang> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select b.id, b.nama, b.harga, k.id as kategori_id, k.nama as kategori_nama " +
                    "from barangs as b inner join kategoris as k on b.kategoris_id = k.id";
            }
            else
            {
                sql = "select b.id, b.nama, b.harga, k.id as kategori_id, k.nama as kategori_nama " +
                    "from barangs as b inner join kategoris as k on b.kategoris_id = k.id" +
                    "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Barang> listBarang = new List<Barang>();

            while (hasil.Read() == true)
            {
                Kategori k = new Kategori(int.Parse(hasil.GetValue(3).ToString()), hasil.GetValue(4).ToString());

                Barang b = new Barang(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), k);

                listBarang.Add(b);
            }
            return listBarang;
        }

        //public static Boolean UpdateData(Barang b)
        //{
        //    string sql = "update barangs set harga='" + b.Harga + "', kategoris_id='" + b.Kategori.Nama + "', cabangs_id='" + b.
        //        "' where id='" + b.Id + "'";

        //    int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
        //    if (jumlahDataBerubah == 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        public static Boolean DeleteData(string id)
        {
            string sql = "delete from barangs where id='" + id + "'";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);
            if (jumlahDataBerubah == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
