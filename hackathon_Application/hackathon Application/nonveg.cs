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
    public partial class nonveg : Form
    {
        int n;
        public nonveg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuitems k = new Menuitems();
            this.Hide();
            k.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cart k = new Cart();
            this.Hide();
            k.Show();
        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAll.Checked == true)
            {
                Eggs.Checked = true;
                FriedFish.Checked = true;
                Mutton.Checked = true;
                FishCuddy.Checked = true;
                Tavvachicken.Checked = true;
                Kadahi_chicken.Checked = true;
                Program.Cartitems.Add(Eggs.Text + " 80");
                Program.Cartitems.Add(FriedFish.Text + " 150");
                Program.Cartitems.Add(Mutton.Text + " 180");
                Program.Cartitems.Add(FishCuddy.Text + " 100");
                Program.Cartitems.Add(Tavvachicken.Text + " 180");
                Program.Cartitems.Add(Kadahi_chicken.Text + "200");
            }
            else
            {
                Eggs.Checked = false;
                FriedFish.Checked = false;
                Mutton.Checked = false;
                FishCuddy.Checked = false;
                Tavvachicken.Checked = false;
                Kadahi_chicken.Checked = false;
                Program.Cartitems.Remove(Eggs.Text + " 80");
                Program.Cartitems.Remove(FriedFish.Text + " 150");
                Program.Cartitems.Remove(Mutton.Text + " 180");
                Program.Cartitems.Remove(FishCuddy.Text + " 100");
                Program.Cartitems.Remove(Tavvachicken.Text + " 180");
                Program.Cartitems.Remove(Kadahi_chicken.Text + "200");
            }
        }

        private void Eggs_CheckedChanged(object sender, EventArgs e)
        {
            if (Eggs.Checked == true)
            {
                n = n + 80;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Add(Eggs.Text + " 80");

            }
            else
            {
                n = n - 80;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Remove(Eggs.Text + " 80");
            }
        }

        private void FriedFish_CheckedChanged(object sender, EventArgs e)
        {
            if (FriedFish.Checked== true)
            {
                n = n + 150;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Add(FriedFish.Text + " 150");

            }
            else
            {
                n = n - 150;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Remove(FriedFish.Text + "150");
            }
        }

        private void Mutton_CheckedChanged(object sender, EventArgs e)
        {
            if (Mutton.Checked == true)
            {
                n = n + 180;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Add(Mutton.Text + " 180");

            }
            else
            {
                n = n - 180;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Remove(Mutton.Text + " 180");
            }
        }

        private void Kadahi_chicken_CheckedChanged(object sender, EventArgs e)
        {
            if (Kadahi_chicken.Checked == true)
            {
                n = n + 200;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Add(Kadahi_chicken.Text + " 200");

            }
            else
            {
                n = n -200;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Remove(Kadahi_chicken.Text + "200");
            }
        }

        private void Tavvachicken_CheckedChanged(object sender, EventArgs e)
        {
            if (Tavvachicken.Checked == true)
            {
                n = n + 180;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Add(Tavvachicken.Text + " 180");

            }
            else
            {
                n = n - 180;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Remove(Tavvachicken.Text + " 180");
            }
        }

        private void FishCuddy_CheckedChanged(object sender, EventArgs e)
        {
            if (FishCuddy.Checked == true)
            {
                n = n + 100;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Add(FishCuddy.Text + " 100");

            }
            else
            {
                n = n - 100;
                textBox1.Text = Convert.ToString(n);
                Program.Cartitems.Remove(FishCuddy.Text + " 100");

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
