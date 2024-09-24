
namespace _3sem_lab2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x1Input = new System.Windows.Forms.TextBox();
            this.x2Input = new System.Windows.Forms.TextBox();
            this.eInput = new System.Windows.Forms.TextBox();
            this.eNInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.functionInput = new System.Windows.Forms.TextBox();
            this.resultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "e";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "eN";
            // 
            // x1Input
            // 
            this.x1Input.Location = new System.Drawing.Point(83, 54);
            this.x1Input.Name = "x1Input";
            this.x1Input.Size = new System.Drawing.Size(100, 20);
            this.x1Input.TabIndex = 4;
            this.x1Input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // x2Input
            // 
            this.x2Input.Location = new System.Drawing.Point(83, 88);
            this.x2Input.Name = "x2Input";
            this.x2Input.Size = new System.Drawing.Size(100, 20);
            this.x2Input.TabIndex = 5;
            // 
            // eInput
            // 
            this.eInput.Location = new System.Drawing.Point(83, 125);
            this.eInput.Name = "eInput";
            this.eInput.Size = new System.Drawing.Size(100, 20);
            this.eInput.TabIndex = 6;
            // 
            // eNInput
            // 
            this.eNInput.Location = new System.Drawing.Point(83, 163);
            this.eNInput.Name = "eNInput";
            this.eNInput.Size = new System.Drawing.Size(100, 20);
            this.eNInput.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Function:";
            // 
            // functionInput
            // 
            this.functionInput.Location = new System.Drawing.Point(83, 28);
            this.functionInput.Name = "functionInput";
            this.functionInput.Size = new System.Drawing.Size(176, 20);
            this.functionInput.TabIndex = 10;
            // 
            // resultat
            // 
            this.resultat.Location = new System.Drawing.Point(171, 235);
            this.resultat.Name = "resultat";
            this.resultat.Size = new System.Drawing.Size(100, 20);
            this.resultat.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultat);
            this.Controls.Add(this.functionInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eNInput);
            this.Controls.Add(this.eInput);
            this.Controls.Add(this.x2Input);
            this.Controls.Add(this.x1Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox x1Input;
        private System.Windows.Forms.TextBox x2Input;
        private System.Windows.Forms.TextBox eInput;
        private System.Windows.Forms.TextBox eNInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox functionInput;
        private System.Windows.Forms.TextBox resultat;
    }
}

