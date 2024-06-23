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
    public partial class FrmIstatislik : Form
    {
        public FrmIstatislik()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        EntityUrunEntities db = new EntityUrunEntities();
        private void FrmIstatislik_Load(object sender, EventArgs e)
        {
            lbl_KatagoriSayisi.Text = db.Tbl_Katagori.Count().ToString();
            lbl_ToplamUrunSayisi.Text = db.Tbl_Urun.Count().ToString();
            lbl_AktifMusteriSayisi.Text = db.Tbl_Musteri.Count(x=>x.DURUM==true).ToString();
            lbl_PasifMusteriSayisi.Text = db.Tbl_Musteri.Count(x=>x.DURUM==false).ToString();
            lbl_StokSayisi.Text=db.Tbl_Urun.Sum(x=>x.STOK).ToString();
            lbl_KasadakiTutar.Text=db.Tbl_Satis.Sum(z=>z.FIYAT).ToString() + " TL";
            lbl_EnYuksekUrun.Text = (from x in db.Tbl_Urun orderby x.FIYAT descending select x.AD).FirstOrDefault();
            lbl_EnDusukUrun.Text=(from x in db.Tbl_Urun orderby x.FIYAT ascending select x.AD).FirstOrDefault();
            lbl_BeyazEsyaSayisi.Text=db.Tbl_Urun.Count(x=>x.KATAGORI==1).ToString();
            lbl_ToplamBuzdolabiSayisi.Text=db.Tbl_Urun.Count(x=>x.AD=="BUZDOLABI").ToString();
            lbl_SehirSayisi.Text=(from x in db.Tbl_Musteri select x.SEHIR).Distinct().Count().ToString();
            lbl_EnFazlaUrunlu.Text = db.markagetir().FirstOrDefault();


        }
    }
}
