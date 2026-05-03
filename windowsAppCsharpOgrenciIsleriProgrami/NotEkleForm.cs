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
            gridFill(ogrenciId);
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

        private void button1_Click(object sender, EventArgs e)
        {
            contact.Open();

            var dataSource = dataGridView1.DataSource as DataTable;

            foreach (DataRow row in dataSource.Rows)
            {
                decimal Midterm = row["Midterm"] != DBNull.Value ? Convert.ToDecimal(row["Midterm"]) : 0;
                decimal Finals = row["Finals"] != DBNull.Value ? Convert.ToDecimal(row["Finals"]) : 0;
                decimal Homeworks = row["Homeworks"] != DBNull.Value ? Convert.ToDecimal(row["Homeworks"]) : 0;
                decimal Quiz = row["Quiz"] != DBNull.Value ? Convert.ToDecimal(row["Quiz"]) : 0;
                var MakeUp = row["MakeUp"];

                if (row["Id"] == DBNull.Value) continue;

                int id = Convert.ToInt32(row["Id"]);
                string sql = "UPDATE Results SET Midterm = @Midterm, Finals = @Finals, Homeworks = @Homeworks, Quiz = @Quiz, MakeUp = @MakeUp WHERE Id=@id";
                using (SqlCommand command = new SqlCommand(sql, contact))
                {
                    command.Parameters.AddWithValue("@Midterm", Midterm);
                    command.Parameters.AddWithValue("@Finals", Finals);
                    command.Parameters.AddWithValue("@Homeworks", Homeworks);
                    command.Parameters.AddWithValue("@Quiz", Quiz);
                    command.Parameters.AddWithValue("@MakeUp", MakeUp);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
            contact.Close();

            MessageBox.Show("Kaydedildi!");

            averageCalculate();

            gridFill(ogrenciId);

        }

        public void averageCalculate()
        {
            var dataSource = dataGridView1.DataSource as DataTable;

            foreach (DataRow row in dataSource.Rows)
            {
                int id = Convert.ToInt32(row["Id"]);
                string sql = "SELECT (Midterm,Finals,Homeworks,Quiz,MakeUp) FROM Results WHERE Id=@id";

                decimal Midterm = row["Midterm"] != DBNull.Value ? Convert.ToDecimal(row["Midterm"]) : 0;
                decimal Finals = row["Finals"] != DBNull.Value ? Convert.ToDecimal(row["Finals"]) : 0;
                decimal Homeworks = row["Homeworks"] != DBNull.Value ? Convert.ToDecimal(row["Homeworks"]) : 0;
                decimal Quiz = row["Quiz"] != DBNull.Value ? Convert.ToDecimal(row["Quiz"]) : 0;
                decimal MakeUp = row["MakeUp"] != DBNull.Value ? Convert.ToDecimal(row["MakeUp"]) : 0;

                if(Finals>=50)
                {
                    if (Finals >= 50 && MakeUp == null)
                    {
                        decimal average = (Midterm * 0.3m) + (Finals * 0.4m) + (Homeworks * 0.1m) + (Quiz * 0.1m); row["TermGrade"] = average;
                        averageSave(average, id);
                    }

                    else if (Finals >= 50 && MakeUp != null)
                    {
                        decimal average = (Midterm * 0.3m) + (Homeworks * 0.1m) + (Quiz * 0.1m) + (MakeUp * 0.4m); row["TermGrade"] = average;
                        averageSave(average,id);
                    }
                }

                else
                {
                    decimal average = (Midterm * 0.3m) + (Homeworks * 0.1m) + (Quiz * 0.1m) + (MakeUp * 0.4m); row["TermGrade"] = average;
                    averageSave(average,id);
                }
            }
        }

        public void averageSave(decimal average,int id)
        {
            string sql = "UPDATE Results SET TermGrade=@TermGrade WHERE Id=@id";
            command = new SqlCommand(sql, contact);
            command.Parameters.AddWithValue("@TermGrade", average);
            command.Parameters.AddWithValue("@id", id);
            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
        }
    }
}
