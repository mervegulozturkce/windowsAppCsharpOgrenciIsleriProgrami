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
    public partial class AnaEkran : Form
    {
        DersList dersList;
        OgrenciList ogrenciList;
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void MenuOgrenciList_Click(object sender, EventArgs e)
        {
            if(ogrenciList == null || ogrenciList.IsDisposed)
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
    }
}