namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class NotGoruntuleForm
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
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label6 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(577, 114);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(407, 20);
            label1.TabIndex = 3;
            label1.Text = "Notunu görüntülemek istediğiniz öğrenciye dair bilgi giriniz:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(343, 194);
            label8.Name = "label8";
            label8.Size = new Size(373, 20);
            label8.TabIndex = 21;
            label8.Text = "(Silmek için okul numarası kısmını doldurmanız yeterli!)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 194);
            label2.Name = "label2";
            label2.Size = new Size(325, 20);
            label2.TabIndex = 20;
            label2.Text = "Güncellemek için aşağıdaki bilgileri doldurunuz.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 274);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 22;
            label3.Text = "Öğrencinin okul numarası:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 297);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(180, 27);
            textBox2.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 327);
            label4.Name = "label4";
            label4.Size = new Size(207, 20);
            label4.TabIndex = 24;
            label4.Text = "Öğrencinin aldığı dersin kodu:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 350);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 27);
            textBox3.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 381);
            label5.Name = "label5";
            label5.Size = new Size(238, 20);
            label5.TabIndex = 26;
            label5.Text = "Öğrencinin ilgili dersten aldığı not:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 404);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 27);
            textBox4.TabIndex = 27;
            // 
            // button1
            // 
            button1.Location = new Point(343, 284);
            button1.Name = "button1";
            button1.Size = new Size(120, 30);
            button1.TabIndex = 28;
            button1.Text = "Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(343, 327);
            button2.Name = "button2";
            button2.Size = new Size(120, 30);
            button2.TabIndex = 29;
            button2.Text = "Sil";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 221);
            label6.Name = "label6";
            label6.Size = new Size(255, 20);
            label6.TabIndex = 30;
            label6.Text = "Öğrencinin bulunduğu satır numarası:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 244);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 27);
            textBox5.TabIndex = 31;
            // 
            // NotGoruntuleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 450);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Name = "NotGoruntuleForm";
            Text = "NotGoruntuleForm";
            Load += NotGoruntuleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label8;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Label label6;
        private TextBox textBox5;
    }
}