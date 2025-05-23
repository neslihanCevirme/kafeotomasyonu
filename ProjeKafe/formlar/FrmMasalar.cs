using DevExpress.XtraGrid.Columns;
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
    public partial class FrmMasalar : Form
    {
        public FrmMasalar()
        {
            InitializeComponent();
        }
        KafeEntities db = new KafeEntities();

        public GridColumn MasaID { get; private set; }

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
            gridControl1.DataSource = degerler;
        }
        private void FrmMasalar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnMenuEkle_Click(object sender, EventArgs e)
        {
            FrmMasaİslem frm = new FrmMasaİslem();
            frm.ShowDialog();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnMasaDüzenle_Click(object sender, EventArgs e)
        {
            FrmMasaİslem frm = new FrmMasaİslem();
            frm.ShowDialog();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
            int x = int.Parse(gridView1.GetFocusedRowCellValue("MasaID").ToString());
            var deger = db.Masalar.Find(x);
            if (deger.Durumu == true)
            {
                deger.Durumu = false;
            }
            else if (deger.Durumu != true)
            {
                deger.Durumu = true;
            }
            db.SaveChanges();
           
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            
            
        }

        private void BtnRezerveDeğis_Click(object sender, EventArgs e)
        {
            int x = int.Parse(gridView1.GetFocusedRowCellValue("MasaID").ToString());
            var deger = db.Masalar.Find(x);
            if (deger.RezerveMi == true)
            {
                deger.RezerveMi = false;
            }
            else if (deger.RezerveMi != true)
            {
                deger.RezerveMi = true;
            }
            db.SaveChanges();

        }
    }
}
