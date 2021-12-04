using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineMart_LIB;

namespace OnlineMart_Ndase
{
    public partial class FormKonsumenChat : Form
    {
        public Order order;
        private Chat chat;

        public FormKonsumenChat()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e) => Close();

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            int hasil = chat.CreateMessage("konsumen", textBoxChat.Text);
            TampilPesan();
            textBoxChat.Clear();
        }

        private void TampilPesan()
        {
            listBoxChat.Items.Clear();

            chat = new Chat(order);
            chat.ReadMessage();

            foreach (string message in chat.ListMessage)
            {
                listBoxChat.Items.Add(message);
            }
        }

        private void FormKonsumenChat_Load(object sender, EventArgs e)
        {
            labelKurir.Text = order.Kurir.Nama;
            Console.WriteLine(order.Konsumen.Id + " ; " + order.Kurir.Id);
            TampilPesan();
        }
    }
}
