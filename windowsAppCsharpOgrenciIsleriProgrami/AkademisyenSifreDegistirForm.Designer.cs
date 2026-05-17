namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class AkademisyenSifreDegistirForm
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
            button1 = new Button();
            txtYeniSifre = new TextBox();
            label2 = new Label();
            txtEskiSifre = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 219);
            button1.Name = "button1";
            button1.Size = new Size(139, 39);
            button1.TabIndex = 9;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(25, 141);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(200, 27);
            txtYeniSifre.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 118);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 7;
            label2.Text = "Yeni şifrenizi giriniz:";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(25, 47);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.ReadOnly = true;
            txtEskiSifre.Size = new Size(200, 27);
            txtEskiSifre.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 5;
            label1.Text = "Güncel şifreniz:";
            // 
            // AkademisyenSifreDegistirForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtYeniSifre);
            Controls.Add(label2);
            Controls.Add(txtEskiSifre);
            Controls.Add(label1);
            Name = "AkademisyenSifreDegistirForm";
            Text = "AkademisyenSifreDegistir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtYeniSifre;
        private Label label2;
        private TextBox txtEskiSifre;
        private Label label1;
    }
}