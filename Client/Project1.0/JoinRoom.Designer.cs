namespace Project1._0
{
    partial class JoinRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinRoom));
            this.btn_back = new System.Windows.Forms.Button();
            this.box_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_join = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.Color.Firebrick;
            this.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_back.Location = new System.Drawing.Point(54, 211);
            this.btn_back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(136, 30);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // box_code
            // 
            this.box_code.Location = new System.Drawing.Point(178, 172);
            this.box_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_code.Name = "box_code";
            this.box_code.Size = new System.Drawing.Size(157, 23);
            this.box_code.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(77, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 88);
            this.label2.TabIndex = 3;
            this.label2.Text = "JOIN ROOM";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(54, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Input your code:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_join
            // 
            this.btn_join.BackColor = System.Drawing.Color.LightCoral;
            this.btn_join.Font = new System.Drawing.Font("Gabriola", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_join.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_join.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_join.Location = new System.Drawing.Point(187, 211);
            this.btn_join.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(148, 30);
            this.btn_join.TabIndex = 7;
            this.btn_join.Text = "Join";
            this.btn_join.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_join.UseVisualStyleBackColor = false;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // JoinRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 434);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.box_code);
            this.Controls.Add(this.btn_back);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "JoinRoom";
            this.Text = "Scribble Together";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_back;
        private TextBox box_code;
        private Label label2;
        private Label label1;
        private Button btn_join;
    }
}