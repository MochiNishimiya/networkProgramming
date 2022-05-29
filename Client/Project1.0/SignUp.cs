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
    public partial class SignUp : Form
    {
        bool check = false;
        bool checkthread = false;
        bool checkw;
        string readData;

        public SignUp()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_sigh_Click(object sender, EventArgs e)
        {
            checkw = true;
            if (box_username.Text != "" && box_pass.Text != "")
            {
                // Gửi thông tin login đến server
                byte[] outStream = Encoding.UTF8.GetBytes("2\n" + box_username.Text + "\n" + box_pass.Text + "\n" + "$");
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
                    if (checkthread)
                    {
                        Program.lg.Show();
                        this.Close();
                        // ctThread.Interrupt();
                        break;
                    }
                }
            }
        }

            private void getMessage()
            {
                while (true)
                {
                    byte[] inStream = new byte[10025];
                    connectServer.serverStream.Read(inStream, 0, inStream.Length);
                    string returndata = Encoding.UTF8.GetString(inStream).Replace("\0", string.Empty);
                    readData = "" + returndata;
                    if(readData == "False")
                    {
                        MessageBox.Show("existing account. Please select another username/password");
                        checkw = false;
                    }
                    if(readData == "True")
                    {
                        MessageBox.Show("Success! Login to continue");
                        checkthread = true;
                        check = false;
                        break;
                    }    
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.lg.Show();
            this.Close();
        }
    }
}
