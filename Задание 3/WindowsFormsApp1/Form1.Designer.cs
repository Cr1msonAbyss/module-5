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
            this.TaskAppendBtn = new System.Windows.Forms.Button();
            this.TaskInputTextBox = new System.Windows.Forms.TextBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.MarkBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TaskAppendBtn
            // 
            this.TaskAppendBtn.Location = new System.Drawing.Point(169, 17);
            this.TaskAppendBtn.Name = "TaskAppendBtn";
            this.TaskAppendBtn.Size = new System.Drawing.Size(147, 29);
            this.TaskAppendBtn.TabIndex = 2;
            this.TaskAppendBtn.Text = "Добавить задачу";
            this.TaskAppendBtn.UseVisualStyleBackColor = true;
            this.TaskAppendBtn.Click += new System.EventHandler(this.TaskAppendBtn_Click);
            // 
            // TaskInputTextBox
            // 
            this.TaskInputTextBox.Location = new System.Drawing.Point(12, 52);
            this.TaskInputTextBox.Name = "TaskInputTextBox";
            this.TaskInputTextBox.Size = new System.Drawing.Size(463, 20);
            this.TaskInputTextBox.TabIndex = 3;
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(12, 408);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // MarkBtn
            // 
            this.MarkBtn.Location = new System.Drawing.Point(93, 408);
            this.MarkBtn.Name = "MarkBtn";
            this.MarkBtn.Size = new System.Drawing.Size(155, 23);
            this.MarkBtn.TabIndex = 6;
            this.MarkBtn.Text = "пометить как выполненное ";
            this.MarkBtn.UseVisualStyleBackColor = true;
            this.MarkBtn.Click += new System.EventHandler(this.MarkBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(463, 303);
            this.listBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.MarkBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.TaskInputTextBox);
            this.Controls.Add(this.TaskAppendBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TaskAppendBtn;
        private System.Windows.Forms.TextBox TaskInputTextBox;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button MarkBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

