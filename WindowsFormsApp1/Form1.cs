using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pnl2.Controls.Clear();
            Form2 frm2 = new Form2();
            frm2.TopLevel = false;
            pnl2.Controls.Add(frm2);
            frm2.Dock = DockStyle.Fill;
            frm2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnl2.Controls.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login f = new Login();
            f.Show();
        }
    }
}
