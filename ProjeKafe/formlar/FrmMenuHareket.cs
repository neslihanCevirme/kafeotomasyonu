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
    public partial class FrmMenuHareket : Form
    {
        public FrmMenuHareket()
        {
            InitializeComponent();
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
            gridControl1.DataSource = degerler;
        }
        private void FrmMenuHareket_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
