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
    public partial class FrmKullanicilar : Form
    {
        public FrmKullanicilar()
        {
            InitializeComponent();
        }

        KafeEntities db = new KafeEntities();
        void Listele()
        {

            var degerler = (from x in db.Kullanicilar
                            select new
                            {
                                x.AdSoyad,
                                x.Telefon,
                                x.Adres,
                                x.Email,
                                x.Gorevi,
                                x.KullaniciAdi,
                                x.Parola,
                                x.AktifMi,
                                x.KayitTarihi




                            }).ToList();
            gridControl1.DataSource = degerler;
        }
        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnYeniKullanici_Click(object sender, EventArgs e)
        {
            FrmKaydol frm = new FrmKaydol();
            frm.ShowDialog();
        }

        private void BtnKullaniciSil_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textKullaniciId.Text);
            var deger = db.Kullanicilar.Find(x);
            db.Kullanicilar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Kullanıcı silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }
    }
}
