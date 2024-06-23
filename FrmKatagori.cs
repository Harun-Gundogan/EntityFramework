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
    public partial class FrmKatagori : Form
    {
        public FrmKatagori()
        {
            InitializeComponent();
        }
        EntityUrunEntities db = new EntityUrunEntities();

        private void Listele()
        {
            var katagoriler = db.Tbl_Katagori.ToList();
            dataGridView1.DataSource = katagoriler;
        }

        private void Temizle()
        {
            txt_katagoriID.Text = "";
            txt_KatagoriAdi.Text = "";
        }
        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            Tbl_Katagori t = new Tbl_Katagori();
            t.AD=txt_KatagoriAdi.Text;
            db.Tbl_Katagori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Katagori Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Temizle();

            Listele();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_katagoriID.Text);
            var katagori = db.Tbl_Katagori.Find(x);
            db.Tbl_Katagori.Remove(katagori);
            db.SaveChanges();
            MessageBox.Show("Katagori Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

            Temizle();

            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_katagoriID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_KatagoriAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_katagoriID.Text);
            var katagori = db.Tbl_Katagori.Find(x);
            katagori.AD=txt_KatagoriAdi.Text;
            db.SaveChanges();
            MessageBox.Show("Katagori Güncellendi","Bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);

            Temizle();

            Listele();
        }

        private void FrmKatagori_Load(object sender, EventArgs e)
        {

        }
    }
}
