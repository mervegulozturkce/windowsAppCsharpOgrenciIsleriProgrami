namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class AkademisyenEklemeForm
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtDogumTarihi = new TextBox();
            txtMemleket = new TextBox();
            txtIletisim = new TextBox();
            txtDepartment = new TextBox();
            label8 = new Label();
            txtParola = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(211, 20);
            label2.TabIndex = 3;
            label2.Text = "Aşağıdaki bilgileri doldurunuz.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 4;
            label1.Text = "Adınızı giriniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 5;
            label3.Text = "Soyadınızı giriniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 173);
            label4.Name = "label4";
            label4.Size = new Size(256, 20);
            label4.TabIndex = 6;
            label4.Text = "Doğum tarihinizi giriniz: (gg/aa/yyyy)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 241);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 7;
            label5.Text = "Memleketinizi giriniz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 308);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 8;
            label6.Text = "İletişim bilgisi giriniz:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 372);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 9;
            label7.Text = "Alanınızı giriniz:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(12, 65);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 10;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(12, 129);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 11;
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.Location = new Point(12, 196);
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.Size = new Size(200, 27);
            txtDogumTarihi.TabIndex = 12;
            // 
            // txtMemleket
            // 
            txtMemleket.Location = new Point(12, 264);
            txtMemleket.Name = "txtMemleket";
            txtMemleket.Size = new Size(200, 27);
            txtMemleket.TabIndex = 13;
            // 
            // txtIletisim
            // 
            txtIletisim.Location = new Point(12, 331);
            txtIletisim.Name = "txtIletisim";
            txtIletisim.Size = new Size(200, 27);
            txtIletisim.TabIndex = 14;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(12, 395);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(200, 27);
            txtDepartment.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 439);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 17;
            label8.Text = "Şifrenizi giriniz:";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(12, 462);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(200, 27);
            txtParola.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 507);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 52);
            panel1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(247, 8);
            button1.Name = "button1";
            button1.Size = new Size(145, 37);
            button1.TabIndex = 17;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // AkademisyenEklemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 559);
            Controls.Add(panel1);
            Controls.Add(txtParola);
            Controls.Add(label8);
            Controls.Add(txtDepartment);
            Controls.Add(txtIletisim);
            Controls.Add(txtMemleket);
            Controls.Add(txtDogumTarihi);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AkademisyenEklemeForm";
            Text = "AkademisyenEklemeForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtDogumTarihi;
        private TextBox txtMemleket;
        private TextBox txtIletisim;
        private TextBox txtDepartment;
        private Label label8;
        private TextBox txtParola;
        private Panel panel1;
        private Button button1;
    }
}