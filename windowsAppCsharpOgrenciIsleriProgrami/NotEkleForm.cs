using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            string sql = @"
            INSERT INTO Results (StudentId, ClassId)
            SELECT @StudentId, C.Id   
            FROM Class C
            WHERE C.Id NOT IN (SELECT ClassId FROM Results WHERE StudentId = @StudentId)";

            command = new SqlCommand(sql, contact);
            command.Parameters.AddWithValue("@StudentId", ogrenciId);
            contact.Open();
            int rowsAffected = command.ExecuteNonQuery();
            contact.Close();
            Console.WriteLine($"{rowsAffected} satır eklendi.");
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
                decimal Final = row["Finals"] != DBNull.Value ? Convert.ToDecimal(row["Finals"]) : 0;
                decimal Homeworks = row["Homeworks"] != DBNull.Value ? Convert.ToDecimal(row["Homeworks"]) : 0;
                decimal Quiz = row["Quiz"] != DBNull.Value ? Convert.ToDecimal(row["Quiz"]) : 0;
                decimal MakeUp = row["MakeUp"] != DBNull.Value ? Convert.ToDecimal(row["MakeUp"]) : 0;

                if (row["Id"] == DBNull.Value) continue;

                int id = Convert.ToInt32(row["Id"]);
                string sql = "UPDATE Results SET Midterm = @Midterm, Finals = @Finals, Homeworks = @Homeworks, Quiz = @Quiz, MakeUp = @MakeUp WHERE Id=@id";
                using (SqlCommand command = new SqlCommand(sql, contact))
                {
                    command.Parameters.AddWithValue("@Midterm", Midterm);
                    command.Parameters.AddWithValue("@Finals", Final);
                    command.Parameters.AddWithValue("@Homeworks", Homeworks);
                    command.Parameters.AddWithValue("@Quiz", Quiz);
                    command.Parameters.AddWithValue("@MakeUp", MakeUp);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Kaydedildi!");

            averageCalculate();

            contact.Close();

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

                decimal PerMid, PerFin, PerHom, PerQuiz, PerMakeUp;

                percentageCalc( out PerMid, out PerFin, out PerHom, out PerQuiz, out PerMakeUp);

                if (Finals >= 50)
                {
                    if (MakeUp == null)
                    {
                        decimal average = (Midterm * PerMid / 100) + (Finals * PerFin / 100) + (Homeworks * PerHom / 100) + (Quiz * PerQuiz / 100); row["TermGrade"] = average;
                        averageSave(average, id);
                    }

                    else if (MakeUp != null)
                    {
                        decimal average = (Midterm * PerMid / 100) + (Homeworks * PerHom / 100) + (Quiz * PerQuiz / 100) + (Convert.ToDecimal(MakeUp) * PerMakeUp / 100); row["TermGrade"] = average;
                        averageSave(average, id);
                    }
                }

                else
                {
                    decimal average = (Midterm * PerMid / 100) + (Homeworks * PerHom / 100) + (Quiz * PerQuiz / 100) + (Convert.ToDecimal(MakeUp) * PerMakeUp / 100); row["TermGrade"] = average;
                    averageSave(average, id);
                }

            }
        }

        public void percentageCalc(out decimal PerMid, out decimal PerFin, out decimal PerHom, out decimal PerQuiz, out decimal PerMakeUp)
        {
            PerMid = 0;
            PerFin = 0;
            PerHom = 0;
            PerQuiz = 0;
            PerMakeUp = 0;

            string sql = "SELECT * FROM Class WHERE Id IN (SELECT ClassId FROM Results WHERE StudentId = @ogrenciId)";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@ogrenciId", ogrenciId);
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    PerMid = Convert.ToDecimal(row["PerMid"]);
                    PerFin = Convert.ToDecimal(row["PerFin"]);
                    PerHom = Convert.ToDecimal(row["PerHom"]);
                    PerQuiz = Convert.ToDecimal(row["PerQuiz"]);
                    PerMakeUp = Convert.ToDecimal(row["PerMakeUp"]);
                }
            }
        }

        public void averageSave(decimal average,int id)
        {
            string sql = "UPDATE Results SET TermGrade=@TermGrade WHERE Id=@id";
            command = new SqlCommand(sql, contact);
            command.Parameters.AddWithValue("@TermGrade", average);
            command.Parameters.AddWithValue("@id", id);

            command.ExecuteNonQuery();
        }
    }
}