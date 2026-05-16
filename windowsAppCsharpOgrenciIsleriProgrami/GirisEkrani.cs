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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class GirisEkrani : Form
    {

        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;


        public GirisEkrani()
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             IfStudent();
             IfLecturer();
        }

        public void IfStudent()
        {
            string username = txtAdSoyad.Text.Trim();
            string password = txtParola.Text.Trim();

            string sql = "SELECT CONCAT(Name, ' ', Surname) AS username FROM Ogrenci  WHERE CONCAT(Name, ' ', Surname) = @username AND Password = @password";
            command = new SqlCommand(sql, contact);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            contact.Open();

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                string retrievedUsername = reader["username"].ToString();
                MessageBox.Show("Giriş başarılı! Hoş geldiniz, " + retrievedUsername + ".");

                int studentId = GetingStudentId();

                NotGoruntulemeForm notGoruntulemeForm = new NotGoruntulemeForm(studentId);
                notGoruntulemeForm.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış. Lütfen tekrar deneyiniz.");
            }

            if (reader != null && !reader.IsClosed)
                reader.Close();

            if (contact.State == ConnectionState.Open)
                contact.Close();
        }

        public void IfLecturer()
        {
            string username = txtAdSoyad.Text.Trim();
            string password = txtParola.Text.Trim();

            string sql = "SELECT CONCAT(Name, ' ', Surname) AS username FROM Akademisyen WHERE CONCAT(Name, ' ', Surname) = @username AND Password = @password";
            command = new SqlCommand(sql, contact);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            contact.Open();

            reader = command.ExecuteReader();

            if (reader.Read())
            {
                string retrievedUsername = reader["username"].ToString();
                MessageBox.Show("Giriş başarılı! Hoş geldiniz, " + retrievedUsername + ".");
                AnaEkranForm anaEkran = new AnaEkranForm();
                anaEkran.Show();

                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı adı veya parola yanlış. Lütfen tekrar deneyiniz.");
            }

            if (reader != null && !reader.IsClosed)
                reader.Close();

            if (contact.State == ConnectionState.Open)
                contact.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KisiEklemeForm kisiEklemeForm = new KisiEklemeForm();
            kisiEklemeForm.Show();
        }

        public int GetingStudentId()
        {
            string username = txtAdSoyad.Text.Trim();
            string password = txtParola.Text.Trim();

            string sql = "SELECT Id FROM Ogrenci WHERE CONCAT(Name, ' ', Surname) = @username AND Password = @password";

            using (SqlConnection localContact = new SqlConnection(contact.ConnectionString))
            {
                command = new SqlCommand(sql, localContact);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                localContact.Open();
              
                using (reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int studentId = Convert.ToInt32(reader["Id"]);
                        this.Hide();

                        return studentId;
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adı veya parola yanlış. Lütfen tekrar deneyiniz.");
                        return -1;
                    }
                }
            }       
        }
    }
}
// butonu çalışır hale getirecm.
// hoca kısmı benim 1 aydır yğraştığım kısma gidecek
// öğrenci kısmı sadece not görüntüleyeck
// sanırım passwordü gizli şekilde eklenebileiyormuş bu şekilde güvenlik açığı oluşuyor
//öğrenci kendini eklerken password ekleyeck
// dün eklediğim tümmmm textboxların adına güncelleme gir.


//öğrenci kaydında sadece bu olacak
//öğretmen öğrenci eklerken random şifre olacak
// öğrenci onu girişte linklabeldan güncelleycek

///////////////buradan aşağısı problemma
// öğretmen öğrenci ekleeymesin???? ama silebilsin???
//öpretmen öğrenci eklerken otomatik şifre girilecek ve bu şifre xıkkım olacak sonra öğrenci değiştrebilecek???? buna zaman kalırsa bakrız.
