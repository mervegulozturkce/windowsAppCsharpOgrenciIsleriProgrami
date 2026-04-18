namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class OgrenciEkleForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(205, 20);
            label1.TabIndex = 1;
            label1.Text = "Öğrencinin numarasını giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 2;
            label2.Text = "Aşağıdaki bilgileri doldurunuz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 110);
            label3.Name = "label3";
            label3.Size = new Size(166, 20);
            label3.TabIndex = 4;
            label3.Text = "Öğrencinin adını giriniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 182);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 8;
            label4.Text = "Öğrencinin soyadını giriniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 257);
            label5.Name = "label5";
            label5.Size = new Size(170, 20);
            label5.TabIndex = 9;
            label5.Text = "Öğrencinin yaşını giriniz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 325);
            label6.Name = "label6";
            label6.Size = new Size(215, 20);
            label6.TabIndex = 10;
            label6.Text = "Öğrencinin memleketini giriniz:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(27, 205);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(27, 348);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(200, 27);
            textBox5.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(48, 394);
            button1.Name = "button1";
            button1.Size = new Size(145, 37);
            button1.TabIndex = 16;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 280);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 27);
            textBox4.TabIndex = 17;
            // 
            // OgrenciEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrenciEkleForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private Button button1;
        private TextBox textBox4;
    }
}