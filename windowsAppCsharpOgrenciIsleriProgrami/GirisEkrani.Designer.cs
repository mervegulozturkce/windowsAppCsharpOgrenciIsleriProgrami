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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(138, 49);
            label1.Name = "label1";
            label1.Size = new Size(374, 46);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ BİLGİ SİSTEMİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(278, 116);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı adı:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(245, 150);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(160, 27);
            txtAdSoyad.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(298, 193);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "Parola:";
            // 
            // txtParola
            // 
            txtParola.Location = new Point(245, 216);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '*';
            txtParola.Size = new Size(160, 27);
            txtParola.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(245, 278);
            button1.Name = "button1";
            button1.Size = new Size(160, 27);
            button1.TabIndex = 5;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GirisEkrani
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 384);
            Controls.Add(button1);
            Controls.Add(txtParola);
            Controls.Add(label3);
            Controls.Add(txtAdSoyad);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "GirisEkrani";
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
    }
}