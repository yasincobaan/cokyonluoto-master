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

namespace Çok_Yönlü_Otomasyon_Programı.Modül_Kullanici
{
    public partial class frmKullaniciYönetimi : DevExpress.XtraEditors.XtraForm
    {
        int secim = -1;
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
 
        
        public frmKullaniciYönetimi()
        {
            InitializeComponent();
            this.Shown += frmKullaniciYönetimi_Shown;        
            
        }
        void frmKullaniciYönetimi_Shown(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            var lst = from s in DB.TBL_KULLANICILAR
                      select s;
            Liste.DataSource = lst;
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            Formlar.KullaniciPanel();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            
            Formlar.KullaniciPanel(true,secim);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (Mesajlar.Sil() == DialogResult.Yes)
            {       

                    DB.TBL_KULLANICILAR.DeleteOnSubmit(DB.TBL_KULLANICILAR.First(s => s.ID == secim));
                    DB.SubmitChanges();
                    Listele();
            }
        }
        private void frmKullaniciYönetimi_Load(object sender, EventArgs e)
        {

        }

        private void Liste_Click(object sender, EventArgs e)
        {
            secim = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            
        }
    }
}