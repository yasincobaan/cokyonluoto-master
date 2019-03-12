namespace Çok_Yönlü_Otomasyon_Programı.Modül_Stok
{
    partial class frmStokKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStokKarti));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnResimSec = new DevExpress.XtraEditors.SimpleButton();
            this.txtResim = new System.Windows.Forms.PictureBox();
            this.txtStokAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtStokKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatısKdv = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAlısKdv = new DevExpress.XtraEditors.TextEdit();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.txtBirim = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSatısFiyati = new DevExpress.XtraEditors.TextEdit();
            this.txtAlısFiyati = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.txtGrupKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.txtGrupAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatısKdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlısKdv.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatısFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlısFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdı.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnResimSec);
            this.groupControl1.Controls.Add(this.txtResim);
            this.groupControl1.Controls.Add(this.txtStokAdı);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtStokKodu);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(457, 94);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Ana Stok Bilgileri";
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(378, 24);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(72, 59);
            this.btnResimSec.TabIndex = 2;
            this.btnResimSec.Text = "Stok \r\nResmi \r\nSeç";
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(245, 24);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(127, 59);
            this.txtResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtResim.TabIndex = 2;
            this.txtResim.TabStop = false;
            // 
            // txtStokAdı
            // 
            this.txtStokAdı.Location = new System.Drawing.Point(73, 63);
            this.txtStokAdı.Name = "txtStokAdı";
            this.txtStokAdı.Size = new System.Drawing.Size(168, 20);
            this.txtStokAdı.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Stok Adı :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Stok Kodu :";
            // 
            // txtStokKodu
            // 
            this.txtStokKodu.Location = new System.Drawing.Point(73, 31);
            this.txtStokKodu.Name = "txtStokKodu";
            this.txtStokKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtStokKodu.Size = new System.Drawing.Size(168, 20);
            this.txtStokKodu.TabIndex = 0;
            this.txtStokKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtStokKodu_ButtonClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl7);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Controls.Add(this.groupControl6);
            this.groupControl2.Controls.Add(this.groupControl4);
            this.groupControl2.Location = new System.Drawing.Point(3, 101);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(457, 234);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Genel Stok Bilgileri";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.labelControl8);
            this.groupControl7.Controls.Add(this.txtSatısKdv);
            this.groupControl7.Controls.Add(this.labelControl7);
            this.groupControl7.Controls.Add(this.txtAlısKdv);
            this.groupControl7.Location = new System.Drawing.Point(267, 118);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(183, 104);
            this.groupControl7.TabIndex = 3;
            this.groupControl7.Text = "KDV Bilgileri  %";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 32);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(45, 13);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Alış KDV :";
            // 
            // txtSatısKdv
            // 
            this.txtSatısKdv.Location = new System.Drawing.Point(82, 57);
            this.txtSatısKdv.Name = "txtSatısKdv";
            this.txtSatısKdv.Properties.Mask.EditMask = "c";
            this.txtSatısKdv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSatısKdv.Size = new System.Drawing.Size(83, 20);
            this.txtSatısKdv.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 64);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Satış KDV :";
            // 
            // txtAlısKdv
            // 
            this.txtAlısKdv.Location = new System.Drawing.Point(82, 25);
            this.txtAlısKdv.Name = "txtAlısKdv";
            this.txtAlısKdv.Properties.Mask.EditMask = "c";
            this.txtAlısKdv.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAlısKdv.Size = new System.Drawing.Size(83, 20);
            this.txtAlısKdv.TabIndex = 0;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Controls.Add(this.labelControl5);
            this.groupControl5.Controls.Add(this.txtBarkod);
            this.groupControl5.Controls.Add(this.txtBirim);
            this.groupControl5.Location = new System.Drawing.Point(5, 118);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(256, 104);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Barkod ve Birim";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(29, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Birim :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(11, 64);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(40, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Barkod :";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(71, 61);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(165, 20);
            this.txtBarkod.TabIndex = 1;
            // 
            // txtBirim
            // 
            this.txtBirim.EditValue = "Adet";
            this.txtBirim.Location = new System.Drawing.Point(71, 29);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBirim.Properties.Items.AddRange(new object[] {
            "Adet",
            "Tane",
            "Kilo",
            "Metre"});
            this.txtBirim.Size = new System.Drawing.Size(165, 20);
            this.txtBirim.TabIndex = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.labelControl10);
            this.groupControl6.Controls.Add(this.labelControl9);
            this.groupControl6.Controls.Add(this.txtSatısFiyati);
            this.groupControl6.Controls.Add(this.txtAlısFiyati);
            this.groupControl6.Location = new System.Drawing.Point(267, 23);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(183, 89);
            this.groupControl6.TabIndex = 2;
            this.groupControl6.Text = "Fiyat Bilgileri";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(17, 30);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 13);
            this.labelControl10.TabIndex = 0;
            this.labelControl10.Text = "Alış Fiyatı :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(17, 58);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 13);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "Satış Fiyatı :";
            // 
            // txtSatısFiyati
            // 
            this.txtSatısFiyati.Location = new System.Drawing.Point(82, 55);
            this.txtSatısFiyati.Name = "txtSatısFiyati";
            this.txtSatısFiyati.Properties.Mask.EditMask = "c";
            this.txtSatısFiyati.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSatısFiyati.Size = new System.Drawing.Size(83, 20);
            this.txtSatısFiyati.TabIndex = 1;
            // 
            // txtAlısFiyati
            // 
            this.txtAlısFiyati.Location = new System.Drawing.Point(82, 23);
            this.txtAlısFiyati.Name = "txtAlısFiyati";
            this.txtAlısFiyati.Properties.Mask.EditMask = "c";
            this.txtAlısFiyati.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAlısFiyati.Size = new System.Drawing.Size(83, 20);
            this.txtAlısFiyati.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.txtGrupKodu);
            this.groupControl4.Controls.Add(this.labelControl11);
            this.groupControl4.Controls.Add(this.txtGrupAdı);
            this.groupControl4.Controls.Add(this.labelControl12);
            this.groupControl4.Location = new System.Drawing.Point(5, 23);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(256, 89);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Grup Bilgileri";
            // 
            // txtGrupKodu
            // 
            this.txtGrupKodu.Location = new System.Drawing.Point(71, 23);
            this.txtGrupKodu.Name = "txtGrupKodu";
            this.txtGrupKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtGrupKodu.Size = new System.Drawing.Size(165, 20);
            this.txtGrupKodu.TabIndex = 0;
            this.txtGrupKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtGrupKodu_ButtonClick);
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(11, 26);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(57, 13);
            this.labelControl11.TabIndex = 0;
            this.labelControl11.Text = "Grup Kodu :";
            // 
            // txtGrupAdı
            // 
            this.txtGrupAdı.Location = new System.Drawing.Point(71, 55);
            this.txtGrupAdı.Name = "txtGrupAdı";
            this.txtGrupAdı.Size = new System.Drawing.Size(165, 20);
            this.txtGrupAdı.TabIndex = 1;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(11, 58);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(48, 13);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "Grup Adı :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(8, 341);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(89, 39);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(103, 341);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 39);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(198, 341);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(89, 39);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmStokKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 387);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok Kartı";
            this.Load += new System.EventHandler(this.frmStokKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStokKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatısKdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlısKdv.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBirim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            this.groupControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatısFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlısFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrupAdı.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnResimSec;
        private System.Windows.Forms.PictureBox txtResim;
        private DevExpress.XtraEditors.TextEdit txtStokAdı;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ButtonEdit txtStokKodu;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtSatısKdv;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtAlısKdv;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraEditors.ComboBoxEdit txtBirim;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtSatısFiyati;
        private DevExpress.XtraEditors.TextEdit txtAlısFiyati;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ButtonEdit txtGrupKodu;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit txtGrupAdı;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}