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
        }
    }
}

// ikinci hedef ise datagridview'e o öğrenciye ait dersler ve notları yazdırmak
// yani önce derlerden girdiridiğim dersleri resultta id sütüuna alt alta yazdırmak
// sonrasında gridde yazılabilecek kıvama getirmek ve tabiki bunu kaydedebilmek her 
