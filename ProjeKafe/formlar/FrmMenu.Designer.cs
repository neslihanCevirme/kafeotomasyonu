namespace ProjeKafe.formlar
{
    partial class FrmMenuler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuler));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textMenuId = new DevExpress.XtraEditors.TextEdit();
            this.BtnMenuEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textMenuAd = new DevExpress.XtraEditors.TextEdit();
            this.textMenuAciklama = new DevExpress.XtraEditors.TextEdit();
            this.BtnMenuSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMenuListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMenuGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMenuId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMenuAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMenuAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 37);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(635, 308);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnMenuGuncelle);
            this.groupControl1.Controls.Add(this.BtnMenuListele);
            this.groupControl1.Controls.Add(this.BtnMenuSil);
            this.groupControl1.Controls.Add(this.textMenuAciklama);
            this.groupControl1.Controls.Add(this.textMenuAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.BtnMenuEkle);
            this.groupControl1.Controls.Add(this.textMenuId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(681, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(505, 308);
            this.groupControl1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Menü Id";
            // 
            // textMenuId
            // 
            this.textMenuId.Location = new System.Drawing.Point(158, 64);
            this.textMenuId.Name = "textMenuId";
            this.textMenuId.Size = new System.Drawing.Size(125, 22);
            this.textMenuId.TabIndex = 1;
            // 
            // BtnMenuEkle
            // 
            this.BtnMenuEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnMenuEkle.Location = new System.Drawing.Point(27, 234);
            this.BtnMenuEkle.Name = "BtnMenuEkle";
            this.BtnMenuEkle.Size = new System.Drawing.Size(94, 29);
            this.BtnMenuEkle.TabIndex = 2;
            this.BtnMenuEkle.Text = "Ekle";
            this.BtnMenuEkle.Click += new System.EventHandler(this.BtnMenuEkle_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Açıklama";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Menü Adı";
            // 
            // textMenuAd
            // 
            this.textMenuAd.Location = new System.Drawing.Point(158, 100);
            this.textMenuAd.Name = "textMenuAd";
            this.textMenuAd.Size = new System.Drawing.Size(125, 22);
            this.textMenuAd.TabIndex = 5;
            // 
            // textMenuAciklama
            // 
            this.textMenuAciklama.Location = new System.Drawing.Point(158, 136);
            this.textMenuAciklama.Name = "textMenuAciklama";
            this.textMenuAciklama.Size = new System.Drawing.Size(188, 22);
            this.textMenuAciklama.TabIndex = 6;
            // 
            // BtnMenuSil
            // 
            this.BtnMenuSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnMenuSil.Location = new System.Drawing.Point(140, 234);
            this.BtnMenuSil.Name = "BtnMenuSil";
            this.BtnMenuSil.Size = new System.Drawing.Size(94, 29);
            this.BtnMenuSil.TabIndex = 7;
            this.BtnMenuSil.Text = "Sil";
            this.BtnMenuSil.Click += new System.EventHandler(this.BtnMenuSil_Click);
            // 
            // BtnMenuListele
            // 
            this.BtnMenuListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.BtnMenuListele.Location = new System.Drawing.Point(252, 234);
            this.BtnMenuListele.Name = "BtnMenuListele";
            this.BtnMenuListele.Size = new System.Drawing.Size(94, 29);
            this.BtnMenuListele.TabIndex = 8;
            this.BtnMenuListele.Text = "Listele";
            this.BtnMenuListele.Click += new System.EventHandler(this.BtnMenuListele_Click);
            // 
            // BtnMenuGuncelle
            // 
            this.BtnMenuGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.BtnMenuGuncelle.Location = new System.Drawing.Point(368, 234);
            this.BtnMenuGuncelle.Name = "BtnMenuGuncelle";
            this.BtnMenuGuncelle.Size = new System.Drawing.Size(94, 29);
            this.BtnMenuGuncelle.TabIndex = 9;
            this.BtnMenuGuncelle.Text = "Güncelle";
            this.BtnMenuGuncelle.Click += new System.EventHandler(this.BtnMenuGuncelle_Click);
            // 
            // FrmMenuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 372);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMenuler";
            this.Text = "Menüler";
            this.Load += new System.EventHandler(this.FrmMenuler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMenuId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMenuAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMenuAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnMenuGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnMenuListele;
        private DevExpress.XtraEditors.SimpleButton BtnMenuSil;
        private DevExpress.XtraEditors.TextEdit textMenuAciklama;
        private DevExpress.XtraEditors.TextEdit textMenuAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnMenuEkle;
        private DevExpress.XtraEditors.TextEdit textMenuId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}