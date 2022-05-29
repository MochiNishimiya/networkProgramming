namespace Project1._0
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_username = new System.Windows.Forms.TextBox();
            this.box_pass = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_sigh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(709, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label2.Location = new System.Drawing.Point(609, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label3.Location = new System.Drawing.Point(609, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 51);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // box_username
            // 
            this.box_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_username.Location = new System.Drawing.Point(609, 245);
            this.box_username.Name = "box_username";
            this.box_username.Size = new System.Drawing.Size(377, 34);
            this.box_username.TabIndex = 3;
            // 
            // box_pass
            // 
            this.box_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_pass.Location = new System.Drawing.Point(609, 367);
            this.box_pass.Name = "box_pass";
            this.box_pass.Size = new System.Drawing.Size(377, 34);
            this.box_pass.TabIndex = 4;
            this.box_pass.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_login.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_login.ForeColor = System.Drawing.Color.Teal;
            this.btn_login.Location = new System.Drawing.Point(794, 450);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(136, 43);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "LOGIN";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
//            this.btn_login.MouseHover += new System.EventHandler(this.loginIntro);
            // 
            // btn_sigh
            // 
            this.btn_sigh.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_sigh.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sigh.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.btn_sigh.Location = new System.Drawing.Point(659, 450);
            this.btn_sigh.Name = "btn_sigh";
            this.btn_sigh.Size = new System.Drawing.Size(136, 43);
            this.btn_sigh.TabIndex = 7;
            this.btn_sigh.Text = "CREATE";
            this.btn_sigh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sigh.UseVisualStyleBackColor = false;
            this.btn_sigh.Click += new System.EventHandler(this.btn_sigh_Click);
//            this.btn_sigh.MouseHover += new System.EventHandler(this.createIntro);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gabriola", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label4.Location = new System.Drawing.Point(-6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(591, 294);
            this.label4.TabIndex = 8;
            this.label4.Text = "WELCOME TO\r\nE-LEARNING SPACE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1002, 645);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_sigh);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.box_pass);
            this.Controls.Add(this.box_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox box_username;
        private TextBox box_pass;
        private Button btn_login;
        private Button btn_sigh;
        private Label label4;
    }
}