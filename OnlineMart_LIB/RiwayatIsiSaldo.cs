using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class RiwayatIsiSaldo
    {
        private int id;
        private DateTime waktuIsi;
        private float saldo;
        private Konsumen konsumen;
        private string bulan;
        private double totalTransaksi;

        public RiwayatIsiSaldo()
        {
            Id = 0;
            WaktuIsi = DateTime.Now;
            Saldo = 0;
            Konsumen = null;
        }

        public RiwayatIsiSaldo(DateTime waktuIsi, float saldo, Konsumen konsumen)
        {
            WaktuIsi = waktuIsi;
            Saldo = saldo;
            Konsumen = konsumen;
        }
        public RiwayatIsiSaldo(int id, DateTime waktuIsi, float saldo, Konsumen konsumen)
        {
            Id = id;
            WaktuIsi = waktuIsi;
            Saldo = saldo;
            Konsumen = konsumen;
        }

        public int Id { get => id; set => id = value; }
        public DateTime WaktuIsi { get => waktuIsi; set => waktuIsi = value; }
        public float Saldo { get => saldo; set => saldo = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public string Bulan { get => bulan; set => bulan = value; }
        public double TotalTransaksi { get => totalTransaksi; set => totalTransaksi = value; }

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

        public static void CreateData(RiwayatIsiSaldo ris)
        {
            string sql = "insert into riwayat_isi_saldos (waktu, isi_saldo, pelanggans_id) " +
                "values (now(), " + ris.Saldo + "," + ris.Konsumen.Id + ")";

            Koneksi.JalankanPerintahDML(sql);
        }

        //public static List<RiwayatIsiSaldo> ReadData() => ReadData("", "");

        public static List<RiwayatIsiSaldo> ReadData(string kriteria, string bulan, string tahun)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "select month(waktu), sum(isi_saldo) from riwayat_isi_saldos where year(waktu) = " + tahun;
            }
            else
            {
                sql = "select month(waktu), sum(isi_saldo) from riwayat_isi_saldos where year(waktu) = '" + tahun + 
                    "' and month(waktu) = '" + ConvertMonth(bulan) + "'";
            }

            sql += " group by month(waktu)";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);
            List<RiwayatIsiSaldo> listRiwayatIsiSaldo = new List<RiwayatIsiSaldo>();

            while (hasil.Read() == true)
            {
                RiwayatIsiSaldo ris = new RiwayatIsiSaldo();
                ris.Bulan = hasil.GetString(0);
                ris.TotalTransaksi = hasil.GetDouble(1);

                listRiwayatIsiSaldo.Add(ris);
            }
            return listRiwayatIsiSaldo;
        }
    }
}
