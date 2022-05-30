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
    public partial class Login : Form
    {
        string readData = null;
        bool check = false;
        bool checkw;
        public Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        bool refromServer = false;
        Dashboard dashboard = new Dashboard();

        private void btn_login_Click(object sender, EventArgs e)
        {
            checkw = true;
            if (box_username.Text != "" && box_pass.Text != "")
            {
                // Gửi thông tin login đến server
                byte[] outStream = Encoding.UTF8.GetBytes("1\n" + box_username.Text + "\n" + box_pass.Text + "\n" + "$");
                outStream = XOR(outStream, connectServer.key);
                connectServer.serverStream.Write(outStream, 0, outStream.Length);
                connectServer.serverStream.Flush();

                // Mở thread để nhận thông tin từ server
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
                        dashboard.username = box_username.Text;
                        dashboard.Show();
                        this.Hide();
                        break;
                    }
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
                byte[] inStream = new byte[10025];
                connectServer.serverStream.Read(inStream, 0, inStream.Length);
                inStream = del(inStream);
                inStream = XOR(inStream, connectServer.key);
                string returndata = Encoding.UTF8.GetString(inStream).Replace("\0", string.Empty);
                readData = "" + returndata;
                if (readData == "True")
                {
                    refromServer = true;
                    break;
                    check = false;
                }
                if (readData == "False")
                {
                    MessageBox.Show("Username or password is incorrect. Please double check");
                    checkw = false;
                }
            }
        }

        private void btn_sigh_Click(object sender, EventArgs e)
        {                   
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
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
