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
    public partial class FrmUrunİslem : Form
    {
        public FrmUrunİslem()
        {
            InitializeComponent();
            var degerler = (from x in db.Urunler
                            select new
                            {
                                x.Menuler.MenuID,
                               // MenuID = (int?)x.Menuler.MenuID,
                                x.Menuler.MenuAd,
                            }).ToList();


            lookUpEditMenuSec.Properties.ValueMember = "MenuID";
            lookUpEditMenuSec.Properties.DisplayMember = "MenuAd";
            lookUpEditMenuSec.Properties.DataSource = degerler;
        }
        KafeEntities db = new KafeEntities();
        void Listele()
        {

            var degerler = (from x in db.Urunler
                            select new
                            {
                                x.UrunID,
                                x.Menuler.MenuAd,
                                x.UrunKodu,
                                x.UrunAdi,
                                x.BirimFiyati,
                                x.UrunAciklama,
                                x.Tarih


                            }).ToList();
        }

        private void FrmUrunİslem_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenuEkle_Click(object sender, EventArgs e)
        {
          

                Urunler u = new Urunler();
                u.MenuId = int.Parse(lookUpEditMenuSec.EditValue.ToString());
                u.UrunKodu = textUrunKod.Text;
                u.UrunAdi = textUrunAd.Text;
                u.BirimFiyati = calcEditFiyat.Value;
                u.UrunAciklama = textUrunAciklama.Text;
                u.Tarih = dateEditTarih.DateTime;

                db.Urunler.Add(u);
                db.SaveChanges();
                XtraMessageBox.Show("Ürün sisteme kaydedildi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
           
 

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUrunSil_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textUrunId.Text);
            var deger = db.Urunler.Find(x);
            deger.UrunAdi = textUrunAd.Text;
            deger.BirimFiyati = calcEditFiyat.Value;
            db.SaveChanges();
            XtraMessageBox.Show("Ürün güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void BtnUrunSil_Click_1(object sender, EventArgs e)
        {
            int x = int.Parse(textUrunId.Text);
            var deger = db.Urunler.Find(x);
            db.Urunler.Remove(deger);
        }
    }
}
