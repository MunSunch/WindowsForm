namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.AddToListBoxButton = new System.Windows.Forms.Button();
            this.CopyFromListBoxButton = new System.Windows.Forms.Button();
            this.RemoveSelectedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(35, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(97, 82);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(156, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(97, 82);
            this.listBox2.TabIndex = 1;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(35, 110);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(97, 20);
            this.InputTextBox.TabIndex = 2;
            // 
            // AddToListBoxButton
            // 
            this.AddToListBoxButton.Location = new System.Drawing.Point(35, 148);
            this.AddToListBoxButton.Name = "AddToListBoxButton";
            this.AddToListBoxButton.Size = new System.Drawing.Size(100, 23);
            this.AddToListBoxButton.TabIndex = 3;
            this.AddToListBoxButton.Text = "AddToListBox";
            this.AddToListBoxButton.UseVisualStyleBackColor = true;
            this.AddToListBoxButton.Click += new System.EventHandler(this.AddToListBoxButton_Click);
            // 
            // CopyFromListBoxButton
            // 
            this.CopyFromListBoxButton.Location = new System.Drawing.Point(156, 148);
            this.CopyFromListBoxButton.Name = "CopyFromListBoxButton";
            this.CopyFromListBoxButton.Size = new System.Drawing.Size(97, 23);
            this.CopyFromListBoxButton.TabIndex = 4;
            this.CopyFromListBoxButton.Text = "CopyFromListBox";
            this.CopyFromListBoxButton.UseVisualStyleBackColor = true;
            this.CopyFromListBoxButton.Click += new System.EventHandler(this.CopyFromListBoxButton_Click);
            // 
            // RemoveSelectedButton
            // 
            this.RemoveSelectedButton.Location = new System.Drawing.Point(35, 203);
            this.RemoveSelectedButton.Name = "RemoveSelectedButton";
            this.RemoveSelectedButton.Size = new System.Drawing.Size(100, 23);
            this.RemoveSelectedButton.TabIndex = 5;
            this.RemoveSelectedButton.Text = "RemoveSelected";
            this.RemoveSelectedButton.UseVisualStyleBackColor = true;
            this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 248);
            this.Controls.Add(this.RemoveSelectedButton);
            this.Controls.Add(this.CopyFromListBoxButton);
            this.Controls.Add(this.AddToListBoxButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Задание 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button AddToListBoxButton;
        private System.Windows.Forms.Button CopyFromListBoxButton;
        private System.Windows.Forms.Button RemoveSelectedButton;
    }
}

