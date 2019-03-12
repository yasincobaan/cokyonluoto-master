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
    public partial class frmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        int HareketID = -1;
        int KasaID = -1;
        int EvrakID = -1;
        string EvrakTÜRÜ;
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar mesajlar = new Fonksiyonlar.Mesajlar();
        Fonksiyonlar.Formlar formlar = new Fonksiyonlar.Formlar();
        public frmKasaHareketleri()
        {
            InitializeComponent();
        }
        void DurumGetir()
        {
            Fonksiyonlar.VW_KASADURUM Kasa = DB.VW_KASADURUM.First(s => s.KASAID == KasaID);
            txtGiriş.Text = Kasa.GİRİS.Value.ToString();
            txtÇıkış.Text = Kasa.CİKİS.Value.ToString();
            txtBakiye.Text = Kasa.BAKİYE.Value.ToString();
        }

        public void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaKodu.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).KASAKODU;
                txtKasaAdı.Text = DB.TBL_KASALAR.First(s => s.ID == KasaID).KASAADI;
                DurumGetir();
                Listele();
            }
            catch (Exception e)
            {
                mesajlar.Hata(e);
            }

        }
        void Listele()
        {
            var lst = from s in DB.VW_KASAHAREKETLERİ
                      where s.KASAID == KasaID
                      select s;
            Liste.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                try
                {
                    EvrakID = int.Parse(gridView1.GetFocusedRowCellValue("EVRAKID").ToString());
                }
                catch (Exception)
                {
                    EvrakID = -1;
                }
                EvrakTÜRÜ = gridView1.GetFocusedRowCellValue("EVRAKTÜRÜ").ToString();
            }
            catch (Exception)
            {
                HareketID = -1;
                EvrakID = -1;
                EvrakTÜRÜ = "";
            }

        }
        private void frmKasaHareketleri_Load(object sender, EventArgs e)
        {

        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = formlar.KasaListesi(true);
            if (ID > 0)
            {
                Ac(ID);
                AnaForm.Aktarma = -1;
            }
        }

        private void Sağtik_Opening(object sender, CancelEventArgs e)
        {
            Sec();
            if (EvrakTÜRÜ == "Kasa Devir Kartı")
            {
                devirKartıToolStripMenuItem.Enabled = true;
                tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Enabled = false;
            }
            else if (EvrakTÜRÜ == "Kasa Tahsilat" || EvrakTÜRÜ == "Kasa Ödeme")
            {
                devirKartıToolStripMenuItem.Enabled = false;
                tahsilatÖdemeİşleminiDüzenleToolStripMenuItem.Enabled = true;

            }
        }

        private void devirKartıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formlar.KasaDevirIslemKarti(true, HareketID);
        }

        private void tahsilatÖdemeİşleminiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formlar.KasaTahsilatÖdemeKartı(true, HareketID);
        }
    }
}