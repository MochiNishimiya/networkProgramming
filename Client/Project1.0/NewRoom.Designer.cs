namespace Project1._0
{
    partial class NewRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_code = new System.Windows.Forms.TextBox();
            this.btn_back_nroom = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gabriola", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(74, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEW ROOM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gabriola", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(49, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Input your code:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // box_code
            // 
            this.box_code.Location = new System.Drawing.Point(162, 170);
            this.box_code.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.box_code.Name = "box_code";
            this.box_code.Size = new System.Drawing.Size(198, 23);
            this.box_code.TabIndex = 2;
            // 
            // btn_back_nroom
            // 
            this.btn_back_nroom.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back_nroom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_back_nroom.Location = new System.Drawing.Point(49, 203);
            this.btn_back_nroom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_back_nroom.Name = "btn_back_nroom";
            this.btn_back_nroom.Size = new System.Drawing.Size(156, 26);
            this.btn_back_nroom.TabIndex = 3;
            this.btn_back_nroom.Text = "Back";
            this.btn_back_nroom.UseVisualStyleBackColor = true;
            this.btn_back_nroom.Click += new System.EventHandler(this.btn_back_nroom_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.LightCoral;
            this.btn_create.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_create.Location = new System.Drawing.Point(205, 203);
            this.btn_create.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(155, 26);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // NewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 434);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.btn_back_nroom);
            this.Controls.Add(this.box_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewRoom";
            this.Text = "Scribble Together";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox box_code;
        private Button btn_back_nroom;
        private Button btn_create;
    }
}