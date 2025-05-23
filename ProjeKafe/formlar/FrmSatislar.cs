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
    public partial class FrmSatislar : Form
    {
        public FrmSatislar()
        {
            InitializeComponent();
        }
        KafeEntities db = new KafeEntities();
        void Listele()
        {

            var degerler = (from x in db.Satislar
                            select new
                            {
                                x.SatisID,
                                x.Tutar,
                                x.Odenen,
                                x.Kalan,
                                x.SatisAciklamasi,
                                x.Tarih
                            }).ToList();
            gridControl1.DataSource = degerler;
        }
        private void FrmSatislar_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
