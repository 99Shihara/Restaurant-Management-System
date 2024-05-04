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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f5 = new Form4();
            f5.Show();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f6 = new Form4();
            f6.Show();
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f4 = new Menu();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f8 = new Form5(); 
            f8.Show();
        }
    }
}
