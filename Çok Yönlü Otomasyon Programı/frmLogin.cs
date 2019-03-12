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
using Microsoft.Win32;
using System.Security.Cryptography;

namespace Çok_Yönlü_Otomasyon_Programı
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Mesajlar Mesajlar = new Fonksiyonlar.Mesajlar();
        public frmLogin()
        {
            InitializeComponent();
            txtKullanici.Focus();

        }
        
        private void btnGiriş_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text == "")
            {
                errorProvider1.SetError(txtKullanici, "Bu alan boş geçilemez");
                errorProvider1.BlinkRate = 500;
            }
            else if (txtSifre.Text == "")
            {
                errorProvider1.SetError(txtSifre, "Bu alan boş geçilemez");
                errorProvider1.BlinkRate = 500;
            }
            else
            {
                try
                {

                    Fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILAR.First(s => s.KULLANICI == txtKullanici.Text.Trim() && s.SİFRE == MD5eDonustur(txtSifre.Text));
                    Kullanici.LASTLOGİN = DateTime.Now;
                    DB.SubmitChanges();
                    Hide();
                    AnaForm frm = new AnaForm(Kullanici);
                    frm.Show();
                    MessageBox.Show("Çok Yönlü Otomasyon Programına Hoşgeldiniz", "http://www.yasincoban.com", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Giriş Yapılamadı. Kullanıcı adı yada şifreniz geçersiz olabilir. Lütfen düzeltip tekrar deneyiniz", "http://www.yasincoban.com", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            

        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            frmayarlar frm = new frmayarlar();
            frm.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
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

        private void btnLisans_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.yasincoban.com");
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {

                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("Çok_Yönlü_Otomasyon_Programı", "\"" + Application.ExecutablePath + "\"");

            }
            else
            {  //işaret kaldırıldı ise Regeditten açılışta çalıştırılacaklardan kaldır
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("Çok_Yönlü_Otomasyon_Programı");
            }
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.yasincoban.com");
        }
    }
}