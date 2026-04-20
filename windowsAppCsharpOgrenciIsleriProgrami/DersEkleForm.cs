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
        }
        public void add()
        {
            contact = DataLayer.GetSqlConnection();
            string sql = "Insert into Ders ([Dersin Adı],[Dersin Kodu]) values (@ClassName,@ClassCode)";
            command = new SqlCommand(sql, contact);
            command.Parameters.AddWithValue("@ClassName", textBox1.Text);
            command.Parameters.AddWithValue("@ClassCode", textBox2.Text);
            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();

            contact = DataLayer.GetSqlConnection();
            string sql = "Select * from Ders";
            adapter = new SqlDataAdapter(sql, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            MessageBox.Show("Ders ekleniyor...");
            Close();
        }
    }
}
