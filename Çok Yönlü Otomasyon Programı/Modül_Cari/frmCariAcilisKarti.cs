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
    public partial class frmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;
        public frmCariAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            txtCariKodu.Text = Numaralar.CariKodNumarasi();
        }
        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";
            foreach (Control CE in groupControl3.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";
            txtCariKodu.Text = Numaralar.CariKodNumarasi();
            Edit = false;
            CariID = -1;
            GrupID = -1;
            AnaForm.Aktarma = -1;

        }
        void Yenikaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARİLER Cari = new Fonksiyonlar.TBL_CARİLER();
                Cari.ADRES = txtAdres.Text;
                Cari.CARİADI = txtCariAdı.Text;
                Cari.CARİKODU = txtCariKodu.Text;
                Cari.FAX1 = txtfax1.Text;
                Cari.FAX2 = txtfax2.Text;
                Cari.GRUPID = GrupID;
                Cari.İLCE = txtİlçe.Text;
                Cari.MAILINFO = txtMail.Text;
                Cari.SEHİR = txtSehir.Text;
                Cari.TELEFON1 = txtTel1.Text;
                Cari.TELEFON2 = txtTel2.Text;
                Cari.ULKE = txtÜlke.Text;
                Cari.VERGİDAİRESİ = txtVergiDairesi.Text;
                Cari.VERGİNO = txtVergiNo.Text;
                Cari.WEBADRES = txtWebAdres.Text;
                Cari.YETKİLİ1 = txtYetkili1.Text;
                Cari.YETKİLİ2 = txtYetkili2.Text;
                Cari.YETKİLİ1EMAİLİ1 = txtYetkili1email.Text;
                Cari.YETKİLİ2EMAİLİ2 = txtYetkili2email.Text;
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARİLER.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Yeni Cari Kaydı oluşturulmuştur.");
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
                Fonksiyonlar.TBL_CARİLER Cari = DB.TBL_CARİLER.First(s => s.ID == CariID);
                Cari.ADRES = txtAdres.Text;
                Cari.CARİADI = txtCariAdı.Text;
                Cari.CARİKODU = txtCariKodu.Text;
                Cari.FAX1 = txtfax1.Text;
                Cari.FAX2 = txtfax2.Text;
                Cari.GRUPID = GrupID;
                Cari.İLCE = txtİlçe.Text;
                Cari.MAILINFO = txtMail.Text;
                Cari.SEHİR = txtSehir.Text;
                Cari.TELEFON1 = txtTel1.Text;
                Cari.TELEFON2 = txtTel2.Text;
                Cari.ULKE = txtÜlke.Text;
                Cari.VERGİDAİRESİ = txtVergiDairesi.Text;
                Cari.VERGİNO = txtVergiNo.Text;
                Cari.WEBADRES = txtWebAdres.Text;
                Cari.YETKİLİ1 = txtYetkili1.Text;
                Cari.YETKİLİ2 = txtYetkili2.Text;
                Cari.YETKİLİ1EMAİLİ1 = txtYetkili1email.Text;
                Cari.YETKİLİ2EMAİLİ2 = txtYetkili2email.Text;
                Cari.EDİTDATE = DateTime.Now;
                Cari.EDİTUSER = AnaForm.UserID;
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
                DB.TBL_CARİLER.DeleteOnSubmit(DB.TBL_CARİLER.First(s => s.ID == CariID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                Fonksiyonlar.TBL_CARİGRUPLARI Grup = DB.TBL_CARİGRUPLARI.First(s => s.ID == GrupID);
                txtCariGrupAdı.Text = Grup.GRUPADI;
                txtCariGrupKodu.Text = Grup.GRUPKODU;
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
                CariID = ID;
                Fonksiyonlar.TBL_CARİLER Cari = DB.TBL_CARİLER.First(s => s.ID == CariID);
                txtAdres.Text = Cari.ADRES;
                txtCariAdı.Text = Cari.CARİADI;
                txtCariKodu.Text = Cari.CARİKODU;
                txtfax1.Text = Cari.FAX1;
                txtfax2.Text = Cari.FAX2;
                txtİlçe.Text = Cari.İLCE;
                txtMail.Text = Cari.MAILINFO;
                txtSehir.Text = Cari.SEHİR;
                txtTel1.Text = Cari.TELEFON1;
                txtTel2.Text = Cari.TELEFON2;
                txtÜlke.Text = Cari.ULKE;
                txtVergiDairesi.Text = Cari.VERGİDAİRESİ;
                txtVergiNo.Text = Cari.VERGİNO;
                txtWebAdres.Text = Cari.WEBADRES;
                txtYetkili1.Text = Cari.YETKİLİ1;
                txtYetkili2.Text = Cari.YETKİLİ2;
                txtYetkili1email.Text = Cari.YETKİLİ1EMAİLİ1;
                txtYetkili2email.Text = Cari.YETKİLİ2EMAİLİ2;
                GrupAc(Cari.GRUPID.Value);
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            if (ID > 0)
            {
                Ac(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void txtCariGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariGrupları(true);
            if (ID > 0)
            {
                GrupAc(ID);
            }
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
            else Yenikaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}