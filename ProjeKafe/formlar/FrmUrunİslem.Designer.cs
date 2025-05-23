namespace ProjeKafe.formlar
{
    partial class FrmUrunİslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunİslem));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.dateEditTarih = new DevExpress.XtraEditors.DateEdit();
            this.calcEditFiyat = new DevExpress.XtraEditors.CalcEdit();
            this.lookUpEditMenuSec = new DevExpress.XtraEditors.LookUpEdit();
            this.textUrunAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textUrunKod = new DevExpress.XtraEditors.TextEdit();
            this.textUrunAciklama = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnMenuEkle = new DevExpress.XtraEditors.SimpleButton();
            this.textUrunId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUrunSil = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMenuSec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunKod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnUrunSil);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnKapat);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.dateEditTarih);
            this.groupControl1.Controls.Add(this.calcEditFiyat);
            this.groupControl1.Controls.Add(this.lookUpEditMenuSec);
            this.groupControl1.Controls.Add(this.textUrunAd);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.textUrunKod);
            this.groupControl1.Controls.Add(this.textUrunAciklama);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.BtnMenuEkle);
            this.groupControl1.Controls.Add(this.textUrunId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(23, 26);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(621, 403);
            this.groupControl1.TabIndex = 2;
            // 
            // BtnKapat
            // 
            this.BtnKapat.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKapat.Appearance.Options.UseFont = true;
            this.BtnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKapat.ImageOptions.Image")));
            this.BtnKapat.Location = new System.Drawing.Point(453, 341);
            this.BtnKapat.Name = "BtnKapat";
            this.BtnKapat.Size = new System.Drawing.Size(108, 43);
            this.BtnKapat.TabIndex = 17;
            this.BtnKapat.Text = "Kapat";
            this.BtnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(383, 60);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.NullText = "Resim Seçilmedi";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(178, 167);
            this.pictureEdit1.TabIndex = 16;
            // 
            // dateEditTarih
            // 
            this.dateEditTarih.EditValue = null;
            this.dateEditTarih.Location = new System.Drawing.Point(137, 279);
            this.dateEditTarih.Name = "dateEditTarih";
            this.dateEditTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditTarih.Size = new System.Drawing.Size(125, 22);
            this.dateEditTarih.TabIndex = 15;
            // 
            // calcEditFiyat
            // 
            this.calcEditFiyat.Location = new System.Drawing.Point(137, 208);
            this.calcEditFiyat.Name = "calcEditFiyat";
            this.calcEditFiyat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calcEditFiyat.Properties.DisplayFormat.FormatString = "C2";
            this.calcEditFiyat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.calcEditFiyat.Size = new System.Drawing.Size(125, 22);
            this.calcEditFiyat.TabIndex = 14;
            // 
            // lookUpEditMenuSec
            // 
            this.lookUpEditMenuSec.Location = new System.Drawing.Point(137, 100);
            this.lookUpEditMenuSec.Name = "lookUpEditMenuSec";
            this.lookUpEditMenuSec.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditMenuSec.Properties.NullText = "Menü Seçiniz";
            this.lookUpEditMenuSec.Size = new System.Drawing.Size(125, 22);
            this.lookUpEditMenuSec.TabIndex = 13;
            // 
            // textUrunAd
            // 
            this.textUrunAd.Location = new System.Drawing.Point(137, 176);
            this.textUrunAd.Name = "textUrunAd";
            this.textUrunAd.Size = new System.Drawing.Size(125, 22);
            this.textUrunAd.TabIndex = 12;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(27, 282);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(30, 16);
            this.labelControl7.TabIndex = 11;
            this.labelControl7.Text = "Tarih";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(25, 137);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 16);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Ürün Kodu";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(25, 211);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(63, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Birim Fiyatı";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(27, 179);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Ürün Adı";
            // 
            // textUrunKod
            // 
            this.textUrunKod.Location = new System.Drawing.Point(137, 134);
            this.textUrunKod.Name = "textUrunKod";
            this.textUrunKod.Size = new System.Drawing.Size(125, 22);
            this.textUrunKod.TabIndex = 6;
            // 
            // textUrunAciklama
            // 
            this.textUrunAciklama.Location = new System.Drawing.Point(137, 251);
            this.textUrunAciklama.Name = "textUrunAciklama";
            this.textUrunAciklama.Size = new System.Drawing.Size(204, 22);
            this.textUrunAciklama.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 103);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Menü ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 246);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(51, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Açıklama";
            // 
            // BtnMenuEkle
            // 
            this.BtnMenuEkle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMenuEkle.Appearance.Options.UseFont = true;
            this.BtnMenuEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnMenuEkle.ImageOptions.Image")));
            this.BtnMenuEkle.Location = new System.Drawing.Point(51, 341);
            this.BtnMenuEkle.Name = "BtnMenuEkle";
            this.BtnMenuEkle.Size = new System.Drawing.Size(97, 43);
            this.BtnMenuEkle.TabIndex = 2;
            this.BtnMenuEkle.Text = "Kaydet";
            this.BtnMenuEkle.Click += new System.EventHandler(this.BtnMenuEkle_Click);
            // 
            // textUrunId
            // 
            this.textUrunId.Location = new System.Drawing.Point(137, 64);
            this.textUrunId.Name = "textUrunId";
            this.textUrunId.Size = new System.Drawing.Size(125, 22);
            this.textUrunId.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürün Id";
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(308, 341);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(114, 43);
            this.BtnGuncelle.TabIndex = 18;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnUrunSil
            // 
            this.BtnUrunSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnUrunSil.Appearance.Options.UseFont = true;
            this.BtnUrunSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnUrunSil.ImageOptions.Image")));
            this.BtnUrunSil.Location = new System.Drawing.Point(173, 341);
            this.BtnUrunSil.Name = "BtnUrunSil";
            this.BtnUrunSil.Size = new System.Drawing.Size(113, 43);
            this.BtnUrunSil.TabIndex = 19;
            this.BtnUrunSil.Text = "Sil";
            this.BtnUrunSil.Click += new System.EventHandler(this.BtnUrunSil_Click_1);
            // 
            // FrmUrunİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmUrunİslem";
            this.Text = "Ürün Kayıt";
            this.Load += new System.EventHandler(this.FrmUrunİslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcEditFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditMenuSec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunKod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textUrunId.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit textUrunKod;
        private DevExpress.XtraEditors.TextEdit textUrunAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnMenuEkle;
        private DevExpress.XtraEditors.TextEdit textUrunId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.DateEdit dateEditTarih;
        private DevExpress.XtraEditors.CalcEdit calcEditFiyat;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditMenuSec;
        private DevExpress.XtraEditors.TextEdit textUrunAd;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnKapat;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnUrunSil;
    }
}