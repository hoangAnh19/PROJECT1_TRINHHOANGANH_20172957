namespace Algorithm
{
    partial class index
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
            this.components = new System.ComponentModel.Container();
            this.btnInfosys = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởTabMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đỏiMàuNềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorbackground = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInfosys
            // 
            this.btnInfosys.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnInfosys.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnInfosys.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfosys.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInfosys.Location = new System.Drawing.Point(98, 115);
            this.btnInfosys.Name = "btnInfosys";
            this.btnInfosys.Size = new System.Drawing.Size(189, 107);
            this.btnInfosys.TabIndex = 1;
            this.btnInfosys.Text = "Thông tin máy sử dụng";
            this.btnInfosys.UseVisualStyleBackColor = false;
            this.btnInfosys.Click += new System.EventHandler(this.btnInfosys_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnProcess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnProcess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnProcess.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcess.Location = new System.Drawing.Point(358, 115);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(189, 107);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Danh sách bài toán";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 35);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởTabMớiToolStripMenuItem,
            this.đỏiMàuNềnToolStripMenuItem,
            this.toolStripMenuItem2});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(90, 31);
            this.fileToolStripMenuItem.Text = "Option";
            // 
            // mởTabMớiToolStripMenuItem
            // 
            this.mởTabMớiToolStripMenuItem.Name = "mởTabMớiToolStripMenuItem";
            this.mởTabMớiToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.mởTabMớiToolStripMenuItem.Text = "Mở tab mới";
            this.mởTabMớiToolStripMenuItem.Click += new System.EventHandler(this.mởTabMớiToolStripMenuItem_Click);
            // 
            // đỏiMàuNềnToolStripMenuItem
            // 
            this.đỏiMàuNềnToolStripMenuItem.Name = "đỏiMàuNềnToolStripMenuItem";
            this.đỏiMàuNềnToolStripMenuItem.Size = new System.Drawing.Size(219, 32);
            this.đỏiMàuNềnToolStripMenuItem.Text = "Đỏi màu nền";
            this.đỏiMàuNềnToolStripMenuItem.Click += new System.EventHandler(this.đỏiMàuNềnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(219, 32);
            this.toolStripMenuItem2.Text = "Đổi font chữ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(642, 321);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.btnInfosys);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "index";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.index_FormClosing_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInfosys;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorbackground;
        private System.Windows.Forms.ToolStripMenuItem mởTabMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đỏiMàuNềnToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}