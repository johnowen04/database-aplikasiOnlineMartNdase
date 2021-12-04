using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Konsumen
    {
        #region FIELDS
        private int id;
        private string nama;
        private string email;
        private string password;
        private string telepon;
        private float saldo;
        private int poin;
        #endregion

        #region CONSTRUCTORS
        public Konsumen(string nama, string email, string password, string telepon, float saldo, int poin)
        {
            Id = 0;
            Nama = nama;
            Email = email;
            Password = password;
            Telepon = telepon;
            Saldo = saldo;
            Poin = poin;
        }

        public Konsumen(int id, string nama, string email, string password, string telepon, float saldo, int poin)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Password = password;
            Telepon = telepon;
            Saldo = saldo;
            Poin = poin;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Telepon { get => telepon; set => telepon = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public int Poin { get => poin; set => poin = value; }
        #endregion

        #region METHODS
        public static Konsumen CekLogin(string email, string password)
        {
            string sql = "";

            sql = "select id, nama, email, password, telepon, saldo, poin " +
                    " from pelanggans " +
                    " where email='" + email + "' AND password = SHA2('" + password + "', 512)";


            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read() == true)
            {
                Konsumen k = new Konsumen(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(),
                    float.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()));

                return k;
            }

            return null;
        }

        public static Boolean CreateData(Konsumen k)
        {
            string sql = "insert into pelanggans (nama, email, password, telepon, saldo, poin) values ('" + 
                k.Nama.Replace("'", "\\'") + "','" + k.Email +"', SHA2('" + k.Password +"', 512), '" + 
                k.Telepon + "','" + k.Saldo + "','" + k.Poin + "')";

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

        public static Boolean UpdateData(Konsumen k)
        {
            string sql = "update pelanggans set nama='" + k.Nama.Replace("'", "\\'") + "', email='" + k.Email + "', telepon='" + 
                k.Telepon + "' where id='" + k.Id + "'";

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

        public static List<Konsumen> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select * from pelanggans";
            }
            else
            {
                sql = "select * from pelanggans where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Konsumen> listKonsumen = new List<Konsumen>();

            while (hasil.Read() == true)
            {
                Konsumen k = new Konsumen(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), hasil.GetValue(4).ToString(),
                    float.Parse(hasil.GetValue(5).ToString()), int.Parse(hasil.GetValue(6).ToString()));

                listKonsumen.Add(k);
            }
            return listKonsumen;
        }
        #endregion
    }
}
