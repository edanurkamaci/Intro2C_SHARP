using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Game = new Form2();

            if (textBox1.Text == "edanurkamaci" && textBox2.Text == "12345")
            {
                Game.Show();
                this.Hide();
            }
            else
            { 
                MessageBox.Show("Wrong username or password! Please try again.");
                textBox1.Text = "";
                textBox2.Text = "";
            }
                
        }
    }
}
