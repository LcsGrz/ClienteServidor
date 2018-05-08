using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServer
{
    public partial class Form1 : Form
    {
        server servidor;
        cliente cliente;
        public Form1()
        {
            InitializeComponent();
            servidor = new server() { f = this };
            cliente = new cliente() { f = this };
            lblIPMIA.Text = GetLocalIPAddress();
            // servidor.StartListening();
            // cliente.StartClient();
        }
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        public void Escribir(string texto) {
            tbRecibido.Clear();
            tbRecibido.Text = texto;
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.OpenFile() != null)
            {
                lblRuta.Text = openFileDialog1.FileName;
            }
        }
    }
}
