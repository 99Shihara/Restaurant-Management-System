using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _111111111111111111
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f44 = new Form1();
            f44.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f55 = new Form3();
            f55.Show();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f00 = new Form1();
            f00.Show();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Table_Management f6 = new Table_Management();
            f6.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock_Management f8 = new Stock_Management();
            f8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            order_management f6 = new order_management();
            f6.Show();
        }
    }
}
