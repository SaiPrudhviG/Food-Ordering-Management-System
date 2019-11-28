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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.Cartitems.Count; i++)
                listView1.Items.Add(
                    Program.Cartitems.ElementAt(i)); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menuitems k = new Menuitems();
            this.Hide();
            k.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FinalStatement k = new FinalStatement();
            this.Hide();
            k.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuyingForm k = new BuyingForm();
            this.Hide();
            k.Show();
        }
    }
}
