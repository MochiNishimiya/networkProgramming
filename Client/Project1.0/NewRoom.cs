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
            byte[] outStream = Encoding.UTF8.GetBytes("3\n" + box_code.Text + "\n" + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            CheckForIllegalCrossThreadCalls = false;
            Thread ctThread = new Thread(getMessage);
            if (check == false)
            {
                ctThread.Start();
            }
            check = true;

            while (checkw)
            {
                if(refromServer)
                {
#pragma warning disable SYSLIB0006 // Type or member is obsolete
                    ctThread.Abort();
#pragma warning restore SYSLIB0006 // Type or member is obsolete
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
                string returndata = Encoding.UTF8.GetString(inStream);
                readData = "" + returndata;
                if (readData == "True")
                {
                    refromServer = true;
                }
                if (readData == "False")
                {
                    MessageBox.Show("Ma phong da ton tai.");
                    checkw = false;
                }
            }
        }
    }
}
