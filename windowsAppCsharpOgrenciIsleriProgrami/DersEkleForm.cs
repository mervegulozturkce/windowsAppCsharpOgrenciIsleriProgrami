using Microsoft.Data.SqlClient;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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
            contact = DataLayer.GetSqlConnection();
        }
        public void add()
        {
            string sql = "Insert into Class (Name,Code) values (@Name,@Code)";

            command = new SqlCommand(sql, contact);

            command.Parameters.AddWithValue("@Name", textBox1.Text);
            command.Parameters.AddWithValue("@Code", textBox2.Text);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();

        }

        public void add2()
        {
            string sql = "Insert into Results (Name) values (@Name)";

            command = new SqlCommand(sql, contact);

            command.Parameters.AddWithValue("@Name", textBox1.Text);

            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();

            string sql = "Select * from Class";

            adapter = new SqlDataAdapter(sql, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            sended();

            MessageBox.Show("Ders ekleniyor...");

            Close();
        }

        public void sended()
        {
            add2();

            string sql = "Select * from Results";

            adapter = new SqlDataAdapter(sql, contact);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
        }
    }
}
