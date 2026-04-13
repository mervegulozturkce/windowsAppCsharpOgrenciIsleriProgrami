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
    public partial class NotGoruntuleForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;
        public NotGoruntuleForm()
        {
            InitializeComponent();
        }
        public void list(object entrance)
        {
            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "Select * from OgrenciNot where StudentId LIKE @entrance ";

            SqlCommand command = new SqlCommand(data, contact);
            command.Parameters.AddWithValue("@entrance", "%" + entrance + "%");

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            object entrance = textBox1.Text;
            list(entrance);
        }

        private void NotGoruntuleForm_Load(object sender, EventArgs e)
        {
            list(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "UPDATE OgrenciNot SET StudentId=@StudentId, ClassCode=@ClassCode, Score=@Score WHERE Id=@Id";
            SqlCommand command = new SqlCommand(data, contact);
            command.Parameters.AddWithValue("@Id", textBox5.Text);
            command.Parameters.AddWithValue("@StudentId", textBox2.Text);
            command.Parameters.AddWithValue("@ClassCode", textBox3.Text);
            command.Parameters.AddWithValue("@Score", textBox4.Text);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili öğrencinin notları güncelleniyor...");
            list(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "DELETE FROM OgrenciNot WHERE Id=@Id";

            SqlCommand command = new SqlCommand(data, contact);
            command.Parameters.AddWithValue("@Id", int.Parse(textBox5.Text));

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili öğrencinin seçilen notu siliniyor...");
            list(1);
        }
    }
}
