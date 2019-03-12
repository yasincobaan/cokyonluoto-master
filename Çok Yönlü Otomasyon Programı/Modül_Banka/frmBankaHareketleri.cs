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
    public partial class frmBankaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        int BankaID = -1;
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        public frmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void frmBankaHareketleri_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.VW_BANKAHAREKETLERİ
                      select s;
            Liste.DataSource = lst;
        }
        public void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                Fonksiyonlar.VW_BANKALİSTESİ Banka = DB.VW_BANKALİSTESİ.First(s => s.ID == BankaID);
                txtHesapAdı.Text = DB.VW_BANKALİSTESİ.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = Banka.HESAPNO;
                txtHesapAdı.Text = Banka.HESAPADI;
                txtGiris.Text = Banka.GİRİS.Value.ToString();
                txtCikis.Text = Banka.CİKİS.Value.ToString();
                txtBakiye.Text = Banka.BAKİYE.Value.ToString();
                Listele();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdı_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesi(true);
            if (Id > 0) BankaAc(Id);
            AnaForm.Aktarma = -1;
        }

        private void Sag_tık_Opening(object sender, CancelEventArgs e)
        {
            Sec();
        }
        void Sec()
        {

        }
    }
}