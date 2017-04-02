//chanakya banala 
//CS5110  TR 01:30 pm
// 26 june 2016
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_colors
{
    public partial class Form1 : Form
    {
        private Random generator;
        public Form1()
        {
            InitializeComponent();
            generator = new Random();
        }



     

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(generator.Next(256), generator.Next(256), generator.Next(256));
        }
    }
}