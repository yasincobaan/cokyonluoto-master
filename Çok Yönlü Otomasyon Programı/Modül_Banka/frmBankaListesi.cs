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
    public partial class frmBankaListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        public bool Secim = false;
        int SecimID = -1;
        public frmBankaListesi()
        {
            InitializeComponent();
        }
        void Listele()
        {
            var lst = from s in DB.TBL_BANKALAR
                      where s.HESAPADI.Contains(txtHesapAdi.Text) && s.HESAPNO.Contains(txtHesapNo.Text) && s.IBAN.Contains(txtIBAN.Text)
                      select s;
            Liste.DataSource = lst;
        }
        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {
                SecimID = -1;
            }
        }

        private void frmBankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
        

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtIBAN.Text = "";
            txtHesapNo.Text = "";
            txtHesapAdi.Text = "";
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (SecimID > 0 && Secim)
            {
                AnaForm.Aktarma = SecimID;
                this.Close();
            }
        }
    }
}