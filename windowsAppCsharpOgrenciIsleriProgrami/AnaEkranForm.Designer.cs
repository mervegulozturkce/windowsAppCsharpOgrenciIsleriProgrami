namespace windowsAppCsharpOgrenciIsleriProgrami
{
    partial class AnaEkranForm
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
            menuStrip1 = new MenuStrip();
            menuOgrenciList = new ToolStripMenuItem();
            menuDersList = new ToolStripMenuItem();
            bilgiGüncellemeToolStripMenuItem = new ToolStripMenuItem();
            akademisyenEkleToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuOgrenciList, menuDersList, bilgiGüncellemeToolStripMenuItem, akademisyenEkleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuOgrenciList
            // 
            menuOgrenciList.Name = "menuOgrenciList";
            menuOgrenciList.Size = new Size(119, 24);
            menuOgrenciList.Text = "Öğrenci Listesi";
            menuOgrenciList.Click += MenuOgrenciList_Click;
            // 
            // menuDersList
            // 
            menuDersList.Name = "menuDersList";
            menuDersList.Size = new Size(97, 24);
            menuDersList.Text = "Ders Listesi";
            menuDersList.Click += menuDersList_Click;
            // 
            // bilgiGüncellemeToolStripMenuItem
            // 
            bilgiGüncellemeToolStripMenuItem.Name = "bilgiGüncellemeToolStripMenuItem";
            bilgiGüncellemeToolStripMenuItem.Size = new Size(135, 24);
            bilgiGüncellemeToolStripMenuItem.Text = "Bilgi Güncelleme";
            bilgiGüncellemeToolStripMenuItem.Click += bilgiGüncellemeToolStripMenuItem_Click;
            // 
            // akademisyenEkleToolStripMenuItem
            // 
            akademisyenEkleToolStripMenuItem.Name = "akademisyenEkleToolStripMenuItem";
            akademisyenEkleToolStripMenuItem.Size = new Size(142, 24);
            akademisyenEkleToolStripMenuItem.Text = "Akademisyen Ekle";
            akademisyenEkleToolStripMenuItem.Click += akademisyenEkleToolStripMenuItem_Click;
            // 
            // AnaEkranForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "AnaEkranForm";
            Text = "Öğrenci Bilgi Sistemi";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuOgrenciList;
        private ToolStripMenuItem menuDersList;
        private ToolStripMenuItem bilgiGüncellemeToolStripMenuItem;
        private ToolStripMenuItem akademisyenEkleToolStripMenuItem;
    }
}