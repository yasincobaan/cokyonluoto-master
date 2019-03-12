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

namespace Çok_Yönlü_Otomasyon_Programı.Modül_Kasa
{
    public partial class frmKasaTahsilatÖdeme : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();

        bool Edit = false;
        int IslemID = -1;
        int KasaID = -1;
        int CariID = -1;
        int CariHareketID = -1;
        
        public frmKasaTahsilatÖdeme()
        {
            InitializeComponent();
        }
        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdı.Text = "";
            txtCariKodu.Text = "";
            txtİslemTürü.SelectedIndex = 0;
            txtKasaAdı.Text = "";
            txtKasaKodu.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            KasaID = -1;
            CariID = -1;
            CariHareketID = -1;
            AnaForm.Aktarma = -1;
        }
        void KasaAc(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaAdı.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).KASAADI;
                txtKasaKodu.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).KASAKODU;
            }
            catch (Exception)
            {
                KasaID = -1;
            }
        }
        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariAdı.Text = DB.TBL_CARİLER.First(s => s.ID == KasaID).CARİADI;
                txtCariKodu.Text = DB.TBL_CARİLER.First(s => s.ID == KasaID).CARİKODU;
            }
            catch (Exception)
            {
                CariID = -1;
            }
        }
        void Yenikaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASAHAREKETLERİ Kasahareket = new Fonksiyonlar.TBL_KASAHAREKETLERİ();
                Kasahareket.ACIKLAMA = txtAciklama.Text;
                Kasahareket.BELGENO = txtBelgeNo.Text;
                Kasahareket.CARİID = CariID;
                Kasahareket.EVRAKTURU = txtİslemTürü.SelectedItem.ToString();
                if (txtİslemTürü.SelectedIndex == 0) Kasahareket.GCKODU = "G";
                if (txtİslemTürü.SelectedIndex == 1) Kasahareket.GCKODU = "C";
                Kasahareket.KASAID = KasaID;
                Kasahareket.SAVEDATE = DateTime.Now;
                Kasahareket.SAVEUSER = AnaForm.UserID;
                Kasahareket.TARİH = DateTime.Parse(txtTarih.Text);
                Kasahareket.TUTAR = decimal.Parse(txtTutar.Text);
                DB.TBL_KASAHAREKETLERİ.InsertOnSubmit(Kasahareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt(txtİslemTürü.SelectedText + "Yeni Kasa Hareketi olarak İşlenmiştir");
                Fonksiyonlar.TBL_CARİHAREKETLERİ CariHareket = new Fonksiyonlar.TBL_CARİHAREKETLERİ();
                CariHareket.ACIKLAMA = txtBelgeNo.Text + "Belge Numaralı" + txtİslemTürü.SelectedItem.ToString();
                if (txtİslemTürü.SelectedIndex == 0) CariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtİslemTürü.SelectedIndex == 1) CariHareket.BORC = int.Parse(txtTutar.Text);
                CariHareket.CARİID = CariID;
                CariHareket.EVRAKID = Kasahareket.ID;
                CariHareket.EVRAKTURU = txtİslemTürü.SelectedItem.ToString();
                CariHareket.TARİH = DateTime.Parse(txtTarih.Text);
                if (txtİslemTürü.SelectedIndex == 0) CariHareket.TİPİ = "KT";
                if (txtİslemTürü.SelectedIndex == 1) CariHareket.TİPİ = "KÖ";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARİHAREKETLERİ.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt(txtİslemTürü.SelectedText + "Yeni Cari Hareketi olarak İşlenmiştir");
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
                Fonksiyonlar.TBL_KASAHAREKETLERİ Kasahareket = DB.TBL_KASAHAREKETLERİ.First(s => s.ID == IslemID);

                Kasahareket.ACIKLAMA = txtAciklama.Text;
                Kasahareket.BELGENO = txtBelgeNo.Text;
                Kasahareket.CARİID = CariID;
                Kasahareket.EVRAKTURU = txtİslemTürü.SelectedItem.ToString();
                if (txtİslemTürü.SelectedIndex == 0) Kasahareket.GCKODU = "G";
                if (txtİslemTürü.SelectedIndex == 1) Kasahareket.GCKODU = "C";
                Kasahareket.KASAID = KasaID;
                Kasahareket.EDİTDATE = DateTime.Now;
                Kasahareket.EDİTUSER =  AnaForm.UserID;
                Kasahareket.TARİH = DateTime.Parse(txtTarih.Text);
                Kasahareket.TUTAR = decimal.Parse(txtTutar.Text);
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Fonksiyonlar.TBL_CARİHAREKETLERİ CariHareket = DB.TBL_CARİHAREKETLERİ.First(s => s.ID == CariHareketID);
                CariHareket.ACIKLAMA = txtBelgeNo.Text + "Belge Numaralı" + txtİslemTürü.SelectedItem.ToString();
                if (txtİslemTürü.SelectedIndex == 0) CariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtİslemTürü.SelectedIndex == 1) CariHareket.BORC = int.Parse(txtTutar.Text);
                CariHareket.CARİID = CariID;
                CariHareket.EVRAKID = Kasahareket.ID;
                CariHareket.EVRAKTURU = txtİslemTürü.SelectedItem.ToString();
                CariHareket.TARİH = DateTime.Parse(txtTarih.Text);
                if (txtİslemTürü.SelectedIndex == 0) CariHareket.TİPİ = "KT";
                if (txtİslemTürü.SelectedIndex == 1) CariHareket.TİPİ = "KÖ";
                CariHareket.EDİTDATE = DateTime.Now;
                CariHareket.EDİTUSER = AnaForm.UserID;
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
                DB.TBL_KASAHAREKETLERİ.DeleteOnSubmit(DB.TBL_KASAHAREKETLERİ.First(s => s.ID == IslemID));
                DB.TBL_CARİHAREKETLERİ.DeleteOnSubmit(DB.TBL_CARİHAREKETLERİ.First(s => s.ID == IslemID));
                Temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }
        public void Ac(int HareketID)
        {
            try
            {
                Edit = true;
                IslemID = HareketID;
                Fonksiyonlar.TBL_KASAHAREKETLERİ KasaHareketi = DB.TBL_KASAHAREKETLERİ.First(s => s.ID == IslemID);
                CariHareketID = DB.TBL_CARİHAREKETLERİ.First(s => s.EVRAKTURU == KasaHareketi.EVRAKTURU && s.EVRAKID == IslemID).ID;
                MessageBox.Show("Cari Hareket ID : " + CariHareketID.ToString());
                txtAciklama.Text = KasaHareketi.ACIKLAMA;
                txtBelgeNo.Text = KasaHareketi.BELGENO;
                if (KasaHareketi.EVRAKTURU == "Kasa Tahsilat") txtİslemTürü.SelectedIndex = 0;
                if (KasaHareketi.EVRAKTURU == "Kasa Ödeme") txtİslemTürü.SelectedIndex = 1;
                KasaAc(KasaHareketi.KASAID.Value);
                CariAc(KasaHareketi.CARİID.Value);


            }
            catch (Exception e)
            {
                Temizle();
                Mesajlar.Hata(e);
            }
        }
        private void frmKasaTahsilatÖdeme_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
            else Yenikaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtİslemTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            //IslemTürü = txtİslemTürü.SelectedItem.ToString();
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.KasaListesi(true);
            if (Id > 0)
            {
                KasaAc(Id);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0)
            {
                CariAc(Id);
                AnaForm.Aktarma = -1;
            }
        }
    }
}