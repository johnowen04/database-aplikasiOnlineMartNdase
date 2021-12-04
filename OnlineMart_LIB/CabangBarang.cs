using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class CabangBarang
    {
        #region FIELDS
        private Cabang cabang;
        private Barang barang;
        private int stok;
        #endregion

        #region CONSTRUCTORS
        public CabangBarang(Barang barang, Cabang cabang, int stok)
        {
            Barang = barang;
            Cabang = cabang;
            Stok = stok;
        }
        #endregion

        #region PROPERTIES
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Barang Barang { get => barang; set => barang = value; }
        public int Stok { get => stok; set => stok = value; }
        #endregion

        #region METHODS
        public static void UpdateStok(int jumlahStok, int idBarang, int idCabang, string jenisTransaksi)
        {
            string sql = "";
            if (jenisTransaksi == "penjualan")
            {
                sql = "update cabangs_barangs set stok=stok-" + jumlahStok +
                " where barangs_id = " + idBarang + " and cabangs_id =" + idCabang;
            }
            else if (jenisTransaksi == "pembelian")
            {
                sql = "update cabangs_barangs set stok=stok+" + jumlahStok +
                " where barangs_id = " + idBarang + " and cabangs_id =" + idCabang;
            }

            Koneksi.JalankanPerintahDML(sql);
        }

        public static List<CabangBarang> ReadData(string kriteria, string nilaiKriteria)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select cb.cabangs_id as cabang_id, c.nama, c.alamat, " +
                    "cb.barangs_id as barang_id, b.nama, b.harga, k.id as kategori_id, k.nama as kategori_nama, " +
                    "cb.stok as stok " +
                    "from cabangs_barangs as cb " +
                    "inner join cabangs as c on cb.cabangs_id=c.id " +
                    "inner join pegawais as p on c.pegawais_id=p.id " +
                    "inner join barangs as b on cb.barangs_id=b.id " +
                    "inner join kategoris as k on b.kategoris_id=k.id";
            }
            else
            {
                sql = "select cb.cabangs_id as cabang_id, c.nama, c.alamat, " +
                    "cb.barangs_id as barang_id, b.nama, b.harga, k.id as kategori_id, k.nama as kategori_nama, " +
                    "cb.stok as stok " +
                    "from cabangs_barangs as cb " +
                    "inner join cabangs as c on cb.cabangs_id=c.id " +
                    "inner join pegawais as p on c.pegawais_id=p.id " +
                    "inner join barangs as b on cb.barangs_id=b.id " +
                    "inner join kategoris as k on b.kategoris_id=k.id " +
                    "where " + kriteria + " like '%" + nilaiKriteria + "%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<CabangBarang> listCabangBarang = new List<CabangBarang>();

            while (hasil.Read() == true)
            {
                Pegawai p = new Pegawai();

                Cabang c = new Cabang(hasil.GetInt32(0), hasil.GetString(1), hasil.GetString(2), p);

                Kategori k = new Kategori(hasil.GetInt32(6), hasil.GetString(7));

                Barang b = new Barang(hasil.GetInt32(3), hasil.GetString(4), hasil.GetString(5), k);

                CabangBarang cb = new CabangBarang(b, c, hasil.GetInt32(8));

                listCabangBarang.Add(cb);
            }
            return listCabangBarang;
        }
        #endregion
    }
}
