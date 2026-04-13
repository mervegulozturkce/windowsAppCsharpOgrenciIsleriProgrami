using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class NotEkleForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;
        public NotEkleForm()
        {
            InitializeComponent();
        }
        public void add()
        {
            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "Insert into OgrenciNot (StudentId,ClassCode,Score) values (@StudentId,@ClassCode,@Score)";
            command = new SqlCommand(data, contact);
            command.Parameters.AddWithValue("@StudentId", textBox1.Text);
            command.Parameters.AddWithValue("@ClassCode", textBox2.Text);
            command.Parameters.AddWithValue("@Score", textBox3.Text);
            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();

            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "Select * from OgrenciNot";
            adapter = new SqlDataAdapter(data, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            MessageBox.Show("İlgili öğrenciye not ekleniyor...");
            Close();
        }

    }
}