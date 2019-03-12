namespace Çok_Yönlü_Otomasyon_Programı.Modül_Kasa
{
    partial class frmKasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasaHareketleri));
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Sağtik = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.devirKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BELGENO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKTÜRÜ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EVRAKID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GİRİS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CIKIS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtKasaAdı = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtBakiye = new DevExpress.XtraEditors.TextEdit();
            this.txtÇıkış = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtGiriş = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.Sağtik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdı.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtÇıkış.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiriş.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tahsilatÖdemeİşleminiDüzenleToolStripMenuItem
            // 
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Enabled = false;
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Name = "tahsilatÖdemeİşleminiDüzenleToolStripMenuItem";
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Text = "Tahsilat/Ödeme İşlemini Düzenle";
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Click += new System.EventHandler(this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem_Click);
            // 
            // Sağtik
            // 
            this.Sağtik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devirKartıToolStripMenuItem,
            this.tahsilatÖdemeİşleminiDüzenleToolStripMenuItem});
            this.Sağtik.Name = "Sağtik";
            this.Sağtik.Size = new System.Drawing.Size(248, 48);
            this.Sağtik.Opening += new System.ComponentModel.CancelEventHandler(this.Sağtik_Opening);
            // 
            // devirKartıToolStripMenuItem
            // 
            this.devirKartıToolStripMenuItem.Enabled = false;
            this.devirKartıToolStripMenuItem.Name = "devirKartıToolStripMenuItem";
            this.devirKartıToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.devirKartıToolStripMenuItem.Text = "Devir Kartı İşlemini Düzenle";
            this.devirKartıToolStripMenuItem.Click += new System.EventHandler(this.devirKartıToolStripMenuItem_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Kasa Kodu:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 101);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(761, 255);
            this.groupControl2.TabIndex = 5;
            this.groupControl2.Text = "Hareket Listesi";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(2, 20);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(757, 233);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.BELGENO,
            this.EVRAKTÜRÜ,
            this.EVRAKID,
            this.GİRİS,
            this.CIKIS,
            this.ACIKLAMA});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.OptionsColumn.AllowEdit = false;
            this.ID.OptionsColumn.AllowFocus = false;
            this.ID.OptionsColumn.FixedWidth = true;
            // 
            // BELGENO
            // 
            this.BELGENO.Caption = "BELGENO";
            this.BELGENO.FieldName = "BELGENO";
            this.BELGENO.Name = "BELGENO";
            this.BELGENO.OptionsColumn.AllowEdit = false;
            this.BELGENO.OptionsColumn.AllowFocus = false;
            this.BELGENO.OptionsColumn.FixedWidth = true;
            this.BELGENO.Visible = true;
            this.BELGENO.VisibleIndex = 0;
            // 
            // EVRAKTÜRÜ
            // 
            this.EVRAKTÜRÜ.Caption = "EVRAKTÜRÜ";
            this.EVRAKTÜRÜ.FieldName = "EVRAKTÜRÜ";
            this.EVRAKTÜRÜ.Name = "EVRAKTÜRÜ";
            this.EVRAKTÜRÜ.OptionsColumn.AllowEdit = false;
            this.EVRAKTÜRÜ.OptionsColumn.AllowFocus = false;
            this.EVRAKTÜRÜ.OptionsColumn.FixedWidth = true;
            this.EVRAKTÜRÜ.Visible = true;
            this.EVRAKTÜRÜ.VisibleIndex = 1;
            // 
            // EVRAKID
            // 
            this.EVRAKID.Caption = "EVRAKID";
            this.EVRAKID.FieldName = "EVRAKID";
            this.EVRAKID.Name = "EVRAKID";
            this.EVRAKID.OptionsColumn.AllowEdit = false;
            this.EVRAKID.OptionsColumn.AllowFocus = false;
            this.EVRAKID.OptionsColumn.FixedWidth = true;
            this.EVRAKID.Visible = true;
            this.EVRAKID.VisibleIndex = 2;
            // 
            // GİRİS
            // 
            this.GİRİS.Caption = "GİRİS";
            this.GİRİS.FieldName = "GİRİS";
            this.GİRİS.Name = "GİRİS";
            this.GİRİS.OptionsColumn.AllowEdit = false;
            this.GİRİS.OptionsColumn.AllowFocus = false;
            this.GİRİS.OptionsColumn.FixedWidth = true;
            this.GİRİS.Visible = true;
            this.GİRİS.VisibleIndex = 3;
            // 
            // CIKIS
            // 
            this.CIKIS.Caption = "CIKIS";
            this.CIKIS.FieldName = "CIKIS";
            this.CIKIS.Name = "CIKIS";
            this.CIKIS.OptionsColumn.AllowEdit = false;
            this.CIKIS.OptionsColumn.AllowFocus = false;
            this.CIKIS.OptionsColumn.FixedWidth = true;
            this.CIKIS.Visible = true;
            this.CIKIS.VisibleIndex = 4;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "ACIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            this.ACIKLAMA.OptionsColumn.AllowEdit = false;
            this.ACIKLAMA.OptionsColumn.AllowFocus = false;
            this.ACIKLAMA.OptionsColumn.FixedWidth = true;
            this.ACIKLAMA.Visible = true;
            this.ACIKLAMA.VisibleIndex = 5;
            // 
            // txtKasaAdı
            // 
            this.txtKasaAdı.Location = new System.Drawing.Point(112, 58);
            this.txtKasaAdı.Name = "txtKasaAdı";
            this.txtKasaAdı.Properties.ReadOnly = true;
            this.txtKasaAdı.Size = new System.Drawing.Size(327, 20);
            this.txtKasaAdı.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(448, 31);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Giriş:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(45, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Kasa Adı:";
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(112, 28);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Size = new System.Drawing.Size(327, 20);
            this.txtKasaKodu.TabIndex = 0;
            this.txtKasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaKodu_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtBakiye);
            this.groupControl1.Controls.Add(this.txtÇıkış);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtGiriş);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtKasaAdı);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(761, 101);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Banka Bilgileri";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(638, 28);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Properties.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(100, 20);
            this.txtBakiye.TabIndex = 4;
            // 
            // txtÇıkış
            // 
            this.txtÇıkış.Location = new System.Drawing.Point(478, 58);
            this.txtÇıkış.Name = "txtÇıkış";
            this.txtÇıkış.Properties.ReadOnly = true;
            this.txtÇıkış.Size = new System.Drawing.Size(100, 20);
            this.txtÇıkış.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(597, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Bakiye:";
            // 
            // txtGiriş
            // 
            this.txtGiriş.Location = new System.Drawing.Point(478, 28);
            this.txtGiriş.Name = "txtGiriş";
            this.txtGiriş.Properties.ReadOnly = true;
            this.txtGiriş.Size = new System.Drawing.Size(100, 20);
            this.txtGiriş.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(447, 61);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(25, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Çıkış:";
            // 
            // frmKasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 356);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Hareketleri";
            this.Load += new System.EventHandler(this.frmKasaHareketleri_Load);
            this.Sağtik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdı.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBakiye.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtÇıkış.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiriş.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tahsilatÖdemeİşleminiDüzenleToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Sağtik;
        private System.Windows.Forms.ToolStripMenuItem devirKartıToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn BELGENO;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKTÜRÜ;
        private DevExpress.XtraGrid.Columns.GridColumn EVRAKID;
        private DevExpress.XtraGrid.Columns.GridColumn GİRİS;
        private DevExpress.XtraGrid.Columns.GridColumn CIKIS;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
        private DevExpress.XtraEditors.TextEdit txtKasaAdı;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ButtonEdit txtKasaKodu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtBakiye;
        private DevExpress.XtraEditors.TextEdit txtÇıkış;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtGiriş;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}