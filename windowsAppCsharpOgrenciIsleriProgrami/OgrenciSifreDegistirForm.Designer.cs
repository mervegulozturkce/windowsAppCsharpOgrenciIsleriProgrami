namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class OgrenciSifreDegistirForm
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
            txtEskiSifre = new TextBox();
            label2 = new Label();
            txtYeniSifre = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 24);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 0;
            label1.Text = "Güncel şifreniz:";
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(23, 47);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.ReadOnly = true;
            txtEskiSifre.Size = new Size(200, 27);
            txtEskiSifre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 105);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 2;
            label2.Text = "Yeni şifrenizi giriniz:";
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(23, 128);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(200, 27);
            txtYeniSifre.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(57, 3);
            button1.Name = "button1";
            button1.Size = new Size(139, 39);
            button1.TabIndex = 4;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 183);
            panel1.Name = "panel1";
            panel1.Size = new Size(265, 52);
            panel1.TabIndex = 21;
            // 
            // OgrenciSifreDegistirForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 235);
            Controls.Add(panel1);
            Controls.Add(txtYeniSifre);
            Controls.Add(label2);
            Controls.Add(txtEskiSifre);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OgrenciSifreDegistirForm";
            Text = "SifreDegistirForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEskiSifre;
        private Label label2;
        private TextBox txtYeniSifre;
        private Button button1;
        private Panel panel1;
    }
}