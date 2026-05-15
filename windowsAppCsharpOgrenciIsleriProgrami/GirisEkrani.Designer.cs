namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class GirisEkrani
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
            txtAdSoyad = new TextBox();
            label3 = new Label();
            txtParola = new TextBox();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(171, 37);
            label1.Name = "label1";
            label1.Size = new Size(399, 42);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ OTOMASYONU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 146);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı adı:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(290, 180);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(160, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 245);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "Parola:";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(290, 279);
            txtParola.Name = "txtParola";
            txtParola.Size = new Size(160, 27);
            txtParola.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(290, 348);
            button1.Name = "button1";
            button1.Size = new Size(160, 27);
            button1.TabIndex = 5;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Blue;
            linkLabel1.Location = new Point(341, 399);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Kaydol!";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(txtParola);
            Controls.Add(label3);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "GirisEkrani";
            Text = "GirisEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtAdSoyad;
        private Label label3;
        private TextBox txtParola;
        private Button button1;
        private LinkLabel linkLabel1;
    }
}