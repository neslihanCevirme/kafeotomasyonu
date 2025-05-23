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
    public partial class FrmMasaDurum : Form
    {
        
        public FrmMasaDurum()
        {
            InitializeComponent();
        }
        KafeEntities db = new KafeEntities();
        private void FrmMasaDurum_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < db.Masalar.Count(); i++)
            {
                var btn = new CheckButton();
                var masa = db.Masalar.FirstOrDefault(m => m.MasaAd == "MasaAd");
                if (masa != null)
                {
                    btn.Name = masa.MasaAd;
                }
                btn.Height = 100;
                btn.Width = 80;
                panel1.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var btn = sender as CheckButton;
            MessageBox.Show(btn.Text);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
