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
        private List<KeranjangBarang> listKeranjangBarang;
        #endregion

        #region CONSTRUCTORS

        public Konsumen()
        {
            Id = 0;
            Nama = "";
            Email = "";
            Password = "";
            Telepon = "";
            Saldo = 0.0f;
            Poin = 0;
            ListKeranjangBarang = new List<KeranjangBarang>();
        }

        public Konsumen(string nama, string email, string password, string telepon, float saldo, int poin)
        {
            Id = 0;
            Nama = nama;
            Email = email;
            Password = password;
            Telepon = telepon;
            Saldo = saldo;
            Poin = poin;
            ListKeranjangBarang = new List<KeranjangBarang>();
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
            ListKeranjangBarang = new List<KeranjangBarang>();
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
        public List<KeranjangBarang> ListKeranjangBarang { get => listKeranjangBarang; private set => listKeranjangBarang = value; }
        #endregion

        #region METHODS
        public Boolean CheckDuplicate(KeranjangBarang kb)
        {
            if (ListKeranjangBarang.Find(keranjangBarang => keranjangBarang.Cabang.Nama == kb.Cabang.Nama && keranjangBarang.Barang.Nama == kb.Barang.Nama) != null)
                return true;

            return false;
        }
        public static Konsumen CekLogin(string email, string password)
        {
            string sql;
            sql = "select id, nama, email, password, telepon, saldo, poin " +
                    "from pelanggans " +
                    "where email='" + email + "' AND password = SHA2('" + password + "', 512)";


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

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static List<Konsumen> ReadData() => ReadData("", "");

        public static List<Konsumen> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql;
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
                Konsumen k = new Konsumen(hasil.GetInt32(0), hasil.GetString(1),
                    hasil.GetString(2), hasil.GetString(3), hasil.GetString(4),
                    hasil.GetFloat(5), hasil.GetInt32(6));

                string sqlKeranjangBarang = "select cabangs_id, barangs_id, quantity from keranjangs_barangs where pelanggans_id='" + hasil.GetInt32(0) + "'";

                MySqlDataReader hasilQueryKeranjang = Koneksi.JalankanPerintahQuery(sqlKeranjangBarang);
                while (hasilQueryKeranjang.Read())
                {
                    List<Cabang> listCabang = Cabang.ReadData("c.id", hasilQueryKeranjang.GetInt32(0).ToString());
                    List<Barang> listBarang = Barang.ReadData("b.id", hasilQueryKeranjang.GetInt32(1).ToString());
                    int quantity = hasilQueryKeranjang.GetInt32(2);

                    k.TambahBarangKeKeranjang(listCabang[0], listBarang[0], quantity);
                }

                listKonsumen.Add(k);
            }
            return listKonsumen;
        }

        public static Boolean UpdateData(Konsumen k)
        {
            string sql = "update pelanggans set nama='" + k.Nama.Replace("'", "\\'") + "', email='" + k.Email + "', telepon='" + 
                k.Telepon + "' where id='" + k.Id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static Boolean UpdateSaldo(float jumlahSaldo, Konsumen k)
        {
            string sql = "update pelanggans set saldo=saldo+" + jumlahSaldo +
                "where id=" + k.Id;

            if (Koneksi.JalankanPerintahDML(sql) != 0)
                return RiwayatIsiSaldo.CreateData(new RiwayatIsiSaldo(DateTime.Now, jumlahSaldo, k));
            
            return false;
        }

        public void TambahBarangKeKeranjang(KeranjangBarang kb) => ListKeranjangBarang.Add(kb);

        public void TambahBarangKeKeranjang(Cabang cabang, Barang barang, int quantity)
        {
            ListKeranjangBarang.Add(new KeranjangBarang(this, cabang, barang, quantity));
        }
        #endregion
    }
}
