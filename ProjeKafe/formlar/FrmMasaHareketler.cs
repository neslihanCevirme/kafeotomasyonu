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
    public partial class FrmMasaHareketler : Form
    {
        public FrmMasaHareketler()
        {
            InitializeComponent();
        }
        KafeEntities db = new KafeEntities();
        void Listele()
        {

            var degerler = (from x in db.MasaHareketleri
                            select new
                            {
                                x.MasaHareketID,
                                x.SatisKodu,
                                x.Masalar.MasaAd,
                                x.MasaAciklamasi,
                                x.BirimFiyati,
                                x.Tarih


                            }).ToList();
            gridControl1.DataSource = degerler;
        }
        private void FrmMasaHareketler_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
