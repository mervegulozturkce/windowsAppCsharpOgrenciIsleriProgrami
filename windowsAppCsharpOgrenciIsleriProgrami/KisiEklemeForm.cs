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
    public partial class KisiEklemeForm : Form
    {
        public KisiEklemeForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OgrencininKendisiniEklemeForm ogrencininKendisiniEklemeForm = new OgrencininKendisiniEklemeForm();
            ogrencininKendisiniEklemeForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AkademisyenEklemeForm akademisyenEklemeForm = new AkademisyenEklemeForm();
            akademisyenEklemeForm.Show();
        }
    }
}
