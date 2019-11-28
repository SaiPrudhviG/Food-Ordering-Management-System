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
    public partial class JunkFood : Form
    {
        int j;
        public JunkFood()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuitems j = new Menuitems();
            this.Hide();
            j.Show();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (sanwidch.Checked == true)
            {
                j = j + 50;
                textBox1.Text = Convert.ToString(j);

            }
            else
            {
                j = j - 50;
                textBox1.Text = Convert.ToString(j);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAll.Checked == true)
            {
                Burger.Checked =true;
                Pizza.Checked = true;
                hotdog.Checked = true;
                noodles.Checked = true;
                frenchfries.Checked = true;
                sanwidch.Checked = true;
                Program.Cartitems.Add(Burger.Text + " 40");
                Program.Cartitems.Add(Pizza.Text + " 40");
                Program.Cartitems.Add(hotdog.Text + " 60");
                Program.Cartitems.Add(noodles.Text + " 40");
                Program.Cartitems.Add(frenchfries.Text + " 70");
                Program.Cartitems.Add(sanwidch.Text + " 50");
            }
            else if (SelectAll.Checked == false)
            {
                Burger.Checked = false;
                Pizza.Checked = false;
                hotdog.Checked = false;
                noodles.Checked = false;
                frenchfries.Checked = false;
                sanwidch.Checked = false;
            }
        }

        private void Burger_CheckedChanged(object sender, EventArgs e)
        {
            if(Burger.Checked==true)
            {
                //j = j + 40;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Add(Burger.Text+" 40");
            }
            else
            {
                //j = j - 40;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Remove(Burger.Text + "40");
            }
        }

        private void hotdog_CheckedChanged(object sender, EventArgs e)
        {
            if (hotdog.Checked== true)
            {
                j = j + 60;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Add(hotdog.Text + " 60");
            }
            else
            {
                j = j - 60;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Remove(hotdog.Text + " 60");
            }
        }

        private void Pizza_CheckedChanged(object sender, EventArgs e)
        {
            if (Pizza.Checked == true)
            {
                j = j + 40;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Add(Pizza.Text + " 40");

            }
            else
            {
                j = j - 40;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Remove(Pizza.Text + " 40");
            }
        }

        private void frenchfries_CheckedChanged(object sender, EventArgs e)
        {
            if (Burger.Checked == true)
            {
                j = j + 70;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Add(frenchfries.Text + " 70");
            }
            else
            {
                j = j - 70;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Remove(frenchfries.Text + " 70");
            }
        }

        private void noodles_CheckedChanged(object sender, EventArgs e)
        {
            if (noodles.Checked == true)
            {
                j = j + 40;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Add(noodles.Text + " 40");

            }
            else
            {
                j = j - 40;
                textBox1.Text = Convert.ToString(j);
                Program.Cartitems.Remove(noodles.Text + " 40");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cart k = new Cart();
            this.Hide();
            k.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
