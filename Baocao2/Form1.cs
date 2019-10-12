using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1_trinhhoanganh_winform_taskmanagerr
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
            GetProcess();
        }
        Process[] processarr;//mang ds process
        void GetProcess()
        {
            processarr = Process.GetProcesses();
            listView1.Items.Clear();
            // lay danh sach process 
            //  dua hien thi listview
            foreach (var item in processarr)
            {
                ListViewItem newitem = new ListViewItem() { Text = item.ProcessName };
               newitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.PagedMemorySize64.ToString() });
                newitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.VirtualMemorySize64.ToString() });
                newitem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.WorkingSet64.ToString() });
                listView1.Items.Add(newitem);

            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath+"/project1_trinhhoanganh_winform_taskmanagerr.exe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1Closed();
        }

        private void Form1Closed()
        {
            throw new NotImplementedException();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Demo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Demo_Load(object sender, EventArgs e)
        {

        }
    }
    
}
