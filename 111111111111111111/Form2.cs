using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace _111111111111111111
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                MessageBox.Show("Enter The User Name");

            }
            else if (txtpass.Text=="")
            {
                MessageBox.Show("Enter The Password");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("Data Source=MSI\\SQLEXPRESS01;Initial Catalog=RM;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select * from Table_login where username =@username and password = @password", con);
                    cmd.Parameters.AddWithValue("@username", txtuser.Text);
                    cmd.Parameters.AddWithValue("@password", txtpass.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        
                        this.Hide();
                        Form3 f77 = new Form3();
                        f77.Show();
                        MessageBox.Show("login Successful");


                    }
                    else {
                        MessageBox.Show("User name or Password Incorrectl");

                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f4 = new Form1();
            f4.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
