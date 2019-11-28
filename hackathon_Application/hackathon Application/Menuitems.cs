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
    public partial class Menuitems : Form
    {
        public Menuitems()
        {
            //int n;
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Fruits1 m = new Fruits1();
            this.Hide();
            m.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Cooldrinks m= new Cooldrinks();
            this.Hide();
            m.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            JunkFood m= new JunkFood();
            this.Hide();
            m.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            nonveg m = new nonveg();
            this.Hide();
            m.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Vegetable k = new Vegetable();
            this.Hide();
            k.Show();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
