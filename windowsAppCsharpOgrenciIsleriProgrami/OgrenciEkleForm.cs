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
using System.Data.OleDb;
using Microsoft.Data.SqlClient;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class OgrenciEkleForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        public void add()
        {
            contact = DataLayer.GetSqlConnection();
            string sql = "Insert into Ogrenci (Name,Surname,Age,Hometown,StudentNumber) values (@Name,@Surname,@Age,@Hometown,@StudentNumber)";
            command = new SqlCommand(sql, contact);
            command.Parameters.AddWithValue("@Name", txtAd.Text);
            command.Parameters.AddWithValue("@Surname", txtSoyad.Text);
            command.Parameters.AddWithValue("@Age", txtYas.Text);
            command.Parameters.AddWithValue("@Hometown", txtMemleket.Text);
            command.Parameters.AddWithValue("@StudentNumber", txtNumara.Text);
            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
        }
  
        public OgrenciEkleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();

            contact = DataLayer.GetSqlConnection();
            string sql = "Select * from Ogrenci";
            adapter = new SqlDataAdapter(sql, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            MessageBox.Show("Öğrenci ekleniyor...");
            Close();
        }
    }
}

