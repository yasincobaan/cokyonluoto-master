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

namespace Çok_Yönlü_Otomasyon_Programı.Modül_Banka
{
    public partial class frmBankaIslem : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;
        public frmBankaIslem()
        {
            InitializeComponent();
        }

        private void frmBankaIslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        void Temizle()
        {
            txtAçıklama.Text = "";
            txtBelgeNo.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            AnaForm.Aktarma = -1;

        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERİ Hareket = new Fonksiyonlar.TBL_BANKAHAREKETLERİ();
                Hareket.ACIKLAMA = txtAçıklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTÜRÜ = "Banka İşlem";
                if (radioBtnGiriş.Checked) Hareket.GCKODU = "G";
                if (radioBtnGiriş.Checked) Hareket.GCKODU = "C";
                Hareket.TARİH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERİ.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Banka İşlemi kaydı yapılmıştır");
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }
        void Güncelle()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERİ Hareket = DB.TBL_BANKAHAREKETLERİ.First(s => s.ID == IslemID);
                Hareket.ACIKLAMA = txtAçıklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTÜRÜ = "Banka İşlem";
                if (radioBtnGiriş.Checked) Hareket.GCKODU = "G";
                if (radioBtnGiriş.Checked) Hareket.GCKODU = "C";
                Hareket.TARİH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.EDİTTİME = DateTime.Now;
                Hareket.EDİTUSER = AnaForm.UserID;
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
                DB.TBL_BANKAHAREKETLERİ.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERİ.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERİ Hareket = DB.TBL_BANKAHAREKETLERİ.First(s => s.ID == IslemID);
                BankaAc(Hareket.BANKAID.Value);
                txtAçıklama.Text = Hareket.ACIKLAMA;
                txtBelgeNo.Text = Hareket.BELGENO;
                txtTarih.Text = Hareket.TARİH.Value.ToShortDateString();
                txtTutar.Text = Hareket.TUTAR.ToString();
                if (Hareket.GCKODU == "G") radioBtnGiriş.Checked = true;
                if (Hareket.GCKODU == "C") radioBtnÇıkış.Checked = true;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdı.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = DB.TBL_BANKALAR.First(s => s.ID == BankaID).HESAPNO;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHesapAdı_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }
    }
}