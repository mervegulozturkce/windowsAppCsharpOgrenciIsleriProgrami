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
            string sql = "Select Name,Code from Class where Id=@dersId ";

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
                    textBox1.Text = row["Name"].ToString();
                    textBox2.Text = row["Code"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Class SET Name=@Name,Code=@Code WHERE Id=@dersId";
            SqlCommand command= new SqlCommand(sql,contact);

            command.Parameters.AddWithValue("@dersId", dersId);
            command.Parameters.AddWithValue("@Name", textBox1.Text);
            command.Parameters.AddWithValue("@Code", textBox2.Text);
            contact.Open();
            command.ExecuteNonQuery();
            contact.Close();
            MessageBox.Show("Ders başarıyla güncellendi."); 
        }
    }
}
