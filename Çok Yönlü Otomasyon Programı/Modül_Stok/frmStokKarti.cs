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

namespace Çok_Yönlü_Otomasyon_Programı.Modül_Stok
{
    public partial class frmStokKarti : DevExpress.XtraEditors.XtraForm
    {
        bool Edit = false;
        bool Resim = false;
        int GrupID = -1;
        int StokID = -1;

        OpenFileDialog dosya = new OpenFileDialog();
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Resimleme Resimleme = new Fonksiyonlar.Resimleme();
        public frmStokKarti()
        {
            InitializeComponent();
        }
        private void frmStokKarti_Load(object sender, EventArgs e)
        {
            txtStokKodu.Text = Numaralar.StokKodNumarasi();
        }
        void Temizle() {
            txtStokKodu.Text = Numaralar.StokKodNumarasi();
            txtStokAdı.Text = "";
            txtSatısKdv.Text = "0";
            txtSatısFiyati.Text = "0";
            txtGrupKodu.Text = "";
            txtGrupAdı.Text = "";
            txtBirim.SelectedIndex = 0;
            txtBarkod.Text = "";
            txtResim.Image = null;
            txtAlısKdv.Text = "0";
            txtAlısFiyati.Text = "0";
            Resim = false;
            Edit = false;
            GrupID = -1;
            StokID = -1;
            AnaForm.Aktarma = -1;
        }
        void ResimSecme() {
            dosya.Filter = "jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (dosya.ShowDialog() == DialogResult.OK)
            {
                txtResim.ImageLocation = dosya.FileName;
                Resim = true;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSecme();
        }

        void Yenikaydet()
        {
            try
            {
                Fonksiyonlar.TBL_STOKLAR Stok = new Fonksiyonlar.TBL_STOKLAR();
                Stok.STOKADI = txtStokAdı.Text;
                Stok.STOKALISFİYAT = decimal.Parse(txtAlısFiyati.Text);
                Stok.STOKALISKDV = decimal.Parse(txtAlısKdv.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBİRİM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtStokKodu.Text;
                if (Resim) Stok.STOKRESİM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(txtResim.Image));
                Stok.STOKSATISFİYAT = decimal.Parse(txtSatısFiyati.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtSatısKdv.Text);
                Stok.STOKSAVEDATE = DateTime.Now;
                Stok.STOKSAVEUSER = AnaForm.UserID;
                DB.TBL_STOKLAR.InsertOnSubmit(Stok);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Yeni stok kaydı oluşturuldu.");
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
                Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
                Stok.STOKADI = txtStokAdı.Text;
                Stok.STOKALISFİYAT = decimal.Parse(txtAlısFiyati.Text);
                Stok.STOKALISKDV = decimal.Parse(txtAlısKdv.Text);
                Stok.STOKBARKOD = txtBarkod.Text;
                Stok.STOKBİRİM = txtBirim.Text;
                Stok.STOKGRUPID = GrupID;
                Stok.STOKKODU = txtStokKodu.Text;
                if (Resim) Stok.STOKRESİM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(txtResim.Image));
                Stok.STOKSATISFİYAT = decimal.Parse(txtSatısFiyati.Text);
                Stok.STOKSATISKDV = decimal.Parse(txtSatısKdv.Text);
                Stok.STOKEDİTTİME = DateTime.Now;
                Stok.STOKEDİTUSER = AnaForm.UserID;

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
                DB.TBL_STOKLAR.DeleteOnSubmit(DB.TBL_STOKLAR.First(s => s.ID == StokID));
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }
        void GrupAc(int ID)
        {
            GrupID = ID;
            txtGrupAdı.Text = DB.TBL_STOKGRUPLARI.First(s => s.ID == GrupID).GRUPADI;
            txtGrupKodu.Text = DB.TBL_STOKGRUPLARI.First(s => s.ID == GrupID).GRUPKODU;
        }
        public void Ac(int ID)
        {
            Edit = true;
            StokID = ID;
            Fonksiyonlar.TBL_STOKLAR Stok = DB.TBL_STOKLAR.First(s => s.ID == StokID);
            GrupAc(Stok.STOKGRUPID.Value);
            txtResim.Image = Resimleme.ResimGetirme(Stok.STOKRESİM.ToArray());
            txtAlısFiyati.Text = Stok.STOKALISFİYAT.ToString();
            txtAlısKdv.Text = Stok.STOKALISKDV.ToString();
            txtBarkod.Text = Stok.STOKBARKOD;
            txtBirim.Text = Stok.STOKBİRİM;
            txtSatısFiyati.Text = Stok.STOKSATISFİYAT.ToString();
            txtSatısKdv.Text = Stok.STOKSATISKDV.ToString();
            txtStokAdı.Text = Stok.STOKADI;
            txtStokKodu.Text = Stok.STOKKODU;
        }

        private void txtStokKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.StokListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.StokGrupları(true);
            if (Id > 0)
            {
                GrupAc(Id);
            }
            AnaForm.Aktarma = -1;
        }

        

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Güncelle() == DialogResult.Yes)
            {
                Güncelle();
            }
            else
            {
                Yenikaydet();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && StokID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}