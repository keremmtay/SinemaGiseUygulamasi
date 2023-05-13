namespace SinemaGiseUygulamasi
{
    partial class FormTur
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxYasSiniri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTurAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.btnFormuTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(720, 209);
            this.dataGridView1.TabIndex = 82;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(39, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 79;
            this.label4.Text = "Yaş Sınırı";
            // 
            // tbxYasSiniri
            // 
            this.tbxYasSiniri.Location = new System.Drawing.Point(155, 84);
            this.tbxYasSiniri.Name = "tbxYasSiniri";
            this.tbxYasSiniri.Size = new System.Drawing.Size(100, 20);
            this.tbxYasSiniri.TabIndex = 76;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 80;
            this.label2.Text = "Tür Adı";
            // 
            // tbxTurAdi
            // 
            this.tbxTurAdi.Location = new System.Drawing.Point(155, 52);
            this.tbxTurAdi.Name = "tbxTurAdi";
            this.tbxTurAdi.Size = new System.Drawing.Size(100, 20);
            this.tbxTurAdi.TabIndex = 77;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 81;
            this.label1.Text = "Id";
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(155, 23);
            this.tbxId.Name = "tbxId";
            this.tbxId.ReadOnly = true;
            this.tbxId.Size = new System.Drawing.Size(100, 20);
            this.tbxId.TabIndex = 78;
            // 
            // btnFormuTemizle
            // 
            this.btnFormuTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFormuTemizle.Location = new System.Drawing.Point(612, 105);
            this.btnFormuTemizle.Name = "btnFormuTemizle";
            this.btnFormuTemizle.Size = new System.Drawing.Size(138, 39);
            this.btnFormuTemizle.TabIndex = 72;
            this.btnFormuTemizle.Text = "Formu Temizle";
            this.btnFormuTemizle.UseVisualStyleBackColor = true;
            this.btnFormuTemizle.Click += new System.EventHandler(this.btnFormuTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(612, 27);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 39);
            this.btnGuncelle.TabIndex = 73;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(443, 105);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(138, 39);
            this.btnSil.TabIndex = 74;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(443, 27);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(138, 39);
            this.btnKaydet.TabIndex = 75;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FormTur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxYasSiniri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxTurAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxId);
            this.Controls.Add(this.btnFormuTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormTur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTur";
            this.Load += new System.EventHandler(this.FormTur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxYasSiniri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTurAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Button btnFormuTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
    }
}