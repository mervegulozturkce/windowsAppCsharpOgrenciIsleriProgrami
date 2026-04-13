namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class NotEkleForm
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
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(410, 20);
            label1.TabIndex = 0;
            label1.Text = "Öğrenciye not girişi yapmak için aşağıdaki bilgileri doldurun.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 59);
            label2.Name = "label2";
            label2.Size = new Size(237, 20);
            label2.TabIndex = 1;
            label2.Text = "Öğrencinin okul numarasını giriniz:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(21, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 130);
            label3.Name = "label3";
            label3.Size = new Size(256, 20);
            label3.TabIndex = 3;
            label3.Text = "Öğrencinin aldığı ders kodunu giriniz:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(21, 153);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 27);
            textBox2.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 202);
            label4.Name = "label4";
            label4.Size = new Size(365, 20);
            label4.TabIndex = 5;
            label4.Text = "Girdiğiniz kodlu dersten öğrencinin aldığı notu giriniz:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(21, 225);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(39, 284);
            button1.Name = "button1";
            button1.Size = new Size(145, 37);
            button1.TabIndex = 7;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NotEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NotEkleForm";
            Text = "NotEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Button button1;
    }
}