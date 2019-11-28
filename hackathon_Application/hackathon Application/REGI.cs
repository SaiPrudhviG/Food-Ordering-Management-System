using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace hackathon_Application
{
    public partial class REGI : Form
    {
        OleDbConnection con = new OleDbConnection();   
        public REGI()
        {
            InitializeComponent();
        }

        private void REGI_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "provider=Microsoft.ACE.OleDb.12.0; Data Source=C:\\Users\\Prudhvi\\Documents\\Database1.accdb";
                con.ConnectionString = str;
                OleDbCommand cmd = new OleDbCommand();
                string ins = "INSERT INTO table1 VALUES('" + textBox1.Text + "','" +textBox2.Text+ "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Enter Your Details");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Enter Your Mobile Number");
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Enter Your Email Id");
                }
                else if (textBox4.Text == " ")
                {
                    MessageBox.Show("Enter Your Password");
                }
                if (textBox4.Text == textBox5.Text)
                {
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = ins;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Thanks For Registering");
                    LOGIN_PAGE f = new LOGIN_PAGE();
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Password Dont Match");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.PasswordChar = '*';
        }
    }
}
