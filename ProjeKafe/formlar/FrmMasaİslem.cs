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
    public partial class FrmMasaİslem : Form
    {
        public FrmMasaİslem()
        {
            InitializeComponent();
        }
        KafeEntities db = new KafeEntities();

        void Listele()
        {

            var degerler = (from x in db.Masalar
                            select new
                            {
                                x.MasaID,
                                x.MasaAd,
                                x.MasaAciklama,
                                x.Durumu,
                                x.RezerveMi,
                                x.EklenmeTarihi,
                                x.SonİslemTarihi
                            }).ToList();
            
        }
        private void BtnMenuEkle_Click(object sender, EventArgs e)
        {
            Masalar masa = new Masalar();
            masa.MasaAd = textMasaAd.Text;
            masa.MasaAciklama = textMasaAciklama.Text;
            db.Masalar.Add(masa);
            db.SaveChanges();
            XtraMessageBox.Show("Masa sisteme kaydedildi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnMasaSil_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textMasaId.Text);
            var deger = db.Masalar.Find(x);
            db.Masalar.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Masa silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMasaİslem_Load(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }
}
