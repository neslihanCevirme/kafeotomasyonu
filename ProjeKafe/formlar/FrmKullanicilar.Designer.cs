namespace ProjeKafe.formlar
{
    partial class FrmKullanicilar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanicilar));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnYeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKullaniciSil = new DevExpress.XtraEditors.SimpleButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textKullaniciId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKullaniciId.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 26);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1174, 323);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // BtnYeniKullanici
            // 
            this.BtnYeniKullanici.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnYeniKullanici.Appearance.Options.UseFont = true;
            this.BtnYeniKullanici.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnYeniKullanici.Location = new System.Drawing.Point(1012, 374);
            this.BtnYeniKullanici.Name = "BtnYeniKullanici";
            this.BtnYeniKullanici.Size = new System.Drawing.Size(100, 40);
            this.BtnYeniKullanici.TabIndex = 12;
            this.BtnYeniKullanici.Text = "Yeni \r\nEkle";
            this.BtnYeniKullanici.Click += new System.EventHandler(this.BtnYeniKullanici_Click);
            // 
            // BtnKullaniciSil
            // 
            this.BtnKullaniciSil.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKullaniciSil.Appearance.Options.UseFont = true;
            this.BtnKullaniciSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnKullaniciSil.Location = new System.Drawing.Point(343, 374);
            this.BtnKullaniciSil.Name = "BtnKullaniciSil";
            this.BtnKullaniciSil.Size = new System.Drawing.Size(90, 36);
            this.BtnKullaniciSil.TabIndex = 13;
            this.BtnKullaniciSil.Text = "Sil";
            this.BtnKullaniciSil.Click += new System.EventHandler(this.BtnKullaniciSil_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textKullaniciId
            // 
            this.textKullaniciId.Location = new System.Drawing.Point(148, 371);
            this.textKullaniciId.Name = "textKullaniciId";
            this.textKullaniciId.Size = new System.Drawing.Size(125, 22);
            this.textKullaniciId.TabIndex = 15;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(50, 374);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 16);
            this.labelControl1.TabIndex = 16;
            this.labelControl1.Text = "Kullanıcı Id";
            // 
            // FrmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 450);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textKullaniciId);
            this.Controls.Add(this.BtnKullaniciSil);
            this.Controls.Add(this.BtnYeniKullanici);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmKullanicilar";
            this.Text = "Kullanıcılar";
            this.Load += new System.EventHandler(this.FrmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textKullaniciId.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnYeniKullanici;
        private DevExpress.XtraEditors.SimpleButton BtnKullaniciSil;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DevExpress.XtraEditors.TextEdit textKullaniciId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}