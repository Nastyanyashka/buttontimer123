using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buttontimer123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick +=new EventHandler(Timer1_Tick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            timer1.Enabled = true;
        }
        private void Timer1_Tick(object sender,EventArgs e)
        {
            button1.Enabled = true;
            timer1.Enabled = false;
        }
    }
}
