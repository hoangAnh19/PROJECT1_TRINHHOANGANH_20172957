using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;

namespace Algorithm
{
    public partial class infosys : Form
    {
        public infosys()
        {
            InitializeComponent();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/wmi/info_bios.exe");
        }

        
        private void btnPath_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/wmi/Environment.exe");

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void heart_Click(object sender, EventArgs e)
        {

        }

        private void mởTabMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đổiMàuNềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorbackground.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorbackground.Color;
            }
        }

        private void infosys_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông báo",
             MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }
        }

       
        private void btnSys_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/wmi/info_product.exe");
        }

        private void btnRAm_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/wmi/Ram.exe");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mởTabMớiToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            infosys in1 = new infosys();
            in1.Show();
        }

        private void đổiFontChữToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.Font = fontDialog1.Font;
            }
        }
    }
}
