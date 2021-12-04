using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Pegawai
    {
        #region FIELDS
        private int id;
        private string nama;
        private string email;
        private string password;
        private string telephone;
        #endregion

        #region CONSTRUCTORS
        public Pegawai(int id, string nama, string email, string password, string telephone)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Password = password;
            Telephone = telephone;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        #endregion

        #region METHODS
        public override string ToString()
        {
            return Nama;
        }

        public static Pegawai CekLogin(string email, string password)
        {
            string sql = "";

            sql = "select id, nama, email, password, telepon from pegawais " +
                    " where email='" + email + "' AND password = SHA2('" + password + "', 512)";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(),
                    hasil.GetValue(4).ToString());

                return p;
            }

            return null;
        }

        public static List<Pegawai> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from pegawais";
            }
            else
            {
                sql = "select * from pegawais where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Pegawai> listPegawai = new List<Pegawai>();

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(),
                    hasil.GetValue(4).ToString());
                listPegawai.Add(p);
            }
            return listPegawai;
        }
        #endregion
    }
}
