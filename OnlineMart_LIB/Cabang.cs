using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Cabang
    {
        #region FIELDS
        private int id;
        private string nama;
        private string alamat;
        private Pegawai pegawai;
        private List<StokBarang> listStokBarang;
        #endregion

        #region CONSTRUCTORS
        public Cabang()
        {
            Id = 0;
            Nama = "";
            Alamat = "";
            Pegawai = null;
            ListStokBarang = new List<StokBarang>();
        }

        public Cabang(int id, string nama, string alamat, Pegawai pegawai)
        {
            Id = id;
            Nama = nama;
            Alamat = alamat;
            Pegawai = pegawai;
            ListStokBarang = new List<StokBarang>();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        public List<StokBarang> ListStokBarang { get => listStokBarang; private set => listStokBarang = value; }
        #endregion

        #region METHODS
        public static Boolean CreateData(Cabang c)
        {
            string sql = "insert into cabangs (id, nama, alamat, pegawais_id) values ('" + c.Id + "','" + 
                c.Nama.Replace("'", "\\'") + "','" + c.Alamat + "','" + c.Pegawai.Id + "')";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static List<Cabang> ReadData() => ReadData("", "");

        public static List<Cabang> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select c.id, c.nama, c.alamat, p.id as pegawai_id, p.nama as pegawai_nama, " +
                    "p.email as pegawai_email, p.password as pegawai_password, p.telepon as pegawai_telepon " +
                    "from cabangs as c inner join pegawais as p on c.pegawais_id = p.id";
            }
            else
            {
                sql = "select c.id, c.nama, c.alamat, p.id as pegawai_id, p.nama as pegawai_nama, " +
                    "p.email as pegawai_email, p.password as pegawai_password, p.telepon as pegawai_telepon " +
                    "from cabangs as c inner join pegawais as p on c.pegawais_id = p.id " +
                    "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<Cabang> listCabang = new List<Cabang>();

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai(hasil.GetInt32(3), hasil.GetString(4),
                    hasil.GetString(5), hasil.GetString(6), hasil.GetString(7));

                Cabang c = new Cabang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), p);

                string sqlStokBarang = "select barangs_id, stok from cabangs_barangs where cabangs_id='" + hasil.GetInt32(0) + "'";

                MySqlDataReader hasilQueryStock = Koneksi.JalankanPerintahQuery(sqlStokBarang);
                while (hasilQueryStock.Read())
                {
                    List<Barang> listBarang = Barang.ReadData("b.id", hasilQueryStock.GetInt32(0).ToString());
                    int stok = hasilQueryStock.GetInt32(1);

                    c.TambahStokBarang(listBarang[0], stok);
                }

                listCabang.Add(c);
            }
            return listCabang;
        }

        public static Boolean UpdateData(Cabang c)
        {
            string sql = "update cabangs set nama='" + c.Nama.Replace("'", "\\'") + "', alamat='" + c.Alamat + 
                "' where id='" + c.Id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public static Boolean DeleteData(string id)
        {
            string sql = "delete from cabangs where id='" + id + "'";

            return Koneksi.JalankanPerintahDML(sql) != 0;
        }

        public void TambahStokBarang(Barang barang, int stok)
        {
            ListStokBarang.Add(new StokBarang(barang, stok));
        }
        #endregion
    }
}
