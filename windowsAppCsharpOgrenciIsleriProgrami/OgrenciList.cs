using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class OgrenciList : Form
    {
        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;
        public OgrenciList()
        {
            InitializeComponent();
        }

        public void list()
        {
            contact = DataLayer.GetSqlConnection();
            string data = "SELECT * FROM Ogrenci ";

            SqlCommand command = new SqlCommand(data, contact);

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkleForm form2 = new OgrenciEkleForm();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int ogrenciId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;

                OgrenciGoruntuleForm form3 = new OgrenciGoruntuleForm(ogrenciId);
                form3.ShowDialog();
            }
        }

        private void AnaEkranForm_Load(object sender, EventArgs e)
        {
            list();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NotEkleForm form4 = new NotEkleForm();
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotGoruntuleForm form5 = new NotGoruntuleForm();
            form5.ShowDialog();
        }
    }
}



