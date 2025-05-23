namespace ProjeKafe.formlar
{
    partial class FrmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnUrunEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunDüzenle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunListele = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(22, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(976, 329);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // BtnUrunEkle
            // 
            this.BtnUrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunEkle.ImageOptions.Image")));
            this.BtnUrunEkle.Location = new System.Drawing.Point(1040, 126);
            this.BtnUrunEkle.Name = "BtnUrunEkle";
            this.BtnUrunEkle.Size = new System.Drawing.Size(113, 47);
            this.BtnUrunEkle.TabIndex = 4;
            this.BtnUrunEkle.Text = "Yeni";
            this.BtnUrunEkle.Click += new System.EventHandler(this.BtnUrunEkle_Click);
            // 
            // BtnUrunDüzenle
            // 
            this.BtnUrunDüzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunDüzenle.ImageOptions.Image")));
            this.BtnUrunDüzenle.Location = new System.Drawing.Point(1040, 200);
            this.BtnUrunDüzenle.Name = "BtnUrunDüzenle";
            this.BtnUrunDüzenle.Size = new System.Drawing.Size(113, 47);
            this.BtnUrunDüzenle.TabIndex = 10;
            this.BtnUrunDüzenle.Text = "Düzenle";
            this.BtnUrunDüzenle.Click += new System.EventHandler(this.BtnUrunDüzenle_Click);
            // 
            // BtnUrunListele
            // 
            this.BtnUrunListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunListele.ImageOptions.Image")));
            this.BtnUrunListele.Location = new System.Drawing.Point(1040, 270);
            this.BtnUrunListele.Name = "BtnUrunListele";
            this.BtnUrunListele.Size = new System.Drawing.Size(135, 47);
            this.BtnUrunListele.TabIndex = 11;
            this.BtnUrunListele.Text = "Listele Yenile";
            this.BtnUrunListele.Click += new System.EventHandler(this.BtnUrunListele_Click);
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.BtnUrunListele);
            this.Controls.Add(this.BtnUrunDüzenle);
            this.Controls.Add(this.BtnUrunEkle);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnUrunEkle;
        private DevExpress.XtraEditors.SimpleButton BtnUrunDüzenle;
        private DevExpress.XtraEditors.SimpleButton BtnUrunListele;
    }
}