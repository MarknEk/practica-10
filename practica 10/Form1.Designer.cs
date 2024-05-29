namespace practica_10
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
            this.listBoxProgrammer = new System.Windows.Forms.ListBox();
            this.btnDeleteFirst1 = new System.Windows.Forms.Button();
            this.btnMutate2 = new System.Windows.Forms.Button();
            this.btnDeleteLast1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxProgrammer
            // 
            this.listBoxProgrammer.FormattingEnabled = true;
            this.listBoxProgrammer.ItemHeight = 16;
            this.listBoxProgrammer.Location = new System.Drawing.Point(14, 24);
            this.listBoxProgrammer.Name = "listBoxProgrammer";
            this.listBoxProgrammer.Size = new System.Drawing.Size(447, 228);
            this.listBoxProgrammer.TabIndex = 0;
            // 
            // btnDeleteFirst1
            // 
            this.btnDeleteFirst1.Location = new System.Drawing.Point(14, 258);
            this.btnDeleteFirst1.Name = "btnDeleteFirst1";
            this.btnDeleteFirst1.Size = new System.Drawing.Size(143, 50);
            this.btnDeleteFirst1.TabIndex = 2;
            this.btnDeleteFirst1.Text = "Удалить";
            this.btnDeleteFirst1.UseVisualStyleBackColor = true;
            this.btnDeleteFirst1.Click += new System.EventHandler(this.btnDeleteFirst_Click);
            // 
            // btnMutate2
            // 
            this.btnMutate2.Location = new System.Drawing.Point(320, 258);
            this.btnMutate2.Name = "btnMutate2";
            this.btnMutate2.Size = new System.Drawing.Size(141, 50);
            this.btnMutate2.TabIndex = 3;
            this.btnMutate2.Text = "Мульти";
            this.btnMutate2.UseVisualStyleBackColor = true;
            this.btnMutate2.Click += new System.EventHandler(this.btnMutate_Click);
            // 
            // btnDeleteLast1
            // 
            this.btnDeleteLast1.Location = new System.Drawing.Point(163, 258);
            this.btnDeleteLast1.Name = "btnDeleteLast1";
            this.btnDeleteLast1.Size = new System.Drawing.Size(151, 50);
            this.btnDeleteLast1.TabIndex = 4;
            this.btnDeleteLast1.Text = "Удалить последнюю запись";
            this.btnDeleteLast1.UseVisualStyleBackColor = true;
            this.btnDeleteLast1.Click += new System.EventHandler(this.btnDeleteLast_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(14, 314);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(447, 52);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 377);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDeleteLast1);
            this.Controls.Add(this.btnMutate2);
            this.Controls.Add(this.btnDeleteFirst1);
            this.Controls.Add(this.listBoxProgrammer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxProgrammer;
        private System.Windows.Forms.Button btnDeleteFirst1;
        private System.Windows.Forms.Button btnMutate2;
        private System.Windows.Forms.Button btnDeleteLast1;
        private System.Windows.Forms.Button btnReset;
    }
}

