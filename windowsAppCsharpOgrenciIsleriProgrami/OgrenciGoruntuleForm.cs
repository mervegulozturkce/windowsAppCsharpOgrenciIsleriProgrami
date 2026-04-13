using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class OgrenciGoruntuleForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        public void list(object entrance)
        {
            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "Select * from Ogrenci where " +
                "StudentId LIKE @entrance OR " +
                "Name LIKE @entrance OR " +
                "Surname LIKE @entrance OR " +
               "Age LIKE @entrance OR " +
                "Hometown LIKE @entrance ";

            SqlCommand command = new SqlCommand(data, contact);
            command.Parameters.AddWithValue("@entrance", "%" + entrance + "%");

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }
        public OgrenciGoruntuleForm()
        {
            InitializeComponent();
        }

        private void OgrenciGoruntuleForm_Load(object sender, EventArgs e)
        {
            list(1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            object entrance = textBox1.Text;
            list(entrance);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "DELETE FROM Ogrenci WHERE Id=@Id";

            SqlCommand command = new SqlCommand(data, contact);
            command.Parameters.AddWithValue("@Id", int.Parse(textBox4.Text));

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili öğrenci siliniyor...");
            list(1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "UPDATE Ogrenci SET Name=@Name, Surname=@Surname, Age=@Age, Hometown=@Hometown, StudentId=@StudentId WHERE Id=@Id";
            SqlCommand command = new SqlCommand(data, contact);
            command.Parameters.AddWithValue("@Id", int.Parse(textBox4.Text));
            command.Parameters.AddWithValue("@Name", textBox8.Text);
            command.Parameters.AddWithValue("@Surname", textBox3.Text);
            command.Parameters.AddWithValue("@Age", int.Parse(textBox6.Text));
            command.Parameters.AddWithValue("@Hometown", textBox5.Text);
            command.Parameters.AddWithValue("@StudentId", textBox2.Text);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili öğrenci güncelleniyor...");
            list(1);

        }
    }
}
