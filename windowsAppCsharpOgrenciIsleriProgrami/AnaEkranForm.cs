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
    public partial class AnaEkranForm : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        DersList dersList;
        OgrenciList ogrenciList;
        AkademisyenGuncellemeForm akademisyenGuncellemeForm;

        string _username;

        int Id;
        public AnaEkranForm(string username)
        {
            InitializeComponent();
            contact = DataLayer.GetSqlConnection();
            _username = username;
        }
        private void MenuOgrenciList_Click(object sender, EventArgs e)
        {
            if (ogrenciList == null || ogrenciList.IsDisposed)
            {
                ogrenciList = new OgrenciList();
                ogrenciList.MdiParent = this;
                ogrenciList.Show();
            }
        }
        private void menuDersList_Click(object sender, EventArgs e)
        {
            if (dersList == null || dersList.IsDisposed)
            {
                dersList = new DersList();
                dersList.MdiParent = this;
                dersList.Show();

            }
        }
        private void bilgiGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int Id = 0;

            string sql = "SELECT Id FROM Akademisyen WHERE CONCAT(Name, ' ', Surname) = @username";

            using (SqlCommand command = new SqlCommand(sql, contact))
            {
                command.Parameters.AddWithValue("@username", _username);
                contact.Open();

                object result = command.ExecuteScalar();
                if (result != null)
                    Id = Convert.ToInt32(result);

                contact.Close();
            }

            if (akademisyenGuncellemeForm == null || akademisyenGuncellemeForm.IsDisposed)
            {
                akademisyenGuncellemeForm = new AkademisyenGuncellemeForm(Id);
                akademisyenGuncellemeForm.MdiParent = this;
                akademisyenGuncellemeForm.Show();
            }
        }

        private void akademisyenEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AkademisyenEklemeForm akademisyenEklemeForm = new AkademisyenEklemeForm();
            akademisyenEklemeForm.Show();
        }
    }
}