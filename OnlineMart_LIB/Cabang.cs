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
        #endregion

        #region CONSTRUCTORS
        public Cabang(int id, string nama, string alamat, Pegawai pegawai)
        {
            Id = id;
            Nama = nama;
            Alamat = alamat;
            Pegawai = pegawai;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public Pegawai Pegawai { get => pegawai; set => pegawai = value; }
        #endregion

        #region METHODS
        public static Boolean CreateData(Cabang c)
        {
            string sql = "insert into cabangs (id, nama, alamat, pegawais_id) values ('" + c.Id + "','" + 
                c.Nama.Replace("'", "\\'") + "','" + c.Alamat + "','" + c.Pegawai.Id + "')";

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

        public static Boolean UpdateData(Cabang c)
        {
            string sql = "update cabangs set nama='" + c.Nama.Replace("'", "\\'") + "', alamat='" + c.Alamat + 
                "' where id='" + c.Id + "'";

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

        public static Boolean DeleteData(string id)
        {
            string sql = "delete from cabangs where id='" + id + "'";

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

        public static List<Cabang> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

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
                Pegawai p = new Pegawai(int.Parse(hasil.GetValue(3).ToString()), hasil.GetValue(4).ToString(), 
                    hasil.GetValue(5).ToString(), hasil.GetValue(6).ToString(), hasil.GetValue(7).ToString());

                Cabang c = new Cabang(int.Parse(hasil.GetValue(0).ToString()), hasil.GetValue(1).ToString(), hasil.GetValue(2).ToString(), p);
                
                listCabang.Add(c);
            }
            return listCabang;
        }
        #endregion
    }
}
