using DevExpress.XtraEditors;
using ProjeKafe.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeKafe.formlar
{
    public partial class FrmKullaniciGiris : Form
    {
       private bool giris;
        void BilgileriGetir()
        {
            if (Properties.Settings.Default.BeniHatirla==true)
            {
                textKullaniciAd.Text = Properties.Settings.Default.KullaniciAdi;
                textParola.Text = Properties.Settings.Default.Parola;
                checkBeniHatırla.Checked = true;
            }
            else
            {
                textKullaniciAd.Text = null;
                textParola.Text = null;
                checkBeniHatırla.Checked = false;
            }
        }

        void BilgileriKaydet()
        {
            KafeEntities db = new KafeEntities();
            if (checkBeniHatırla.Checked)
            {
                Properties.Settings.Default.KullaniciAdi = textKullaniciAd.Text;
                Properties.Settings.Default.Parola = textParola.Text;
                Properties.Settings.Default.BeniHatirla= true;
                Properties.Settings.Default.Save();
              
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = null;
                Properties.Settings.Default.Parola = null;
                Properties.Settings.Default.BeniHatirla = false;

            }
        }
        public FrmKullaniciGiris()
        {
            InitializeComponent();
            BilgileriGetir();
        }
        KafeEntities db = new KafeEntities();
        public void FrmKullaniciGiris_Load(object sender, EventArgs e)
        {

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            if(!giris)
            {
                Application.Exit();
            }
           
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (db.Kullanicilar.Any(k => k.KullaniciAdi == textKullaniciAd.Text && k.Parola == textParola.Text))
            {
                giris = true;
                BilgileriKaydet();
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Kullanıcı adı veya şifre yanlış ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FrmKullaniciGiris_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
            
        }

        private void hyperlinkLabelKaydol_Click(object sender, EventArgs e)
        {
            FrmKaydol frm = new FrmKaydol(new Kullanicilar());
            frm.ShowDialog();
        }
    }
}
