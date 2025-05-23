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
    public partial class FrmMenuler : Form
    {
        public FrmMenuler()
        {
            InitializeComponent();
        }
        KafeEntities db = new KafeEntities();
        void Listele()
        {

            var degerler = (from x in db.Menuler
                            select new
                            {
                                x.MenuID,
                                x.MenuAd,
                                x.MenuAciklamasi
                            }).ToList();
            gridControl1.DataSource = degerler;
        }

        private void BtnMenuEkle_Click(object sender, EventArgs e)
        {
            Menuler m = new Menuler();
            m.MenuAd = textMenuAd.Text;
            m.MenuAciklamasi = textMenuAciklama.Text;
            db.Menuler.Add(m);
            db.SaveChanges();
            XtraMessageBox.Show("Menü sisteme kaydedildi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void FrmMenuler_Load(object sender, EventArgs e)
        {

        }

        private void BtnMenuListele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnMenuSil_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textMenuId.Text);
            var deger = db.Menuler.Find(x);
            db.Menuler.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Menü silindi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void BtnMenuGuncelle_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textMenuId.Text);
            var deger = db.Menuler.Find(x);
            deger.MenuAd = textMenuAd.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Menü güncellendi ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            textMenuId.Text = gridView1.GetFocusedRowCellValue("MenuID").ToString();
            textMenuAd.Text = gridView1.GetFocusedRowCellValue("MenuAd").ToString();
        }
    }
}
