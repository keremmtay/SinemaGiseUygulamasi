namespace SinemaGiseUygulamasi
{
    partial class FormPersonel
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
            this.cbxAktifMi = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSoyadi = new System.Windows.Forms.TextBox();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.tbxGorevi = new System.Windows.Forms.TextBox();
            this.tbxSifre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxAktifMi
            // 
            this.cbxAktifMi.AutoSize = true;
            this.cbxAktifMi.Location = new System.Drawing.Point(155, 200);
            this.cbxAktifMi.Name = "cbxAktifMi";
            this.cbxAktifMi.Size = new System.Drawing.Size(15, 14);
            this.cbxAktifMi.TabIndex = 53;
            this.cbxAktifMi.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(720, 209);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(39, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Görevi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Soyadı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(39, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 47;
            this.label6.Text = "Aktif Mi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 48;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // tbxSoyadi
            // 
            this.tbxSoyadi.Location = new System.Drawing.Point(155, 75);
            this.tbxSoyadi.Name = "tbxSoyadi";
            this.tbxSoyadi.Size = new System.Drawing.Size(100, 20);
            this.tbxSoyadi.TabIndex = 40;
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(155, 137);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.tbxKullaniciAdi.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 49;
            this.label2.Text = "Adı";
            // 
            // tbxAdi
            // 
            this.tbxAdi.Location = new System.Drawing.Point(155, 43);
            this.tbxAdi.Name = "tbxAdi";
            this.tbxAdi.Size = new System.Drawing.Size(100, 20);
            this.tbxAdi.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Id";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(155, 14);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(100, 20);
            this.tbxId.TabIndex = 43;
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormuTemizle.Location = new System.Drawing.Point(612, 115);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(138, 39);
            this.btnFormuTemizle.TabIndex = 36;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = true;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(612, 37);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 39);
            this.btnGuncelle.TabIndex = 37;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(443, 115);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(138, 39);
            this.btnSil.TabIndex = 38;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(443, 37);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(138, 39);
            this.btnKaydet.TabIndex = 39;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // tbxGorevi
            // 
            this.tbxGorevi.Location = new System.Drawing.Point(155, 104);
            this.tbxGorevi.Name = "tbxGorevi";
            this.tbxGorevi.Size = new System.Drawing.Size(100, 20);
            this.tbxGorevi.TabIndex = 40;
            // 
            // tbxSifre
            // 
            this.tbxSifre.Location = new System.Drawing.Point(155, 167);
            this.tbxSifre.Name = "tbxSifre";
            this.tbxSifre.Size = new System.Drawing.Size(100, 20);
            this.tbxSifre.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(39, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 48;
            this.label7.Text = "Şifre";
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxAktifMi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxGorevi);
            this.Controls.Add(this.tbxSifre);
            this.Controls.Add(this.tbxSoyadi);
            this.Controls.Add(this.tbxKullaniciAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.btnFormuTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Name = "FormPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPersonel";
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbxAktifMi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSoyadi;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnFormuTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox tbxGorevi;
        private System.Windows.Forms.TextBox tbxSifre;
        private System.Windows.Forms.Label label7;
    }
}