namespace EntityUrun
{
    partial class FrmIstatislik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Katagori = new System.Windows.Forms.Label();
            this.lbl_KatagoriSayisi = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ToplamUrunSayisi = new System.Windows.Forms.Label();
            this.lbl_Urun = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_AktifMusteriSayisi = new System.Windows.Forms.Label();
            this.lbl_AktifMusteri = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_PasifMusteriSayisi = new System.Windows.Forms.Label();
            this.lbl_PasifMusteri = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_EnDusukUrun = new System.Windows.Forms.Label();
            this.lbl_Min = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_EnYuksekUrun = new System.Windows.Forms.Label();
            this.lbl_Max = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_StokSayisi = new System.Windows.Forms.Label();
            this.lbl_Stok = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_BeyazEsyaSayisi = new System.Windows.Forms.Label();
            this.lbl_BeyazEsya = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_ToplamBuzdolabiSayisi = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbl_EnFazlaUrunlu = new System.Windows.Forms.Label();
            this.lbl_SumMarka = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbl_KasadakiTutar = new System.Windows.Forms.Label();
            this.lbl_Kasa = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbl_SehirSayisi = new System.Windows.Forms.Label();
            this.lbl_Sehir = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lbl_KatagoriSayisi);
            this.panel1.Controls.Add(this.lbl_Katagori);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 175);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Katagori
            // 
            this.lbl_Katagori.AutoSize = true;
            this.lbl_Katagori.Location = new System.Drawing.Point(14, 12);
            this.lbl_Katagori.Name = "lbl_Katagori";
            this.lbl_Katagori.Size = new System.Drawing.Size(243, 25);
            this.lbl_Katagori.TabIndex = 0;
            this.lbl_Katagori.Text = "Toplam Katagori Sayısı:";
            // 
            // lbl_KatagoriSayisi
            // 
            this.lbl_KatagoriSayisi.AutoSize = true;
            this.lbl_KatagoriSayisi.Location = new System.Drawing.Point(14, 57);
            this.lbl_KatagoriSayisi.Name = "lbl_KatagoriSayisi";
            this.lbl_KatagoriSayisi.Size = new System.Drawing.Size(24, 25);
            this.lbl_KatagoriSayisi.TabIndex = 1;
            this.lbl_KatagoriSayisi.Text = "0";
            this.lbl_KatagoriSayisi.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.lbl_ToplamUrunSayisi);
            this.panel2.Controls.Add(this.lbl_Urun);
            this.panel2.Location = new System.Drawing.Point(296, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 175);
            this.panel2.TabIndex = 1;
            // 
            // lbl_ToplamUrunSayisi
            // 
            this.lbl_ToplamUrunSayisi.AutoSize = true;
            this.lbl_ToplamUrunSayisi.Location = new System.Drawing.Point(14, 57);
            this.lbl_ToplamUrunSayisi.Name = "lbl_ToplamUrunSayisi";
            this.lbl_ToplamUrunSayisi.Size = new System.Drawing.Size(24, 25);
            this.lbl_ToplamUrunSayisi.TabIndex = 1;
            this.lbl_ToplamUrunSayisi.Text = "0";
            // 
            // lbl_Urun
            // 
            this.lbl_Urun.Location = new System.Drawing.Point(14, 12);
            this.lbl_Urun.Name = "lbl_Urun";
            this.lbl_Urun.Size = new System.Drawing.Size(205, 25);
            this.lbl_Urun.TabIndex = 0;
            this.lbl_Urun.Text = "Toplam Ürün Sayısı:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.lbl_AktifMusteriSayisi);
            this.panel3.Controls.Add(this.lbl_AktifMusteri);
            this.panel3.Location = new System.Drawing.Point(578, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(276, 175);
            this.panel3.TabIndex = 2;
            // 
            // lbl_AktifMusteriSayisi
            // 
            this.lbl_AktifMusteriSayisi.AutoSize = true;
            this.lbl_AktifMusteriSayisi.Location = new System.Drawing.Point(14, 57);
            this.lbl_AktifMusteriSayisi.Name = "lbl_AktifMusteriSayisi";
            this.lbl_AktifMusteriSayisi.Size = new System.Drawing.Size(24, 25);
            this.lbl_AktifMusteriSayisi.TabIndex = 1;
            this.lbl_AktifMusteriSayisi.Text = "0";
            // 
            // lbl_AktifMusteri
            // 
            this.lbl_AktifMusteri.AutoSize = true;
            this.lbl_AktifMusteri.Location = new System.Drawing.Point(14, 12);
            this.lbl_AktifMusteri.Name = "lbl_AktifMusteri";
            this.lbl_AktifMusteri.Size = new System.Drawing.Size(204, 25);
            this.lbl_AktifMusteri.TabIndex = 0;
            this.lbl_AktifMusteri.Text = "Aktif Müşteri Sayısı:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PeachPuff;
            this.panel4.Controls.Add(this.lbl_PasifMusteriSayisi);
            this.panel4.Controls.Add(this.lbl_PasifMusteri);
            this.panel4.Location = new System.Drawing.Point(861, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(276, 175);
            this.panel4.TabIndex = 3;
            // 
            // lbl_PasifMusteriSayisi
            // 
            this.lbl_PasifMusteriSayisi.AutoSize = true;
            this.lbl_PasifMusteriSayisi.Location = new System.Drawing.Point(14, 57);
            this.lbl_PasifMusteriSayisi.Name = "lbl_PasifMusteriSayisi";
            this.lbl_PasifMusteriSayisi.Size = new System.Drawing.Size(24, 25);
            this.lbl_PasifMusteriSayisi.TabIndex = 1;
            this.lbl_PasifMusteriSayisi.Text = "0";
            // 
            // lbl_PasifMusteri
            // 
            this.lbl_PasifMusteri.AutoSize = true;
            this.lbl_PasifMusteri.Location = new System.Drawing.Point(14, 12);
            this.lbl_PasifMusteri.Name = "lbl_PasifMusteri";
            this.lbl_PasifMusteri.Size = new System.Drawing.Size(209, 25);
            this.lbl_PasifMusteri.TabIndex = 0;
            this.lbl_PasifMusteri.Text = "Pasif Müşteri Sayısı:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PeachPuff;
            this.panel5.Controls.Add(this.lbl_EnDusukUrun);
            this.panel5.Controls.Add(this.lbl_Min);
            this.panel5.Location = new System.Drawing.Point(861, 207);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(276, 175);
            this.panel5.TabIndex = 7;
            // 
            // lbl_EnDusukUrun
            // 
            this.lbl_EnDusukUrun.AutoSize = true;
            this.lbl_EnDusukUrun.Location = new System.Drawing.Point(14, 57);
            this.lbl_EnDusukUrun.Name = "lbl_EnDusukUrun";
            this.lbl_EnDusukUrun.Size = new System.Drawing.Size(24, 25);
            this.lbl_EnDusukUrun.TabIndex = 1;
            this.lbl_EnDusukUrun.Text = "0";
            // 
            // lbl_Min
            // 
            this.lbl_Min.AutoSize = true;
            this.lbl_Min.Location = new System.Drawing.Point(14, 12);
            this.lbl_Min.Name = "lbl_Min";
            this.lbl_Min.Size = new System.Drawing.Size(220, 25);
            this.lbl_Min.TabIndex = 0;
            this.lbl_Min.Text = "En Düşük Fiyatlı Ürün";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkOrange;
            this.panel6.Controls.Add(this.lbl_EnYuksekUrun);
            this.panel6.Controls.Add(this.lbl_Max);
            this.panel6.Location = new System.Drawing.Point(578, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(276, 175);
            this.panel6.TabIndex = 6;
            // 
            // lbl_EnYuksekUrun
            // 
            this.lbl_EnYuksekUrun.AutoSize = true;
            this.lbl_EnYuksekUrun.Location = new System.Drawing.Point(14, 57);
            this.lbl_EnYuksekUrun.Name = "lbl_EnYuksekUrun";
            this.lbl_EnYuksekUrun.Size = new System.Drawing.Size(24, 25);
            this.lbl_EnYuksekUrun.TabIndex = 1;
            this.lbl_EnYuksekUrun.Text = "0";
            // 
            // lbl_Max
            // 
            this.lbl_Max.AutoSize = true;
            this.lbl_Max.Location = new System.Drawing.Point(14, 12);
            this.lbl_Max.Name = "lbl_Max";
            this.lbl_Max.Size = new System.Drawing.Size(237, 25);
            this.lbl_Max.TabIndex = 0;
            this.lbl_Max.Text = "En Yüksek Fiyatlı Ürün:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PeachPuff;
            this.panel7.Controls.Add(this.lbl_StokSayisi);
            this.panel7.Controls.Add(this.lbl_Stok);
            this.panel7.Location = new System.Drawing.Point(296, 207);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(276, 175);
            this.panel7.TabIndex = 5;
            // 
            // lbl_StokSayisi
            // 
            this.lbl_StokSayisi.AutoSize = true;
            this.lbl_StokSayisi.Location = new System.Drawing.Point(14, 57);
            this.lbl_StokSayisi.Name = "lbl_StokSayisi";
            this.lbl_StokSayisi.Size = new System.Drawing.Size(24, 25);
            this.lbl_StokSayisi.TabIndex = 1;
            this.lbl_StokSayisi.Text = "0";
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.AutoSize = true;
            this.lbl_Stok.Location = new System.Drawing.Point(14, 12);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(63, 25);
            this.lbl_Stok.TabIndex = 0;
            this.lbl_Stok.Text = "Stok:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkOrange;
            this.panel8.Controls.Add(this.lbl_BeyazEsyaSayisi);
            this.panel8.Controls.Add(this.lbl_BeyazEsya);
            this.panel8.Location = new System.Drawing.Point(13, 207);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(276, 175);
            this.panel8.TabIndex = 4;
            // 
            // lbl_BeyazEsyaSayisi
            // 
            this.lbl_BeyazEsyaSayisi.AutoSize = true;
            this.lbl_BeyazEsyaSayisi.Location = new System.Drawing.Point(14, 57);
            this.lbl_BeyazEsyaSayisi.Name = "lbl_BeyazEsyaSayisi";
            this.lbl_BeyazEsyaSayisi.Size = new System.Drawing.Size(24, 25);
            this.lbl_BeyazEsyaSayisi.TabIndex = 1;
            this.lbl_BeyazEsyaSayisi.Text = "0";
            // 
            // lbl_BeyazEsya
            // 
            this.lbl_BeyazEsya.AutoSize = true;
            this.lbl_BeyazEsya.Location = new System.Drawing.Point(14, 12);
            this.lbl_BeyazEsya.Name = "lbl_BeyazEsya";
            this.lbl_BeyazEsya.Size = new System.Drawing.Size(198, 25);
            this.lbl_BeyazEsya.TabIndex = 0;
            this.lbl_BeyazEsya.Text = "Beyaz Eşya Sayısı:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.PeachPuff;
            this.panel9.Controls.Add(this.lbl_ToplamBuzdolabiSayisi);
            this.panel9.Controls.Add(this.label18);
            this.panel9.Location = new System.Drawing.Point(861, 404);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(276, 174);
            this.panel9.TabIndex = 11;
            // 
            // lbl_ToplamBuzdolabiSayisi
            // 
            this.lbl_ToplamBuzdolabiSayisi.AutoSize = true;
            this.lbl_ToplamBuzdolabiSayisi.Location = new System.Drawing.Point(14, 57);
            this.lbl_ToplamBuzdolabiSayisi.Name = "lbl_ToplamBuzdolabiSayisi";
            this.lbl_ToplamBuzdolabiSayisi.Size = new System.Drawing.Size(24, 25);
            this.lbl_ToplamBuzdolabiSayisi.TabIndex = 1;
            this.lbl_ToplamBuzdolabiSayisi.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(257, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Toplam Buzdolabı Sayısı:";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkOrange;
            this.panel10.Controls.Add(this.lbl_EnFazlaUrunlu);
            this.panel10.Controls.Add(this.lbl_SumMarka);
            this.panel10.Location = new System.Drawing.Point(578, 404);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(276, 174);
            this.panel10.TabIndex = 10;
            // 
            // lbl_EnFazlaUrunlu
            // 
            this.lbl_EnFazlaUrunlu.AutoSize = true;
            this.lbl_EnFazlaUrunlu.Location = new System.Drawing.Point(14, 57);
            this.lbl_EnFazlaUrunlu.Name = "lbl_EnFazlaUrunlu";
            this.lbl_EnFazlaUrunlu.Size = new System.Drawing.Size(24, 25);
            this.lbl_EnFazlaUrunlu.TabIndex = 1;
            this.lbl_EnFazlaUrunlu.Text = "0";
            // 
            // lbl_SumMarka
            // 
            this.lbl_SumMarka.AutoSize = true;
            this.lbl_SumMarka.Location = new System.Drawing.Point(14, 12);
            this.lbl_SumMarka.Name = "lbl_SumMarka";
            this.lbl_SumMarka.Size = new System.Drawing.Size(239, 25);
            this.lbl_SumMarka.TabIndex = 0;
            this.lbl_SumMarka.Text = "En Fazla Ürünlü Marka:";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.PeachPuff;
            this.panel11.Controls.Add(this.lbl_KasadakiTutar);
            this.panel11.Controls.Add(this.lbl_Kasa);
            this.panel11.Location = new System.Drawing.Point(296, 404);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(276, 174);
            this.panel11.TabIndex = 9;
            // 
            // lbl_KasadakiTutar
            // 
            this.lbl_KasadakiTutar.AutoSize = true;
            this.lbl_KasadakiTutar.Location = new System.Drawing.Point(14, 57);
            this.lbl_KasadakiTutar.Name = "lbl_KasadakiTutar";
            this.lbl_KasadakiTutar.Size = new System.Drawing.Size(24, 25);
            this.lbl_KasadakiTutar.TabIndex = 1;
            this.lbl_KasadakiTutar.Text = "0";
            // 
            // lbl_Kasa
            // 
            this.lbl_Kasa.AutoSize = true;
            this.lbl_Kasa.Location = new System.Drawing.Point(14, 12);
            this.lbl_Kasa.Name = "lbl_Kasa";
            this.lbl_Kasa.Size = new System.Drawing.Size(166, 25);
            this.lbl_Kasa.TabIndex = 0;
            this.lbl_Kasa.Text = "Kasadaki Tutar:";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkOrange;
            this.panel12.Controls.Add(this.lbl_SehirSayisi);
            this.panel12.Controls.Add(this.lbl_Sehir);
            this.panel12.Location = new System.Drawing.Point(13, 404);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(276, 174);
            this.panel12.TabIndex = 8;
            // 
            // lbl_SehirSayisi
            // 
            this.lbl_SehirSayisi.AutoSize = true;
            this.lbl_SehirSayisi.Location = new System.Drawing.Point(14, 57);
            this.lbl_SehirSayisi.Name = "lbl_SehirSayisi";
            this.lbl_SehirSayisi.Size = new System.Drawing.Size(24, 25);
            this.lbl_SehirSayisi.TabIndex = 1;
            this.lbl_SehirSayisi.Text = "0";
            // 
            // lbl_Sehir
            // 
            this.lbl_Sehir.AutoSize = true;
            this.lbl_Sehir.Location = new System.Drawing.Point(14, 12);
            this.lbl_Sehir.Name = "lbl_Sehir";
            this.lbl_Sehir.Size = new System.Drawing.Size(135, 25);
            this.lbl_Sehir.TabIndex = 0;
            this.lbl_Sehir.Text = "Şehir Sayısı:";
            // 
            // FrmIstatislik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(1153, 595);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmIstatislik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İstatislik";
            this.Load += new System.EventHandler(this.FrmIstatislik_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_KatagoriSayisi;
        private System.Windows.Forms.Label lbl_Katagori;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ToplamUrunSayisi;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_AktifMusteriSayisi;
        private System.Windows.Forms.Label lbl_AktifMusteri;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_PasifMusteriSayisi;
        private System.Windows.Forms.Label lbl_PasifMusteri;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_EnDusukUrun;
        private System.Windows.Forms.Label lbl_Min;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_EnYuksekUrun;
        private System.Windows.Forms.Label lbl_Max;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_StokSayisi;
        private System.Windows.Forms.Label lbl_Stok;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_BeyazEsyaSayisi;
        private System.Windows.Forms.Label lbl_BeyazEsya;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_ToplamBuzdolabiSayisi;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_EnFazlaUrunlu;
        private System.Windows.Forms.Label lbl_SumMarka;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lbl_KasadakiTutar;
        private System.Windows.Forms.Label lbl_Kasa;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lbl_SehirSayisi;
        private System.Windows.Forms.Label lbl_Sehir;
        private System.Windows.Forms.Label lbl_Urun;
    }
}