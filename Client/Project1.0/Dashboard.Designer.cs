namespace Project1._0
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.MistyRose;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_exit.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_exit.Location = new System.Drawing.Point(111, 169);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(159, 28);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_join
            // 
            this.btn_join.BackColor = System.Drawing.Color.MistyRose;
            this.btn_join.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_join.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_join.Location = new System.Drawing.Point(111, 116);
            this.btn_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(159, 28);
            this.btn_join.TabIndex = 3;
            this.btn_join.Text = "JOIN";
            this.btn_join.UseVisualStyleBackColor = false;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.MistyRose;
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_create.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_create.Location = new System.Drawing.Point(111, 61);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(159, 28);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "CREATE";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(389, 502);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_exit);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Scribble Together";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_exit;
        private Button btn_join;
        private Button btn_create;
    }
}