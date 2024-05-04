using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _111111111111111111
{
    public partial class order_management : Form
    {
        public order_management()
        {
            InitializeComponent();
        }
        public double Cost_of_Items()
        {
            double sum = 0;
            int i = 0;
            for (i = 0; i < (dataGridView1.Rows.Count);
            i++) 
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

            }
                return sum;
        }
        private void Addcost()
        {
            Double tax, q;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                textBox2.Text = String.Format("{0:c2}", (((Cost_of_Items() * tax) / 100)));
                textBox1.Text = String.Format("{0:c2}", (Cost_of_Items()));
                q = ((Cost_of_Items() * tax) / 100);
                textBox3.Text = String.Format("{0:c2}", (Cost_of_Items() +q ));
            }
        }
        private void Change()
        {
            Double tax, q, c;
            tax = 3.9;
            if (dataGridView1.Rows.Count > 0)
            {
                q = ((Cost_of_Items() * tax) / 100) + Cost_of_Items();
                c = Convert.ToInt32(textBox5.Text);
                textBox4.Text = String.Format("{0:c2}", c - q);
            }
        }

        Bitmap bitmap;

        private void order_management_Load(object sender, EventArgs e)
        {

            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Visa Card");
            comboBox1.Items.Add("Master Card");
            // TODO: This line of code loads data into the 'rMDataSet.tb1_food' table. You can move, or remove it, as needed.
            this.tb1_foodTableAdapter.Fill(this.rMDataSet.tb1_food);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {

                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                e.Graphics.DrawImage(bitmap, 0, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "0";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                comboBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (textBox5.Text == "0")
            {
                textBox5.Text = "";
                textBox5.Text = b.Text;
            }
            else if (b.Text == ".")
            {
                if (!textBox5.Text.Contains("."))
                {
                    textBox5.Text = textBox5.Text + b.Text;
                }

            }
            else
                textBox5.Text = textBox5.Text + b.Text;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox5.Text = "0";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                Change();

            }
            else 
            {
                textBox4.Text = "";
                textBox5.Text = "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this. dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            Addcost();
            if (comboBox1.Text == "Cash")
            {
                Change();

            }
            else
            {
                textBox4.Text = "";
                textBox5.Text = "0";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Double Costofitem = 2.3;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Burger"))
                        {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * Costofitem;
                    Addcost();
                }
            }
            dataGridView1.Rows.Add("Burger", "1", Costofitem);
            Addcost() ;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Double Costofitem = 2.8;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Hot Dog"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * Costofitem;
                    Addcost();
                }
            }
            dataGridView1.Rows.Add("Hot Dog", "1", Costofitem);
            Addcost();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Double Costofitem = 8.9;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Biriyani"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * Costofitem;
                    Addcost();
                }
            }
            dataGridView1.Rows.Add("Biriyani", "1", Costofitem);
            Addcost();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Double Costofitem = 5.6;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pizza"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * Costofitem;
                    Addcost();
                }
            }
            dataGridView1.Rows.Add("Pizza", "1", Costofitem);
            Addcost();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Double Costofitem = 1.2;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pepsi"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * Costofitem;
                    Addcost();
                }
            }
            dataGridView1.Rows.Add("Pepsi", "1", Costofitem);
            Addcost();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Double Costofitem = 1.5;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Coca cola"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * Costofitem;
                    Addcost();
                }
            }
            dataGridView1.Rows.Add("Coca cola", "1", Costofitem);
            Addcost();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Double Costofitem = 3.8;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Faluda"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * Costofitem;
                    Addcost();
                }
            }
            dataGridView1.Rows.Add("Faluda", "1", Costofitem);
            Addcost();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Double Costofitem = 1.8;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ice Cream"))
                {
                    row.Cells[1].Value = Double.Parse((String)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((String)row.Cells[1].Value) * Costofitem;
                    Addcost();
                }
            }
            dataGridView1.Rows.Add("Ice cream", "1", Costofitem);
            Addcost();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
