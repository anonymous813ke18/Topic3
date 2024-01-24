namespace Topic3
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.RadioButton();
            this.multiplication = new System.Windows.Forms.RadioButton();
            this.subtraction = new System.Windows.Forms.RadioButton();
            this.addition = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 36;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(73, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(154, 22);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 33;
            this.button1.Text = "SOLVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(179, 266);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(85, 20);
            this.division.TabIndex = 32;
            this.division.TabStop = true;
            this.division.Text = "DIVISION";
            this.division.UseVisualStyleBackColor = true;
            // 
            // multiplication
            // 
            this.multiplication.AutoSize = true;
            this.multiplication.Location = new System.Drawing.Point(11, 266);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(137, 20);
            this.multiplication.TabIndex = 31;
            this.multiplication.TabStop = true;
            this.multiplication.Text = "MULTIPLICATION";
            this.multiplication.UseVisualStyleBackColor = true;
            // 
            // subtraction
            // 
            this.subtraction.AutoSize = true;
            this.subtraction.Location = new System.Drawing.Point(179, 142);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(125, 20);
            this.subtraction.TabIndex = 30;
            this.subtraction.TabStop = true;
            this.subtraction.Text = "SUBTRACTION";
            this.subtraction.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Location = new System.Drawing.Point(11, 142);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(92, 20);
            this.addition.TabIndex = 29;
            this.addition.TabStop = true;
            this.addition.Text = "ADDITION";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(258, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 38;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 301);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton division;
        private System.Windows.Forms.RadioButton multiplication;
        private System.Windows.Forms.RadioButton subtraction;
        private System.Windows.Forms.RadioButton addition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}