using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace ReadTxt_Richtextbox_baocao3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_READ_Click(object sender, EventArgs e)
        {
            TextReader reader = new StreamReader(@"C:\New folder\Text.txt");

            richTextBox1.Text = reader.ReadToEnd();

            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string commandText = @"/c ipconfig";

            System.Diagnostics.Process.Start("CMD.exe", commandText);
            Console.ReadLine();
           
        }
    }
}
