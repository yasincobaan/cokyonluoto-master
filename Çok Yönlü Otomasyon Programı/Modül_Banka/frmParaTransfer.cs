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
    public partial class frmParaTransfer : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        bool Edit = false;
        int BankaID = -1;
        int CariID = -1;
        int IslemID = -1;
        string İslemTürü = "Banka Havale";
        
        public frmParaTransfer()
        {
            InitializeComponent();
        }

        private void frmParaTransfer_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtTransferTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferTürü.SelectedIndex == 00)
            {
                radioBtnGelenHavale.Text = "Gelen Havale";
                radioBtnGidenHavale.Text = "Giden Havale";
                İslemTürü = "Banka Havale";
            }
            else if (txtTransferTürü.SelectedIndex == 1)
            {
                radioBtnGelenHavale.Text = "Gelen EFT";
                radioBtnGidenHavale.Text = "Giden Havale";
                İslemTürü = "Banka EFT";
            }
        }
        void Temizle()
        {
            txtAçıklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariKodu.Text = "";
            txtHesapAdı.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            BankaID = -1;
            CariID = -1;
            IslemID = -1;
            AnaForm.Aktarma = -1;
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
                mesajlar.Hata(e);
            }
        }
        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariKodu.Text = DB.TBL_CARİLER.First(s => s.ID == CariID).CARİKODU;
                txtCaariAdı.Text = DB.TBL_CARİLER.First(s => s.ID == CariID).CARİADI;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERİ Banka = new Fonksiyonlar.TBL_BANKAHAREKETLERİ();
                Banka.ACIKLAMA = txtAçıklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARİID = CariID;
                Banka.EVRAKTÜRÜ = txtTransferTürü.SelectedItem.ToString();
                if (radioBtnGelenHavale.Checked) Banka.GCKODU = "G";
                if (radioBtnGidenHavale.Checked) Banka.GCKODU = "C";
                Banka.TARİH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                DB.TBL_BANKAHAREKETLERİ.InsertOnSubmit(Banka);
                DB.SubmitChanges();

                Fonksiyonlar.TBL_CARİHAREKETLERİ Cari = new Fonksiyonlar.TBL_CARİHAREKETLERİ();
                Cari.ACIKLAMA = txtAçıklama.Text;
                if (radioBtnGelenHavale.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (radioBtnGidenHavale.Checked) Cari.BORC = int.Parse(txtTutar.Text);
                Cari.CARİID = CariID;
                Cari.EVRAKID = BankaID;
                Cari.EVRAKTURU = txtTransferTürü.SelectedItem.ToString();
                Cari.TARİH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTürü.SelectedIndex == 0) Cari.TİPİ = "BH";
                if (txtTransferTürü.SelectedIndex == 1) Cari.TİPİ = "EFT";
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARİHAREKETLERİ.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                mesajlar.YeniKayıt("Para Transfer kaydı işlendi.");
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Güncelle()
        {
            try
            {
                Fonksiyonlar.TBL_BANKAHAREKETLERİ Banka = DB.TBL_BANKAHAREKETLERİ.First(s => s.ID == IslemID);
                Banka.ACIKLAMA = txtAçıklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARİID = CariID;
                Banka.EVRAKTÜRÜ = txtTransferTürü.SelectedItem.ToString();
                if (radioBtnGelenHavale.Checked) Banka.GCKODU = "G";
                if (radioBtnGidenHavale.Checked) Banka.GCKODU = "C";
                Banka.TARİH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.EDİTTİME = DateTime.Now;
                Banka.EDİTUSER = AnaForm.UserID;
                DB.SubmitChanges();

                Fonksiyonlar.TBL_CARİHAREKETLERİ Cari = DB.TBL_CARİHAREKETLERİ.First(s => s.EVRAKTURU == txtTransferTürü.SelectedItem.ToString() && s.EVRAKID == IslemID);
                Cari.ACIKLAMA = txtAçıklama.Text;
                if (radioBtnGelenHavale.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (radioBtnGidenHavale.Checked) Cari.BORC = int.Parse(txtTutar.Text);
                Cari.CARİID = CariID;
                Cari.EVRAKID = BankaID;
                Cari.EVRAKTURU = txtTransferTürü.SelectedItem.ToString();
                Cari.TARİH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTürü.SelectedIndex == 0) Cari.TİPİ = "BH";
                if (txtTransferTürü.SelectedIndex == 1) Cari.TİPİ = "EFT";
                Cari.EDİTDATE = DateTime.Now;
                Cari.EDİTUSER = AnaForm.UserID;
                DB.SubmitChanges();
                mesajlar.YeniKayıt("Para Transfer kaydı güncellenmiştir.");
                Temizle();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                DB.TBL_CARİHAREKETLERİ.DeleteOnSubmit(DB.TBL_CARİHAREKETLERİ.First(s => s.EVRAKTURU == txtTransferTürü.SelectedItem.ToString() && s.EVRAKID == IslemID));
                DB.SubmitChanges();
                DB.TBL_BANKAHAREKETLERİ.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERİ.First(s => s.ID == IslemID));
                DB.SubmitChanges();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }
        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                Fonksiyonlar.TBL_BANKAHAREKETLERİ Banka = DB.TBL_BANKAHAREKETLERİ.First(s => s.ID == IslemID);
                BankaAc(Banka.BANKAID.Value);
                CariAc(Banka.CARİID.Value);
                txtAçıklama.Text = Banka.ACIKLAMA;
                txtBelgeNo.Text = Banka.BELGENO;
                txtTarih.Text = Banka.TARİH.Value.ToShortDateString();
                txtTransferTürü.Text = Banka.EVRAKTÜRÜ;
                txtTutar.Text = Banka.TUTAR.ToString();
                if (Banka.GCKODU == "G") radioBtnGelenHavale.Checked = true;
                if (Banka.GCKODU == "C") radioBtnGidenHavale.Checked = true;
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtHesapAdı_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma=-1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = formlar.CariListesi(true);
            if (Id > 0) CariAc(Id);
            AnaForm.Aktarma = -1;
        }
    }
}