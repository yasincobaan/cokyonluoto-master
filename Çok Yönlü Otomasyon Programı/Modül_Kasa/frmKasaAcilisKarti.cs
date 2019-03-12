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
    public partial class frmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        bool Edit = false;
        int SecimID = -1;
        public frmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarasi();
            Listele();
        }
        void Temizle()
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarasi();
            txtKasaAdı.Text = "";
            txtAciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_KASALAR Kasa = new Fonksiyonlar.TBL_KASALAR();
                Kasa.ACİKLAMA = txtAciklama.Text;
                Kasa.KASAADI = txtKasaAdı.Text;
                Kasa.KASAKODU = txtKasaKodu.Text;
                Kasa.SAVEDATE = DateTime.Now;
                Kasa.SAVEUSER = AnaForm.UserID;
                DB.TBL_KASALAR.InsertOnSubmit(Kasa);
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Yeni Kasa Kaydı oluşturulmuştur");
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
                Fonksiyonlar.TBL_KASALAR Kasa = DB.TBL_KASALAR.First(s => s.ID == SecimID);
                Kasa.ACİKLAMA = txtAciklama.Text;
                Kasa.KASAADI = txtKasaAdı.Text;
                Kasa.KASAKODU = txtKasaKodu.Text;
                Kasa.EDİTDATE = DateTime.Now;
                Kasa.EDİTUSER = AnaForm.UserID;
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
                DB.TBL_KASALAR.DeleteOnSubmit(DB.TBL_KASALAR.First(s => s.ID == SecimID));
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
                txtAciklama.Text = gridView1.GetFocusedRowCellValue("ACİKLAMA").ToString();
                txtKasaAdı.Text = gridView1.GetFocusedRowCellValue("KASAADİ").ToString();
                txtKasaKodu.Text = gridView1.GetFocusedRowCellValue("KASAKODU").ToString();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }

        }
        void Listele()
        {
            var lst = from s in DB.TBL_KASALAR
                      select s;
            Liste.DataSource = lst;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKasaAdı.Text != "" && txtAciklama.Text != "")
            {
                if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
                else YeniKaydet();
            }
            else
            {
                MessageBox.Show("Kasa adı ve açıklama girilmesi gereklidir.", "İşlem Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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