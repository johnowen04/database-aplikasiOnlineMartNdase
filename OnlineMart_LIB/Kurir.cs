using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Kurir
    {
        #region FIELDS
        private int id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string telepon;
        #endregion

        #region CONSTRUCTORS

        public Kurir(int id, string nama, string email, string username, string password, string telepon)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Username = username;
            Password = password;
            Telepon = telepon;
        }

        public Kurir(string nama, string email, string username, string password, string telepon)
        {
            Nama = nama;
            Email = email;
            Username = username;
            Password = password;
            Telepon = telepon;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        #endregion

        #region METHODS
        public static Kurir CekLogin(string username, string password)
        {
            string sql = "";

            sql = "select id, nama, email, username, password, telepon " +
                    " from drivers " +
                    " where username='" + username + "' AND password = SHA2('" + password + "', 512)";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true)
            {
                Kurir k = new Kurir(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(),
                    hasil.GetValue(5).ToString());

                return k;
            }

            return null;
        }

        public static Boolean CreateData(Kurir k)
        {
            string sql = "insert into drivers ( nama, email, username, password, telepon) values ('"
                + k.Nama.Replace("'", "\\'") + "','" + k.Email + "','"
                + k.Username + "',SHA2('" + k.Password + "',512), '"
                + k.Telepon + "')";

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
