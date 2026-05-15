namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class DersEkleForm
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
            txtDersAd = new TextBox();
            label2 = new Label();
            txtDersKod = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtVize = new TextBox();
            txtFinal = new TextBox();
            txtOdev = new TextBox();
            txtQuiz = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 20);
            label1.TabIndex = 0;
            label1.Text = "Eklemek istediğiniz dersin adını giriniz:";
            // 
            // txtDersAd
            // 
            txtDersAd.Location = new Point(12, 32);
            txtDersAd.Name = "txtDersAd";
            txtDersAd.Size = new Size(214, 27);
            txtDersAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(256, 20);
            label2.TabIndex = 2;
            label2.Text = "Adını girdiğiniz dersin kodunu giriniz:";
            // 
            // txtDersKod
            // 
            txtDersKod.Location = new Point(12, 89);
            txtDersKod.Name = "txtDersKod";
            txtDersKod.Size = new Size(214, 27);
            txtDersKod.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(420, 55);
            button1.Name = "button1";
            button1.Size = new Size(121, 31);
            button1.TabIndex = 4;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(495, 20);
            label3.TabIndex = 5;
            label3.Text = "Dersin dönem sonu ortalamasına vizenin yüzde kaç etki edeceğini yazınız:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 285);
            label5.Name = "label5";
            label5.Size = new Size(494, 20);
            label5.TabIndex = 7;
            label5.Text = "Dersin dönem sonu ortalamasına ödevin yüzde kaç etki edeceğini yazınız:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 353);
            label6.Name = "label6";
            label6.Size = new Size(489, 20);
            label6.TabIndex = 8;
            label6.Text = "Dersin dönem sonu ortalamasına quizin yüzde kaç etki edeceğini yazınız:";
            // 
            // txtVize
            // 
            txtVize.Location = new Point(12, 162);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(214, 27);
            txtVize.TabIndex = 9;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(12, 243);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(214, 27);
            txtFinal.TabIndex = 10;
            // 
            // txtOdev
            // 
            txtOdev.Location = new Point(12, 308);
            txtOdev.Name = "txtOdev";
            txtOdev.Size = new Size(214, 27);
            txtOdev.TabIndex = 11;
            // 
            // txtQuiz
            // 
            txtQuiz.Location = new Point(12, 376);
            txtQuiz.Name = "txtQuiz";
            txtQuiz.ReadOnly = true;
            txtQuiz.Size = new Size(214, 27);
            txtQuiz.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(513, 139);
            label7.Name = "label7";
            label7.Size = new Size(297, 20);
            label7.TabIndex = 13;
            label7.Text = "(Rakamlarla, sadece sayıyı yazmanız yeterli)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 220);
            label8.Name = "label8";
            label8.Size = new Size(297, 20);
            label8.TabIndex = 14;
            label8.Text = "(Rakamlarla, sadece sayıyı yazmanız yeterli)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(512, 285);
            label9.Name = "label9";
            label9.Size = new Size(297, 20);
            label9.TabIndex = 15;
            label9.Text = "(Rakamlarla, sadece sayıyı yazmanız yeterli)";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(507, 353);
            label10.Name = "label10";
            label10.Size = new Size(297, 20);
            label10.TabIndex = 16;
            label10.Text = "(Rakamlarla, sadece sayıyı yazmanız yeterli)";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 200);
            label11.Name = "label11";
            label11.Size = new Size(768, 20);
            label11.TabIndex = 18;
            label11.Text = "Dersin dönem sonu ortalamasına finalin yüzde kaç etki edeceğini yazınız:(Bütünleme de aynı oranda etkileyecektir.)";
            // 
            // DersEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 467);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtQuiz);
            Controls.Add(txtOdev);
            Controls.Add(txtFinal);
            Controls.Add(txtVize);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(txtDersKod);
            Controls.Add(label2);
            Controls.Add(txtDersAd);
            Controls.Add(label1);
            Name = "DersEkleForm";
            Text = "DersEkleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDersAd;
        private Label label2;
        private TextBox txtDersKod;
        private Button button1;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox txtVize;
        private TextBox txtFinal;
        private TextBox txtOdev;
        private TextBox txtQuiz;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}