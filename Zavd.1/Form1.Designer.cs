namespace Zavd._1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label_a = new System.Windows.Forms.Label();
            this.label_b = new System.Windows.Forms.Label();
            this.label_c = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_c = new System.Windows.Forms.TextBox();
            this.Riv = new System.Windows.Forms.Label();
            this.dis = new System.Windows.Forms.Label();
            this.Ant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Розрахунок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(44, 80);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(27, 20);
            this.label_a.TabIndex = 1;
            this.label_a.Text = "a=";
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(44, 115);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(27, 20);
            this.label_b.TabIndex = 2;
            this.label_b.Text = "b=";
            // 
            // label_c
            // 
            this.label_c.AutoSize = true;
            this.label_c.Location = new System.Drawing.Point(45, 148);
            this.label_c.Name = "label_c";
            this.label_c.Size = new System.Drawing.Size(26, 20);
            this.label_c.TabIndex = 3;
            this.label_c.Text = "c=";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(78, 80);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(52, 26);
            this.textBox_a.TabIndex = 4;
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(78, 113);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(52, 26);
            this.textBox_b.TabIndex = 5;
            // 
            // textBox_c
            // 
            this.textBox_c.Location = new System.Drawing.Point(78, 146);
            this.textBox_c.Name = "textBox_c";
            this.textBox_c.Size = new System.Drawing.Size(52, 26);
            this.textBox_c.TabIndex = 6;
            // 
            // Riv
            // 
            this.Riv.AutoSize = true;
            this.Riv.Location = new System.Drawing.Point(290, 83);
            this.Riv.Name = "Riv";
            this.Riv.Size = new System.Drawing.Size(0, 20);
            this.Riv.TabIndex = 7;
            // 
            // dis
            // 
            this.dis.AutoSize = true;
            this.dis.Location = new System.Drawing.Point(290, 119);
            this.dis.Name = "dis";
            this.dis.Size = new System.Drawing.Size(0, 20);
            this.dis.TabIndex = 8;
            // 
            // Ant
            // 
            this.Ant.AutoSize = true;
            this.Ant.Location = new System.Drawing.Point(290, 152);
            this.Ant.Name = "Ant";
            this.Ant.Size = new System.Drawing.Size(0, 20);
            this.Ant.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 298);
            this.Controls.Add(this.Ant);
            this.Controls.Add(this.dis);
            this.Controls.Add(this.Riv);
            this.Controls.Add(this.textBox_c);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_c);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_c;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_c;
        private System.Windows.Forms.Label Riv;
        private System.Windows.Forms.Label dis;
        private System.Windows.Forms.Label Ant;
    }
}

