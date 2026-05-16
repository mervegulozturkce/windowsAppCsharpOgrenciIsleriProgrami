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
using windowsAppCsharpOgrenciIsleriProgrami;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class NotGoruntulemeForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        int ogrenciId;
        public NotGoruntulemeForm(int _ogrenciId)
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
            ogrenciId = _ogrenciId;
        }

        private void NotGoruntulemeForm_Load(object sender, EventArgs e)
        {
            list(ogrenciId);
            gridFill(ogrenciId);
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
                        txtAdSoyad.Text = $"{row["Name"].ToString()} {row["Surname"].ToString()}";
                    }
                }
        }

        public void gridFill(int ogrenciId)
        {
            string sql = @"Select R.Id, ClassCode=C.Code, C.Name as ClassName,
		                    R.Midterm,R.Finals,R.Homeworks,R.Quiz,R.MakeUp,R.TermGrade
	                    From Results R	
	                    Inner Join Class C on C.Id=R.ClassId WHERE StudentId = @ogrenciId";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@ogrenciId", ogrenciId);
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


