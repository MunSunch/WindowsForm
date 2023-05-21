using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.listBox1.Items.Add("Audi");
            this.listBox1.Items.Add("Toyota");
            this.listBox1.Items.Add("BMW");
        }

        private void AddToListBoxButton_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Add(InputTextBox.Text);
        }

        private void CopyFromListBoxButton_Click(object sender, EventArgs e)
        {
            if(this.listBox1.SelectedItems != null) {
                for(int i=0; i< this.listBox1.SelectedItems.Count; i++)
                {
                    String text = (String)this.listBox1.SelectedItems[i];
                    this.listBox2.Items.Add(text);
                    this.listBox1.ClearSelected();
                }
            }

            if (this.listBox2.SelectedItems != null)
            {
                for (int i = 0; i < this.listBox2.SelectedItems.Count; i++)
                {
                    String text = (String)this.listBox2.SelectedItems[i];
                    this.listBox1.Items.Add(text);
                    this.listBox2.ClearSelected();
                }
            }
        }

        private void RemoveSelectedButton_Click(object sender, EventArgs e)
        {
            if (this.listBox1.SelectedItems != null)
            {
                for (int i = 0; i < this.listBox1.SelectedItems.Count; i++)
                {
                    this.listBox1.Items.Remove(this.listBox1.SelectedItems[i]);
                }
            }

            if (this.listBox2.SelectedItems != null)
            {
                for (int i = 0; i < this.listBox2.SelectedItems.Count; i++)
                {
                    this.listBox2.Items.Remove(this.listBox2.SelectedItems[i]);
                }
            }
        }
    }
}
