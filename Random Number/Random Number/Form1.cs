using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random number = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int numb = number.Next(1, 6);
            int numb2= number.Next(1, 6);

            textBox1.Text = Convert.ToString(numb);
            textBox2.Text = Convert.ToString(numb2);

            if (numb == 1)
                pictureBox1.Image = Properties.Resources._1_dice;
            else if (numb == 2)
                pictureBox1.Image = Properties.Resources._2_dice;
            else if (numb == 3)
                pictureBox1.Image = Properties.Resources._3_dice;
            else if (numb == 4)
                pictureBox1.Image = Properties.Resources._4_dice;
            else if (numb == 5)
                pictureBox1.Image = Properties.Resources._5_dice;
            else if (numb == 6)
                pictureBox1.Image = Properties.Resources._6_dice;

            if (numb2 == 1)
                pictureBox2.Image = Properties.Resources._1_dice;
            else if (numb2 == 2)
                pictureBox2.Image = Properties.Resources._2_dice;
            else if (numb2 == 3)
                pictureBox2.Image = Properties.Resources._3_dice;
            else if (numb2 == 4)
                pictureBox2.Image = Properties.Resources._4_dice;
            else if (numb2 == 5)
                pictureBox2.Image = Properties.Resources._5_dice;
            else if (numb2 == 6)
                pictureBox2.Image = Properties.Resources._6_dice;

        }
    }
}
