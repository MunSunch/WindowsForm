using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form2.TextBox);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
