using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Kategori
    {
        #region FIELDS
        private int id;
        private string nama;
        #endregion

        #region CONSTRUCTORS
        public Kategori()
        {
            Id = 0;
            Nama = "";
        }

        public Kategori(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region METHODS
        public static Boolean CreateData(Kategori k)
        {
            string sql = "insert into kategoris (id, nama) values ('" + k.Id + "','" + k.Nama.Replace("'", "\\'") + "')";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static List<Kategori> ReadData() => ReadData("", "");

        public static List<Kategori> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select * from kategoris";
            }
            else
            {
                sql = "select * from kategoris where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Kategori> listKategori = new List<Kategori>();

            while (hasil.Read() == true)
            {
                Kategori k = new Kategori(int.Parse(hasil.GetValue(0).ToString()), hasil.GetString(1));
                listKategori.Add(k);
            }
            return listKategori;
        }

        public static Boolean UpdateData(Kategori k)
        {
            string sql = "update kategoris set nama='" + k.Nama.Replace("'", "\\'") + "' where id='" + k.Id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static Boolean DeleteData(string id)
        {
            string sql = "delete from kategoris where id='" + id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public override string ToString()
        {
            return Nama;
        }
        #endregion

    }
}
