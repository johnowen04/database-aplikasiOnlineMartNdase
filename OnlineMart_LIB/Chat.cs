using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OnlineMart_LIB
{
    public class Chat
    {
        private Order order;
        private List<string> listMessage;

        public Chat()
        {
            Order = null;
            ListMessage = new List<string>();
        }

        public Chat(Order order)
        {
            Order = order;
            ListMessage = new List<string>();
        }

        public Order Order { get => order; set => order = value; }
        public List<string> ListMessage { get => listMessage; set => listMessage = value; }

        public void ReadMessage()
        {
            string sql = "(select tanggal, concat(dari, ': ' , pesan) as pesan"
                    + " from chats where dari=" + Order.Konsumen.Id + " and untuk=" + Order.Kurir.Id + " and order_id=" + Order.Id + " and sender='konsumen'"
                    + " union "
                    + " select tanggal, concat(dari, ': ', pesan) as pesan"
                    + " from chats where dari=" + Order.Kurir.Id + " and untuk=" + Order.Konsumen.Id + " and order_id=" + Order.Id + " and sender='kurir'"
                    + " ) order by tanggal";

            MySqlDataReader hasil = Koneksi.JalankanPerintahQuery(sql);

            while (hasil.Read())
            {
                ListMessage.Add(hasil.GetString(1));
            }
        }

        public int CreateMessage(string sender, string message)
        {
            string sql = "insert into chats(tanggal, dari, untuk, pesan, order_id, sender) values('"
                + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "',";
            
            if (sender == "konsumen")
            {
                sql += Order.Konsumen.Id + "," + Order.Kurir.Id + ",'" + message + "','" + Order.Id + "','konsumen')"; 
            }
            else if (sender == "kurir")
            {
                sql += Order.Kurir.Id + "," + Order.Konsumen.Id + ",'" + message + "','" + Order.Id + "','kurir')";
            }

            int hasil = Koneksi.JalankanPerintahDML(sql);
            return hasil;
        }
    }
}
