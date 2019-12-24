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
using System.IO;

namespace wmi_exe
{
    public partial class source : Form
    {
        public source()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string s1 = ".txt";
            string s2 = num.Value.ToString();
            string s3 = "Debug/code_c/Baitoan " + s2 + s1;
            TextReader reader = new StreamReader(s3);
            richTxt.Text = reader.ReadToEnd();

            reader.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = ".exe";
            string s2 = num.Value.ToString();
            string s3 = "/Debug/code_c/Baitoan " + s2 + s1;
            Process.Start(Application.StartupPath + s3);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s1 = " Source.txt";
            string s2 = num.Value.ToString();
            string s3 = "Debug/code_c/Baitoan " + s2 + s1;
            TextReader reader = new StreamReader(s3);
            richTxt.Text = reader.ReadToEnd();

            reader.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhập bài toán cần tìm vào ô tìm kiếm phía dưới, ví dụ 1, 2 ,3 ...", "Hướng dẫn", MessageBoxButtons.OK);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string s1 = ".txt";
            string s2 = num.Value.ToString();
            string s3 = "/Debug/code_c/Baitoan " + s2 + s1;

            Process.Start(Application.StartupPath + s3);
        }

       
        private void button5_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Đề bài")

            {
                string s1 = ".txt";
                string s2 = num.Value.ToString();
                string s3 = "/Debug/code_c/Baitoan " + s2 + s1;

                Process.Start(Application.StartupPath + s3);


            }
            else
            {
                string s1 = " Source.txt";
                string s2 = num.Value.ToString();
                string s3 = "/Debug/code_c/Baitoan " + s2 + s1;

                Process.Start(Application.StartupPath + s3);



            }
        }

        
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            source so1 = new source();
            so1.Show();
        }

        private void source_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát ?", "Thông báo",
             MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;

            }

        }

        private void đổiMàuNềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
            }
        }
    }
}
