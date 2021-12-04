using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class RiwayatPenjualanBarang
    {
        #region FIELDS
        private string bulan;
        private string namaCabang;
        private double total;
        #endregion

        #region CONSTRUCTORS
        public RiwayatPenjualanBarang(string bulan, string namaCabang, double total)
        {
            Bulan = bulan;
            NamaCabang = namaCabang;
            Total = total;
        }
        #endregion

        #region PROPERTIES
        public string Bulan { get => bulan; set => bulan = value; }
        public string NamaCabang { get => namaCabang; set => namaCabang = value; }
        public double Total { get => total; set => total = value; }
        #endregion

        #region METHODS
        static string ConvertMonth(string bulan)
        {
            string angka = "";

            switch(bulan)
            {
                case "Januari":
                    angka = "01";
                    break;
                case "Februari":
                    angka = "02";
                    break;
                case "Maret":
                    angka = "03";
                    break;
                case "April":
                    angka = "04";
                    break;
                case "Mei":
                    angka = "05";
                    break;
                case "Juni":
                    angka = "06";
                    break;
                case "Juli":
                    angka = "07";
                    break;
                case "Agustus":
                    angka = "08";
                    break;
                case "September":
                    angka = "09";
                    break;
                case "Oktober":
                    angka = "10";
                    break;
                case "November":
                    angka = "11";
                    break;
                case "Desember":
                    angka = "12";
                    break;
            }

            return angka;
        }
        public static List<RiwayatPenjualanBarang> ReadData(string kriteria, string bulan, string tahun, string cabang)
        {
            string sql = "";

            if (kriteria == "")
            {
                sql = "select month(tanggal_waktu), c.nama, sum(o.total_bayar) " +
                    "from orders as o inner join cabangs as c on o.cabangs_id=c.id " +
                    "where year(tanggal_waktu) = '" + tahun + "' and c.nama = '" + cabang + "'";
            }

            else
            {
                sql = "select month(tanggal_waktu), c.nama, sum(o.total_bayar) " +
                    "from orders as o inner join cabangs as c on o.cabangs_id=c.id " +
                    "where year(tanggal_waktu) = '" + tahun + "' and month(tanggal_waktu) = '" + ConvertMonth(bulan) + "' and c.nama = '" + cabang + "'";
            }

            sql += "group by month(tanggal_waktu), c.nama";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<RiwayatPenjualanBarang> listRiwayatPenjualanBarang = new List<RiwayatPenjualanBarang>();

            while (hasil.Read() == true)
            {
                RiwayatPenjualanBarang rpb = new RiwayatPenjualanBarang(hasil.GetValue(0).ToString(), hasil.GetString(1), 
                    double.Parse(hasil.GetString(2)));

                listRiwayatPenjualanBarang.Add(rpb);
            }

            return listRiwayatPenjualanBarang;
        }
        #endregion
    }
}
