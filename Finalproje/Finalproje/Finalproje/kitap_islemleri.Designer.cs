namespace Finalproje
{
    partial class kitap_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap_islemleri));
            this.anasayfa = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.kitap_listesi_d = new System.Windows.Forms.DataGridView();
            this.guncelle_b = new System.Windows.Forms.Button();
            this.ekle_b = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.id_t = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tur_t = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.no_t = new System.Windows.Forms.TextBox();
            this.tum_b = new System.Windows.Forms.Button();
            this.sil_b = new System.Windows.Forms.Button();
            this.yazar_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ad_t = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ssayisi_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ktp_ara_t = new System.Windows.Forms.TextBox();
            this.kategori_cmb = new System.Windows.Forms.ComboBox();
            this.ktp_ara_b = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listesi_d)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.LavenderBlush;
            this.anasayfa.FlatAppearance.BorderSize = 0;
            this.anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.anasayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.anasayfa.ImageKey = "icons8-home-64.png";
            this.anasayfa.ImageList = this.ımageList1;
            this.anasayfa.Location = new System.Drawing.Point(729, 24);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(66, 66);
            this.anasayfa.TabIndex = 35;
            this.anasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-home-64.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-update-96.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-list-96.png");
            this.ımageList1.Images.SetKeyName(3, "icons8-delete-bin-96.png");
            this.ımageList1.Images.SetKeyName(4, "icons8-add-new-96.png");
            // 
            // kitap_listesi_d
            // 
            this.kitap_listesi_d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.kitap_listesi_d.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.kitap_listesi_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitap_listesi_d.GridColor = System.Drawing.Color.LavenderBlush;
            this.kitap_listesi_d.Location = new System.Drawing.Point(43, 388);
            this.kitap_listesi_d.Margin = new System.Windows.Forms.Padding(2);
            this.kitap_listesi_d.Name = "kitap_listesi_d";
            this.kitap_listesi_d.RowHeadersWidth = 51;
            this.kitap_listesi_d.RowTemplate.Height = 24;
            this.kitap_listesi_d.Size = new System.Drawing.Size(665, 343);
            this.kitap_listesi_d.TabIndex = 34;
            this.kitap_listesi_d.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitap_listesi_d_CellContentClick);
            // 
            // guncelle_b
            // 
            this.guncelle_b.FlatAppearance.BorderSize = 0;
            this.guncelle_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle_b.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guncelle_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guncelle_b.ImageKey = "icons8-update-96.png";
            this.guncelle_b.ImageList = this.ımageList1;
            this.guncelle_b.Location = new System.Drawing.Point(248, 271);
            this.guncelle_b.Margin = new System.Windows.Forms.Padding(2);
            this.guncelle_b.Name = "guncelle_b";
            this.guncelle_b.Size = new System.Drawing.Size(72, 72);
            this.guncelle_b.TabIndex = 31;
            this.guncelle_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelle_b.UseVisualStyleBackColor = true;
            this.guncelle_b.Click += new System.EventHandler(this.guncelle_b_Click);
            // 
            // ekle_b
            // 
            this.ekle_b.FlatAppearance.BorderSize = 0;
            this.ekle_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_b.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ekle_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ekle_b.ImageKey = "icons8-add-new-96.png";
            this.ekle_b.ImageList = this.ımageList1;
            this.ekle_b.Location = new System.Drawing.Point(79, 271);
            this.ekle_b.Margin = new System.Windows.Forms.Padding(2);
            this.ekle_b.Name = "ekle_b";
            this.ekle_b.Size = new System.Drawing.Size(72, 72);
            this.ekle_b.TabIndex = 30;
            this.ekle_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ekle_b.UseVisualStyleBackColor = true;
            this.ekle_b.Click += new System.EventHandler(this.ekle_b_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kitap ID:";
            // 
            // id_t
            // 
            this.id_t.Location = new System.Drawing.Point(99, 29);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(350, 20);
            this.id_t.TabIndex = 8;
            this.id_t.Text = "Kitap ID";
            this.id_t.Click += new System.EventHandler(this.id_t_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tür:";
            // 
            // tur_t
            // 
            this.tur_t.Location = new System.Drawing.Point(99, 153);
            this.tur_t.Margin = new System.Windows.Forms.Padding(2);
            this.tur_t.Name = "tur_t";
            this.tur_t.Size = new System.Drawing.Size(350, 20);
            this.tur_t.TabIndex = 6;
            this.tur_t.Text = "Kitabın Türü";
            this.tur_t.Click += new System.EventHandler(this.tur_t_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "No:";
            // 
            // no_t
            // 
            this.no_t.Location = new System.Drawing.Point(99, 123);
            this.no_t.Margin = new System.Windows.Forms.Padding(2);
            this.no_t.Name = "no_t";
            this.no_t.Size = new System.Drawing.Size(350, 20);
            this.no_t.TabIndex = 4;
            this.no_t.Text = "Kitap Numarası";
            this.no_t.Click += new System.EventHandler(this.no_t_Click);
            // 
            // tum_b
            // 
            this.tum_b.FlatAppearance.BorderSize = 0;
            this.tum_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tum_b.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tum_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tum_b.ImageKey = "icons8-list-96.png";
            this.tum_b.ImageList = this.ımageList1;
            this.tum_b.Location = new System.Drawing.Point(412, 271);
            this.tum_b.Margin = new System.Windows.Forms.Padding(2);
            this.tum_b.Name = "tum_b";
            this.tum_b.Size = new System.Drawing.Size(72, 72);
            this.tum_b.TabIndex = 33;
            this.tum_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tum_b.UseVisualStyleBackColor = true;
            this.tum_b.Click += new System.EventHandler(this.tum_b_Click);
            // 
            // sil_b
            // 
            this.sil_b.FlatAppearance.BorderSize = 0;
            this.sil_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil_b.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sil_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sil_b.ImageKey = "icons8-delete-bin-96.png";
            this.sil_b.ImageList = this.ımageList1;
            this.sil_b.Location = new System.Drawing.Point(592, 271);
            this.sil_b.Margin = new System.Windows.Forms.Padding(2);
            this.sil_b.Name = "sil_b";
            this.sil_b.Size = new System.Drawing.Size(72, 72);
            this.sil_b.TabIndex = 32;
            this.sil_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil_b.UseVisualStyleBackColor = true;
            this.sil_b.Click += new System.EventHandler(this.sil_b_Click);
            // 
            // yazar_t
            // 
            this.yazar_t.Location = new System.Drawing.Point(99, 92);
            this.yazar_t.Margin = new System.Windows.Forms.Padding(2);
            this.yazar_t.Name = "yazar_t";
            this.yazar_t.Size = new System.Drawing.Size(350, 20);
            this.yazar_t.TabIndex = 3;
            this.yazar_t.Text = "Kitabın Yazarı";
            this.yazar_t.Click += new System.EventHandler(this.yazar_t_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yazar:";
            // 
            // ad_t
            // 
            this.ad_t.Location = new System.Drawing.Point(99, 61);
            this.ad_t.Margin = new System.Windows.Forms.Padding(2);
            this.ad_t.Name = "ad_t";
            this.ad_t.Size = new System.Drawing.Size(350, 20);
            this.ad_t.TabIndex = 0;
            this.ad_t.Text = "Kitap Adı";
            this.ad_t.Click += new System.EventHandler(this.ad_t_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ssayisi_t);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.id_t);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tur_t);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.no_t);
            this.groupBox2.Controls.Add(this.yazar_t);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ad_t);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(256, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(452, 219);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 188);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Sayfa Sayısı:";
            // 
            // ssayisi_t
            // 
            this.ssayisi_t.Location = new System.Drawing.Point(99, 184);
            this.ssayisi_t.Margin = new System.Windows.Forms.Padding(2);
            this.ssayisi_t.Name = "ssayisi_t";
            this.ssayisi_t.Size = new System.Drawing.Size(350, 20);
            this.ssayisi_t.TabIndex = 10;
            this.ssayisi_t.Text = "Sayfa Sayısı";
            this.ssayisi_t.Click += new System.EventHandler(this.ssayisi_t_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kitap Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Önce Arama Kriteri Seçiniz";
            // 
            // ktp_ara_t
            // 
            this.ktp_ara_t.Location = new System.Drawing.Point(10, 94);
            this.ktp_ara_t.Name = "ktp_ara_t";
            this.ktp_ara_t.Size = new System.Drawing.Size(143, 20);
            this.ktp_ara_t.TabIndex = 3;
            this.ktp_ara_t.Text = "Kitap Bilgisi";
            this.ktp_ara_t.Click += new System.EventHandler(this.ktp_ara_t_Click);
            // 
            // kategori_cmb
            // 
            this.kategori_cmb.FormattingEnabled = true;
            this.kategori_cmb.Items.AddRange(new object[] {
            "kitapadi",
            "yazar",
            "tur",
            "kitapnumara"});
            this.kategori_cmb.Location = new System.Drawing.Point(9, 54);
            this.kategori_cmb.Margin = new System.Windows.Forms.Padding(2);
            this.kategori_cmb.Name = "kategori_cmb";
            this.kategori_cmb.Size = new System.Drawing.Size(144, 21);
            this.kategori_cmb.TabIndex = 2;
            this.kategori_cmb.SelectedIndexChanged += new System.EventHandler(this.kategori_cmb_SelectedIndexChanged);
            // 
            // ktp_ara_b
            // 
            this.ktp_ara_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ktp_ara_b.Location = new System.Drawing.Point(10, 124);
            this.ktp_ara_b.Margin = new System.Windows.Forms.Padding(2);
            this.ktp_ara_b.Name = "ktp_ara_b";
            this.ktp_ara_b.Size = new System.Drawing.Size(143, 31);
            this.ktp_ara_b.TabIndex = 1;
            this.ktp_ara_b.Text = "Kitap Ara";
            this.ktp_ara_b.UseVisualStyleBackColor = true;
            this.ktp_ara_b.Click += new System.EventHandler(this.ktp_ara_b_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ktp_ara_t);
            this.groupBox1.Controls.Add(this.kategori_cmb);
            this.groupBox1.Controls.Add(this.ktp_ara_b);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(43, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(164, 219);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Ara";
            // 
            // kitap_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(811, 742);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.kitap_listesi_d);
            this.Controls.Add(this.guncelle_b);
            this.Controls.Add(this.ekle_b);
            this.Controls.Add(this.tum_b);
            this.Controls.Add(this.sil_b);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "kitap_islemleri";
            this.Text = "kitap_islemleri";
            ((System.ComponentModel.ISupportInitialize)(this.kitap_listesi_d)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.DataGridView kitap_listesi_d;
        private System.Windows.Forms.Button guncelle_b;
        private System.Windows.Forms.Button ekle_b;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tur_t;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox no_t;
        private System.Windows.Forms.Button tum_b;
        private System.Windows.Forms.Button sil_b;
        private System.Windows.Forms.TextBox yazar_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ad_t;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ktp_ara_t;
        private System.Windows.Forms.ComboBox kategori_cmb;
        private System.Windows.Forms.Button ktp_ara_b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ssayisi_t;
        private System.Windows.Forms.ImageList ımageList1;
    }
}