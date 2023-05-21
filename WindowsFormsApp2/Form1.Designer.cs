namespace WindowsFormsApp2
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddToCheckedListBoxButton = new System.Windows.Forms.Button();
            this.AddSelectedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(27, 28);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkedListBox1.Size = new System.Drawing.Size(116, 109);
            this.checkedListBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(172, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(116, 108);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 157);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 2;
            // 
            // AddToCheckedListBoxButton
            // 
            this.AddToCheckedListBoxButton.Location = new System.Drawing.Point(27, 192);
            this.AddToCheckedListBoxButton.Name = "AddToCheckedListBoxButton";
            this.AddToCheckedListBoxButton.Size = new System.Drawing.Size(128, 23);
            this.AddToCheckedListBoxButton.TabIndex = 3;
            this.AddToCheckedListBoxButton.Text = "AddToCheckedListBox";
            this.AddToCheckedListBoxButton.UseVisualStyleBackColor = true;
            this.AddToCheckedListBoxButton.Click += new System.EventHandler(this.AddToCheckedListBoxButton_Click);
            // 
            // AddSelectedButton
            // 
            this.AddSelectedButton.Location = new System.Drawing.Point(172, 192);
            this.AddSelectedButton.Name = "AddSelectedButton";
            this.AddSelectedButton.Size = new System.Drawing.Size(116, 23);
            this.AddSelectedButton.TabIndex = 4;
            this.AddSelectedButton.Text = "AddSelected";
            this.AddSelectedButton.UseVisualStyleBackColor = true;
            this.AddSelectedButton.Click += new System.EventHandler(this.AddSelectedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 248);
            this.Controls.Add(this.AddSelectedButton);
            this.Controls.Add(this.AddToCheckedListBoxButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddToCheckedListBoxButton;
        private System.Windows.Forms.Button AddSelectedButton;
    }
}

