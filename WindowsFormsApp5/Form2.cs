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
    public partial class Form2 : Form
    {
        private Form1 form;
        public Form2(string s)
        {
            InitializeComponent();

            textBox1.Text = s;
        }

        public Form2()
        {
            InitializeComponent();
        }

        public string TextBox1
        {
            set => textBox1.Text = value;
            get => textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public DialogResult ShowDialog(string s)
        {
            textBox1.Text = s;
            return ShowDialog();
        }
    }
}
