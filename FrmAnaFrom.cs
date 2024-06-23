using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityUrun
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

       
        private void btn_Katagori_Click(object sender, EventArgs e)
        {
            FrmKatagori frm = new FrmKatagori();
            frm.Show();
        }

        private void btn_Istatislik_Click(object sender, EventArgs e)
        {
            FrmIstatislik frm = new FrmIstatislik();
            frm.Show();
        }

        private void btn_Urun_Click(object sender, EventArgs e)
        {
            FrmUrun frm = new FrmUrun();
            frm.Show();
        }
    }
}
