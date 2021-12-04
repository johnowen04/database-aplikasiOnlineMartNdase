using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class RekapPendapatanKurir
    {
        private string bulan;
        private double gajian;

        public RekapPendapatanKurir(string bulan, double gajian)
        {
            Bulan = bulan;
            Gajian = gajian;
        }

        public string Bulan { get => bulan; set => bulan = value; }
        public double Gajian { get => gajian; set => gajian = value; }

        static string ConvertMonth(string bulan)
        {
            string angka = "";

            switch (bulan)
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

        public static List<RekapPendapatanKurir> ReadData(string kriteria, string bulan, string tahun, string driverID)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select month(tanggal_waktu), sum(ongkos_kirim * 0.8) " +
                    "from orders where year(tanggal_waktu) = '" + tahun + "' and drivers_id = '" + driverID + "'";
            }
            else
            {
                sql = "select month(tanggal_waktu), sum(ongkos_kirim * 0.8) " +
                    "from orders where year(tanggal_waktu) = '" + tahun + "'  and month(tanggal_waktu) = '" + ConvertMonth(bulan) +
                    "' and drivers_id = '" + driverID + "'";
            }

            sql += " group by month(tanggal_waktu)";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<RekapPendapatanKurir> listPendapatan = new List<RekapPendapatanKurir>();

            while (hasil.Read() == true)
            {
                RekapPendapatanKurir rpk = new RekapPendapatanKurir(hasil.GetString(0), hasil.GetDouble(1));

                listPendapatan.Add(rpk);
            }
            return listPendapatan;
        }
    }
}
