using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class OgrenciEkleForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        public OgrenciEkleForm()
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
        }
        public void add()
        { 
            string sql = "Insert into Ogrenci (Name,Surname,Birthdate,Hometown,StudentNumber,Password) values (@Name,@Surname,@Birthdate,@Hometown,@StudentNumber,@Password)";
            command = new SqlCommand(sql, contact);
            command.Parameters.AddWithValue("@Name", txtAd.Text);
            command.Parameters.AddWithValue("@Surname", txtSoyad.Text);
            command.Parameters.AddWithValue("@Birthdate", txtDogumTarihi.Text);
            command.Parameters.AddWithValue("@Hometown", txtMemleket.Text);
            command.Parameters.AddWithValue("@StudentNumber", txtNumara.Text);

            string randomPassword = SecureRandomString();
            command.Parameters.AddWithValue("@Password", randomPassword);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
        }

        string SecureRandomString(int length = 10)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(RandomNumberGenerator.GetItems<char>(chars, length));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            add();

            contact = DataLayer.GetSqlConnection();
            string sql = "Select * from Ogrenci";
            adapter = new SqlDataAdapter(sql, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            writePasswordOnTheTextbox();

            MessageBox.Show("Öğrenci ekleniyor...");

            Close();
        }


        public void writePasswordOnTheTextbox()
        {
            string Name = txtAd.Text;
            string Surname = txtSoyad.Text;
            string Birthdate = txtDogumTarihi.Text;
            string Hometown = txtMemleket.Text;
            string StudentNumber = txtNumara.Text;

            string sql = "SELECT Password FROM Ogrenci WHERE Name = @Name AND Surname = @Surname AND Birthdate = @Birthdate AND Hometown = @Hometown AND StudentNumber = @StudentNumber";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Surname", Surname);
                command.Parameters.AddWithValue("@Birthdate", Birthdate);
                command.Parameters.AddWithValue("@Hometown", Hometown);
                command.Parameters.AddWithValue("@StudentNumber", StudentNumber);
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                contact.Open();
                adapter.Fill(dataTable);
                contact.Close();

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    txtParola.Text = row["Password"].ToString();
                }
            }
        }
    }
}

