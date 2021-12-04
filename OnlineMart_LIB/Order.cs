using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Order
    {
        private string id;
        private DateTime tanggal_waktu;
        private string alamat_tujuan;
        private float ongkos_kirim;
        private float total_bayar;
        private Cabang cabang;
        private Kurir kurir;
        private Konsumen konsumen;
        private Promo promo;
        private string status;
        private MetodePembayaran metodePembayaran;
        private List<BarangOrder> listBarangOrder;

        public Order(string id, DateTime tanggal_waktu, string alamat_tujuan, float ongkos_kirim, float total_bayar, 
            Cabang cabang, Kurir kurir, Konsumen konsumen, Promo promo, string status, MetodePembayaran metodePembayaran)
        {
            Id = id;
            Tanggal_Waktu = tanggal_waktu;
            Alamat_Tujuan = alamat_tujuan;
            Ongkos_Kirim = ongkos_kirim;
            Total_Bayar = total_bayar;
            Cabang = cabang;
            Kurir = kurir;
            Konsumen = konsumen;
            Promo = promo;
            Status = status;
            MetodePembayaran = metodePembayaran;
            ListBarangOrder = new List<BarangOrder>();
        }

        public string Id { get => id; set => id = value; }
        public DateTime Tanggal_Waktu { get => tanggal_waktu; set => tanggal_waktu = value; }
        public string Alamat_Tujuan { get => alamat_tujuan; set => alamat_tujuan = value; }
        public float Ongkos_Kirim { get => ongkos_kirim; set => ongkos_kirim = value; }
        public float Total_Bayar { get => total_bayar; set => total_bayar = value; }
        public Cabang Cabang { get => cabang; set => cabang = value; }
        public Kurir Kurir { get => kurir; set => kurir = value; }
        public Konsumen Konsumen { get => konsumen; set => konsumen = value; }
        public Promo Promo { get => promo; set => promo = value; }
        public string Status { get => status; set => status = value; }
        public MetodePembayaran MetodePembayaran { get => metodePembayaran; set => metodePembayaran = value; }
        public List<BarangOrder> ListBarangOrder { get => listBarangOrder; private set => listBarangOrder = value; }

        public static string GenerateNoNota()
        {
            string sql = "select RIGHT(id, 3) as NoOrder" +
                " from orders " +
                " where Date(tanggal_waktu) = Date(CURRENT_DATE)" +
                " order by tanggal_waktu DESC limit 1";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            string hasilNoOrder = "";
            if (hasil.Read() == true)
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    int noOrders = int.Parse(hasil.GetValue(0).ToString()) + 1;
                    hasilNoOrder = DateTime.Now.Year +
                                  DateTime.Now.Month.ToString().PadLeft(2, '0') +
                                  DateTime.Now.Day.ToString().PadLeft(2, '0') +
                                  noOrders.ToString().PadLeft(3, '0');
                }
            }
            else
            {
                hasilNoOrder = DateTime.Now.Year +
                              DateTime.Now.Month.ToString().PadLeft(2, '0') +
                              DateTime.Now.Day.ToString().PadLeft(2, '0') +
                              "001";
            }
            return hasilNoOrder;
        }

        public void TambahDetilBarang(Barang barang, int jumlah, float harga)
        {
            ListBarangOrder.Add(new BarangOrder(barang, jumlah, harga));
        }

        public static Boolean CreateData(Order order)
        {
            string sql1 = "insert into orders(id, tanggal_waktu, alamat_tujuan, ongkos_kirim, total_bayar, "
                + "cabangs_id, drivers_id, pelanggans_id, promo_id, status, metode_pembayaran_id) " 
                + " values(" + order.Id + ",'" + order.Tanggal_Waktu.ToString("yyyy-MM-dd hh:mm:ss") + "','"
                + order.Alamat_Tujuan + "'," + order.Ongkos_Kirim + "," + order.Total_Bayar + "," + order.Cabang.Id + ","
                + order.Kurir.Id + "," + order.Konsumen.Id + "," + order.Promo.Id + ",'Pesanan Diproses',"
                + order.MetodePembayaran.Id + ")";

            if (Koneksi.JalankanPerintahDML(sql1) != 0)
            {
                foreach (BarangOrder barangOrder in order.ListBarangOrder)
                {
                    string sql2 = "insert into barangs_orders(barangs_id, orders_id, jumlah, harga) "
                        + " values (" + barangOrder.Barang.Id + "," + order.Id + "," + barangOrder.Jumlah + ","
                        + barangOrder.Harga + ")";

                    if (Koneksi.JalankanPerintahDML(sql2) != 0)
                    { 
                        StokBarang.UpdateStok("penjualan",
                            new StokBarang(order.Cabang, barangOrder.Barang, barangOrder.Jumlah));
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
