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
    public partial class FrmKaydol : Form
    {
        public bool Kaydet = false;
        public FrmKaydol(Kullanicilar kullanicilar)
        {
            InitializeComponent();
        }

        public FrmKaydol()
        {
        }

        KafeEntities db = new KafeEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            Kullanicilar x = new Kullanicilar();
            x.AktifMi =Convert.ToBoolean(toggleAktifMi.EditValue);
            x.AdSoyad = textAdSoyad.Text;
            x.Telefon = textTelefon.Text;
            x.Email = textEmail.Text;
            x.Adres = textAdres.Text;
            x.Gorevi = textGorevi.Text;
            x.KullaniciAdi = textKullaniciAd.Text;
            x.Parola = textParola.Text;
            if (textParola.Text==textParolaTekrar.Text)
            {
                db.Kullanicilar.Add(x);
                db.SaveChanges();
                Kaydet = true;
                this.Close(); 
            }
            else
            {
                XtraMessageBox.Show("Şifreler uyuşmuyor ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKaydol_Load(object sender, EventArgs e)
        {

        }
    }
}
