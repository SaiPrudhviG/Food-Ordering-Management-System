using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hackathon_Application
{
    public partial class regisration : Form
    {
        public regisration()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void regisration_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LOGIN_PAGE n = new LOGIN_PAGE();
            this.Hide();
            n.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            REGI k = new REGI();
            this.Hide();
            k.Show();
        }

        private void VIEW_Click(object sender, EventArgs e)
        {

        }
    }
}
