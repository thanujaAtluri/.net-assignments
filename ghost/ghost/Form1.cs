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

namespace ghost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.Opacity >= 0.2)
                {
                    //Decrement
                    this.Opacity -= 0.1;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                //Increment
                this.Opacity += 0.1;
            }
        }
    }
}
