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
            txtNumara = new TextBox();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtMemleket = new TextBox();
            button1 = new Button();
            txtYas = new TextBox();
            txtParola = new TextBox();
            label7 = new Label();
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
            label5.Location = new Point(27, 252);
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
            // txtNumara
            // 
            txtNumara.Location = new Point(27, 69);
            txtNumara.Name = "txtNumara";
            txtNumara.Size = new Size(200, 27);
            txtNumara.TabIndex = 11;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(27, 133);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 12;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(27, 205);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 13;
            // 
            // txtMemleket
            // 
            txtMemleket.Location = new Point(27, 348);
            txtMemleket.Name = "txtMemleket";
            txtMemleket.Size = new Size(200, 27);
            txtMemleket.TabIndex = 15;
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
            // txtYas
            // 
            txtYas.Location = new Point(27, 275);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(200, 27);
            txtYas.TabIndex = 17;
            // 
            // txtParola
            // 
            txtParola.Location = new Point(317, 55);
            txtParola.Name = "txtParola";
            txtParola.ReadOnly = true;
            txtParola.Size = new Size(200, 27);
            txtParola.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 26);
            label7.Name = "label7";
            label7.Size = new Size(169, 20);
            label7.TabIndex = 19;
            label7.Text = "Öğrencinin geçici şifresi:";
            // 
            // OgrenciEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            Controls.Add(label7);
            Controls.Add(txtParola);
            Controls.Add(txtYas);
            Controls.Add(button1);
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
            Name = "OgrenciEkleForm";
            Text = "OgrenciEkleForm";
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
        private TextBox txtNumara;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtMemleket;
        private Button button1;
        private TextBox txtYas;
        private TextBox txtParola;
        private Label label7;
    }
}