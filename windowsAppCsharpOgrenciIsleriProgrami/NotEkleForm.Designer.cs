namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class NotEkleForm
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
            label10 = new Label();
            dataGridView1 = new DataGridView();
            ResultsList_ClassName = new DataGridViewTextBoxColumn();
            ResultsList_ClassCode = new DataGridViewTextBoxColumn();
            ResultsList_Id = new DataGridViewTextBoxColumn();
            ResultsList_Midterm = new DataGridViewTextBoxColumn();
            ResultsList_Finals = new DataGridViewTextBoxColumn();
            ResultsList_Homeworks = new DataGridViewTextBoxColumn();
            ResultsList_Quiz = new DataGridViewTextBoxColumn();
            ResultsList_MakeUp = new DataGridViewTextBoxColumn();
            ResultsList_TermGrade = new DataGridViewTextBoxColumn();
            textBox9 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 9);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 8;
            label10.Text = "Öğrenci:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ResultsList_ClassName, ResultsList_ClassCode, ResultsList_Id, ResultsList_Midterm, ResultsList_Finals, ResultsList_Homeworks, ResultsList_Quiz, ResultsList_MakeUp, ResultsList_TermGrade });
            dataGridView1.Location = new Point(12, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1054, 351);
            dataGridView1.TabIndex = 9;
            // 
            // ResultsList_ClassName
            // 
            ResultsList_ClassName.DataPropertyName = "ClassName";
            ResultsList_ClassName.HeaderText = "Ders Adı";
            ResultsList_ClassName.MinimumWidth = 6;
            ResultsList_ClassName.Name = "ResultsList_ClassName";
            ResultsList_ClassName.ReadOnly = true;
            ResultsList_ClassName.Width = 125;
            // 
            // ResultsList_ClassCode
            // 
            ResultsList_ClassCode.DataPropertyName = "ClassCode";
            ResultsList_ClassCode.HeaderText = "Ders Kodu";
            ResultsList_ClassCode.MinimumWidth = 6;
            ResultsList_ClassCode.Name = "ResultsList_ClassCode";
            ResultsList_ClassCode.ReadOnly = true;
            ResultsList_ClassCode.Width = 125;
            // 
            // ResultsList_Id
            // 
            ResultsList_Id.DataPropertyName = "Id";
            ResultsList_Id.HeaderText = "Id";
            ResultsList_Id.MinimumWidth = 6;
            ResultsList_Id.Name = "ResultsList_Id";
            ResultsList_Id.Visible = false;
            ResultsList_Id.Width = 125;
            // 
            // ResultsList_Midterm
            // 
            ResultsList_Midterm.DataPropertyName = "Midterm";
            ResultsList_Midterm.HeaderText = "Vize";
            ResultsList_Midterm.MinimumWidth = 6;
            ResultsList_Midterm.Name = "ResultsList_Midterm";
            ResultsList_Midterm.Width = 125;
            // 
            // ResultsList_Finals
            // 
            ResultsList_Finals.DataPropertyName = "Finals";
            ResultsList_Finals.HeaderText = "Final";
            ResultsList_Finals.MinimumWidth = 6;
            ResultsList_Finals.Name = "ResultsList_Finals";
            ResultsList_Finals.Width = 125;
            // 
            // ResultsList_Homeworks
            // 
            ResultsList_Homeworks.DataPropertyName = "Homeworks";
            ResultsList_Homeworks.HeaderText = "Ödev";
            ResultsList_Homeworks.MinimumWidth = 6;
            ResultsList_Homeworks.Name = "ResultsList_Homeworks";
            ResultsList_Homeworks.Width = 125;
            // 
            // ResultsList_Quiz
            // 
            ResultsList_Quiz.DataPropertyName = "Quiz";
            ResultsList_Quiz.HeaderText = "Quiz";
            ResultsList_Quiz.MinimumWidth = 6;
            ResultsList_Quiz.Name = "ResultsList_Quiz";
            ResultsList_Quiz.Width = 125;
            // 
            // ResultsList_MakeUp
            // 
            ResultsList_MakeUp.DataPropertyName = "MakeUp";
            ResultsList_MakeUp.HeaderText = "Bütünleme";
            ResultsList_MakeUp.MinimumWidth = 6;
            ResultsList_MakeUp.Name = "ResultsList_MakeUp";
            ResultsList_MakeUp.Width = 125;
            // 
            // ResultsList_TermGrade
            // 
            ResultsList_TermGrade.DataPropertyName = "TermGrade";
            ResultsList_TermGrade.HeaderText = "Not Ortalaması";
            ResultsList_TermGrade.MinimumWidth = 6;
            ResultsList_TermGrade.Name = "ResultsList_TermGrade";
            ResultsList_TermGrade.ReadOnly = true;
            ResultsList_TermGrade.Width = 125;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(109, 6);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(189, 27);
            textBox9.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(548, 406);
            button1.Name = "button1";
            button1.Size = new Size(152, 33);
            button1.TabIndex = 11;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NotEkleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 450);
            Controls.Add(button1);
            Controls.Add(textBox9);
            Controls.Add(dataGridView1);
            Controls.Add(label10);
            Name = "NotEkleForm";
            Text = "NotEkleForm";
            Load += NotEkleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private DataGridView dataGridView1;
        private TextBox textBox9;
        private DataGridViewTextBoxColumn ResultsList_Code;
        private Button button1;
        private DataGridViewTextBoxColumn ResultsList_ClassName;
        private DataGridViewTextBoxColumn ResultsList_ClassCode;
        private DataGridViewTextBoxColumn ResultsList_Id;
        private DataGridViewTextBoxColumn ResultsList_Midterm;
        private DataGridViewTextBoxColumn ResultsList_Finals;
        private DataGridViewTextBoxColumn ResultsList_Homeworks;
        private DataGridViewTextBoxColumn ResultsList_Quiz;
        private DataGridViewTextBoxColumn ResultsList_MakeUp;
        private DataGridViewTextBoxColumn ResultsList_TermGrade;
    }
}