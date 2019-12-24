namespace wmi_exe
{
    partial class infosys
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
            this.btnTen = new System.Windows.Forms.Button();
            this.btnRAm = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnSys = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMàuNềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorbackground = new System.Windows.Forms.ColorDialog();
            this.mởTabMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTen
            // 
            this.btnTen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTen.Location = new System.Drawing.Point(415, 53);
            this.btnTen.Name = "btnTen";
            this.btnTen.Size = new System.Drawing.Size(138, 60);
            this.btnTen.TabIndex = 0;
            this.btnTen.Text = "Kiểm tra";
            this.btnTen.UseVisualStyleBackColor = false;
            this.btnTen.Click += new System.EventHandler(this.btnTen_Click);
            // 
            // btnRAm
            // 
            this.btnRAm.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRAm.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAm.Location = new System.Drawing.Point(415, 284);
            this.btnRAm.Name = "btnRAm";
            this.btnRAm.Size = new System.Drawing.Size(138, 53);
            this.btnRAm.TabIndex = 1;
            this.btnRAm.Text = "Kiểm tra";
            this.btnRAm.UseVisualStyleBackColor = false;
            this.btnRAm.Click += new System.EventHandler(this.btnRAm_Click);
            // 
            // btnPath
            // 
            this.btnPath.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPath.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(415, 204);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(138, 60);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Kiểm tra";
            this.btnPath.UseVisualStyleBackColor = false;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnSys
            // 
            this.btnSys.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSys.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSys.Location = new System.Drawing.Point(415, 136);
            this.btnSys.Name = "btnSys";
            this.btnSys.Size = new System.Drawing.Size(138, 55);
            this.btnSys.TabIndex = 3;
            this.btnSys.Text = "Kiểm tra";
            this.btnSys.UseVisualStyleBackColor = false;
            this.btnSys.Click += new System.EventHandler(this.btnSys_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Thông tin bios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(606, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dòng máy ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Môi trường được cài đặt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   //         this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thông tin Ram";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMàuNềnToolStripMenuItem,
            this.mởTabMớiToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // đổiMàuNềnToolStripMenuItem
            // 
            this.đổiMàuNềnToolStripMenuItem.Name = "đổiMàuNềnToolStripMenuItem";
            this.đổiMàuNềnToolStripMenuItem.Size = new System.Drawing.Size(198, 30);
            this.đổiMàuNềnToolStripMenuItem.Text = "Đổi màu nền";
            this.đổiMàuNềnToolStripMenuItem.Click += new System.EventHandler(this.đổiMàuNềnToolStripMenuItem_Click);
            // 
            // mởTabMớiToolStripMenuItem
            // 
            this.mởTabMớiToolStripMenuItem.Name = "mởTabMớiToolStripMenuItem";
            this.mởTabMớiToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.mởTabMớiToolStripMenuItem.Text = "Mở tab mới";
            this.mởTabMớiToolStripMenuItem.Click += new System.EventHandler(this.mởTabMớiToolStripMenuItem_Click_1);
            // 
            // infosys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSys);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnRAm);
            this.Controls.Add(this.btnTen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "infosys";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "infosys";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.infosys_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTen;
        private System.Windows.Forms.Button btnRAm;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnSys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMàuNềnToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorbackground;
        private System.Windows.Forms.ToolStripMenuItem mởTabMớiToolStripMenuItem;
    }
}