﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace Project1._0
{
    public partial class NewRoom : Form
    {

        public string username;
        TcpClient clientSocket;
        NetworkStream serverStream;
        string readData;
        bool checkw = true;
        bool refromServer = false;
        bool check = false;
        public NewRoom(string us, TcpClient cl, NetworkStream ns)
        {
            InitializeComponent();
            username = us;
            clientSocket = cl;
            serverStream = ns;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_back_nroom_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.username = username;
            dashboard.clientSocket = clientSocket;
            dashboard.serverStream = serverStream;
            dashboard.Show();
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            checkw = true;
            byte[] outStream = Encoding.UTF8.GetBytes("3\n" + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            if (check == false)
            {
                Thread ctThread = new Thread(getMessage);
                ctThread.Start();
            }
            check = true;

            while (checkw)
            {
                if(refromServer)
                {
                    Ve ve = new Ve(username, clientSocket, serverStream, readData);
                    ve.Show();
                    this.Close();
                    break;
                }    
            }    
        }

        private void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                byte[] inStream = new byte[10025];
                serverStream.Read(inStream, 0, inStream.Length);
                string returndata = Encoding.UTF8.GetString(inStream).Replace("\0", string.Empty); ;
                readData = "" + returndata;
                if (readData != "False")
                {
                    refromServer = true;
                    break;
                }
                if (readData == "False")
                {
                    MessageBox.Show("Server bi loi, mong ban thong cam.");
                    checkw = false;
                }
            }
        }
    }
}