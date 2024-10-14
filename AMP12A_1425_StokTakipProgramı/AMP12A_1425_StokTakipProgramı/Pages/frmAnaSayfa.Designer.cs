namespace AMP12A_1425_StokTakipProgramı
{
    partial class frmAnaSayfa
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuTedarikci = new System.Windows.Forms.ToolStripMenuItem();
            this.menuUrun = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMusteri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPersonel = new System.Windows.Forms.ToolStripMenuItem();
            this.grdUrunListesi = new System.Windows.Forms.GroupBox();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtNot = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMusteriSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskTxtMusteriTelefon = new System.Windows.Forms.MaskedTextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.grdSatilacakUrunler = new System.Windows.Forms.DataGridView();
            this.lblPersonelAdSoyad = new System.Windows.Forms.Label();
            this.lblYetki = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grdUrunListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilacakUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTedarikci,
            this.menuUrun,
            this.menuSatis,
            this.menuMusteri,
            this.menuPersonel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuTedarikci
            // 
            this.menuTedarikci.Name = "menuTedarikci";
            this.menuTedarikci.Size = new System.Drawing.Size(149, 24);
            this.menuTedarikci.Text = "Tedarikçi İşlemleri";
            // 
            // menuUrun
            // 
            this.menuUrun.Name = "menuUrun";
            this.menuUrun.Size = new System.Drawing.Size(122, 24);
            this.menuUrun.Text = "Ürün İşlemleri";
            // 
            // menuSatis
            // 
            this.menuSatis.Name = "menuSatis";
            this.menuSatis.Size = new System.Drawing.Size(123, 24);
            this.menuSatis.Text = "Satış Detayları";
            // 
            // menuMusteri
            // 
            this.menuMusteri.Name = "menuMusteri";
            this.menuMusteri.Size = new System.Drawing.Size(141, 24);
            this.menuMusteri.Text = "Müşteri İşlemleri";
            // 
            // menuPersonel
            // 
            this.menuPersonel.Name = "menuPersonel";
            this.menuPersonel.Size = new System.Drawing.Size(147, 24);
            this.menuPersonel.Text = "Personel İşlemleri";
            // 
            // grdUrunListesi
            // 
            this.grdUrunListesi.Controls.Add(this.txtGenelToplam);
            this.grdUrunListesi.Controls.Add(this.btnSatisYap);
            this.grdUrunListesi.Controls.Add(this.label7);
            this.grdUrunListesi.Controls.Add(this.txtNot);
            this.grdUrunListesi.Controls.Add(this.label5);
            this.grdUrunListesi.Controls.Add(this.dataGridView1);
            this.grdUrunListesi.Controls.Add(this.label4);
            this.grdUrunListesi.Controls.Add(this.txtMusteriAdSoyad);
            this.grdUrunListesi.Controls.Add(this.label3);
            this.grdUrunListesi.Controls.Add(this.btnMusteriSec);
            this.grdUrunListesi.Controls.Add(this.label2);
            this.grdUrunListesi.Controls.Add(this.label1);
            this.grdUrunListesi.Controls.Add(this.mskTxtMusteriTelefon);
            this.grdUrunListesi.Controls.Add(this.btnEkle);
            this.grdUrunListesi.Controls.Add(this.btnSil);
            this.grdUrunListesi.Controls.Add(this.grdSatilacakUrunler);
            this.grdUrunListesi.Location = new System.Drawing.Point(16, 33);
            this.grdUrunListesi.Margin = new System.Windows.Forms.Padding(4);
            this.grdUrunListesi.Name = "grdUrunListesi";
            this.grdUrunListesi.Padding = new System.Windows.Forms.Padding(4);
            this.grdUrunListesi.Size = new System.Drawing.Size(1868, 746);
            this.grdUrunListesi.TabIndex = 1;
            this.grdUrunListesi.TabStop = false;
            this.grdUrunListesi.Text = "Ürün İşlemleri";
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Enabled = false;
            this.txtGenelToplam.Location = new System.Drawing.Point(1587, 678);
            this.txtGenelToplam.Margin = new System.Windows.Forms.Padding(4);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(132, 22);
            this.txtGenelToplam.TabIndex = 17;
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSatisYap.ImageKey = "shopping-bag.png";
            this.btnSatisYap.ImageList = this.ımageList1;
            this.btnSatisYap.Location = new System.Drawing.Point(1188, 670);
            this.btnSatisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(189, 48);
            this.btnSatisYap.TabIndex = 16;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = true;
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1448, 687);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Genel Toplam:";
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(1245, 491);
            this.txtNot.Margin = new System.Windows.Forms.Padding(4);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(471, 117);
            this.txtNot.TabIndex = 13;
            this.txtNot.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1068, 540);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Not Ekle:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(995, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(723, 265);
            this.dataGridView1.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Kod";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Miktar";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "BirimFiyat";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Toplam";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1132, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Satış Yapılacak Ürünler";
            // 
            // txtMusteriAdSoyad
            // 
            this.txtMusteriAdSoyad.Enabled = false;
            this.txtMusteriAdSoyad.Location = new System.Drawing.Point(1148, 114);
            this.txtMusteriAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtMusteriAdSoyad.Name = "txtMusteriAdSoyad";
            this.txtMusteriAdSoyad.Size = new System.Drawing.Size(160, 22);
            this.txtMusteriAdSoyad.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1031, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Müşteri:";
            // 
            // btnMusteriSec
            // 
            this.btnMusteriSec.Location = new System.Drawing.Point(1331, 59);
            this.btnMusteriSec.Margin = new System.Windows.Forms.Padding(4);
            this.btnMusteriSec.Name = "btnMusteriSec";
            this.btnMusteriSec.Size = new System.Drawing.Size(75, 28);
            this.btnMusteriSec.TabIndex = 7;
            this.btnMusteriSec.Text = "Seç";
            this.btnMusteriSec.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1011, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşteri Telefon:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(940, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Satış İşlemi";
            // 
            // mskTxtMusteriTelefon
            // 
            this.mskTxtMusteriTelefon.Location = new System.Drawing.Point(1148, 63);
            this.mskTxtMusteriTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.mskTxtMusteriTelefon.Mask = "(999) 000-0000";
            this.mskTxtMusteriTelefon.Name = "mskTxtMusteriTelefon";
            this.mskTxtMusteriTelefon.Size = new System.Drawing.Size(160, 22);
            this.mskTxtMusteriTelefon.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEkle.ImageKey = "right-arrow.png";
            this.btnEkle.ImageList = this.ımageList1;
            this.btnEkle.Location = new System.Drawing.Point(856, 215);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(131, 75);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSil.ImageKey = "arrow.png";
            this.btnSil.ImageList = this.ımageList1;
            this.btnSil.Location = new System.Drawing.Point(856, 347);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(131, 69);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // grdSatilacakUrunler
            // 
            this.grdSatilacakUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSatilacakUrunler.Location = new System.Drawing.Point(8, 23);
            this.grdSatilacakUrunler.Margin = new System.Windows.Forms.Padding(4);
            this.grdSatilacakUrunler.Name = "grdSatilacakUrunler";
            this.grdSatilacakUrunler.RowHeadersWidth = 51;
            this.grdSatilacakUrunler.Size = new System.Drawing.Size(840, 722);
            this.grdSatilacakUrunler.TabIndex = 0;
            // 
            // lblPersonelAdSoyad
            // 
            this.lblPersonelAdSoyad.AutoSize = true;
            this.lblPersonelAdSoyad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblPersonelAdSoyad.Location = new System.Drawing.Point(1184, 14);
            this.lblPersonelAdSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            this.lblPersonelAdSoyad.Size = new System.Drawing.Size(82, 16);
            this.lblPersonelAdSoyad.TabIndex = 2;
            this.lblPersonelAdSoyad.Text = "personel adı";
            // 
            // lblYetki
            // 
            this.lblYetki.AutoSize = true;
            this.lblYetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYetki.Location = new System.Drawing.Point(1371, 14);
            this.lblYetki.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYetki.Name = "lblYetki";
            this.lblYetki.Size = new System.Drawing.Size(37, 17);
            this.lblYetki.TabIndex = 3;
            this.lblYetki.Text = "yetki";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 843);
            this.Controls.Add(this.lblYetki);
            this.Controls.Add(this.lblPersonelAdSoyad);
            this.Controls.Add(this.grdUrunListesi);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAnaSayfa";
            this.Text = "frmAnaSayfa";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grdUrunListesi.ResumeLayout(false);
            this.grdUrunListesi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSatilacakUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuTedarikci;
        private System.Windows.Forms.ToolStripMenuItem menuUrun;
        private System.Windows.Forms.ToolStripMenuItem menuSatis;
        private System.Windows.Forms.ToolStripMenuItem menuMusteri;
        private System.Windows.Forms.ToolStripMenuItem menuPersonel;
        private System.Windows.Forms.GroupBox grdUrunListesi;
        private System.Windows.Forms.DataGridView grdSatilacakUrunler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.MaskedTextBox mskTxtMusteriTelefon;
        private System.Windows.Forms.Label lblPersonelAdSoyad;
        private System.Windows.Forms.Label lblYetki;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMusteriSec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMusteriAdSoyad;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtNot;
        private System.Windows.Forms.Label label5;
    }
}