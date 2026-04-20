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
            string sql = "Select Ad,Soyad,Yaş,Memleket,[Öğrenci Numarası] from Ogrenci where Id=@ogrenciId ";

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
                    textBox8.Text = row["Ad"].ToString();
                    textBox3.Text = row["Soyad"].ToString();
                    textBox6.Text = row["Yaş"].ToString();
                    textBox5.Text = row["Memleket"].ToString();
                    textBox2.Text = row["Öğrenci Numarası"].ToString();
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
            string sql = "UPDATE Ogrenci SET Ad=@Name, Soyad=@Surname, Yaş=@Age, Memleket=@Hometown, [Öğrenci Numarası]=@StudentId WHERE Id=@ogrenciId";
            SqlCommand command = new SqlCommand(sql, contact);

            command.Parameters.AddWithValue("@ogrenciId", ogrenciId);
            command.Parameters.AddWithValue("@Name", textBox8.Text);
            command.Parameters.AddWithValue("@Surname", textBox3.Text);
            command.Parameters.AddWithValue("@Age", int.Parse(textBox6.Text));
            command.Parameters.AddWithValue("@Hometown", textBox5.Text);
            command.Parameters.AddWithValue("@StudentId", textBox2.Text);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili öğrenci güncelleniyor...");
        }
    }
}
