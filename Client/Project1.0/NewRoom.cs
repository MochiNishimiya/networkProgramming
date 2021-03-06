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
        string readData;
        bool checkw = true;
        bool refromServer = false;
        bool check = false;
        public NewRoom(string us)
        {
            InitializeComponent();
            username = us;
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            checkw = true;
            byte[] outStream = Encoding.UTF8.GetBytes("3\n" + "$");
            outStream = XOR(outStream, connectServer.key);
            connectServer.serverStream.Write(outStream, 0, outStream.Length);
            connectServer.serverStream.Flush();

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
                    Ve ve = new Ve(username, connectServer.clientSocket, connectServer.serverStream, readData);
                    ve.Show();
                    this.Close();
                    break;
                }    
            }    
        }

        public static byte[] del(byte[] input)
        {
            int i = input.Length - 1;
            while (input[i] == 0)
                i--;
            byte[] output = new byte[i + 1];
            bool r = true;
            for (int j = 0; j <= i; j++)
            {
                output[j] = input[j];
            }
            return output;
        }
        private void getMessage()
        {
            while (true)
            {
                connectServer.serverStream = connectServer.clientSocket.GetStream();
                byte[] inStream = new byte[10025];
                connectServer.serverStream.Read(inStream, 0, inStream.Length);
                inStream = del(inStream);
                inStream = XOR(inStream, connectServer.key);
                string returndata = Encoding.UTF8.GetString(inStream).Replace("\0", string.Empty); ;
                readData = "" + returndata;
                if (readData != "False")
                {
                    refromServer = true;
                    break;
                }
                if (readData == "False")
                {
                    MessageBox.Show("SOS!!! Server Down. Please go back later");
                    checkw = false;
                }
            }
        }
        public byte[] XOR(byte[] data, byte[] key)
        {

            for (int i = 0, j = 0; i < data.Length; i++)

            {

                data[i] ^= key[j];

                j = (++j < key.Length) ? j : 0;

            }
            return data;
        }
    }
}
