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

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class AkademisyenGuncellemeForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        int akademisyenId;
        public AkademisyenGuncellemeForm(int _akademisyenId)
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();

            akademisyenId = _akademisyenId;

            list(akademisyenId);
        }

        public void list(int akademisyenId)
        {
            string sql = "Select Name, Surname, Birthdate, Hometown, Contact, Department, Password from Akademisyen where Id=@akademisyenId ";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@akademisyenId", akademisyenId);
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                contact.Open();
                adapter.Fill(dataTable);
                contact.Close();

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    txtAd.Text = row["Name"].ToString();
                    txtSoyad.Text = row["Surname"].ToString();
                    txtDogumTarihi.Text = row["Birthdate"].ToString();
                    txtMemleket.Text = row["Hometown"].ToString();
                    txtIletisim.Text= row["Contact"].ToString();
                    txtDepartment.Text = row["Department"].ToString();
                    txtParola.Text = row["Password"].ToString();
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sql = "UPDATE Akademisyen SET Name=@Name, Surname=@Surname, Birthdate=@Birthdate, Hometown=@Hometown, Contact=@Contact, Department=@Department, Password=@Password WHERE Id=@akademisyenId";
            SqlCommand command = new SqlCommand(sql, contact);

            command.Parameters.AddWithValue("@akademisyenId", akademisyenId);
            command.Parameters.AddWithValue("@Name", txtAd.Text);
            command.Parameters.AddWithValue("@Surname", txtSoyad.Text);
            command.Parameters.AddWithValue("@Birthdate", txtDogumTarihi.Text);
            command.Parameters.AddWithValue("@Hometown", txtMemleket.Text);
            command.Parameters.AddWithValue("@Contact", txtIletisim.Text);
            command.Parameters.AddWithValue("@Department", txtDepartment.Text);
            command.Parameters.AddWithValue("@Password", txtParola.Text);
            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili akademisyen güncelleniyor...");
        }
    }
}

