using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIZZA_MAKER
{
    public partial class pizza : Form
    {
        int textRemainn = 80;
        string ingres="";
        public pizza()
        {
            InitializeComponent();
        }
        private void order_Click(object sender, EventArgs e)
        {
            nameBox.Items.Add(nameText.Text);
            numbBox.Items.Add(numberText.Text);
            addressBox.Items.Add(addressText.Text);
            sizeBox.Items.Add(sizeInfo.SelectedItem);
            drBox.Items.Add(drinkInfı.SelectedItem);
            ingreBox.Items.Add(ingres);
        }
        private void clear_Click(object sender, EventArgs e)
        {
            nameBox.Items.Clear();
            numbBox.Items.Clear();
            addressBox.Items.Clear();
            sizeBox.Items.Clear();
            drBox.Items.Clear();
            ingreBox.Items.Clear();
            nameText.Clear();
            numberText.Clear();
            addressText.Clear();
            sizeInfo.Text = "";
            drinkInfı.Text = "";
            Sausage.Checked = false;
            Salami.Checked = false;
            Olive.Checked = false;
            Mushroom.Checked = false;
            Sweetcorn.Checked = false;
            Tomato.Checked = false;
            Pepper.Checked = false;
            Mozzarella.Checked = false;
            ingres = "";
        }
        private void addressText_TextChanged(object sender, EventArgs e)
        {
            remain.Text = Convert.ToString( textRemainn - Convert.ToInt32( addressText.Text.Length));
        }
        
        private void Sausage_CheckedChanged(object sender, EventArgs e)
        {
            if(Sausage.Checked==true)    
                ingres+="Sausage ";
        }
        private void Salami_CheckedChanged(object sender, EventArgs e)
        {
            if (Salami.Checked == true)
                ingres += "Salami ";
        }

        private void Olive_CheckedChanged(object sender, EventArgs e)
        {
            if (Olive.Checked == true)
                ingres += "Olive ";
        }

        private void Mushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (Mushroom.Checked == true)
                ingres += "Mushroom ";
        }

        private void Sweetcorn_CheckedChanged(object sender, EventArgs e)
        {
            if (Sweetcorn.Checked == true)
                ingres += "Sweetcorn ";
        }

        private void Tomato_CheckedChanged(object sender, EventArgs e)
        {
            if (Tomato.Checked == true)
                ingres += "Tomato ";
        }

        private void Pepper_CheckedChanged(object sender, EventArgs e)
        {
            if (Pepper.Checked == true)
                ingres += "Pepper ";
        }

        private void Mozzarella_CheckedChanged(object sender, EventArgs e)
        {
            if (Mozzarella.Checked == true)
                ingres += "Mozzarella ";
        }
    }
}
