namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class DersList
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
            classList = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            classList_Id = new DataGridViewTextBoxColumn();
            classList_Name = new DataGridViewTextBoxColumn();
            classList_Code = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)classList).BeginInit();
            SuspendLayout();
            // 
            // classList
            // 
            classList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            classList.Columns.AddRange(new DataGridViewColumn[] { classList_Id, classList_Name, classList_Code });
            classList.Location = new Point(12, 55);
            classList.Name = "classList";
            classList.RowHeadersWidth = 51;
            classList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            classList.Size = new Size(775, 392);
            classList.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 13);
            button1.Name = "button1";
            button1.Size = new Size(164, 30);
            button1.TabIndex = 1;
            button1.Text = "Ders Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(182, 13);
            button2.Name = "button2";
            button2.Size = new Size(164, 30);
            button2.TabIndex = 2;
            button2.Text = "Ders Güncelle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(352, 12);
            button3.Name = "button3";
            button3.Size = new Size(164, 30);
            button3.TabIndex = 3;
            button3.Text = "Ders Sil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // classList_Id
            // 
            classList_Id.DataPropertyName = "Id";
            classList_Id.HeaderText = "Id";
            classList_Id.MinimumWidth = 6;
            classList_Id.Name = "classList_Id";
            classList_Id.ReadOnly = true;
            classList_Id.Width = 125;
            // 
            // classList_Name
            // 
            classList_Name.DataPropertyName = "Name";
            classList_Name.HeaderText = "Ders Adı";
            classList_Name.MinimumWidth = 6;
            classList_Name.Name = "classList_Name";
            classList_Name.Width = 125;
            // 
            // classList_Code
            // 
            classList_Code.DataPropertyName = "Code";
            classList_Code.HeaderText = "Ders Kodu";
            classList_Code.MinimumWidth = 6;
            classList_Code.Name = "classList_Code";
            classList_Code.Width = 125;
            // 
            // DersList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(classList);
            Name = "DersList";
            Text = "DersList";
            FormClosed += DersList_FormClosed;
            Load += DersList_Load;
            ((System.ComponentModel.ISupportInitialize)classList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView classList;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn classList_Id;
        private DataGridViewTextBoxColumn classList_Name;
        private DataGridViewTextBoxColumn classList_Code;
    }
}