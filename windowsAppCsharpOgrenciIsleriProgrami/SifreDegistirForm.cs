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

namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class SifreDegistirForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        int ogrenciId;
        public SifreDegistirForm(int _ogrenciId)
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
            ogrenciId = _ogrenciId;

            writeOldpasswordOnTextBox(ogrenciId);
        }

        public void ChangePassword(int ogrenciId)
        {
            string sql = "UPDATE Ogrenci SET Password = @newPassword WHERE Id = @ogrenciId";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@newPassword", txtYeniSifre.Text);
                command.Parameters.AddWithValue("@ogrenciId", ogrenciId);
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

        public void writeOldpasswordOnTextBox(int ogrenciId)
        {
            string sql = "SELECT Password FROM Ogrenci WHERE Id = @ogrenciId";

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
                    txtEskiSifre.Text = row["Password"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePassword(ogrenciId);

            Close();
        }
    }
}
