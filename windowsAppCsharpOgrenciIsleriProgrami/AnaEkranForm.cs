using Microsoft.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace windowsAppCsharpOgrenciIsleriProgrami
{
    public partial class AnaEkranForm : Form
    {

        SqlConnection contact;
        SqlCommand command;
        SqlDataAdapter adapter;

        public void list()
        {
            contact = new SqlConnection(@"Server=MERVEGUL\SQL_2025_STD_DEV; Initial Catalog=Ogrenci; Integrated Security=True; TrustServerCertificate=True;");
            string data = "SELECT * FROM Ogrenci ";

            SqlCommand command = new SqlCommand(data, contact);

            adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        public AnaEkranForm()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkleForm form2 = new OgrenciEkleForm();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OgrenciGoruntuleForm form3 = new OgrenciGoruntuleForm();
            form3.ShowDialog();
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



