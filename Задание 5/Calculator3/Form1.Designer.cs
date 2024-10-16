namespace Calculator3
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
            this.ResTextBox = new System.Windows.Forms.RichTextBox();
            this.EqualBtn = new System.Windows.Forms.Button();
            this.ErraseAllBtn = new System.Windows.Forms.Button();
            this.ErraseLastBtn = new System.Windows.Forms.Button();
            this.SqrtBtn = new System.Windows.Forms.Button();
            this.MultyplicationBtn = new System.Windows.Forms.Button();
            this.PlusBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.DevisionBtn = new System.Windows.Forms.Button();
            this.Number7 = new System.Windows.Forms.Button();
            this.Number8 = new System.Windows.Forms.Button();
            this.Number9 = new System.Windows.Forms.Button();
            this.Number6 = new System.Windows.Forms.Button();
            this.Number5 = new System.Windows.Forms.Button();
            this.Number4 = new System.Windows.Forms.Button();
            this.Number3 = new System.Windows.Forms.Button();
            this.Number2 = new System.Windows.Forms.Button();
            this.Number1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ResTextBox
            // 
            this.ResTextBox.Location = new System.Drawing.Point(10, 17);
            this.ResTextBox.Name = "ResTextBox";
            this.ResTextBox.Size = new System.Drawing.Size(254, 53);
            this.ResTextBox.TabIndex = 37;
            this.ResTextBox.Text = "";
            // 
            // EqualBtn
            // 
            this.EqualBtn.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EqualBtn.Location = new System.Drawing.Point(113, 76);
            this.EqualBtn.Name = "EqualBtn";
            this.EqualBtn.Size = new System.Drawing.Size(50, 50);
            this.EqualBtn.TabIndex = 36;
            this.EqualBtn.Text = "=";
            this.EqualBtn.UseVisualStyleBackColor = true;
            this.EqualBtn.Click += new System.EventHandler(this.EqualBtn_Click_1);
            // 
            // ErraseAllBtn
            // 
            this.ErraseAllBtn.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErraseAllBtn.Location = new System.Drawing.Point(216, 335);
            this.ErraseAllBtn.Name = "ErraseAllBtn";
            this.ErraseAllBtn.Size = new System.Drawing.Size(50, 50);
            this.ErraseAllBtn.TabIndex = 34;
            this.ErraseAllBtn.Text = "АС";
            this.ErraseAllBtn.UseVisualStyleBackColor = true;
            // 
            // ErraseLastBtn
            // 
            this.ErraseLastBtn.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErraseLastBtn.Location = new System.Drawing.Point(216, 269);
            this.ErraseLastBtn.Name = "ErraseLastBtn";
            this.ErraseLastBtn.Size = new System.Drawing.Size(50, 50);
            this.ErraseLastBtn.TabIndex = 33;
            this.ErraseLastBtn.Text = "⌫";
            this.ErraseLastBtn.UseVisualStyleBackColor = true;
            // 
            // SqrtBtn
            // 
            this.SqrtBtn.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SqrtBtn.Location = new System.Drawing.Point(216, 204);
            this.SqrtBtn.Name = "SqrtBtn";
            this.SqrtBtn.Size = new System.Drawing.Size(50, 50);
            this.SqrtBtn.TabIndex = 32;
            this.SqrtBtn.Text = "√";
            this.SqrtBtn.UseVisualStyleBackColor = true;
            // 
            // MultyplicationBtn
            // 
            this.MultyplicationBtn.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultyplicationBtn.Location = new System.Drawing.Point(216, 136);
            this.MultyplicationBtn.Name = "MultyplicationBtn";
            this.MultyplicationBtn.Size = new System.Drawing.Size(50, 50);
            this.MultyplicationBtn.TabIndex = 31;
            this.MultyplicationBtn.Text = "x";
            this.MultyplicationBtn.UseVisualStyleBackColor = true;
            this.MultyplicationBtn.Click += new System.EventHandler(this.MultyplicationBtn_Click);
            // 
            // PlusBtn
            // 
            this.PlusBtn.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlusBtn.Location = new System.Drawing.Point(12, 136);
            this.PlusBtn.Name = "PlusBtn";
            this.PlusBtn.Size = new System.Drawing.Size(50, 50);
            this.PlusBtn.TabIndex = 30;
            this.PlusBtn.Text = "+";
            this.PlusBtn.UseVisualStyleBackColor = true;
            this.PlusBtn.Click += new System.EventHandler(this.PlusBtn_Click);
            // 
            // MinusBtn
            // 
            this.MinusBtn.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinusBtn.Location = new System.Drawing.Point(81, 136);
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.Size = new System.Drawing.Size(50, 50);
            this.MinusBtn.TabIndex = 29;
            this.MinusBtn.Text = "-";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // DevisionBtn
            // 
            this.DevisionBtn.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DevisionBtn.Location = new System.Drawing.Point(148, 136);
            this.DevisionBtn.Name = "DevisionBtn";
            this.DevisionBtn.Size = new System.Drawing.Size(50, 50);
            this.DevisionBtn.TabIndex = 28;
            this.DevisionBtn.Text = "/";
            this.DevisionBtn.UseVisualStyleBackColor = true;
            this.DevisionBtn.Click += new System.EventHandler(this.DevisionBtn_Click);
            // 
            // Number7
            // 
            this.Number7.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number7.Location = new System.Drawing.Point(12, 204);
            this.Number7.Name = "Number7";
            this.Number7.Size = new System.Drawing.Size(50, 50);
            this.Number7.TabIndex = 27;
            this.Number7.Text = "7";
            this.Number7.UseVisualStyleBackColor = true;
            // 
            // Number8
            // 
            this.Number8.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number8.Location = new System.Drawing.Point(81, 204);
            this.Number8.Name = "Number8";
            this.Number8.Size = new System.Drawing.Size(50, 50);
            this.Number8.TabIndex = 26;
            this.Number8.Text = "8";
            this.Number8.UseVisualStyleBackColor = true;
            // 
            // Number9
            // 
            this.Number9.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number9.Location = new System.Drawing.Point(148, 204);
            this.Number9.Name = "Number9";
            this.Number9.Size = new System.Drawing.Size(50, 50);
            this.Number9.TabIndex = 25;
            this.Number9.Text = "9";
            this.Number9.UseVisualStyleBackColor = true;
            // 
            // Number6
            // 
            this.Number6.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number6.Location = new System.Drawing.Point(148, 269);
            this.Number6.Name = "Number6";
            this.Number6.Size = new System.Drawing.Size(50, 50);
            this.Number6.TabIndex = 24;
            this.Number6.Text = "6";
            this.Number6.UseVisualStyleBackColor = true;
            // 
            // Number5
            // 
            this.Number5.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number5.Location = new System.Drawing.Point(81, 269);
            this.Number5.Name = "Number5";
            this.Number5.Size = new System.Drawing.Size(50, 50);
            this.Number5.TabIndex = 23;
            this.Number5.Text = "5";
            this.Number5.UseVisualStyleBackColor = true;
            // 
            // Number4
            // 
            this.Number4.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number4.Location = new System.Drawing.Point(12, 269);
            this.Number4.Name = "Number4";
            this.Number4.Size = new System.Drawing.Size(50, 50);
            this.Number4.TabIndex = 22;
            this.Number4.Text = "4";
            this.Number4.UseVisualStyleBackColor = true;
            // 
            // Number3
            // 
            this.Number3.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number3.Location = new System.Drawing.Point(148, 335);
            this.Number3.Name = "Number3";
            this.Number3.Size = new System.Drawing.Size(50, 50);
            this.Number3.TabIndex = 21;
            this.Number3.Text = "3";
            this.Number3.UseVisualStyleBackColor = true;
            // 
            // Number2
            // 
            this.Number2.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number2.Location = new System.Drawing.Point(81, 335);
            this.Number2.Name = "Number2";
            this.Number2.Size = new System.Drawing.Size(50, 50);
            this.Number2.TabIndex = 20;
            this.Number2.Text = "2";
            this.Number2.UseVisualStyleBackColor = true;
            // 
            // Number1
            // 
            this.Number1.Font = new System.Drawing.Font("Monoid", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Number1.Location = new System.Drawing.Point(12, 335);
            this.Number1.Name = "Number1";
            this.Number1.Size = new System.Drawing.Size(50, 50);
            this.Number1.TabIndex = 19;
            this.Number1.Text = "1";
            this.Number1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 390);
            this.Controls.Add(this.ResTextBox);
            this.Controls.Add(this.EqualBtn);
            this.Controls.Add(this.ErraseAllBtn);
            this.Controls.Add(this.ErraseLastBtn);
            this.Controls.Add(this.SqrtBtn);
            this.Controls.Add(this.MultyplicationBtn);
            this.Controls.Add(this.PlusBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.DevisionBtn);
            this.Controls.Add(this.Number7);
            this.Controls.Add(this.Number8);
            this.Controls.Add(this.Number9);
            this.Controls.Add(this.Number6);
            this.Controls.Add(this.Number5);
            this.Controls.Add(this.Number4);
            this.Controls.Add(this.Number3);
            this.Controls.Add(this.Number2);
            this.Controls.Add(this.Number1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResTextBox;
        private System.Windows.Forms.Button EqualBtn;
        private System.Windows.Forms.Button ErraseAllBtn;
        private System.Windows.Forms.Button ErraseLastBtn;
        private System.Windows.Forms.Button SqrtBtn;
        private System.Windows.Forms.Button MultyplicationBtn;
        private System.Windows.Forms.Button PlusBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button DevisionBtn;
        private System.Windows.Forms.Button Number7;
        private System.Windows.Forms.Button Number8;
        private System.Windows.Forms.Button Number9;
        private System.Windows.Forms.Button Number6;
        private System.Windows.Forms.Button Number5;
        private System.Windows.Forms.Button Number4;
        private System.Windows.Forms.Button Number3;
        private System.Windows.Forms.Button Number2;
        private System.Windows.Forms.Button Number1;
    }
}

