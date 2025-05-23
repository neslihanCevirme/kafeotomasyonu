namespace ProjeKafe.formlar
{
    partial class FrmMasalar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasalar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnMenuEkle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMasaDüzenle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMasaListele = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRezerveDeğis = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnMasaSil = new DevExpress.XtraEditors.SimpleButton();
            this.textMasaAciklama = new DevExpress.XtraEditors.TextEdit();
            this.textMasaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnMasaEkle = new DevExpress.XtraEditors.SimpleButton();
            this.textMasaId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(976, 329);
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
            // BtnMenuEkle
            // 
            this.BtnMenuEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenuEkle.ImageOptions.Image")));
            this.BtnMenuEkle.Location = new System.Drawing.Point(52, 347);
            this.BtnMenuEkle.Name = "BtnMenuEkle";
            this.BtnMenuEkle.Size = new System.Drawing.Size(109, 47);
            this.BtnMenuEkle.TabIndex = 3;
            this.BtnMenuEkle.Text = "Yeni";
            this.BtnMenuEkle.Click += new System.EventHandler(this.BtnMenuEkle_Click);
            // 
            // BtnMasaDüzenle
            // 
            this.BtnMasaDüzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMasaDüzenle.ImageOptions.Image")));
            this.BtnMasaDüzenle.Location = new System.Drawing.Point(181, 347);
            this.BtnMasaDüzenle.Name = "BtnMasaDüzenle";
            this.BtnMasaDüzenle.Size = new System.Drawing.Size(113, 47);
            this.BtnMasaDüzenle.TabIndex = 9;
            this.BtnMasaDüzenle.Text = "Düzenle";
            this.BtnMasaDüzenle.Click += new System.EventHandler(this.BtnMasaDüzenle_Click);
            // 
            // BtnMasaListele
            // 
            this.BtnMasaListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMasaListele.ImageOptions.Image")));
            this.BtnMasaListele.Location = new System.Drawing.Point(300, 347);
            this.BtnMasaListele.Name = "BtnMasaListele";
            this.BtnMasaListele.Size = new System.Drawing.Size(135, 47);
            this.BtnMasaListele.TabIndex = 10;
            this.BtnMasaListele.Text = "Listele Yenile";
            this.BtnMasaListele.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(453, 347);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(154, 47);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Durum Değiştir";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnRezerveDeğis
            // 
            this.BtnRezerveDeğis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRezerveDeğis.ImageOptions.Image")));
            this.BtnRezerveDeğis.Location = new System.Drawing.Point(641, 347);
            this.BtnRezerveDeğis.Name = "BtnRezerveDeğis";
            this.BtnRezerveDeğis.Size = new System.Drawing.Size(166, 47);
            this.BtnRezerveDeğis.TabIndex = 12;
            this.BtnRezerveDeğis.Text = "Rezerve Değiştir";
            this.BtnRezerveDeğis.Click += new System.EventHandler(this.BtnRezerveDeğis_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnKapat);
            this.groupControl1.Controls.Add(this.BtnMasaSil);
            this.groupControl1.Controls.Add(this.textMasaAciklama);
            this.groupControl1.Controls.Add(this.textMasaAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.BtnMasaEkle);
            this.groupControl1.Controls.Add(this.textMasaId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1163, 183);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(10, 10);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Visible = false;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Appearance.Options.UseFont = true;
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.Location = new System.Drawing.Point(277, 218);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(109, 45);
            this.BtnKapat.TabIndex = 8;
            this.BtnKapat.Text = "Kapat";
            // 
            // BtnMasaSil
            // 
            this.BtnMasaSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMasaSil.Appearance.Options.UseFont = true;
            this.BtnMasaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMasaSil.ImageOptions.Image")));
            this.BtnMasaSil.Location = new System.Drawing.Point(156, 218);
            this.BtnMasaSil.Name = "BtnMasaSil";
            this.BtnMasaSil.Size = new System.Drawing.Size(100, 45);
            this.BtnMasaSil.TabIndex = 7;
            this.BtnMasaSil.Text = "Sil";
            // 
            // textMasaAciklama
            // 
            this.textMasaAciklama.Location = new System.Drawing.Point(158, 136);
            this.textMasaAciklama.Name = "textMasaAciklama";
            this.textMasaAciklama.Size = new System.Drawing.Size(188, 22);
            this.textMasaAciklama.TabIndex = 6;
            // 
            // textMasaAd
            // 
            this.textMasaAd.Location = new System.Drawing.Point(158, 100);
            this.textMasaAd.Name = "textMasaAd";
            this.textMasaAd.Size = new System.Drawing.Size(125, 22);
            this.textMasaAd.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 21);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Masa Adı";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(27, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 21);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Açıklama";
            // 
            // BtnMasaEkle
            // 
            this.BtnMasaEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMasaEkle.Appearance.Options.UseFont = true;
            this.BtnMasaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMasaEkle.ImageOptions.Image")));
            this.BtnMasaEkle.Location = new System.Drawing.Point(27, 218);
            this.BtnMasaEkle.Name = "BtnMasaEkle";
            this.BtnMasaEkle.Size = new System.Drawing.Size(107, 45);
            this.BtnMasaEkle.TabIndex = 2;
            this.BtnMasaEkle.Text = "Ekle";
            // 
            // textMasaId
            // 
            this.textMasaId.Location = new System.Drawing.Point(158, 64);
            this.textMasaId.Name = "textMasaId";
            this.textMasaId.Size = new System.Drawing.Size(125, 22);
            this.textMasaId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(27, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Masa Id";
            // 
            // FrmMasalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 450);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.BtnRezerveDeğis);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.BtnMasaListele);
            this.Controls.Add(this.BtnMasaDüzenle);
            this.Controls.Add(this.BtnMenuEkle);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmMasalar";
            this.Text = "Masalar";
            this.Load += new System.EventHandler(this.FrmMasalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnMenuEkle;
        private DevExpress.XtraEditors.SimpleButton BtnMasaDüzenle;
        private DevExpress.XtraEditors.SimpleButton BtnMasaListele;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton BtnRezerveDeğis;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnMasaSil;
        private DevExpress.XtraEditors.TextEdit textMasaAciklama;
        private DevExpress.XtraEditors.TextEdit textMasaAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnMasaEkle;
        private DevExpress.XtraEditors.TextEdit textMasaId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}