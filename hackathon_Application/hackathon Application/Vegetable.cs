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
    public partial class Vegetable : Form
    {
        int v;
        public Vegetable()
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
                Pratha.Checked = true;
                Rice.Checked = true;
                Chana_Puri.Checked = true;
                Thali.Checked = true;
                Dal.Checked = true;
                Chapathi.Checked = true;
                Program.Cartitems.Add(Rice.Text + " 50");
                Program.Cartitems.Add(Chana_Puri.Text + " 40");
                Program.Cartitems.Add(Pratha.Text + " 20");
                Program.Cartitems.Add(Dal.Text + " 30");
                Program.Cartitems.Add(Chapathi.Text + " 10");
                Program.Cartitems.Add(Thali.Text + " 60");
            }
            else
            {
                Pratha.Checked = false;
                Rice.Checked = false;
                Chana_Puri.Checked = false;
                Thali.Checked = false;
                Dal.Checked = false;
                Chapathi.Checked = false;
                Program.Cartitems.Remove(Rice.Text + " 50");
                Program.Cartitems.Remove(Chana_Puri.Text + " 40");
                Program.Cartitems.Remove(Pratha.Text + " 20");
                Program.Cartitems.Remove(Dal.Text + " 30");
                Program.Cartitems.Remove(Chapathi.Text + " 10");
                Program.Cartitems.Remove(Thali.Text + " 60");
            }

        }

        private void Pratha_CheckedChanged(object sender, EventArgs e)
        {
            if (Pratha.Checked == true)
            {
                v = v + 20;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Add(Pratha.Text + " 20");

            }
            else
            {
                v = v - 20;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Remove(Pratha.Text + " 20");
            }
        }

        private void Chana_Puri_CheckedChanged(object sender, EventArgs e)
        {
            if (Chana_Puri.Checked == true)
            {
                v = v + 40;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Add(Chana_Puri.Text + " 50");

            }
            else
            {
                v = v - 40;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Remove(Chana_Puri.Text + " 40");
            }
        }

        private void Chapathi_CheckedChanged(object sender, EventArgs e)
        {
            if (Chapathi.Checked == true)
            {
                v = v + 10;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Add(Chapathi.Text + " 10");

            }
            else
            {
                v = v - 10;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Remove(Chapathi.Text + " 10");
            }
        }

        private void Rice_CheckedChanged(object sender, EventArgs e)
        {
            if (Rice.Checked == true)
            {
                v = v + 50;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Add(Rice.Text + " 50");

            }
            else
            {
                v = v - 50;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Remove(Rice.Text + " 50");
            }
        }

        private void Thali_CheckedChanged(object sender, EventArgs e)
        {
            if (Thali.Checked == true)
            {
                v = v + 60;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Add(Thali.Text + " 60");

            }
            else
            {
                v = v - 60;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Remove(Thali.Text + " 60");
            }
        }

        private void Dal_CheckedChanged(object sender, EventArgs e)
        {
            if (Dal.Checked == true)
            {
                v = v + 30;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Add(Dal.Text + " 30");
            }
            else
            {
                v = v - 30;
                textBox1.Text = Convert.ToString(v);
                Program.Cartitems.Remove(Dal.Text + " 30");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
