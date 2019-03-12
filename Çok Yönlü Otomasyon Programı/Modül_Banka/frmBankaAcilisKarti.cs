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
    public partial class frmBankaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        bool Edit = false;
        int SecimID = -1;
        public frmBankaAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmBankaAcilisKarti_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Temizle()
        {
            txtAdres.Text = "";
            txtBankaAdı.Text = "";
            txtHesapTürü.Text = "";
            txtHesapNo.Text = "";
            txtIBAN.Text = "";
            txtBankaSubesi.Text = "";
            txtSubeTel.Text = "";
            txtYetkili.Text = "";
            txtYetEmail.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();

        }
        void Listele()
        {
            var lst = from s in DB.TBL_BANKALAR
                      select s;
            Liste.DataSource = lst;
        }
        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = new Fonksiyonlar.TBL_BANKALAR();
                Banka.ADRES = txtAdres.Text;
                Banka.BANKAADI = txtBankaAdı.Text;
                Banka.HESAPADI = txtHesapTürü.Text;
                Banka.HESAPNO = txtHesapNo.Text;
                Banka.IBAN = txtIBAN.Text;
                Banka.SUBE = txtBankaSubesi.Text;
                Banka.TEL = txtSubeTel.Text;
                Banka.TEMSILCI = txtYetkili.Text;
                Banka.TEMSILCIEMAIL = txtYetEmail.Text;
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Mesajlar.YeniKayıt("Yeni Banka kaydı Açılmıştır.");
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
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALAR.First(s => s.ID == SecimID);
                Banka.ADRES = txtAdres.Text;
                Banka.BANKAADI = txtBankaAdı.Text;
                Banka.HESAPADI = txtHesapTürü.Text;
                Banka.HESAPNO = txtHesapNo.Text;
                Banka.IBAN = txtIBAN.Text;
                Banka.SUBE = txtBankaSubesi.Text;
                Banka.TEL = txtSubeTel.Text;
                Banka.TEMSILCI = txtYetkili.Text;
                Banka.TEMSILCIEMAIL = txtYetEmail.Text;
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = AnaForm.UserID;

                Mesajlar.YeniKayıt("Banka kaydı Güncelleştirilmiştir");
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
                DB.TBL_BANKALAR.DeleteOnSubmit(DB.TBL_BANKALAR.First(s => s.ID == SecimID));
                DB.SubmitChanges();

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
                if (SecimID > 0)
                {
                    Ac();
                }
            }
            catch (Exception)
            {
                Edit = false;
                SecimID = -1;
            }
        }
        void Ac()
        {
            try
            {
                Fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALAR.First(s => s.ID == SecimID);
                txtAdres.Text = Banka.ADRES;
                txtBankaAdı.Text = Banka.BANKAADI;
                txtHesapTürü.Text = Banka.HESAPADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtIBAN.Text = Banka.IBAN;
                txtBankaSubesi.Text = Banka.SUBE;
                txtSubeTel.Text = Banka.TEL;
                txtYetkili.Text = Banka.TEMSILCI;
                txtYetEmail.Text = Banka.TEMSILCIEMAIL;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Güncelle() == DialogResult.Yes) Güncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}