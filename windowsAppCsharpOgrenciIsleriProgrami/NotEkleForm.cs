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
            string sql = "SELECT ClassName, Midterm, Finals, Homeworks, Quiz, MakeUp, TermGrade FROM Results WHERE StudentId = @ogrenciId";

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
            Close();
            MessageBox.Show("Not ekleme işlemi tamamlanıyor...");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

//resultsa gelen derslerin silinmesi güncellenmesi- silmesi gerek
//ders güncelleden güncellediğim dersi resulsta bulunanan dersi de aynı nada güncellemeli-silmeli
// result sqlini not ekleye bağlamam gerek
// sonrasında gridde yazılabilecek kıvama getirmek ve tabiki bunu kaydedebilmek her 

//rsulstaki dders adına satır no yazacak

// not ekledeki gönder butonunu çalıştır


// DERSİN SATIR NOSU RSULTSA GELECEK


//////////////////// butonu çlaışı hael getir