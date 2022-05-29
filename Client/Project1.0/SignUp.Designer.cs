namespace Project1._0
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.btn_sigh = new System.Windows.Forms.Button();
            this.box_pass = new System.Windows.Forms.TextBox();
            this.box_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sigh
            // 
            this.btn_sigh.BackColor = System.Drawing.Color.Firebrick;
            this.btn_sigh.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sigh.ForeColor = System.Drawing.Color.White;
            this.btn_sigh.Location = new System.Drawing.Point(584, 437);
            this.btn_sigh.Name = "btn_sigh";
            this.btn_sigh.Size = new System.Drawing.Size(152, 45);
            this.btn_sigh.TabIndex = 14;
            this.btn_sigh.Text = "CREATE";
            this.btn_sigh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sigh.UseVisualStyleBackColor = false;
            this.btn_sigh.Click += new System.EventHandler(this.btn_sigh_Click);
            // 
            // box_pass
            // 
            this.box_pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_pass.Location = new System.Drawing.Point(543, 341);
            this.box_pass.Name = "box_pass";
            this.box_pass.Size = new System.Drawing.Size(377, 34);
            this.box_pass.TabIndex = 12;
            this.box_pass.UseSystemPasswordChar = true;
           // this.box_pass.MouseHover += new System.EventHandler(this.pwIntro);
            // 
            // box_username
            // 
            this.box_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box_username.Location = new System.Drawing.Point(543, 254);
            this.box_username.Name = "box_username";
            this.box_username.Size = new System.Drawing.Size(377, 34);
            this.box_username.TabIndex = 11;
           // this.box_username.MouseHover += new System.EventHandler(this.usernameIntro);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Brown;
            this.label3.Location = new System.Drawing.Point(543, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 51);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(543, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 51);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(619, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 110);
            this.label1.TabIndex = 8;
            this.label1.Text = "SIGN UP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(730, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 15;
            this.button1.Text = "BACK";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 632);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_sigh);
            this.Controls.Add(this.box_pass);
            this.Controls.Add(this.box_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_sigh;
        private TextBox box_pass;
        private TextBox box_username;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}