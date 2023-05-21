using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            timer1.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal value = numericUpDown1.Value;
            progressBar1.Value = (int)value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString();
            toolStripStatusLabel2.Text = DateTime.Now.DayOfWeek.ToString();
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
