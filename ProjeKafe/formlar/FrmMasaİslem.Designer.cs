namespace ProjeKafe.formlar
{
    partial class FrmMasaİslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasaİslem));
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.BtnKapat);
            this.groupControl1.Controls.Add(this.BtnMasaSil);
            this.groupControl1.Controls.Add(this.textMasaAciklama);
            this.groupControl1.Controls.Add(this.textMasaAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.BtnMasaEkle);
            this.groupControl1.Controls.Add(this.textMasaId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(29, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(522, 317);
            this.groupControl1.TabIndex = 2;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Appearance.Options.UseFont = true;
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.Location = new System.Drawing.Point(375, 208);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(109, 45);
            this.BtnKapat.TabIndex = 8;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // BtnMasaSil
            // 
            this.BtnMasaSil.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMasaSil.Appearance.Options.UseFont = true;
            this.BtnMasaSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMasaSil.ImageOptions.Image")));
            this.BtnMasaSil.Location = new System.Drawing.Point(140, 208);
            this.BtnMasaSil.Name = "BtnMasaSil";
            this.BtnMasaSil.Size = new System.Drawing.Size(100, 45);
            this.BtnMasaSil.TabIndex = 7;
            this.BtnMasaSil.Text = "Sil";
            this.BtnMasaSil.Click += new System.EventHandler(this.BtnMasaSil_Click);
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
            this.BtnMasaEkle.Location = new System.Drawing.Point(27, 208);
            this.BtnMasaEkle.Name = "BtnMasaEkle";
            this.BtnMasaEkle.Size = new System.Drawing.Size(107, 45);
            this.BtnMasaEkle.TabIndex = 2;
            this.BtnMasaEkle.Text = "Ekle";
            this.BtnMasaEkle.Click += new System.EventHandler(this.BtnMenuEkle_Click);
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
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(246, 208);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(123, 45);
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "Güncelle";
            // 
            // FrmMasaİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 358);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmMasaİslem";
            this.Text = "Masa İşlemler";
            this.Load += new System.EventHandler(this.FrmMasaİslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textMasaId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnMasaSil;
        private DevExpress.XtraEditors.TextEdit textMasaAciklama;
        private DevExpress.XtraEditors.TextEdit textMasaAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnMasaEkle;
        private DevExpress.XtraEditors.TextEdit textMasaId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}