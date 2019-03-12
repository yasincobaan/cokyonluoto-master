using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Çok_Yönlü_Otomasyon_Programı.Modül_Cari
{
    public partial class frmCariGruplari : DevExpress.XtraEditors.XtraForm
    {
        public frmCariGruplari()
        {
            InitializeComponent();
        }

        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool Edit = false;
        int SecimID = -1;
        public bool Secim = false;
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && SecimID > 0)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
        void Listele()
        {
            var lst = from s in DB.TBL_CARİGRUPLARI
                      select s;
            Liste.DataSource = lst;
        }
        void Temizle()
        {
            txtGrupAdı.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }
        void Yenikaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARİGRUPLARI Grup = new Fonksiyonlar.TBL_CARİGRUPLARI();
                Grup.GRUPADI = txtGrupAdı.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.SAVEDATE = DateTime.Now;
                Grup.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARİGRUPLARI.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Yeni Cari Grup Kaydı Oluşturuldu.");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARİGRUPLARI Grup = DB.TBL_CARİGRUPLARI.First(s => s.ID == SecimID);
                Grup.GRUPADI = txtGrupAdı.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.EDİTDATE = DateTime.Now;
                Grup.EDİTUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                DB.TBL_CARİGRUPLARI.DeleteOnSubmit(DB.TBL_CARİGRUPLARI.First(S => S.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdı.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
                Edit = false;
                SecimID = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Guncelle();
            else Yenikaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}