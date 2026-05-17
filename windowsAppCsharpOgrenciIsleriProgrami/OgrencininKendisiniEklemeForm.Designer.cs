namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class OgrencininKendisiniEklemeForm
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
            txtDogumTarihi = new TextBox();
            txtMemleket = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            txtNumara = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            txtParola = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtDogumTarihi
            // 
            txtDogumTarihi.Location = new Point(33, 278);
            txtDogumTarihi.Name = "txtDogumTarihi";
            txtDogumTarihi.Size = new Size(200, 27);
            txtDogumTarihi.TabIndex = 29;
            // 
            // txtMemleket
            // 
            txtMemleket.Location = new Point(33, 351);
            txtMemleket.Name = "txtMemleket";
            txtMemleket.Size = new Size(200, 27);
            txtMemleket.TabIndex = 27;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(33, 208);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 26;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(33, 136);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 25;
            // 
            // txtNumara
            // 
            txtNumara.Location = new Point(33, 72);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(200, 27);
            txtNumara.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 328);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 23;
            label6.Text = "Memleketinizi giriniz:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 255);
            label5.Name = "label5";
            label5.Size = new Size(256, 20);
            label5.TabIndex = 22;
            label5.Text = "Doğum tarihinizi giriniz: (gg/aa/yyyy)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 185);
            label4.Name = "label4";
            label4.Size = new Size(125, 20);
            label4.TabIndex = 21;
            label4.Text = "Soyadınızı giriniz:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 113);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 20;
            label3.Text = "Adınızı giriniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 12);
            label2.Name = "label2";
            label2.Size = new Size(208, 20);
            label2.TabIndex = 19;
            label2.Text = "Aşağıdaki bilgileri doldurunuz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 18;
            label1.Text = "Numaranızı giriniz:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 402);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 30;
            label7.Text = "Şifrenizi giriniz:";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(33, 425);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(200, 27);
            txtParola.TabIndex = 31;
            // 
            // button1
            // 
            button1.Location = new Point(46, 477);
            button1.Name = "button1";
            button1.Size = new Size(155, 36);
            button1.TabIndex = 32;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OgrencininKendisiniEklemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 586);
            Controls.Add(button1);
            Controls.Add(txtParola);
            Controls.Add(label7);
            Controls.Add(txtDogumTarihi);
            Controls.Add(txtMemleket);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(txtNumara);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "OgrencininKendisiniEklemeForm";
            Text = "OgrencininKendisiniEklemeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDogumTarihi;
        private TextBox txtMemleket;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private TextBox txtNumara;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txtParola;
        private Button button1;
    }
}