namespace EntityUrun
{
    partial class FrmAnaForm
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
            this.btn_Katagori = new System.Windows.Forms.Button();
            this.btn_Urun = new System.Windows.Forms.Button();
            this.btn_Istatislik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Katagori
            // 
            this.btn_Katagori.Location = new System.Drawing.Point(13, 14);
            this.btn_Katagori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Katagori.Name = "btn_Katagori";
            this.btn_Katagori.Size = new System.Drawing.Size(261, 155);
            this.btn_Katagori.TabIndex = 0;
            this.btn_Katagori.Text = "Katagori İşlemleri";
            this.btn_Katagori.UseVisualStyleBackColor = true;
            this.btn_Katagori.Click += new System.EventHandler(this.btn_Katagori_Click);
            // 
            // btn_Urun
            // 
            this.btn_Urun.Location = new System.Drawing.Point(13, 179);
            this.btn_Urun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Urun.Name = "btn_Urun";
            this.btn_Urun.Size = new System.Drawing.Size(261, 155);
            this.btn_Urun.TabIndex = 1;
            this.btn_Urun.Text = "Ürün İşlemleri";
            this.btn_Urun.UseVisualStyleBackColor = true;
            this.btn_Urun.Click += new System.EventHandler(this.btn_Urun_Click);
            // 
            // btn_Istatislik
            // 
            this.btn_Istatislik.Location = new System.Drawing.Point(13, 344);
            this.btn_Istatislik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Istatislik.Name = "btn_Istatislik";
            this.btn_Istatislik.Size = new System.Drawing.Size(261, 155);
            this.btn_Istatislik.TabIndex = 2;
            this.btn_Istatislik.Text = "İstatislikler";
            this.btn_Istatislik.UseVisualStyleBackColor = true;
            this.btn_Istatislik.Click += new System.EventHandler(this.btn_Istatislik_Click);
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(286, 514);
            this.Controls.Add(this.btn_Istatislik);
            this.Controls.Add(this.btn_Urun);
            this.Controls.Add(this.btn_Katagori);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Katagori;
        private System.Windows.Forms.Button btn_Urun;
        private System.Windows.Forms.Button btn_Istatislik;
    }
}