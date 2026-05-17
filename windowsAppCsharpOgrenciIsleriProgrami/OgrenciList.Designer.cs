namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class OgrenciList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            studentList = new DataGridView();
            studentList_Id = new DataGridViewTextBoxColumn();
            studentList_StudentNumber = new DataGridViewTextBoxColumn();
            studentList_Name = new DataGridViewTextBoxColumn();
            studentList_Surname = new DataGridViewTextBoxColumn();
            studentList_Birthdate = new DataGridViewTextBoxColumn();
            studentList_Hometown = new DataGridViewTextBoxColumn();
            button4 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 62);
            panel1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(332, 18);
            button3.Name = "button3";
            button3.Size = new Size(154, 30);
            button3.TabIndex = 9;
            button3.Text = "Not ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 18);
            button2.Name = "button2";
            button2.Size = new Size(154, 30);
            button2.TabIndex = 8;
            button2.Text = "Öğrenci Görüntüle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(6, 18);
            button1.Name = "button1";
            button1.Size = new Size(154, 30);
            button1.TabIndex = 7;
            button1.Text = "Öğrenci Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // studentList
            // 
            studentList.AllowUserToAddRows = false;
            studentList.AllowUserToDeleteRows = false;
            studentList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            studentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentList.Columns.AddRange(new DataGridViewColumn[] { studentList_Id, studentList_StudentNumber, studentList_Name, studentList_Surname, studentList_Birthdate, studentList_Hometown });
            studentList.Location = new Point(0, 62);
            studentList.MultiSelect = false;
            studentList.Name = "studentList";
            studentList.ReadOnly = true;
            studentList.RowHeadersWidth = 51;
            studentList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            studentList.Size = new Size(805, 266);
            studentList.TabIndex = 10;
            // 
            // studentList_Id
            // 
            studentList_Id.DataPropertyName = "Id";
            studentList_Id.HeaderText = "Id";
            studentList_Id.MinimumWidth = 6;
            studentList_Id.Name = "studentList_Id";
            studentList_Id.ReadOnly = true;
            studentList_Id.Width = 125;
            // 
            // studentList_StudentNumber
            // 
            studentList_StudentNumber.DataPropertyName = "StudentNumber";
            studentList_StudentNumber.HeaderText = "Öğrenci Numarası";
            studentList_StudentNumber.MinimumWidth = 6;
            studentList_StudentNumber.Name = "studentList_StudentNumber";
            studentList_StudentNumber.ReadOnly = true;
            studentList_StudentNumber.Width = 125;
            // 
            // studentList_Name
            // 
            studentList_Name.DataPropertyName = "Name";
            studentList_Name.HeaderText = "Ad";
            studentList_Name.MinimumWidth = 6;
            studentList_Name.Name = "studentList_Name";
            studentList_Name.ReadOnly = true;
            studentList_Name.Width = 125;
            // 
            // studentList_Surname
            // 
            studentList_Surname.DataPropertyName = "Surname";
            studentList_Surname.HeaderText = "Soyad";
            studentList_Surname.MinimumWidth = 6;
            studentList_Surname.Name = "studentList_Surname";
            studentList_Surname.ReadOnly = true;
            studentList_Surname.Width = 125;
            // 
            // studentList_Birthdate
            // 
            studentList_Birthdate.DataPropertyName = "Birthdate";
            studentList_Birthdate.HeaderText = "Doğum Tarihi";
            studentList_Birthdate.MinimumWidth = 6;
            studentList_Birthdate.Name = "studentList_Birthdate";
            studentList_Birthdate.ReadOnly = true;
            studentList_Birthdate.Width = 125;
            // 
            // studentList_Hometown
            // 
            studentList_Hometown.DataPropertyName = "Hometown";
            studentList_Hometown.HeaderText = "Memleket";
            studentList_Hometown.MinimumWidth = 6;
            studentList_Hometown.Name = "studentList_Hometown";
            studentList_Hometown.ReadOnly = true;
            studentList_Hometown.Width = 125;
            // 
            // button4
            // 
            button4.Location = new Point(492, 18);
            button4.Name = "button4";
            button4.Size = new Size(154, 30);
            button4.TabIndex = 10;
            button4.Text = "Öğrenci Sil";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // OgrenciList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 328);
            Controls.Add(studentList);
            Controls.Add(panel1);
            Name = "OgrenciList";
            Text = "Ögrenci Listesi";
            Load += AnaEkranForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView studentList;
        private DataGridViewTextBoxColumn studentList_Id;
        private DataGridViewTextBoxColumn studentList_StudentNumber;
        private DataGridViewTextBoxColumn studentList_Name;
        private DataGridViewTextBoxColumn studentList_Surname;
        private DataGridViewTextBoxColumn studentList_Birthdate;
        private DataGridViewTextBoxColumn studentList_Hometown;
        private Button button4;
    }
}
