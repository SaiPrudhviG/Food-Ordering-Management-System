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
    public partial class Fruits1 : Form
    {
        int f;
        public Fruits1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (pineapple.Checked == true)
            {
                f = f + 40;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Add(pineapple.Text + " 40");

            }
            else
            {
                f = f - 40;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Remove(pineapple.Text + " 40");
            }
        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAll.Checked == true)
            {
                pineapple.Checked = true;
                Apple.Checked = true;
                straberry.Checked = true;
                Mango.Checked = true;
                Bananna.Checked = true;
                cherry.Checked = true;
                Program.Cartitems.Add(Bananna.Text + " 50");
                Program.Cartitems.Add(Apple.Text + " 70");
                Program.Cartitems.Add(cherry.Text + " 30");
                Program.Cartitems.Add(Mango.Text + " 50");
                Program.Cartitems.Add(straberry.Text + " 50");
                Program.Cartitems.Add(pineapple.Text + " 40");
            }
            else if (SelectAll.Checked == false)
            {
                pineapple.Checked = false;
                Apple.Checked = false;
                straberry.Checked = false;
                Mango.Checked = false;
                Bananna.Checked = false;
                cherry.Checked = false;
                Program.Cartitems.Remove(Bananna.Text + " 50");
                Program.Cartitems.Remove(Apple.Text + " 70");
                Program.Cartitems.Remove(cherry.Text + " 30");
                Program.Cartitems.Remove(Mango.Text + " 50");
                Program.Cartitems.Remove(straberry.Text + " 50");
                Program.Cartitems.Remove(pineapple.Text + " 40");
            }
        }

        private void Apple_CheckedChanged(object sender, EventArgs e)
        {
            if (Apple.Checked == true)
            {
                f = f + 70;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Add(Apple.Text + " 70");
            }
            else
            {
                f = f - 70;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Remove(Apple.Text + " 70");
            }
        }

        private void cherry_CheckedChanged(object sender, EventArgs e)
        {
            if (cherry.Checked == true)
            {
                f = f + 30;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Add(cherry.Text + " 30");
            }
            else
            {
                f = f - 30;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Remove(cherry.Text + " 30");
            }
        }

        private void Bananna_CheckedChanged(object sender, EventArgs e)
        {
            if (Bananna.Checked == true)
            {
                f = f + 50;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Add(Bananna.Text + " 50");

            }
            else
            {
                f = f - 50;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Remove(Bananna.Text + " 50");
            }
        }

        private void Mango_CheckedChanged(object sender, EventArgs e)
        {
            if (Mango.Checked == true)
            {
                f = f + 50;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Add(Mango.Text + " 50");
            }
            else
            {
                f = f - 50;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Remove(Mango.Text + " 50");
            }
        }

        private void straberry_CheckedChanged(object sender, EventArgs e)
        {
            if (straberry.Checked == true)
            {
                f = f + 60;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Add(straberry.Text + " 60");

            }
            else
            {
                f = f - 60;
                textBox1.Text = Convert.ToString(f);
                Program.Cartitems.Remove(straberry.Text + " 60");
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Cart k = new Cart();
            this.Hide();
            k.Show();
        }
    }
}
