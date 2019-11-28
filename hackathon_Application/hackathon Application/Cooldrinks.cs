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
    public partial class Cooldrinks : Form
    {
        int c;
        public Cooldrinks()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menuitems k = new Menuitems();
            this.Hide();
            k.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cart k = new Cart();
            this.Hide();
            k.Show();
        }

        private void Fanta_CheckedChanged(object sender, EventArgs e)
        {
            if (Fanta.Checked == true)
            {
                c = c + 35;
                textBox1.Text = Convert.ToString(c);

            }
            else
            {
                c = c - 35;
                textBox1.Text = Convert.ToString(c);
            }
        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAll.Checked == true)
            {
                Fanta.Checked = true;
                lemon.Checked = true;
                Coca_Cola.Checked = true;
                Mirinda.Checked = true;
                Appie.Checked = true;
            }
            else
            {
                Fanta.Checked = false;
                lemon.Checked = false;
                Coca_Cola.Checked = false;
                Mirinda.Checked = false;
                Appie.Checked = false;
            }

        }

        private void lemon_CheckedChanged(object sender, EventArgs e)
        {
            if (lemon.Checked == true)
            {
                c = c + 15;
                textBox1.Text = Convert.ToString(c);

            }
            else
            {
                c = c - 15;
                textBox1.Text = Convert.ToString(c);
            }
        }

        private void Coca_Cola_CheckedChanged(object sender, EventArgs e)
        {
            if (Coca_Cola.Checked == true)
            {
                c = c + 35;
                textBox1.Text = Convert.ToString(c);

            }
            else
            {
                c= c - 35;
                textBox1.Text = Convert.ToString(c);
            }
        }

        private void Sprite_CheckedChanged(object sender, EventArgs e)
        {
            if (Sprite.Checked == true)
            {
                c = c + 50;
                textBox1.Text = Convert.ToString(c);

            }
            else
            {
                c = c - 50;
                textBox1.Text = Convert.ToString(c);
            }
        }

        private void Mirinda_CheckedChanged(object sender, EventArgs e)
        {
            if (Mirinda.Checked == true)
            {
                c = c + 50;
                textBox1.Text = Convert.ToString(c);

            }
            else
            {
                c = c - 50;
                textBox1.Text = Convert.ToString(c);
            }
        }

        private void Appie_CheckedChanged(object sender, EventArgs e)
        {
            if (Appie.Checked == true)
            {
                c = c + 60;
                textBox1.Text = Convert.ToString(c);

            }
            else
            {
                c = c - 60;
                textBox1.Text = Convert.ToString(c);
            }
        }
    }
}
