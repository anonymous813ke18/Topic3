namespace Topic3
{
    partial class Form3
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.RadioButton();
            this.multiplication = new System.Windows.Forms.RadioButton();
            this.subtraction = new System.Windows.Forms.RadioButton();
            this.addition = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox2.Size = new System.Drawing.Size(154, 22);
            this.textBox2.TabIndex = 20;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "SOLVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(176, 268);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(85, 20);
            this.division.TabIndex = 17;
            this.division.TabStop = true;
            this.division.Text = "DIVISION";
            this.division.UseVisualStyleBackColor = true;
            // 
            // multiplication
            // 
            this.multiplication.AutoSize = true;
            this.multiplication.Location = new System.Drawing.Point(8, 268);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(137, 20);
            this.multiplication.TabIndex = 16;
            this.multiplication.TabStop = true;
            this.multiplication.Text = "MULTIPLICATION";
            this.multiplication.UseVisualStyleBackColor = true;
            // 
            // subtraction
            // 
            this.subtraction.AutoSize = true;
            this.subtraction.Location = new System.Drawing.Point(176, 144);
            this.subtraction.Name = "subtraction";
            this.subtraction.Size = new System.Drawing.Size(125, 20);
            this.subtraction.TabIndex = 15;
            this.subtraction.TabStop = true;
            this.subtraction.Text = "SUBTRACTION";
            this.subtraction.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            this.addition.AutoSize = true;
            this.addition.Location = new System.Drawing.Point(8, 144);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(92, 20);
            this.addition.TabIndex = 14;
            this.addition.TabStop = true;
            this.addition.Text = "ADDITION";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 309);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.subtraction);
            this.Controls.Add(this.addition);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton division;
        private System.Windows.Forms.RadioButton multiplication;
        private System.Windows.Forms.RadioButton subtraction;
        private System.Windows.Forms.RadioButton addition;
    }
}