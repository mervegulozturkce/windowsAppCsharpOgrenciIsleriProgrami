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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class DersGoruntuleForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;
        int dersId;

        public DersGoruntuleForm(int _dersId)
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
            dersId = _dersId;
            list(dersId);
        }
        public void list(int dersId)
        {
            string sql = "Select Name, Code, PerMid, PerFin, PerHom, PerQuiz from Class where Id=@dersId ";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@dersId", dersId);
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                contact.Open();
                adapter.Fill(dataTable);
                contact.Close();

                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    txtDersAd.Text = row["Name"].ToString();
                    txtDersKod.Text = row["Code"].ToString();
                    txtVize.Text = row["PerMid"].ToString();
                    txtFinal.Text = row["PerFin"].ToString();
                    txtOdev.Text = row["PerHom"].ToString();
                    txtQuiz.Text = row["PerQuiz"].ToString();
                }
            }
        }

        public bool add()
        {
            double percentageMidterm = Convert.ToDouble(txtVize.Text);
            double percentageFinal = Convert.ToDouble(txtFinal.Text);
            double percentageHomework = Convert.ToDouble(txtOdev.Text);
            //double percentageQuiz = Convert.ToDouble(txtQuiz.Text);

            double almostPercentage = percentageMidterm + percentageFinal + percentageHomework;

            if (almostPercentage <= 100)
            {
                double remainingPercentage = 100 - almostPercentage;
                txtQuiz.Text = remainingPercentage.ToString();
            }
            // textbox6 neden kullanıcı girişine açık
            else
            {
                MessageBox.Show("Hatalı giriş yaptınız, tekrar giriniz.");
                return false;
            }

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if(!add()) return;

            string sql = "UPDATE Class SET Name=@Name, Code=@Code, PerMid=@perMid, PerFin=@perFin, PerHom=@perHom, PerQuiz=@perQuiz WHERE Id=@dersId";
            SqlCommand command = new SqlCommand(sql, contact);


            command.Parameters.AddWithValue("@dersId", dersId);
            command.Parameters.AddWithValue("@Name", txtDersAd.Text);
            command.Parameters.AddWithValue("@Code", txtDersKod.Text);
            command.Parameters.AddWithValue("@perMid", Convert.ToDouble(txtVize.Text));
            command.Parameters.AddWithValue("@perFin", Convert.ToDouble(txtFinal.Text));
            command.Parameters.AddWithValue("@perHom", Convert.ToDouble(txtOdev.Text));
            command.Parameters.AddWithValue("@perQuiz", Convert.ToDouble(txtQuiz.Text));
            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();

            MessageBox.Show("Ders başarıyla güncellendi.");

            Close();
        }
    }
}
