using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\kamac\\OneDrive\\Masaüstü\\MURAT YÜCEDAĞ C# LESSONS\\Media Player\\Media Player\\Nirvana - Something In The Way  The Batman .mp3";
        }
    }
}
