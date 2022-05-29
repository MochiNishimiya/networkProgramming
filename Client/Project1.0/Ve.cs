using System.Drawing.Imaging;
using System.Net.Sockets;

namespace Project1._0
{
    public partial class Ve : Form
    {
        public Ve(string us, TcpClient cl, NetworkStream ns, string c)
        {
            InitializeComponent();
            this.Width = 1900;
            this.Height = 1080;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            boxsize.Text = "1";
            username = us;
            clientSocket = cl;
            serverStream = ns;
            code = c;
            CheckForIllegalCrossThreadCalls = false;
            label1.Text += c;
        }

        string username;
        TcpClient clientSocket;
        NetworkStream serverStream;
        string code;
        Bitmap bm;
        Graphics g;
        bool paint = false;
        bool run = false;
        Point Px, Py;
        Pen P = new Pen(Color.Black, 1);
        int index;
        Pen E = new Pen(Color.White, 1);
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        int Size = 1;
        int SizeFont = 8;
        Font ff = new Font("Arial", 1);
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        PictureBox piclone;

        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(paint)
            {
                // Ellipse
                if (index == 3)
                {
                    g.DrawEllipse(P, cX, cY, sX, sY);
                }

                // Rectangle
                if (index == 4)
                {
                    g.DrawRectangle(P, cX, cY, sX, sY);
                }

                if (index == 5)
                {
                    g.DrawLine(P, cX, cY, x, y);
                }

                if (index == 8)
                {
                    g.DrawString(contentText.Text, ff, drawBrush, cX, cY);
                }
            }    
        }

        private void btnPencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void colorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(colorPicker, e.Location);
            pickColor.BackColor = ((Bitmap)colorPicker.Image).GetPixel(point.X, point.Y);
            new_color = pickColor.BackColor;
            P.Color = pickColor.BackColor;
            drawBrush.Color = pickColor.BackColor;
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pickColor.BackColor = cd.Color;
            P.Color = cd.Color;
            drawBrush.Color = pickColor.BackColor;
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index == 7)
            {
                Point point = set_point(pic,e.Location);
                Fill(bm, point.X, point.Y, new_color);
                run = true;
            }
            //piclone = pic;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if(sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName,ImageFormat.Jpeg);
            }    
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            run = true;
        }

        private void boxsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            Size = Int32.Parse(boxsize.Text);
            P.Width = Size;
        }

        private void inc_Click(object sender, EventArgs e)
        {
            Size++;
            P.Width = Size;
            E.Width = Size;
            boxsize.Text = Size.ToString();
        }

        private void dec_Click(object sender, EventArgs e)
        {
            if (Size - 1 >= 1)
                Size--;
            P.Width = Size;
            E.Width = Size;
            boxsize.Text = Size.ToString();
        }

        private void btnText_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void Ve_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                listFont.Items.Add(font.Name.ToString());
            }
            listFont.SelectedItem = "Arial";
            sizebox.SelectedItem = "8";
            Thread threadget = new Thread(getMessage);
            Thread threadsend = new Thread(sendMessage);
            //Thread threadcon = new Thread(con);
            threadget.Start();
            threadsend.Start();
            //threadcon.Start();
        }

        private void listFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            ff = new Font(listFont.SelectedItem.ToString(), SizeFont);  
        }

        private void sizebox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SizeFont = Int32.Parse(sizebox.SelectedItem.ToString());
            ff = new Font(listFont.SelectedItem.ToString(), SizeFont);
        }

        // Pic
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            Py= e.Location;
            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                // Pen
                if(index == 1)
                {
                    Px = e.Location;
                    g.DrawLine(P, Px, Py);
                    Py = Px;
                }
                // Erase
                if (index == 2)
                {
                    Px = e.Location;
                    g.DrawLine(E, Px, Py);
                    Py = Px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;    
            sY = y - cY;

            // Ellipse
            if(index == 3)
            {
                g.DrawEllipse(P,cX,cY,sX,sY);
                //bm = (Bitmap)pic.Image;
            }

            // Rectangle
            if (index == 4)
            {
                g.DrawRectangle(P, cX, cY, sX, sY);
                //bm = (Bitmap)pic.Image;
            }

            if (index == 5)
            {
                g.DrawLine(P, cX, cY, x, y);
                //bm = (Bitmap)pic.Image;
            }

            if (index == 8)
            {
                g.DrawString(contentText.Text, ff, drawBrush, cX, cY);
                //bm = (Bitmap)pic.Image;
            }
            run = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float Px = 1f * pb.Image.Width / pb.Width;
            float Py = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X*Px),(int)(pt.Y*Py));
        }

        private void Guide(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, welcome to our app. I am knowing that you don't know how to use our excellent app :)) So I'm here to show you how to use. Select color that you want then select drawing tool relevant for you. And then draw :v Remember that other people in this room can see what you draw. ");
        }

        private void txtBtn_Click(object sender, EventArgs e)
        {
            byte[] outStream = Encoding.UTF8.GetBytes("5\n" + username+": "+txtBox.Text + "\n" + "$");
            connectServer.serverStream.Write(outStream, 0, outStream.Length);
            connectServer.serverStream.Flush();
            txtBox.Clear();
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color o_color, Color n_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == o_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, n_color);
            }    
        }

        public void Fill(Bitmap bm, int x, int y, Color n_color)
        {
            Color o_color = bm.GetPixel(x, y);
            Stack<Point> picel = new Stack<Point>();
            picel.Push(new Point(x, y));
            bm.SetPixel(x, y, n_color);
            if (o_color == n_color) return;

            while(picel.Count > 0)
            {
                Point pt = picel.Pop();
                if(pt.X>0 && pt.Y>0 && pt.X<bm.Width-1 && pt.Y<bm.Height-1)
                    {
                    validate(bm,picel,pt.X-1,pt.Y,o_color,n_color);
                    validate(bm, picel, pt.X, pt.Y-1, o_color, n_color);
                    validate(bm, picel, pt.X+1, pt.Y, o_color, n_color);
                    validate(bm, picel, pt.X, pt.Y+1, o_color, n_color);
                }
            }    
        }

        public static byte[] del(byte[] input)
        {
            int i = input.Length-1;
            while (input[i] == 0)
                i--;
            byte[] output = new byte[i+1];
            bool r = true;
            for(int j=0;j<=i;j++)
            {
                output[j] = input[j];
            }
            return output;
        }

        private void getMessage()
        {
            while (true)
            {
                connectServer.serverStream = clientSocket.GetStream();
                byte[] inStream = new byte[20025];
                connectServer.serverStream.Read(inStream, 0, inStream.Length);
                Bitmap bmp;
                byte[] data = del (inStream);
                string mess = Encoding.UTF8.GetString(inStream);
                if (mess[0] == '#')
                {
                    int i = 1;
                    string rmess = "";
                    while (i < mess.Length)
                    {
                        char temp = mess[i];
                        rmess += temp.ToString();
                    }    
                    box_chat.Text = box_chat.Text + Environment.NewLine + " >> " + rmess;
                }
                else
                {
                    using (var ms = new MemoryStream(data))
                    {
                        bmp = new Bitmap(ms);
                    }
                    pic.Image = bmp;
                    bm = bmp;
                    g = Graphics.FromImage(bmp);
                }
            }
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public void sendMessage()
        {
            while (true)
            {
                if (run)
                {
                    //piclone.Image = pic.Image;
                    Byte[] outStream = null;
                    //Bitmap btm = (Bitmap)piclone.Image;
                    Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                    outStream = ImageToByte(btm);
                    connectServer.serverStream.Write(outStream, 0, outStream.Length);
                    connectServer.serverStream.Flush();
                    run = false;
                }
            }
        }
    }
}