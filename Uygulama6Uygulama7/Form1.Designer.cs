namespace Uygulama6Uygulama7
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mDosya = new System.Windows.Forms.ToolStripMenuItem();
            this.mDuzen = new System.Windows.Forms.ToolStripMenuItem();
            this.mCık = new System.Windows.Forms.ToolStripMenuItem();
            this.mYeni = new System.Windows.Forms.ToolStripMenuItem();
            this.mAc = new System.Windows.Forms.ToolStripMenuItem();
            this.mKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.mYazdır = new System.Windows.Forms.ToolStripMenuItem();
            this.mKes = new System.Windows.Forms.ToolStripMenuItem();
            this.mKopyala = new System.Windows.Forms.ToolStripMenuItem();
            this.mYapistir = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEditor = new System.Windows.Forms.RichTextBox();
            this.cmDuzen = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopyalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yapıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BELGE = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.cmDuzen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mDosya,
            this.mDuzen,
            this.mCık});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mDosya
            // 
            this.mDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mYeni,
            this.mAc,
            this.mKaydet,
            this.mYazdır});
            this.mDosya.Name = "mDosya";
            this.mDosya.Size = new System.Drawing.Size(51, 20);
            this.mDosya.Text = "Dosya";
            // 
            // mDuzen
            // 
            this.mDuzen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mKes,
            this.mKopyala,
            this.mYapistir});
            this.mDuzen.Name = "mDuzen";
            this.mDuzen.Size = new System.Drawing.Size(52, 20);
            this.mDuzen.Text = "Düzen";
            // 
            // mCık
            // 
            this.mCık.Name = "mCık";
            this.mCık.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mCık.Size = new System.Drawing.Size(34, 20);
            this.mCık.Text = "çık";
            this.mCık.Click += new System.EventHandler(this.mCık_Click);
            // 
            // mYeni
            // 
            this.mYeni.Name = "mYeni";
            this.mYeni.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mYeni.Size = new System.Drawing.Size(180, 22);
            this.mYeni.Text = "Yeni";
            // 
            // mAc
            // 
            this.mAc.Name = "mAc";
            this.mAc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mAc.Size = new System.Drawing.Size(180, 22);
            this.mAc.Text = "Aç";
            this.mAc.Click += new System.EventHandler(this.mAc_Click);
            // 
            // mKaydet
            // 
            this.mKaydet.Name = "mKaydet";
            this.mKaydet.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mKaydet.Size = new System.Drawing.Size(180, 22);
            this.mKaydet.Text = "Kaydet";
            this.mKaydet.Click += new System.EventHandler(this.mKaydet_Click);
            // 
            // mYazdır
            // 
            this.mYazdır.Name = "mYazdır";
            this.mYazdır.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mYazdır.Size = new System.Drawing.Size(180, 22);
            this.mYazdır.Text = "Yazdır";
            this.mYazdır.Click += new System.EventHandler(this.mYazdır_Click);
            // 
            // mKes
            // 
            this.mKes.Enabled = false;
            this.mKes.Name = "mKes";
            this.mKes.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mKes.Size = new System.Drawing.Size(180, 22);
            this.mKes.Text = "Kes";
            this.mKes.Click += new System.EventHandler(this.mKes_Click);
            // 
            // mKopyala
            // 
            this.mKopyala.Enabled = false;
            this.mKopyala.Name = "mKopyala";
            this.mKopyala.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mKopyala.Size = new System.Drawing.Size(180, 22);
            this.mKopyala.Text = "Kopyala";
            this.mKopyala.Click += new System.EventHandler(this.mKopyala_Click);
            // 
            // mYapistir
            // 
            this.mYapistir.Enabled = false;
            this.mYapistir.Name = "mYapistir";
            this.mYapistir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mYapistir.Size = new System.Drawing.Size(180, 22);
            this.mYapistir.Text = "Yapıştır";
            this.mYapistir.Click += new System.EventHandler(this.mYapistir_Click);
            // 
            // txtEditor
            // 
            this.txtEditor.ContextMenuStrip = this.cmDuzen;
            this.txtEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEditor.Location = new System.Drawing.Point(0, 24);
            this.txtEditor.Name = "txtEditor";
            this.txtEditor.Size = new System.Drawing.Size(800, 426);
            this.txtEditor.TabIndex = 1;
            this.txtEditor.Text = "";
            // 
            // cmDuzen
            // 
            this.cmDuzen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kesToolStripMenuItem,
            this.kopyalaToolStripMenuItem,
            this.yapıştırToolStripMenuItem});
            this.cmDuzen.Name = "cmDuzen";
            this.cmDuzen.Size = new System.Drawing.Size(116, 70);
            // 
            // kesToolStripMenuItem
            // 
            this.kesToolStripMenuItem.Name = "kesToolStripMenuItem";
            this.kesToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kesToolStripMenuItem.Text = "kes";
            // 
            // kopyalaToolStripMenuItem
            // 
            this.kopyalaToolStripMenuItem.Name = "kopyalaToolStripMenuItem";
            this.kopyalaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.kopyalaToolStripMenuItem.Text = "kopyala";
            // 
            // yapıştırToolStripMenuItem
            // 
            this.yapıştırToolStripMenuItem.Name = "yapıştırToolStripMenuItem";
            this.yapıştırToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.yapıştırToolStripMenuItem.Text = "yapıştır";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEditor);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmDuzen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mDosya;
        private System.Windows.Forms.ToolStripMenuItem mYeni;
        private System.Windows.Forms.ToolStripMenuItem mAc;
        private System.Windows.Forms.ToolStripMenuItem mKaydet;
        private System.Windows.Forms.ToolStripMenuItem mYazdır;
        private System.Windows.Forms.ToolStripMenuItem mDuzen;
        private System.Windows.Forms.ToolStripMenuItem mKes;
        private System.Windows.Forms.ToolStripMenuItem mCık;
        private System.Windows.Forms.ToolStripMenuItem mKopyala;
        private System.Windows.Forms.ToolStripMenuItem mYapistir;
        private System.Windows.Forms.RichTextBox txtEditor;
        private System.Windows.Forms.ContextMenuStrip cmDuzen;
        private System.Windows.Forms.ToolStripMenuItem kesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopyalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yapıştırToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Drawing.Printing.PrintDocument BELGE;
    }
}

