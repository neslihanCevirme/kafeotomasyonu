using ProjeKafe.formlar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeKafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FrmKullaniciGiris frm = new FrmKullaniciGiris();
            frm.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMenuler frm = new formlar.FrmMenuler();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnMasalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMasalar frm = new formlar.FrmMasalar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmUrunler frm = new formlar.FrmUrunler();
            frm.MdiParent = this;
            frm.Show();
        }
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMenuHareket frm = new FrmMenuHareket();
            frm.MdiParent = this;
            frm.Show();
        
        } 
        private void BtnMasaHareket_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmMasaHareketler frm = new FrmMasaHareketler();
            frm.MdiParent = this;
            frm.Show();
        }
        private void ribbonControl1_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    FrmKullaniciGiris 5rm = new FrmKullaniciGiris();
        //    frm.ShwDialog();
        }

        private void BtnMasaDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            formlar.FrmMasaDurum frm = new formlar.FrmMasaDurum();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnKullanicilar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formlar.FrmKullanicilar frm = new formlar.FrmKullanicilar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnSatislar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            formlar.FrmSatislar frm = new formlar.FrmSatislar();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
