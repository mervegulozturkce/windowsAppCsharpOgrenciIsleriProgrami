namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class AkademisyenGuncellemeForm
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
            txtParola = new TextBox();
            label8 = new Label();
            button1 = new Button();
            txtDepartment = new TextBox();
            txtIletisim = new TextBox();
            txtMemleket = new TextBox();
            txtDogumTarihi = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtParola
            // 
            txtParola.Location = new Point(12, 466);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(200, 27);
            txtParola.TabIndex = 34;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 443);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 33;
            label8.Text = "Şifrenizi giriniz:";
            // 
            // button1
            // 
            button1.Location = new Point(266, 3);
            button1.Name = "button1";
            button1.Size = new Size(145, 37);
            button1.TabIndex = 32;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(12, 399);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(200, 27);
            txtDepartment.TabIndex = 31;
            // 
            // txtIletisim
            // 
            txtIletisim.Location = new Point(12, 335);
            txtIletisim.Name = "txtIletisim";
            txtIletisim.Size = new Size(200, 27);
            txtIletisim.TabIndex = 30;
            // 
            // txtMemleket
            // 
            txtMemleket.Location = new Point(12, 268);
            txtMemleket.Name = "txtMemleket";
            txtMemleket.Size = new Size(200, 27);
            txtMemleket.TabIndex = 29;
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.Location = new Point(12, 200);
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.Size = new Size(200, 27);
            txtDogumTarihi.TabIndex = 28;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(12, 133);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 27;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(12, 69);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 376);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 25;
            label7.Text = "Alanınızı giriniz:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 312);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 24;
            label6.Text = "İletişim bilgisi giriniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 23;
            label5.Text = "Memleketinizi giriniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 177);
            label4.Name = "label4";
            label4.Size = new Size(256, 20);
            label4.TabIndex = 22;
            label4.Text = "Doğum tarihinizi giriniz: (gg/aa/yyyy)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(125, 20);
            label3.TabIndex = 21;
            label3.Text = "Soyadınızı giriniz:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 20;
            label1.Text = "Adınızı giriniz:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 9);
            label9.Name = "label9";
            label9.Size = new Size(325, 20);
            label9.TabIndex = 35;
            label9.Text = "Güncellemek için aşağıdaki bilgileri doldurunuz.";
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 501);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 52);
            panel1.TabIndex = 36;
            // 
            // AkademisyenGuncellemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 553);
            Controls.Add(panel1);
            Controls.Add(label9);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "AkademisyenGuncellemeForm";
            Text = "AkademisyenGuncellemeForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtParola;
        private Label label8;
        private Button button1;
        private TextBox txtDepartment;
        private TextBox txtIletisim;
        private TextBox txtMemleket;
        private TextBox txtDogumTarihi;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label9;
        private Panel panel1;
    }
}