using Microsoft.Data.SqlClient;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowsAppCsharpOgrenciIsleriProgrami;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class DersEkleForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;
        public DersEkleForm()
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
        }
        public bool add()
        {
            string sql = "Insert into Class (Name,Code,perMid,perFin,perHom,perQuiz) values (@Name,@Code,@perMid,@perFin,@perHom,@perQuiz)";

            command = new SqlCommand(sql, contact);

            double percentageMidterm = Convert.ToDouble(textBox3.Text);
            double percentageFinal = Convert.ToDouble(textBox4.Text);
            double percentageHomework = Convert.ToDouble(textBox5.Text);
            double percentageQuiz = Convert.ToDouble(textBox6.Text);

            double almostPercentage = percentageMidterm + percentageFinal + percentageHomework;

            if (almostPercentage <= 100)
            {
                double remainingPercentage = 100 - almostPercentage;
                textBox6.Text = remainingPercentage.ToString();
            }

            else
            {
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                MessageBox.Show("Hatalı giriş yaptınız, tekrar giriniz.");
                return false;
            }

            command.Parameters.AddWithValue("@Name", textBox1.Text);
            command.Parameters.AddWithValue("@Code", textBox2.Text);
            command.Parameters.AddWithValue("@perMid", percentageMidterm);
            command.Parameters.AddWithValue("@perFin", percentageFinal);
            command.Parameters.AddWithValue("@perHom", percentageHomework);

            problemWithTextBox6();

            //command.Parameters.AddWithValue("@perQuiz", percentageQuiz);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(!add()) return;

            string sql = "Select * from Class";

            adapter = new SqlDataAdapter(sql, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            MessageBox.Show("Ders ekleniyor...");

            Close();       
        }
        public void problemWithTextBox6()
        {
            string sql= "Insert into Class (perQuiz) values (@perQuiz)";

            double percentageQuiz = Convert.ToDouble(textBox6.Text);
            command.Parameters.AddWithValue("@perQuiz", percentageQuiz);
        }
    }
}