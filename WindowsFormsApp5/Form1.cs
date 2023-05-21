using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
            form2.Show();
        }

        public string TextBox1
        {
            set => textBox1.Text = value;
            get => textBox1.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String text = textBox1.Text;
            form2.TextBox1 = text;
            //Form2 form2 = new Form2(text);
            //form2.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
