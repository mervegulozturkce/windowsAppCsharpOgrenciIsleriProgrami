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
            string sql = "Insert into Class (Name,Code,perMid,perFin,perHom,perQuiz,perMakeUp) values (@Name,@Code,@perMid,@perFin,@perHom,@perQuiz,@perMakeUp)";

            command = new SqlCommand(sql, contact);

            double percentageMidterm = Convert.ToDouble(txtVize.Text);
            double percentageFinal = Convert.ToDouble(txtFinal.Text);
            double percentageHomework = Convert.ToDouble(txtOdev.Text);

            double almostPercentage = percentageMidterm + percentageFinal + percentageHomework;

            if (almostPercentage <= 100)
            {
                double remainingPercentage = 100 - almostPercentage;
                txtQuiz.Text = remainingPercentage.ToString();
            }

            else
            {
                MessageBox.Show("Hatalı giriş yaptınız, tekrar giriniz.");
                return false;
            }

            double percentageQuiz = Convert.ToDouble(txtQuiz.Text);

            command.Parameters.AddWithValue("@Name", txtDersAd.Text);
            command.Parameters.AddWithValue("@Code", txtDersKod.Text);
            command.Parameters.AddWithValue("@perMid", percentageMidterm);
            command.Parameters.AddWithValue("@perFin", percentageFinal);
            command.Parameters.AddWithValue("@perHom", percentageHomework);
            command.Parameters.AddWithValue("@perQuiz", percentageQuiz);
            command.Parameters.AddWithValue("@perMakeUp", percentageFinal);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!add()) return;

            string sql = "Select * from Class";

            adapter = new SqlDataAdapter(sql, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            MessageBox.Show("Ders ekleniyor...");

            Close();
        }
    }
}