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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }

        private void Listele()
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urun select new { x.ID, x.AD, x.MARKA, x.STOK, x.FIYAT, KATAGORI_ADI=x.Tbl_Katagori.AD , x.DURUM }).ToList();
        }

        private void Temizle()
        {
            txt_Durum.Text = "";
            txt_Fiyat.Text = "";
            txt_ID.Text = "";
            txt_Marka.Text = "";
            txt_Stok.Text = "";
            txt_UrunAdi.Text = "";
            cmb_Katagori.Text = "";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt_Durum.Text == "" || txt_Fiyat.Text == "" || txt_ID.Text == "" || txt_Marka.Text == "" || txt_Stok.Text == "" || txt_UrunAdi.Text == "" || cmb_Katagori.Text == "")
            {
                MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int x = Convert.ToInt32(txt_ID.Text);
                var urun = db.Tbl_Urun.Find(x);
                urun.AD = txt_UrunAdi.Text;
                urun.STOK = short.Parse(txt_Stok.Text);
                urun.MARKA = txt_Marka.Text;
                urun.FIYAT = decimal.Parse(txt_Fiyat.Text);
                urun.DURUM = bool.Parse(txt_Durum.Text);
                urun.KATAGORI = int.Parse(cmb_Katagori.Text);
                db.SaveChanges();

                MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();
                Listele();
            }
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_Durum.Text == "" || txt_Fiyat.Text == "" || txt_Marka.Text == "" || txt_Stok.Text == "" || txt_UrunAdi.Text == ""||cmb_Katagori.Text=="")
            {
                MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Tbl_Urun t = new Tbl_Urun();
                t.AD = txt_UrunAdi.Text;
                t.MARKA = txt_Marka.Text;
                t.STOK = short.Parse(txt_Stok.Text);
                t.KATAGORI = int.Parse(cmb_Katagori.SelectedValue.ToString());
                t.FIYAT = decimal.Parse(txt_Fiyat.Text);
                t.DURUM = true;
                db.Tbl_Urun.Add(t);
                db.SaveChanges();

                MessageBox.Show("Ürün Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Listele();
                Temizle();
            }
     
            

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (txt_Durum.Text == "" || txt_Fiyat.Text == "" || txt_ID.Text == "" || txt_Marka.Text == "" || txt_Stok.Text == "" || txt_UrunAdi.Text == "" || cmb_Katagori.Text == "")
            {
                MessageBox.Show("Lütfen boş yerleri doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int x = Convert.ToInt32(txt_ID.Text);
                var urun = db.Tbl_Urun.Find(x);
                db.Tbl_Urun.Remove(urun);
                db.SaveChanges();

                MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Temizle();
                Listele();
            }
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            Listele();
            var katagoriler = (from x in db.Tbl_Katagori select new { x.ID, x.AD }).ToList();
            cmb_Katagori.ValueMember = "ID";
            cmb_Katagori.DisplayMember = "AD";
            cmb_Katagori.DataSource = katagoriler;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        EntityUrunEntities db = new EntityUrunEntities();

        private void button3_Click_1(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_UrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Marka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_Stok.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_Fiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_Durum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmb_Katagori.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
