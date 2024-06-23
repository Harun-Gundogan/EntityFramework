namespace EntityUrun
{
    partial class FrmUrun
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
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_UrunAdi = new System.Windows.Forms.TextBox();
            this.lbl_UrunAd = new System.Windows.Forms.Label();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.lbl_Marka = new System.Windows.Forms.Label();
            this.txt_Stok = new System.Windows.Forms.TextBox();
            this.lbl_Stok = new System.Windows.Forms.Label();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.lbl_Fiyat = new System.Windows.Forms.Label();
            this.txt_Durum = new System.Windows.Forms.TextBox();
            this.lbl_Durum = new System.Windows.Forms.Label();
            this.lbl_Katagori = new System.Windows.Forms.Label();
            this.lbl_UrunIslemleri = new System.Windows.Forms.Label();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Temizle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb_Katagori = new System.Windows.Forms.ComboBox();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(29, 45);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(37, 25);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID:";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(141, 40);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(169, 30);
            this.txt_ID.TabIndex = 1;
            // 
            // txt_UrunAdi
            // 
            this.txt_UrunAdi.Location = new System.Drawing.Point(141, 76);
            this.txt_UrunAdi.Name = "txt_UrunAdi";
            this.txt_UrunAdi.Size = new System.Drawing.Size(169, 30);
            this.txt_UrunAdi.TabIndex = 3;
            // 
            // lbl_UrunAd
            // 
            this.lbl_UrunAd.AutoSize = true;
            this.lbl_UrunAd.Location = new System.Drawing.Point(29, 81);
            this.lbl_UrunAd.Name = "lbl_UrunAd";
            this.lbl_UrunAd.Size = new System.Drawing.Size(94, 25);
            this.lbl_UrunAd.TabIndex = 2;
            this.lbl_UrunAd.Text = "Ürün Adı:";
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(141, 112);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(169, 30);
            this.txt_Marka.TabIndex = 5;
            // 
            // lbl_Marka
            // 
            this.lbl_Marka.AutoSize = true;
            this.lbl_Marka.Location = new System.Drawing.Point(29, 117);
            this.lbl_Marka.Name = "lbl_Marka";
            this.lbl_Marka.Size = new System.Drawing.Size(73, 25);
            this.lbl_Marka.TabIndex = 4;
            this.lbl_Marka.Text = "Marka:";
            // 
            // txt_Stok
            // 
            this.txt_Stok.Location = new System.Drawing.Point(141, 148);
            this.txt_Stok.Name = "txt_Stok";
            this.txt_Stok.Size = new System.Drawing.Size(169, 30);
            this.txt_Stok.TabIndex = 7;
            // 
            // lbl_Stok
            // 
            this.lbl_Stok.AutoSize = true;
            this.lbl_Stok.Location = new System.Drawing.Point(29, 153);
            this.lbl_Stok.Name = "lbl_Stok";
            this.lbl_Stok.Size = new System.Drawing.Size(58, 25);
            this.lbl_Stok.TabIndex = 6;
            this.lbl_Stok.Text = "Stok:";
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(141, 184);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(169, 30);
            this.txt_Fiyat.TabIndex = 9;
            // 
            // lbl_Fiyat
            // 
            this.lbl_Fiyat.AutoSize = true;
            this.lbl_Fiyat.Location = new System.Drawing.Point(29, 189);
            this.lbl_Fiyat.Name = "lbl_Fiyat";
            this.lbl_Fiyat.Size = new System.Drawing.Size(60, 25);
            this.lbl_Fiyat.TabIndex = 8;
            this.lbl_Fiyat.Text = "Fiyat:";
            // 
            // txt_Durum
            // 
            this.txt_Durum.Location = new System.Drawing.Point(141, 220);
            this.txt_Durum.Name = "txt_Durum";
            this.txt_Durum.Size = new System.Drawing.Size(169, 30);
            this.txt_Durum.TabIndex = 11;
            // 
            // lbl_Durum
            // 
            this.lbl_Durum.AutoSize = true;
            this.lbl_Durum.Location = new System.Drawing.Point(29, 225);
            this.lbl_Durum.Name = "lbl_Durum";
            this.lbl_Durum.Size = new System.Drawing.Size(76, 25);
            this.lbl_Durum.TabIndex = 10;
            this.lbl_Durum.Text = "Durum:";
            // 
            // lbl_Katagori
            // 
            this.lbl_Katagori.AutoSize = true;
            this.lbl_Katagori.Location = new System.Drawing.Point(29, 261);
            this.lbl_Katagori.Name = "lbl_Katagori";
            this.lbl_Katagori.Size = new System.Drawing.Size(91, 25);
            this.lbl_Katagori.TabIndex = 12;
            this.lbl_Katagori.Text = "Katagori:";
            // 
            // lbl_UrunIslemleri
            // 
            this.lbl_UrunIslemleri.AutoSize = true;
            this.lbl_UrunIslemleri.Location = new System.Drawing.Point(12, 9);
            this.lbl_UrunIslemleri.Name = "lbl_UrunIslemleri";
            this.lbl_UrunIslemleri.Size = new System.Drawing.Size(130, 25);
            this.lbl_UrunIslemleri.TabIndex = 14;
            this.lbl_UrunIslemleri.Text = "Ürün İşlemleri";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(326, 90);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(100, 33);
            this.btn_Ekle.TabIndex = 16;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(326, 129);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(100, 33);
            this.btn_Guncelle.TabIndex = 17;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(326, 168);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(100, 33);
            this.btn_Sil.TabIndex = 18;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(446, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(744, 246);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_Temizle
            // 
            this.btn_Temizle.Location = new System.Drawing.Point(326, 207);
            this.btn_Temizle.Name = "btn_Temizle";
            this.btn_Temizle.Size = new System.Drawing.Size(100, 33);
            this.btn_Temizle.TabIndex = 20;
            this.btn_Temizle.Text = "Temizle";
            this.btn_Temizle.UseVisualStyleBackColor = true;
            this.btn_Temizle.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(326, 246);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 21;
            this.button2.Text = "Çıkış";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb_Katagori
            // 
            this.cmb_Katagori.FormattingEnabled = true;
            this.cmb_Katagori.Location = new System.Drawing.Point(141, 256);
            this.cmb_Katagori.Name = "cmb_Katagori";
            this.cmb_Katagori.Size = new System.Drawing.Size(169, 33);
            this.cmb_Katagori.TabIndex = 22;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(326, 51);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 33);
            this.btnListele.TabIndex = 24;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1202, 304);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmb_Katagori);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Temizle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.lbl_UrunIslemleri);
            this.Controls.Add(this.lbl_Katagori);
            this.Controls.Add(this.txt_Durum);
            this.Controls.Add(this.lbl_Durum);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.lbl_Fiyat);
            this.Controls.Add(this.txt_Stok);
            this.Controls.Add(this.lbl_Stok);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.lbl_Marka);
            this.Controls.Add(this.txt_UrunAdi);
            this.Controls.Add(this.lbl_UrunAd);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün İşlemleri";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_UrunAdi;
        private System.Windows.Forms.Label lbl_UrunAd;
        private System.Windows.Forms.TextBox txt_Marka;
        private System.Windows.Forms.Label lbl_Marka;
        private System.Windows.Forms.TextBox txt_Stok;
        private System.Windows.Forms.Label lbl_Stok;
        private System.Windows.Forms.TextBox txt_Fiyat;
        private System.Windows.Forms.Label lbl_Fiyat;
        private System.Windows.Forms.TextBox txt_Durum;
        private System.Windows.Forms.Label lbl_Durum;
        private System.Windows.Forms.Label lbl_Katagori;
        private System.Windows.Forms.Label lbl_UrunIslemleri;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Temizle;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmb_Katagori;
        private System.Windows.Forms.Button btnListele;
    }
}