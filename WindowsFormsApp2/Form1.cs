using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            checkedListBox1.Items.Add("Point 1");
            checkedListBox1.Items.Add("Point 2");
            checkedListBox1.Items.Add("Point 3");
            checkedListBox1.Items.Add("Point 4");
        }

        private void AddToCheckedListBoxButton_Click(object sender, EventArgs e)
        {
            String inputText = textBox1.Text;
            if (String.IsNullOrWhiteSpace(inputText))
            {
                MessageBox.Show("Введена пустая строка");
                return;
            }
            checkedListBox1.Items.Add(inputText);
            textBox1.Clear();
        }

        private void AddSelectedButton_Click(object sender, EventArgs e)
        {
            if(checkedListBox1.CheckedItems != null)
            {
                listBox1.Items.Clear();
                for(int i=0; i< checkedListBox1.CheckedItems.Count; i++)
                {
                    String curText = checkedListBox1.CheckedItems[i].ToString();
                    listBox1.Items.Add(curText);
                }
            }
        }
    }
}
