using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Sockets
{
    public partial class Form1 : Form
    {

        IPHostEntry NeighboringHost;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void getHostName_Click(object sender, EventArgs e)
        {
            //string HostName = Dns.GetHostName();
            //txtHostName.Text = HostName;

            String IPLiteral = txtNeighboringIP.Text.Trim();

            IPAddress IPAddress = IPAddress.Parse(IPLiteral);

            NeighboringHost = Dns.GetHostEntry(IPAddress);

            String LiteralHostName = NeighboringHost.HostName;

            txtHostName.Text = LiteralHostName;
        }
    }
}
