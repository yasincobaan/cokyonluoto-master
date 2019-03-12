using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Çok_Yönlü_Otomasyon_Programı.Fonksiyonlar
{
    class Formlar
    {
        #region StokFormları
        public int StokListesi(bool Secim = false)
        {
            Modül_Stok.frmStokListesi frm = new Modül_Stok.frmStokListesi();
            if (Secim)
            {
                frm.Secım = Secim;
                frm.ShowDialog();

            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();

            }
            return AnaForm.Aktarma;

        }

        public int StokGrupları(bool Secim = false)
        {
            Modül_Stok.frmStokGruplari frm = new Modül_Stok.frmStokGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }

        public void StokHareketleri(bool Ac = false)
        {

        }
        public void StokKarti(bool Ac = false)
        {
            Modül_Stok.frmStokKarti frm = new Modül_Stok.frmStokKarti();

            frm.ShowDialog();
        }
        #endregion
        #region CariFormları
        public int CariGrupları(bool Secim = false)
        {
            Modül_Cari.frmCariGruplari frm = new Modül_Cari.frmCariGruplari();
            if (Secim) frm.Secim = Secim;
            frm.ShowDialog();
            return AnaForm.Aktarma;
        }
        public int CariListesi(bool Secim = false)
        {
            Modül_Cari.frmCariListesi frm = new Modül_Cari.frmCariListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public void CariAcilisKartı(bool Ac = false, int CariID = -1)
        {
            Modül_Cari.frmCariAcilisKarti frm = new Modül_Cari.frmCariAcilisKarti();
            if (Ac) frm.Ac(CariID);
            frm.ShowDialog();
        }
        #endregion
        #region KasaFormları
        public void KasaAcilisKarti()
        {
            Modül_Kasa.frmKasaAcilisKarti frm = new Modül_Kasa.frmKasaAcilisKarti();
            frm.ShowDialog();
        }
        public void KasaDevirIslemKarti(bool Ac = false, int IslemID = -1)
        {
            Modül_Kasa.frmKasaDevirİslem frm = new Modül_Kasa.frmKasaDevirİslem();
            if (Ac) frm.Ac(IslemID);
            frm.ShowDialog();
        }
        public int KasaListesi(bool Secim = false)
        {
            Modül_Kasa.frmKasaListesi frm = new Modül_Kasa.frmKasaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public void KasaTahsilatÖdemeKartı(bool Ac = false, int ID = -1)
        {
            Modül_Kasa.frmKasaTahsilatÖdeme frm = new Modül_Kasa.frmKasaTahsilatÖdeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }
        public void KasaHareketleri(bool Ac = false, int ID = -1)
        {
            Modül_Kasa.frmKasaHareketleri frm = new Modül_Kasa.frmKasaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }
        #endregion
        #region BankaFormları
        public void BankaAcilisKartı()
        {
            Modül_Banka.frmBankaAcilisKarti frm = new Modül_Banka.frmBankaAcilisKarti();
            frm.ShowDialog();
        }
        public void Bankaİslem(bool Ac = false, int ID = -1)
        {
            Modül_Banka.frmBankaIslem frm = new Modül_Banka.frmBankaIslem();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }
        public int BankaListesi(bool Secim = false)
        {
            Modül_Banka.frmBankaListesi frm = new Modül_Banka.frmBankaListesi();
            if (Secim)
            {
                frm.Secim = Secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            return AnaForm.Aktarma;
        }
        public void BankaParaTransfer(bool Ac = false, int ID = -1)
        {
            Modül_Banka.frmParaTransfer frm = new Modül_Banka.frmParaTransfer();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }
        public void BankaHareketleri(bool Ac = false, int ID = -1)
        {
            Modül_Banka.frmBankaHareketleri frm = new Modül_Banka.frmBankaHareketleri();
            frm.MdiParent = AnaForm.ActiveForm;
            if (Ac) frm.BankaAc(ID);
            frm.Show();
        }
        #endregion
        #region ÇekFormları

        #endregion
        #region FaturaFormları

        #endregion
        #region KullaniciFormlari
        public void KullaniciYönetimi()
        {
            Modül_Kullanici.frmKullaniciYönetimi frm = new Modül_Kullanici.frmKullaniciYönetimi();
            frm.ShowDialog();
        }
        public void KullaniciPanel(bool ac = false, int ID=-1)
        {
            Modül_Kullanici.frmKullaniciPanel frm = new Modül_Kullanici.frmKullaniciPanel(ID, ac);
            frm.ShowDialog();
        }
        #endregion

    }
}
