namespace Finalproje
{
    partial class ogrenci_islemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrenci_islemleri));
            this.anasayfa = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ogrenci_listesi_d = new System.Windows.Forms.DataGridView();
            this.id_t = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bolum_t = new System.Windows.Forms.TextBox();
            this.numara_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tum_b = new System.Windows.Forms.Button();
            this.guncelle_b = new System.Windows.Forms.Button();
            this.ekle_b = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.isim_t = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sehir_t = new System.Windows.Forms.TextBox();
            this.ogr_ara_b = new System.Windows.Forms.Button();
            this.ogr_ara_t = new System.Windows.Forms.TextBox();
            this.sil_b = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_listesi_d)).BeginInit();
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
            this.anasayfa.Location = new System.Drawing.Point(724, 24);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(66, 66);
            this.anasayfa.TabIndex = 32;
            this.anasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-delete-bin-50.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-edit-user-50.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-add-user-male-50.png");
            this.ımageList1.Images.SetKeyName(3, "");
            this.ımageList1.Images.SetKeyName(4, "icons8-list-64.png");
            this.ımageList1.Images.SetKeyName(5, "icons8-home-64.png");
            // 
            // ogrenci_listesi_d
            // 
            this.ogrenci_listesi_d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ogrenci_listesi_d.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.ogrenci_listesi_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrenci_listesi_d.GridColor = System.Drawing.Color.LavenderBlush;
            this.ogrenci_listesi_d.Location = new System.Drawing.Point(43, 365);
            this.ogrenci_listesi_d.Margin = new System.Windows.Forms.Padding(2);
            this.ogrenci_listesi_d.Name = "ogrenci_listesi_d";
            this.ogrenci_listesi_d.RowTemplate.Height = 24;
            this.ogrenci_listesi_d.Size = new System.Drawing.Size(665, 343);
            this.ogrenci_listesi_d.TabIndex = 31;
            this.ogrenci_listesi_d.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrenci_listesi_d_CellContentClick);
            // 
            // id_t
            // 
            this.id_t.Location = new System.Drawing.Point(74, 26);
            this.id_t.Margin = new System.Windows.Forms.Padding(2);
            this.id_t.Name = "id_t";
            this.id_t.Size = new System.Drawing.Size(350, 20);
            this.id_t.TabIndex = 7;
            this.id_t.Text = "Öğrenci ID";
            this.id_t.Click += new System.EventHandler(this.id_t_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bölüm:";
            // 
            // bolum_t
            // 
            this.bolum_t.Location = new System.Drawing.Point(74, 111);
            this.bolum_t.Margin = new System.Windows.Forms.Padding(2);
            this.bolum_t.Name = "bolum_t";
            this.bolum_t.Size = new System.Drawing.Size(350, 20);
            this.bolum_t.TabIndex = 4;
            this.bolum_t.Text = "Öğrencinin Okuduğu Bölüm";
            this.bolum_t.Click += new System.EventHandler(this.bolum_t_Click);
            // 
            // numara_t
            // 
            this.numara_t.Location = new System.Drawing.Point(74, 82);
            this.numara_t.Margin = new System.Windows.Forms.Padding(2);
            this.numara_t.Name = "numara_t";
            this.numara_t.Size = new System.Drawing.Size(350, 20);
            this.numara_t.TabIndex = 3;
            this.numara_t.Text = "Öğrenci Numarası";
            this.numara_t.Click += new System.EventHandler(this.numara_t_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numara:";
            // 
            // tum_b
            // 
            this.tum_b.BackColor = System.Drawing.Color.LavenderBlush;
            this.tum_b.FlatAppearance.BorderSize = 0;
            this.tum_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tum_b.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tum_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tum_b.ImageKey = "icons8-list-64.png";
            this.tum_b.ImageList = this.ımageList1;
            this.tum_b.Location = new System.Drawing.Point(409, 248);
            this.tum_b.Margin = new System.Windows.Forms.Padding(2);
            this.tum_b.Name = "tum_b";
            this.tum_b.Size = new System.Drawing.Size(72, 72);
            this.tum_b.TabIndex = 30;
            this.tum_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tum_b.UseVisualStyleBackColor = false;
            this.tum_b.Click += new System.EventHandler(this.tum_b_Click);
            // 
            // guncelle_b
            // 
            this.guncelle_b.BackColor = System.Drawing.Color.LavenderBlush;
            this.guncelle_b.FlatAppearance.BorderSize = 0;
            this.guncelle_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guncelle_b.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.guncelle_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guncelle_b.ImageIndex = 0;
            this.guncelle_b.ImageList = this.ımageList1;
            this.guncelle_b.Location = new System.Drawing.Point(256, 247);
            this.guncelle_b.Margin = new System.Windows.Forms.Padding(0);
            this.guncelle_b.Name = "guncelle_b";
            this.guncelle_b.Size = new System.Drawing.Size(72, 72);
            this.guncelle_b.TabIndex = 27;
            this.guncelle_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.guncelle_b.UseVisualStyleBackColor = false;
            this.guncelle_b.Click += new System.EventHandler(this.guncelle_b_Click);
            // 
            // ekle_b
            // 
            this.ekle_b.BackColor = System.Drawing.Color.LavenderBlush;
            this.ekle_b.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.ekle_b.FlatAppearance.BorderSize = 0;
            this.ekle_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ekle_b.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ekle_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ekle_b.ImageIndex = 1;
            this.ekle_b.ImageList = this.ımageList1;
            this.ekle_b.Location = new System.Drawing.Point(92, 248);
            this.ekle_b.Margin = new System.Windows.Forms.Padding(0);
            this.ekle_b.Name = "ekle_b";
            this.ekle_b.Size = new System.Drawing.Size(72, 72);
            this.ekle_b.TabIndex = 27;
            this.ekle_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ekle_b.UseVisualStyleBackColor = false;
            this.ekle_b.Click += new System.EventHandler(this.ekle_b_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "İsim:";
            // 
            // isim_t
            // 
            this.isim_t.Location = new System.Drawing.Point(74, 53);
            this.isim_t.Margin = new System.Windows.Forms.Padding(2);
            this.isim_t.Name = "isim_t";
            this.isim_t.Size = new System.Drawing.Size(350, 20);
            this.isim_t.TabIndex = 0;
            this.isim_t.Text = "Ad Soyad";
            this.isim_t.Click += new System.EventHandler(this.isim_t_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sehir_t);
            this.groupBox2.Controls.Add(this.id_t);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.bolum_t);
            this.groupBox2.Controls.Add(this.numara_t);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.isim_t);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(256, 24);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(452, 184);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Şehir:";
            // 
            // sehir_t
            // 
            this.sehir_t.Location = new System.Drawing.Point(74, 138);
            this.sehir_t.Margin = new System.Windows.Forms.Padding(2);
            this.sehir_t.Name = "sehir_t";
            this.sehir_t.Size = new System.Drawing.Size(350, 20);
            this.sehir_t.TabIndex = 8;
            this.sehir_t.Text = "Öğrencinin Bulunduğu Şehir";
            this.sehir_t.Click += new System.EventHandler(this.sehir_t_Click);
            // 
            // ogr_ara_b
            // 
            this.ogr_ara_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ogr_ara_b.Location = new System.Drawing.Point(16, 91);
            this.ogr_ara_b.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_ara_b.Name = "ogr_ara_b";
            this.ogr_ara_b.Size = new System.Drawing.Size(143, 31);
            this.ogr_ara_b.TabIndex = 1;
            this.ogr_ara_b.Text = "Öğrenci Ara";
            this.ogr_ara_b.UseVisualStyleBackColor = true;
            this.ogr_ara_b.Click += new System.EventHandler(this.ogr_ara_b_Click);
            // 
            // ogr_ara_t
            // 
            this.ogr_ara_t.Location = new System.Drawing.Point(16, 55);
            this.ogr_ara_t.Margin = new System.Windows.Forms.Padding(2);
            this.ogr_ara_t.Name = "ogr_ara_t";
            this.ogr_ara_t.Size = new System.Drawing.Size(144, 20);
            this.ogr_ara_t.TabIndex = 0;
            this.ogr_ara_t.Text = "Öğrenci Numarası Giriniz";
            this.ogr_ara_t.Click += new System.EventHandler(this.ogr_ara_t_Click);
            // 
            // sil_b
            // 
            this.sil_b.BackColor = System.Drawing.Color.LavenderBlush;
            this.sil_b.FlatAppearance.BorderSize = 0;
            this.sil_b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sil_b.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.sil_b.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sil_b.ImageKey = "icons8-add-user-male-50.png";
            this.sil_b.ImageList = this.ımageList1;
            this.sil_b.Location = new System.Drawing.Point(570, 246);
            this.sil_b.Margin = new System.Windows.Forms.Padding(2);
            this.sil_b.Name = "sil_b";
            this.sil_b.Size = new System.Drawing.Size(72, 72);
            this.sil_b.TabIndex = 29;
            this.sil_b.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil_b.UseVisualStyleBackColor = false;
            this.sil_b.Click += new System.EventHandler(this.sil_b_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.ogr_ara_b);
            this.groupBox1.Controls.Add(this.ogr_ara_t);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(43, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(164, 184);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Ara";
            // 
            // ogrenci_islemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(807, 726);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.ogrenci_listesi_d);
            this.Controls.Add(this.tum_b);
            this.Controls.Add(this.guncelle_b);
            this.Controls.Add(this.ekle_b);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.sil_b);
            this.Controls.Add(this.groupBox1);
            this.Name = "ogrenci_islemleri";
            this.Text = "ogrenci_islemleri";
            ((System.ComponentModel.ISupportInitialize)(this.ogrenci_listesi_d)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.DataGridView ogrenci_listesi_d;
        private System.Windows.Forms.TextBox id_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bolum_t;
        private System.Windows.Forms.TextBox numara_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tum_b;
        private System.Windows.Forms.Button guncelle_b;
        private System.Windows.Forms.Button ekle_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox isim_t;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ogr_ara_b;
        private System.Windows.Forms.TextBox ogr_ara_t;
        private System.Windows.Forms.Button sil_b;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sehir_t;
        private System.Windows.Forms.ImageList ımageList1;
    }
}