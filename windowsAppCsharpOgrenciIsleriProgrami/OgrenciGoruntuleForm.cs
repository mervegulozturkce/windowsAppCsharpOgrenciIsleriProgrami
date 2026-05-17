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
            string sql = "Select Name,Surname,Birthdate,Hometown,StudentNumber from Ogrenci where Id=@ogrenciId ";

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
                    txtAd.Text = row["Name"].ToString();
                    txtSoyad.Text = row["Surname"].ToString();
                    txtDogumTarihi.Text = row["Birthdate"].ToString();
                    txtMemleket.Text = row["Hometown"].ToString();
                    txtNumara.Text = row["StudentNumber"].ToString();
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
            string sql = "UPDATE Ogrenci SET Name=@Name, Surname=@Surname, Birthdate=@Birthdate, Hometown=@Hometown, StudentNumber =@StudentNumber WHERE Id=@ogrenciId";
            SqlCommand command = new SqlCommand(sql, contact);

            command.Parameters.AddWithValue("@ogrenciId", ogrenciId);
            command.Parameters.AddWithValue("@Name", txtAd.Text);
            command.Parameters.AddWithValue("@Surname", txtSoyad.Text);
            command.Parameters.AddWithValue("@Birthdate", txtDogumTarihi.Text);
            command.Parameters.AddWithValue("@Hometown", txtMemleket.Text);
            command.Parameters.AddWithValue("@StudentNumber", txtNumara.Text);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("İlgili öğrenci güncelleniyor...");
        }
    }
}
