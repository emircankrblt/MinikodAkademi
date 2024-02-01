namespace şekil_çizimi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            radioButton3 = new RadioButton();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(35, 77);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(60, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Kare";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(35, 107);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Üçgen";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(35, 173);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(35, 137);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(66, 24);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "Daire";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(203, 266);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Yukarı";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(313, 324);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.Text = "Sağ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(86, 324);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.Text = "Sol";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(203, 374);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 8;
            button5.Text = "Aşağı";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(389, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 679);
            Controls.Add(textBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(radioButton3);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private RadioButton radioButton3;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TextBox textBox2;
    }
}