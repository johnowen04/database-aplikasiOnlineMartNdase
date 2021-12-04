using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Hadiah
    {
        private int id;
        private string nama;
        private int jumlahPoin;

        public Hadiah(string nama, int jumlahPoin)
        {
            Nama = nama;
            JumlahPoin = jumlahPoin;
        }

        public Hadiah(int id, string nama, int jumlahPoin)
        {
            Id = id;
            Nama = nama;
            JumlahPoin = jumlahPoin;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int JumlahPoin { get => jumlahPoin; set => jumlahPoin = value; }

        #region METHODS
        public static Boolean CreateData(Hadiah h)
        {
            string sql = "insert into gifts (id, nama, jumlah_poin) " +
                "values (" + h.Id + ",'" + h.Nama.Replace("'", "\\'") + "','" + h.JumlahPoin.ToString() + "')";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);

            if (jumlahDataBerubah == 0)
                return false;
            else
                return true;
        }

        public static List<Hadiah> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from gifts";
            }
            else
            {
                sql = "select * from gifts " +
                    "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Hadiah> listHadiah = new List<Hadiah>();

            while (hasil.Read() == true)
            {
                Hadiah h = new Hadiah(int.Parse(hasil.GetString(0)), hasil.GetString(1), int.Parse(hasil.GetString(2)));

                listHadiah.Add(h);
            }
            return listHadiah;
        }

        public static Boolean UpdateData(Hadiah h)
        {
            string sql = "update gifts set nama=" + h.Nama + ", jumlah_poin=" + h.JumlahPoin.ToString() +
                " where id=" + h.Id;

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);

            if (jumlahDataBerubah == 0)
                return false;
            else
                return true;
        }

        public static Boolean DeleteData(string id)
        {
            string sql = "delete from gifts where id='" + id + "'";

            int jumlahDataBerubah = Koneksi.JalankanPerintahDML(sql);

            if (jumlahDataBerubah == 0)
                return false;
            else
                return true;
        }
        #endregion
    }
}
