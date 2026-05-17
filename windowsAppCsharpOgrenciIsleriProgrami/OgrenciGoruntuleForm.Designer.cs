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
            txtNumara = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSoyad = new TextBox();
            txtMemleket = new TextBox();
            txtDogumTarihi = new TextBox();
            txtAd = new TextBox();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
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
            // txtNumara
            // 
            txtNumara.Location = new Point(14, 83);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(140, 27);
            txtNumara.TabIndex = 6;
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
            label7.Size = new Size(258, 20);
            label7.TabIndex = 10;
            label7.Text = "Öğrencinin doğum tarihi:(gg/aa/yyyy)";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(14, 209);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(140, 27);
            txtSoyad.TabIndex = 11;
            // 
            // txtMemleket
            // 
            txtMemleket.Location = new Point(14, 342);
            txtMemleket.Name = "txtMemleket";
            txtMemleket.Size = new Size(140, 27);
            txtMemleket.TabIndex = 13;
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.Location = new Point(14, 278);
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.ReadOnly = true;
            txtDogumTarihi.Size = new Size(140, 27);
            txtDogumTarihi.TabIndex = 14;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(14, 146);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(140, 27);
            txtAd.TabIndex = 16;
            // 
            // button1
            // 
            button1.Location = new Point(36, 10);
            button1.Name = "button1";
            button1.Size = new Size(118, 30);
            button1.TabIndex = 17;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(207, 10);
            button2.Name = "button2";
            button2.Size = new Size(118, 30);
            button2.TabIndex = 18;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 380);
            panel1.Name = "panel1";
            panel1.Size = new Size(358, 52);
            panel1.TabIndex = 20;
            // 
            // OgrenciGoruntuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 432);
            Controls.Add(panel1);
            Controls.Add(txtAd);
            Controls.Add(txtDogumTarihi);
            Controls.Add(txtMemleket);
            Controls.Add(txtSoyad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNumara);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OgrenciGoruntuleForm";
            Text = "Ögrenci Güncelle";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox txtNumara;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtSoyad;
        private TextBox txtMemleket;
        private TextBox txtDogumTarihi;
        private TextBox txtAd;
        private Button button1;
        private Button button2;
        private Panel panel1;
    }
}