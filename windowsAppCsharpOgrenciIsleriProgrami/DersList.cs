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
    public partial class DersList : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        public DersList()
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
        }
        public void list()
        {
            contact = DataLayer.GetSqlConnection();
            string data = "SELECT * FROM Class";

            SqlCommand command = new SqlCommand(data, contact);

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            classList.DataSource = dataTable;
        }

        private void DersList_Load(object sender, EventArgs e)
        {
            list();
        }

        //ekle
        private void button1_Click(object sender, EventArgs e)
        {
            DersEkleForm form8 = new DersEkleForm();
            form8.ShowDialog();
        }

        //güncelle
        private void button2_Click(object sender, EventArgs e)
        {
            if (classList.CurrentRow != null)
            {
                int dersId = (int)classList.CurrentRow.Cells["classList_Id"].Value;
                DersGoruntuleForm form7 = new DersGoruntuleForm(dersId);
                form7.ShowDialog();
            }
        }

        //sil

        private void button3_Click(object sender, EventArgs e)
        {
            if (classList.CurrentRow != null)
            {
                int dersId = (int)classList.CurrentRow.Cells["classList_Id"].Value;
                string sql = "DELETE FROM Class WHERE Id=@dersId";

                deleteFromResults(dersId);
               
                SqlCommand command = new SqlCommand(sql, contact);
                command.Parameters.AddWithValue("@dersId", dersId);
                contact.Open();
                command.ExecuteNonQuery();
                contact.Close();
                //delete();
                MessageBox.Show("Ders başarıyla silindi.");
            }
        }

        public void deleteFromResults(int dersId)
        {
            if (classList.CurrentRow != null)
            {
                string sql = "DELETE FROM Results WHERE ClassId=@dersId";
                SqlCommand command = new SqlCommand(sql, contact);
                command.Parameters.AddWithValue("@dersId", dersId);
                contact.Open();
                command.ExecuteNonQuery();
                contact.Close();
            }
        }

      

        private void DersList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}
