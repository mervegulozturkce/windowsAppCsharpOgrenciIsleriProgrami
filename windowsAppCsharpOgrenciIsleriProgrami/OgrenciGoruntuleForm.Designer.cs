namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class OgrenciGoruntuleForm
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
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox8 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Size = new Size(325, 20);
            label2.TabIndex = 4;
            label2.Text = "Güncellemek için aşağıdaki bilgileri doldurunuz.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 60);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 5;
            label3.Text = "Öğrencinin okul numarası:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 123);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 7;
            label4.Text = "Öğrencinin adı:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 186);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 8;
            label5.Text = "Öğrencinin soyadı:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 319);
            label6.Name = "label6";
            label6.Size = new Size(158, 20);
            label6.TabIndex = 9;
            label6.Text = "Öğrencinin memleketi:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 255);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 10;
            label7.Text = "Öğrencinin yaşı:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(14, 209);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(14, 342);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 27);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(14, 278);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(140, 27);
            textBox6.TabIndex = 14;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(14, 146);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(140, 27);
            textBox8.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(265, 174);
            button1.Name = "button1";
            button1.Size = new Size(118, 32);
            button1.TabIndex = 17;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(265, 237);
            button2.Name = "button2";
            button2.Size = new Size(118, 32);
            button2.TabIndex = 18;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OgrenciGoruntuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 416);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox8);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "OgrenciGoruntuleForm";
            Text = "OgrenciGoruntuleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox8;
        private Button button1;
        private Button button2;
    }
}