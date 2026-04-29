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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class NotEkleForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;
        int ogrenciId;
        public NotEkleForm(int _ogrenciId)
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
            ogrenciId = _ogrenciId;
        }

        public void list(int ogrenciId)
        {
            string sql = "SELECT Name, Surname FROM Ogrenci WHERE Id = @ogrenciId";

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
                    textBox9.Text = $"{row["Name"].ToString()} {row["Surname"].ToString()}";
                }
            }
        }
        private void NotEkleForm_Load(object sender, EventArgs e)
        {
            list(ogrenciId);
            gridFill();
        }
// buralrdayım
        public void gridFill()
        {
            string sql = "SELECT Midterm,Finals,Homeworks,Quiz,MakeUp,TermGrade FROM Results";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                contact.Open();
                adapter.Fill(dataTable);
                contact.Close();
                dataGridView1.DataSource = dataTable;
            }
        }

    }
}
// result sqlini not ekleye bağlamam gerek
// sonrasında gridde yazılabilecek kıvama getirmek ve tabiki bunu kaydedebilmek her 
