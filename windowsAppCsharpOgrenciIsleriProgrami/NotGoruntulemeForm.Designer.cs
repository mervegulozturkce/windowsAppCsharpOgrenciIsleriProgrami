namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class NotGoruntulemeForm
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
            txtAdSoyad = new TextBox();
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
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(151, 12);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.ReadOnly = true;
            txtAdSoyad.Size = new Size(189, 27);
            txtAdSoyad.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 15);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 11;
            label10.Text = "Adınız soyadınız:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ResultsList_ClassName, ResultsList_ClassCode, ResultsList_Id, ResultsList_Midterm, ResultsList_Finals, ResultsList_Homeworks, ResultsList_Quiz, ResultsList_MakeUp, ResultsList_TermGrade });
            dataGridView1.Location = new Point(12, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1054, 351);
            dataGridView1.TabIndex = 13;
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
            ResultsList_Id.ReadOnly = true;
            ResultsList_Id.Visible = false;
            ResultsList_Id.Width = 125;
            // 
            // ResultsList_Midterm
            // 
            ResultsList_Midterm.DataPropertyName = "Midterm";
            ResultsList_Midterm.HeaderText = "Vize";
            ResultsList_Midterm.MinimumWidth = 6;
            ResultsList_Midterm.Name = "ResultsList_Midterm";
            ResultsList_Midterm.ReadOnly = true;
            ResultsList_Midterm.Width = 125;
            // 
            // ResultsList_Finals
            // 
            ResultsList_Finals.DataPropertyName = "Finals";
            ResultsList_Finals.HeaderText = "Final";
            ResultsList_Finals.MinimumWidth = 6;
            ResultsList_Finals.Name = "ResultsList_Finals";
            ResultsList_Finals.ReadOnly = true;
            ResultsList_Finals.Width = 125;
            // 
            // ResultsList_Homeworks
            // 
            ResultsList_Homeworks.DataPropertyName = "Homeworks";
            ResultsList_Homeworks.HeaderText = "Ödev";
            ResultsList_Homeworks.MinimumWidth = 6;
            ResultsList_Homeworks.Name = "ResultsList_Homeworks";
            ResultsList_Homeworks.ReadOnly = true;
            ResultsList_Homeworks.Width = 125;
            // 
            // ResultsList_Quiz
            // 
            ResultsList_Quiz.DataPropertyName = "Quiz";
            ResultsList_Quiz.HeaderText = "Quiz";
            ResultsList_Quiz.MinimumWidth = 6;
            ResultsList_Quiz.Name = "ResultsList_Quiz";
            ResultsList_Quiz.ReadOnly = true;
            ResultsList_Quiz.Width = 125;
            // 
            // ResultsList_MakeUp
            // 
            ResultsList_MakeUp.DataPropertyName = "MakeUp";
            ResultsList_MakeUp.HeaderText = "Bütünleme";
            ResultsList_MakeUp.MinimumWidth = 6;
            ResultsList_MakeUp.Name = "ResultsList_MakeUp";
            ResultsList_MakeUp.ReadOnly = true;
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
            // button1
            // 
            button1.Location = new Point(903, 9);
            button1.Name = "button1";
            button1.Size = new Size(151, 26);
            button1.TabIndex = 14;
            button1.Text = "Şifre Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // NotGoruntulemeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 443);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(txtAdSoyad);
            Controls.Add(label10);
            Name = "NotGoruntulemeForm";
            Text = "NotGoruntulemeForm";
            Load += NotGoruntulemeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAdSoyad;
        private Label label10;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ResultsList_ClassName;
        private DataGridViewTextBoxColumn ResultsList_ClassCode;
        private DataGridViewTextBoxColumn ResultsList_Id;
        private DataGridViewTextBoxColumn ResultsList_Midterm;
        private DataGridViewTextBoxColumn ResultsList_Finals;
        private DataGridViewTextBoxColumn ResultsList_Homeworks;
        private DataGridViewTextBoxColumn ResultsList_Quiz;
        private DataGridViewTextBoxColumn ResultsList_MakeUp;
        private DataGridViewTextBoxColumn ResultsList_TermGrade;
        private Button button1;
    }
}