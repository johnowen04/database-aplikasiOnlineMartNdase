using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class MetodePembayaran
    {
        private int id;
        private string nama;

        public MetodePembayaran(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }

        public MetodePembayaran(string nama)
        {
            Id = 0;
            Nama = nama;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }

        public static Boolean CreateData(MetodePembayaran mp)
        {
            string sql = "insert into metode_pembayarans (id, nama) values ('" + mp.Id + "','" + mp.Nama.Replace("'", "\\'") + "')";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static List<MetodePembayaran> ReadData() => ReadData("", "");

        public static List<MetodePembayaran> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select * from metode_pembayarans";
            }
            else
            {
                sql = "select * from metode_pembayarans where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<MetodePembayaran> listMetodePembayaran = new List<MetodePembayaran>();

            while (hasil.Read() == true)
            {
                MetodePembayaran mp = new MetodePembayaran(int.Parse(hasil.GetValue(0).ToString()), hasil.GetString(1));
                listMetodePembayaran.Add(mp);
            }
            return listMetodePembayaran;
        }

        public static Boolean UpdateData(MetodePembayaran mp)
        {
            string sql = "update metode_pembayarans set nama='" + mp.Nama.Replace("'", "\\'") + "' where id='" + mp.Id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static Boolean DeleteData(string id)
        {
            string sql = "delete from metode_pembayarans where id='" + id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }
    }
}
