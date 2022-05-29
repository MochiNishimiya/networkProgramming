namespace Project1._0
{
    partial class Ve
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ve));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sizebox = new System.Windows.Forms.ComboBox();
            this.listFont = new System.Windows.Forms.ComboBox();
            this.contentText = new System.Windows.Forms.RichTextBox();
            this.btnText = new System.Windows.Forms.Button();
            this.boxsize = new System.Windows.Forms.TextBox();
            this.dec = new System.Windows.Forms.Button();
            this.inc = new System.Windows.Forms.Button();
            this.btclear = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.pickColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFill = new System.Windows.Forms.Button();
            this.btnPencil = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.txtBtn = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.joinBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.sizebox);
            this.panel1.Controls.Add(this.listFont);
            this.panel1.Controls.Add(this.contentText);
            this.panel1.Controls.Add(this.btnText);
            this.panel1.Controls.Add(this.boxsize);
            this.panel1.Controls.Add(this.dec);
            this.panel1.Controls.Add(this.inc);
            this.panel1.Controls.Add(this.btclear);
            this.panel1.Controls.Add(this.btsave);
            this.panel1.Controls.Add(this.colorPicker);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnEllipse);
            this.panel1.Controls.Add(this.pickColor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1566, 165);
            this.panel1.TabIndex = 0;
            // 
            // sizebox
            // 
            this.sizebox.FormattingEnabled = true;
            this.sizebox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "36",
            "48",
            "72"});
            this.sizebox.Location = new System.Drawing.Point(1416, 16);
            this.sizebox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sizebox.Name = "sizebox";
            this.sizebox.Size = new System.Drawing.Size(51, 28);
            this.sizebox.TabIndex = 19;
            this.sizebox.SelectedIndexChanged += new System.EventHandler(this.sizebox_SelectedIndexChanged);
            // 
            // listFont
            // 
            this.listFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listFont.FormattingEnabled = true;
            this.listFont.Location = new System.Drawing.Point(1264, 16);
            this.listFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listFont.Name = "listFont";
            this.listFont.Size = new System.Drawing.Size(145, 28);
            this.listFont.TabIndex = 18;
            this.listFont.SelectedIndexChanged += new System.EventHandler(this.listFont_SelectedIndexChanged);
            // 
            // contentText
            // 
            this.contentText.Location = new System.Drawing.Point(1264, 51);
            this.contentText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.contentText.Name = "contentText";
            this.contentText.Size = new System.Drawing.Size(203, 96);
            this.contentText.TabIndex = 17;
            this.contentText.Text = "";
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.Transparent;
            this.btnText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnText.BackgroundImage")));
            this.btnText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnText.ForeColor = System.Drawing.Color.Black;
            this.btnText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnText.Location = new System.Drawing.Point(1190, 51);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(66, 64);
            this.btnText.TabIndex = 16;
            this.btnText.Text = "Text";
            this.btnText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // boxsize
            // 
            this.boxsize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxsize.Location = new System.Drawing.Point(558, 98);
            this.boxsize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxsize.Name = "boxsize";
            this.boxsize.Size = new System.Drawing.Size(41, 32);
            this.boxsize.TabIndex = 15;
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dec.ForeColor = System.Drawing.Color.IndianRed;
            this.dec.Location = new System.Drawing.Point(529, 96);
            this.dec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(27, 36);
            this.dec.TabIndex = 14;
            this.dec.Text = "-";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // inc
            // 
            this.inc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inc.ForeColor = System.Drawing.Color.IndianRed;
            this.inc.Location = new System.Drawing.Point(600, 96);
            this.inc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inc.Name = "inc";
            this.inc.Size = new System.Drawing.Size(27, 36);
            this.inc.TabIndex = 13;
            this.inc.Text = "+";
            this.inc.UseVisualStyleBackColor = true;
            this.inc.Click += new System.EventHandler(this.inc_Click);
            // 
            // btclear
            // 
            this.btclear.BackColor = System.Drawing.Color.Transparent;
            this.btclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btclear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btclear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclear.ForeColor = System.Drawing.Color.White;
            this.btclear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btclear.Location = new System.Drawing.Point(1486, 73);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(66, 36);
            this.btclear.TabIndex = 11;
            this.btclear.Text = "Clear";
            this.btclear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btclear.UseVisualStyleBackColor = false;
            this.btclear.Click += new System.EventHandler(this.btclear_Click);
            // 
            // btsave
            // 
            this.btsave.BackColor = System.Drawing.Color.Transparent;
            this.btsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsave.ForeColor = System.Drawing.Color.White;
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btsave.Location = new System.Drawing.Point(1486, 17);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(66, 36);
            this.btsave.TabIndex = 10;
            this.btsave.Text = "Save";
            this.btsave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Cross;
            this.colorPicker.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker.Image")));
            this.colorPicker.Location = new System.Drawing.Point(14, 15);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(502, 133);
            this.colorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPicker.TabIndex = 9;
            this.colorPicker.TabStop = false;
            this.colorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseClick);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.Transparent;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLine.ForeColor = System.Drawing.Color.White;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLine.Location = new System.Drawing.Point(1118, 51);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(66, 64);
            this.btnLine.TabIndex = 7;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.Transparent;
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRectangle.ForeColor = System.Drawing.Color.White;
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRectangle.Location = new System.Drawing.Point(1045, 51);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(66, 64);
            this.btnRectangle.TabIndex = 6;
            this.btnRectangle.Text = "Rec";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackColor = System.Drawing.Color.Transparent;
            this.btnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEllipse.ForeColor = System.Drawing.Color.White;
            this.btnEllipse.Image = ((System.Drawing.Image)(resources.GetObject("btnEllipse.Image")));
            this.btnEllipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEllipse.Location = new System.Drawing.Point(971, 51);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(66, 64);
            this.btnEllipse.TabIndex = 5;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEllipse.UseVisualStyleBackColor = false;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // pickColor
            // 
            this.pickColor.BackColor = System.Drawing.Color.Black;
            this.pickColor.ForeColor = System.Drawing.Color.Black;
            this.pickColor.Location = new System.Drawing.Point(552, 29);
            this.pickColor.Name = "pickColor";
            this.pickColor.Size = new System.Drawing.Size(50, 48);
            this.pickColor.TabIndex = 0;
            this.pickColor.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btnColor);
            this.panel3.Controls.Add(this.btnFill);
            this.panel3.Controls.Add(this.btnPencil);
            this.panel3.Controls.Add(this.btnEraser);
            this.panel3.Location = new System.Drawing.Point(642, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(322, 92);
            this.panel3.TabIndex = 8;
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.Transparent;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.ForeColor = System.Drawing.Color.White;
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColor.Location = new System.Drawing.Point(18, 13);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(66, 64);
            this.btnColor.TabIndex = 1;
            this.btnColor.Text = "Color";
            this.btnColor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFill
            // 
            this.btnFill.BackColor = System.Drawing.Color.Transparent;
            this.btnFill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFill.ForeColor = System.Drawing.Color.White;
            this.btnFill.Image = ((System.Drawing.Image)(resources.GetObject("btnFill.Image")));
            this.btnFill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFill.Location = new System.Drawing.Point(91, 15);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(66, 64);
            this.btnFill.TabIndex = 2;
            this.btnFill.Text = "Fill";
            this.btnFill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFill.UseVisualStyleBackColor = false;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.BackColor = System.Drawing.Color.Transparent;
            this.btnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPencil.ForeColor = System.Drawing.Color.White;
            this.btnPencil.Image = ((System.Drawing.Image)(resources.GetObject("btnPencil.Image")));
            this.btnPencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPencil.Location = new System.Drawing.Point(165, 15);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(66, 64);
            this.btnPencil.TabIndex = 3;
            this.btnPencil.Text = "Pencil";
            this.btnPencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPencil.UseVisualStyleBackColor = false;
            this.btnPencil.Click += new System.EventHandler(this.btnPencil_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.Transparent;
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.ForeColor = System.Drawing.Color.White;
            this.btnEraser.Image = ((System.Drawing.Image)(resources.GetObject("btnEraser.Image")));
            this.btnEraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEraser.Location = new System.Drawing.Point(238, 13);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(66, 64);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(1315, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "CODE: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 704);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1566, 45);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1488, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(3, 171);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1339, 494);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // txtBtn
            // 
            this.txtBtn.BackColor = System.Drawing.Color.Transparent;
            this.txtBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.txtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBtn.ForeColor = System.Drawing.Color.DimGray;
            this.txtBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtBtn.Location = new System.Drawing.Point(1488, 671);
            this.txtBtn.Name = "txtBtn";
            this.txtBtn.Size = new System.Drawing.Size(66, 28);
            this.txtBtn.TabIndex = 22;
            this.txtBtn.Text = "SEND";
            this.txtBtn.UseVisualStyleBackColor = false;
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(3, 671);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(1479, 27);
            this.txtBox.TabIndex = 23;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(1348, 171);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(206, 461);
            this.richTextBox.TabIndex = 24;
            this.richTextBox.Text = "";
            // 
            // joinBtn
            // 
            this.joinBtn.BackColor = System.Drawing.Color.DimGray;
            this.joinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.joinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.joinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.joinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.joinBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.joinBtn.ForeColor = System.Drawing.Color.White;
            this.joinBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.joinBtn.Location = new System.Drawing.Point(1348, 638);
            this.joinBtn.Name = "joinBtn";
            this.joinBtn.Size = new System.Drawing.Size(207, 27);
            this.joinBtn.TabIndex = 22;
            this.joinBtn.Text = "JOIN CHATROOM";
            this.joinBtn.UseVisualStyleBackColor = false;
            // 
            // Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1566, 749);
            this.Controls.Add(this.joinBtn);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.txtBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Name = "Ve";
            this.Text = "Drawing Space";
            this.Load += new System.EventHandler(this.Ve_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button btnColor;
        private Button pickColor;
        private Button btnFill;
        private Button btnEllipse;
        private Button btnEraser;
        private Button btnPencil;
        private Button btnRectangle;
        private Button btnLine;
        private Panel panel3;
        private PictureBox colorPicker;
        private Button btclear;
        private Button btsave;
        private Button dec;
        private Button inc;
        private TextBox boxsize;
        private RichTextBox contentText;
        private Button btnText;
        private ComboBox listFont;
        private ComboBox sizebox;
        private Label label1;
        private Button button1;
        private Button txtBtn;
        private TextBox txtBox;
        private RichTextBox richTextBox;
        private Button joinBtn;
    }
}