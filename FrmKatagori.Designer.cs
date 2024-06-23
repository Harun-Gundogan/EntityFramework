namespace EntityUrun
{
    partial class FrmKatagori
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_KatagoriID = new System.Windows.Forms.Label();
            this.txt_katagoriID = new System.Windows.Forms.TextBox();
            this.txt_KatagoriAdi = new System.Windows.Forms.TextBox();
            this.lbl_KatagoriAdi = new System.Windows.Forms.Label();
            this.btn_Listele = new System.Windows.Forms.Button();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_KatagoriID
            // 
            this.lbl_KatagoriID.AutoSize = true;
            this.lbl_KatagoriID.Location = new System.Drawing.Point(16, 15);
            this.lbl_KatagoriID.Name = "lbl_KatagoriID";
            this.lbl_KatagoriID.Size = new System.Drawing.Size(115, 25);
            this.lbl_KatagoriID.TabIndex = 1;
            this.lbl_KatagoriID.Text = "Katagori ID:";
            // 
            // txt_katagoriID
            // 
            this.txt_katagoriID.Enabled = false;
            this.txt_katagoriID.Location = new System.Drawing.Point(147, 12);
            this.txt_katagoriID.Name = "txt_katagoriID";
            this.txt_katagoriID.Size = new System.Drawing.Size(116, 30);
            this.txt_katagoriID.TabIndex = 2;
            // 
            // txt_KatagoriAdi
            // 
            this.txt_KatagoriAdi.Location = new System.Drawing.Point(147, 57);
            this.txt_KatagoriAdi.Name = "txt_KatagoriAdi";
            this.txt_KatagoriAdi.Size = new System.Drawing.Size(116, 30);
            this.txt_KatagoriAdi.TabIndex = 4;
            // 
            // lbl_KatagoriAdi
            // 
            this.lbl_KatagoriAdi.AutoSize = true;
            this.lbl_KatagoriAdi.Location = new System.Drawing.Point(16, 62);
            this.lbl_KatagoriAdi.Name = "lbl_KatagoriAdi";
            this.lbl_KatagoriAdi.Size = new System.Drawing.Size(125, 25);
            this.lbl_KatagoriAdi.TabIndex = 3;
            this.lbl_KatagoriAdi.Text = "Katagori Adı:";
            // 
            // btn_Listele
            // 
            this.btn_Listele.Location = new System.Drawing.Point(21, 105);
            this.btn_Listele.Name = "btn_Listele";
            this.btn_Listele.Size = new System.Drawing.Size(116, 33);
            this.btn_Listele.TabIndex = 5;
            this.btn_Listele.Text = "Listele";
            this.btn_Listele.UseVisualStyleBackColor = true;
            this.btn_Listele.Click += new System.EventHandler(this.btn_Listele_Click);
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(147, 105);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(116, 33);
            this.btn_Ekle.TabIndex = 6;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(147, 159);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(116, 33);
            this.btn_Sil.TabIndex = 8;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(21, 159);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(116, 33);
            this.btn_Guncelle.TabIndex = 7;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(685, 180);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FrmKatagori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(961, 217);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.btn_Listele);
            this.Controls.Add(this.txt_KatagoriAdi);
            this.Controls.Add(this.lbl_KatagoriAdi);
            this.Controls.Add(this.txt_katagoriID);
            this.Controls.Add(this.lbl_KatagoriID);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmKatagori";
            this.Text = "Katagori İşlemleri";
            this.Load += new System.EventHandler(this.FrmKatagori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_KatagoriID;
        private System.Windows.Forms.TextBox txt_katagoriID;
        private System.Windows.Forms.TextBox txt_KatagoriAdi;
        private System.Windows.Forms.Label lbl_KatagoriAdi;
        private System.Windows.Forms.Button btn_Listele;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

