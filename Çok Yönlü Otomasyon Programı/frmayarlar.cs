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

namespace Çok_Yönlü_Otomasyon_Programı
{
    public partial class frmayarlar : DevExpress.XtraEditors.XtraForm
    {
        public frmayarlar()
        {
            InitializeComponent();
        }

        private void chcYeni_CheckedChanged(object sender, EventArgs e)
        {
            txtDatabase.Enabled = !txtDatabase.Enabled;
            txtPassword.Enabled = !txtPassword.Enabled;
            txtSunucu.Enabled = !txtSunucu.Enabled;
            txtUserID.Enabled = !txtUserID.Enabled;
            btnKaydet.Enabled = !btnKaydet.Enabled;
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.cs_Sunucu = txtSunucu.Text.Trim() + ";";
            Properties.Settings.Default.cs_Database = txtDatabase.Text.Trim() + ";";
            Properties.Settings.Default.cs_UserID = txtUserID.Text.Trim() + ";";
            Properties.Settings.Default.cs_Password = txtPassword.Text.Trim() + ";";
            Properties.Settings.Default.Database = txtDatabase.Text.Trim();
            Properties.Settings.Default.Save();
            DialogResult Dr = MessageBox.Show("Sunucu değiştiği için program yeniden başlatılacaktır", "Sunucu Değişimi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (Dr==DialogResult.Yes)
            {
                Application.Restart();
            }
               
           
            
        }

        private void frmayarlar_Load(object sender, EventArgs e)
        {
            labelControl2.Text = Properties.Settings.Default.cs1 + Properties.Settings.Default.cs_Sunucu + Properties.Settings.Default.Database + Properties.Settings.Default.cs2 + Properties.Settings.Default.cs_Database + Properties.Settings.Default.cs_3 + Properties.Settings.Default.cs_UserID + Properties.Settings.Default.cs4;
            MessageBox.Show("Dikkat Bu pencerede yaptığınız değişiklikler veri kaybına yol açabilir","Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}