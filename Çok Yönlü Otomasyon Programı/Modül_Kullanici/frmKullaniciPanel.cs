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
using System.Security.Cryptography;

namespace Çok_Yönlü_Otomasyon_Programı.Modül_Kullanici
{
    public partial class frmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool Ac = false;
        int KullaniciID = -1;
        public frmKullaniciPanel(int ID, bool Acc)
        {
            InitializeComponent();
            Ac = Acc;
            KullaniciID = ID;
            if (Ac)
            {
                KullaniciGetir(ID);
                txtKullanıcıAdı.Enabled = false;
            }

        }
        public static string MD5eDonustur(string metin)
        {
            MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
            return Sifrele(metin, pwd);
        }
        private static string Sifrele(string metin, HashAlgorithm alg)
        {
            byte[] byteDegeri = System.Text.Encoding.UTF8.GetBytes(metin);
            byte[] sifreliByte = alg.ComputeHash(byteDegeri);
            return Convert.ToBase64String(sifreliByte);
        }
        private void btnYeniKullanici_Load(object sender, EventArgs e)
        {

        }
        void YeniKaydet()
        {
            if (MD5eDonustur(txtSifre.Text)== MD5eDonustur(txtSıfreTekrar.Text))
            {
                if(txtIsim.Text=="")
                {
                    MessageBox.Show("Bir isim girişi yapmak zorundasınız.");
                    return;
                }
                else if(txtSoyIsim.Text=="")
                {
                    MessageBox.Show("Bir soyisim girişi yapmak zorundasınız.");
                    return;
                }
                else if (txtKullanıcıAdı.Text=="")
                {
                    MessageBox.Show("Bir kullanıcı adı girişi yapmak zorundasınız.");
                    return;
                }
                else if (txtSifre.Text=="")
                {
                    MessageBox.Show("Bir şifre girişi yapmak zorundasınız.");
                    return;
                }
                DialogResult Dr = MessageBox.Show(txtKullanıcıKodu.Text + "türünde bir kullanıcı açmak üzeresiniz. Emin misiniz?",
                    "Kullanıcı kaydı tamamlama", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (Dr== DialogResult.Yes)
                {
                    try
                    {
                        if (!Ac)
                        {
                            if (DB.TBL_KULLANICILAR.Where(s => s.KULLANICI == txtKullanıcıAdı.Text).Count() > 0)
                            {
                                MessageBox.Show("Böyle bir kullanıcı zaten açılmış. Aynı kullanıcı adını tekrar kullanamazsınız!");
                                return;
                            }
                        }
                        
                        Fonksiyonlar.TBL_KULLANICILAR Kullanici;
                        if (!Ac) Kullanici = new Fonksiyonlar.TBL_KULLANICILAR();
                        else Kullanici = DB.TBL_KULLANICILAR.First(s => s.ID == KullaniciID);
                        if (rBtnAktif.Checked) Kullanici.KODU = true;
                        if (rBtnPasif.Checked) Kullanici.KODU = false;
                        Kullanici.ISIM = txtIsim.Text;
                        Kullanici.SOYISIM = txtSoyIsim.Text;
                        Kullanici.KULLANICI = txtKullanıcıAdı.Text;
                        Kullanici.AKTİF = txtKullanıcıKodu.Text;
                        if (Ac) Kullanici.EDİTTİME = DateTime.Now;
                        else Kullanici.SAVEDATE = DateTime.Now;
                        Kullanici.SİFRE = MD5eDonustur(txtSifre.Text);
                        if (!Ac) DB.TBL_KULLANICILAR.InsertOnSubmit(Kullanici);
                        DB.SubmitChanges();
                        if (Ac) Mesajlar.Guncelle(true);
                        else Mesajlar.YeniKayıt(txtKullanıcıAdı.Text + " Kullanıcı kaydı açılmıştır");
                        Temizle();

                    }
                    catch (Exception EX)
                    {
                        Mesajlar.Hata(EX);
                    }
                }
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Temizle()
        {
            txtIsim.Text = "";
            txtKullanıcıAdı.Text = "";
            txtKullanıcıKodu.SelectedIndex = 1;
            txtSifre.Text = "";
            txtSoyIsim.Text = "";
            txtSıfreTekrar.Text = "";
            rBtnPasif.Checked = true;
            Ac = false;
            KullaniciID = -1;
        }
        void KullaniciGetir(int ID)
        {
            KullaniciID = ID;
            try
            {
                Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILAR.First(S => S.ID == KullaniciID);
                txtIsim.Text = Kullanici.ISIM;
                txtSoyIsim.Text = Kullanici.SOYISIM;
                txtKullanıcıAdı.Text = Kullanici.KULLANICI;
                txtSifre.Text = Kullanici.SİFRE;
                txtSıfreTekrar.Text = Kullanici.SİFRE;
                if (Kullanici.AKTİF=="Normal") txtKullanıcıKodu.SelectedIndex = 1;
                if (Kullanici.AKTİF == "Yönetici") txtKullanıcıKodu.SelectedIndex = 0;
                if (Kullanici.KODU.Value) rBtnAktif.Checked = true;
                if (!Kullanici.KODU.Value) rBtnPasif.Checked = true;

            }
            catch (Exception EX)
            {
                Mesajlar.Hata(EX);
            }
        }
    }
}