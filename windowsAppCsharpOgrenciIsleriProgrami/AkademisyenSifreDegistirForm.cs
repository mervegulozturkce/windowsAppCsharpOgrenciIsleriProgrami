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


//bu kısım şimdilik kullanılmıyor.

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class AkademisyenSifreDegistirForm : Form
    {

        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        int akademisyenId;
        public AkademisyenSifreDegistirForm(int _akademisyenId)
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
            akademisyenId = _akademisyenId;

            writeOldpasswordOnTextBox(akademisyenId);
        }

        public void ChangePassword(int akademisyenId)
        {
            string sql = "UPDATE Akademisyen SET Password = @newPassword WHERE Id = @akademisyenId";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@newPassword", txtYeniSifre.Text);
                command.Parameters.AddWithValue("@akademisyenId", akademisyenId);
                contact.Open();
                int rowsAffected = command.ExecuteNonQuery();
                contact.Close();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Şifre başarıyla değiştirildi.");
                }
                else
                {
                    MessageBox.Show("Şifre değiştirme işlemi başarısız oldu.");
                }
            }
        }

        public void writeOldpasswordOnTextBox(int akademisyenId)
        {
            string sql = "SELECT Password FROM Akademisyen WHERE Id = @akademisyenId";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@akademisyenId", akademisyenId);
                adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                contact.Open();
                adapter.Fill(dataTable);
                contact.Close();
                if (dataTable.Rows.Count > 0)
                {
                    DataRow row = dataTable.Rows[0];
                    txtEskiSifre.Text = row["Password"].ToString();
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ChangePassword(akademisyenId);

            Close();
        }
    }
}