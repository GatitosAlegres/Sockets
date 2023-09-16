﻿using System;
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
    public partial class Form1 : Form // SERVER
    {

        IPHostEntry LocalHost;
        IPEndPoint LocalPoint;
        Socket ServerSocket;
        IPAddress LocalIP;


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

            LocalHost = Dns.GetHostEntry(Dns.GetHostName());

            String IPLiteral = LocalHost.AddressList[1].ToString();

            LocalIP = IPAddress.Parse(IPLiteral);

            LocalPoint = new IPEndPoint(LocalIP, 1300);

            ServerSocket = new Socket(
                addressFamily: AddressFamily.InterNetwork,
                socketType: SocketType.Stream,
                protocolType: ProtocolType.Tcp
            );

            MessageBox.Show("Socket Server: " + IPLiteral + " " + Dns.GetHostName().ToString());
        }
    }
}
