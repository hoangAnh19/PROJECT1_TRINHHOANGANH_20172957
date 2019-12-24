using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Algorithm
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void btnInfosys_Click(object sender, EventArgs e)
        {
            infosys pageInfoSys = new infosys();
            pageInfoSys.ShowDialog();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            source source = new source();
            source.Show();
        }



        private void đỏiMàuNềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorbackground.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorbackground.Color;
            }

        }

        private void mởTabMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + "/wmi_exe.exe");
        }
        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void index_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ? ", "Thông báo",
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;


            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if( fontDialog1.ShowDialog()==DialogResult.OK )
            {
                this.Font = fontDialog1.Font;
            }
        }

       
    }
}
