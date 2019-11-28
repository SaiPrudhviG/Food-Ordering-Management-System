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
    public partial class LOGIN_PAGE : Form
    {
        OleDbConnection con = new OleDbConnection();
        OleDbDataReader reader;
        public LOGIN_PAGE()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            regisration n = new regisration();
            this.Hide();
            n.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String str = "provider=Microsoft.ACE.OleDb.12.0; Data Source=C:\\Users\\Prudhvi\\Documents\\Database1.accdb";
                con.ConnectionString = str;
                OleDbCommand cmd = new OleDbCommand();
                string log = "select * from table1 where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                cmd.Connection = con;
                cmd.CommandText = log;
                con.Open();
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Login Successfull");
                    Menuitems f = new Menuitems();
                    this.Hide();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("incorrect Password or Username");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed" + ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
