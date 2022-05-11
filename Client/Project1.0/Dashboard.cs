using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.Net;

namespace Project1._0
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public TcpClient clientSocket;
        public NetworkStream serverStream;
        public string username;

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            NewRoom newRoom = new NewRoom(username,clientSocket,serverStream);
            newRoom.Show();
            this.Close();
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            this.Hide();
            JoinRoom joinRoom = new JoinRoom(username, clientSocket, serverStream);
            joinRoom.Show();
            this.Close();
        }
    }
}
