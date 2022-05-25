using System;
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
    public partial class JoinRoom : Form
    {
        public string username;
        TcpClient clientSocket;
        NetworkStream serverStream;
        string readData;
        bool checkw = true;
        bool check = false;
        bool refromServer = false;

        public JoinRoom(string us, TcpClient cl, NetworkStream ns)
        {
            InitializeComponent();
            username = us;
            clientSocket = cl;
            serverStream = ns;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.username = username;
            dashboard.Show();
            this.Close();
        }

        private void btn_join_Click(object sender, EventArgs e)
        {
            checkw = true;
            byte[] outStream = Encoding.UTF8.GetBytes("4\n" + box_code.Text + "\n" + "$");
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
                if (refromServer)
                {
                    Ve ve = new Ve(username, clientSocket, serverStream, box_code.Text);
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
                if (readData == "True")
                {
                    refromServer = true;
                    break;
                }
                if (readData == "False")
                {
                    MessageBox.Show("Ma phong khong ton tai hoac ban khong duoc phep vao phong.");
                    checkw = false;
                }
            }
        }
    }
}
