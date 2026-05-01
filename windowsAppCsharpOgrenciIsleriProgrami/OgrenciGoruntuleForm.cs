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
        int ogrenciId;
        public OgrenciGoruntuleForm(int _ogrenciId)
        {                
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
            ogrenciId = _ogrenciId;
            list(ogrenciId);
        }

        public void list(int ogrenciId)
        {
            string sql = "Select Name,Surname,Age,Hometown,StudentNumber from Ogrenci where Id=@ogrenciId ";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@ogrenciId", ogrenciId);
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                contact.Open();
                adapter.Fill(dataTable);
                contact.Close();

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    textBox8.Text = row["Name"].ToString();
                    textBox3.Text = row["Surname"].ToString();
                    textBox6.Text = row["Age"].ToString();
                    textBox5.Text = row["Hometown"].ToString();
                    textBox2.Text = row["StudentNumber"].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            string sql = "DELETE FROM Ogrenci WHERE Id=@ogrenciId";
            
            SqlCommand command = new SqlCommand(sql, contact);
            command.Parameters.AddWithValue("@ogrenciId",ogrenciId);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili öğrenci siliniyor...");
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            string sql = "UPDATE Ogrenci SET Name=@Name, Surname=@Surname, Age=@Age, Hometown=@Hometown, StudentNumber =@StudentNumber WHERE Id=@ogrenciId";
            SqlCommand command = new SqlCommand(sql, contact);

            command.Parameters.AddWithValue("@ogrenciId", ogrenciId);
            command.Parameters.AddWithValue("@Name", textBox8.Text);
            command.Parameters.AddWithValue("@Surname", textBox3.Text);
            command.Parameters.AddWithValue("@Age", int.Parse(textBox6.Text));
            command.Parameters.AddWithValue("@Hometown", textBox5.Text);
            command.Parameters.AddWithValue("@StudentNumber", textBox2.Text);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili öğrenci güncelleniyor...");
        }
    }
}
