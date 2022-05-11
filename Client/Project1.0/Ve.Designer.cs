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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 124);
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
            this.sizebox.Location = new System.Drawing.Point(1239, 12);
            this.sizebox.Name = "sizebox";
            this.sizebox.Size = new System.Drawing.Size(45, 23);
            this.sizebox.TabIndex = 19;
            this.sizebox.SelectedIndexChanged += new System.EventHandler(this.sizebox_SelectedIndexChanged);
            // 
            // listFont
            // 
            this.listFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listFont.FormattingEnabled = true;
            this.listFont.Location = new System.Drawing.Point(1106, 12);
            this.listFont.Name = "listFont";
            this.listFont.Size = new System.Drawing.Size(127, 23);
            this.listFont.TabIndex = 18;
            this.listFont.SelectedIndexChanged += new System.EventHandler(this.listFont_SelectedIndexChanged);
            // 
            // contentText
            // 
            this.contentText.Location = new System.Drawing.Point(1106, 38);
            this.contentText.Name = "contentText";
            this.contentText.Size = new System.Drawing.Size(178, 73);
            this.contentText.TabIndex = 17;
            this.contentText.Text = "";
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.Color.Transparent;
            this.btnText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.ForeColor = System.Drawing.Color.White;
            this.btnText.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnText.Location = new System.Drawing.Point(1042, 38);
            this.btnText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(58, 48);
            this.btnText.TabIndex = 16;
            this.btnText.Text = "Text";
            this.btnText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // boxsize
            // 
            this.boxsize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.boxsize.Location = new System.Drawing.Point(488, 72);
            this.boxsize.Name = "boxsize";
            this.boxsize.Size = new System.Drawing.Size(36, 27);
            this.boxsize.TabIndex = 15;
            // 
            // dec
            // 
            this.dec.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dec.ForeColor = System.Drawing.Color.IndianRed;
            this.dec.Location = new System.Drawing.Point(463, 72);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(24, 27);
            this.dec.TabIndex = 14;
            this.dec.Text = "-";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.dec_Click);
            // 
            // inc
            // 
            this.inc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inc.ForeColor = System.Drawing.Color.IndianRed;
            this.inc.Location = new System.Drawing.Point(525, 72);
            this.inc.Name = "inc";
            this.inc.Size = new System.Drawing.Size(24, 27);
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
            this.btclear.Location = new System.Drawing.Point(1290, 71);
            this.btclear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btclear.Name = "btclear";
            this.btclear.Size = new System.Drawing.Size(58, 27);
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
            this.btsave.Location = new System.Drawing.Point(1290, 29);
            this.btsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(58, 27);
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
            this.colorPicker.Location = new System.Drawing.Point(12, 11);
            this.colorPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(439, 100);
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
            this.btnLine.Location = new System.Drawing.Point(978, 38);
            this.btnLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(58, 48);
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
            this.btnRectangle.Location = new System.Drawing.Point(914, 38);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(58, 48);
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
            this.btnEllipse.Location = new System.Drawing.Point(850, 38);
            this.btnEllipse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(58, 48);
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
            this.pickColor.Location = new System.Drawing.Point(483, 22);
            this.pickColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickColor.Name = "pickColor";
            this.pickColor.Size = new System.Drawing.Size(44, 36);
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
            this.panel3.Location = new System.Drawing.Point(562, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 69);
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
            this.btnColor.Location = new System.Drawing.Point(16, 10);
            this.btnColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(58, 48);
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
            this.btnFill.Location = new System.Drawing.Point(80, 11);
            this.btnFill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(58, 48);
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
            this.btnPencil.Location = new System.Drawing.Point(144, 11);
            this.btnPencil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(58, 48);
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
            this.btnEraser.Location = new System.Drawing.Point(208, 10);
            this.btnEraser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(58, 48);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.Text = "Eraser";
            this.btnEraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 542);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 20);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(0, 115);
            this.pic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1370, 585);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Ve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ve";
            this.Text = "Drawing Space";
            this.Load += new System.EventHandler(this.Ve_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

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
    }
}