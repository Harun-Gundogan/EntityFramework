using System;
using System.CodeDom;
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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }
        EntityUrunEntities db = new EntityUrunEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var sorgu = from x in db.Tbl_Admin where x.USARNAME == txt_KullaniciAdi.Text && x.PASSWORD == txt_Sifre.Text select x;
                if (sorgu.Any())
                {
                    FrmAnaForm frm = new FrmAnaForm();
                    frm.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Lütfen girmiş olduğunuz bilgileri kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);                  
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                txt_KullaniciAdi.Text = "";
                txt_Sifre.Text = "";
            }

            
            

            
        }
    }
}
