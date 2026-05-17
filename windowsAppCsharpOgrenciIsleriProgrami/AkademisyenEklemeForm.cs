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
    public partial class AkademisyenEklemeForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        public AkademisyenEklemeForm()
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
        }

        public void add()
        {
            string sql = "Insert into Akademisyen (Name, Surname, Birthdate, Hometown, Contact, Department, Password) values (@Name,@Surname,@Birthdate,@Hometown,@Contact,@Department,@Password)";
            command = new SqlCommand(sql, contact);
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();

            contact = DataLayer.GetSqlConnection();
            string sql = "Select * from Akademisyen";
            adapter = new SqlDataAdapter(sql, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            MessageBox.Show("Akademisyen ekleniyor...");
            Close();
        }
    }
}
