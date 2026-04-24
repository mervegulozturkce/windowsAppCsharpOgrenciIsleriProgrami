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
            studentList.DataSource = dataTable;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            OgrenciEkleForm form2 = new OgrenciEkleForm();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (studentList.CurrentRow != null)
            {
                int ogrenciId = (int)studentList.CurrentRow.Cells["studentList_Id"].Value;

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
            if (studentList.CurrentRow != null)
            {
                int ogrenciId = (int)studentList.CurrentRow.Cells["studentList_ Id"].Value;

                NotEkleForm form4 = new NotEkleForm(ogrenciId);
                form4.ShowDialog();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotGoruntuleForm form5 = new NotGoruntuleForm();
            form5.ShowDialog();
        }
    }
}

// not ekleye týklayýp birde öðrenciye týklayýp not ekleyeck oraya ders kodunu da gireceek
// hatalý kod girerse kayýt etmeyecek messeage box hatasý verecek
// sonra not görüntüleye týklayýp öðrenciye týklayýp o öðrencinin aldýðý tümm notlarý görecek
// bir tane daha sql açmam gerke notlarýn girþiinin olduðu bir sql:)


