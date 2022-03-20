using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LESSON_1__MURAT_YÜCEDAĞ_
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            name3.Text = textBox1.Text;
            surname3.Text = textBox2.Text;
            city3.Text = comboBox1.Text;
            address3.Text = textBox3.Text;   
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            count.Text = Convert.ToString(120 - textBox3.Text.Length);
        }
    }
}
