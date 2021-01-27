namespace Finalproje
{
    partial class alim_iade_gosterim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alim_iade_gosterim));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.arama_btn = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.giris_t = new System.Windows.Forms.TextBox();
            this.yukleme_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ozellik_c = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.anasayfa = new System.Windows.Forms.Button();
            this.liste_d = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.arama_btn);
            this.groupBox1.Controls.Add(this.giris_t);
            this.groupBox1.Controls.Add(this.yukleme_btn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ozellik_c);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Location = new System.Drawing.Point(36, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(584, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet-İade edilen kitap";
            // 
            // arama_btn
            // 
            this.arama_btn.FlatAppearance.BorderSize = 0;
            this.arama_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arama_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.arama_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.arama_btn.ImageKey = "icons8-literature-64.png";
            this.arama_btn.ImageList = this.ımageList1;
            this.arama_btn.Location = new System.Drawing.Point(162, 104);
            this.arama_btn.Name = "arama_btn";
            this.arama_btn.Size = new System.Drawing.Size(137, 75);
            this.arama_btn.TabIndex = 4;
            this.toolTip1.SetToolTip(this.arama_btn, "Arama Yap");
            this.arama_btn.UseVisualStyleBackColor = true;
            this.arama_btn.Click += new System.EventHandler(this.arama_btn_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-book-shelf-64.png");
            this.ımageList1.Images.SetKeyName(1, "icons8-literature-64.png");
            this.ımageList1.Images.SetKeyName(2, "icons8-home-64.png");
            // 
            // giris_t
            // 
            this.giris_t.ForeColor = System.Drawing.SystemColors.ControlText;
            this.giris_t.Location = new System.Drawing.Point(162, 59);
            this.giris_t.Name = "giris_t";
            this.giris_t.Size = new System.Drawing.Size(303, 20);
            this.giris_t.TabIndex = 3;
            // 
            // yukleme_btn
            // 
            this.yukleme_btn.FlatAppearance.BorderSize = 0;
            this.yukleme_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yukleme_btn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.yukleme_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yukleme_btn.ImageKey = "icons8-book-shelf-64.png";
            this.yukleme_btn.ImageList = this.ımageList1;
            this.yukleme_btn.Location = new System.Drawing.Point(336, 104);
            this.yukleme_btn.Name = "yukleme_btn";
            this.yukleme_btn.Size = new System.Drawing.Size(129, 75);
            this.yukleme_btn.TabIndex = 9;
            this.toolTip2.SetToolTip(this.yukleme_btn, "Listele");
            this.yukleme_btn.UseVisualStyleBackColor = true;
            this.yukleme_btn.Click += new System.EventHandler(this.cagirma_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(27, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kitap Bilgisi:";
            // 
            // ozellik_c
            // 
            this.ozellik_c.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ozellik_c.FormattingEnabled = true;
            this.ozellik_c.Items.AddRange(new object[] {
            "kitapadi",
            "yazar",
            "tur"});
            this.ozellik_c.Location = new System.Drawing.Point(162, 24);
            this.ozellik_c.Name = "ozellik_c";
            this.ozellik_c.Size = new System.Drawing.Size(303, 21);
            this.ozellik_c.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(27, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitabı şuna göre ara:";
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.LavenderBlush;
            this.anasayfa.FlatAppearance.BorderSize = 0;
            this.anasayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.anasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anasayfa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.anasayfa.ImageKey = "icons8-home-64.png";
            this.anasayfa.ImageList = this.ımageList1;
            this.anasayfa.Location = new System.Drawing.Point(626, 21);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(66, 66);
            this.anasayfa.TabIndex = 10;
            this.anasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip3.SetToolTip(this.anasayfa, "Anasayfa");
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // liste_d
            // 
            this.liste_d.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.liste_d.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.liste_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.liste_d.GridColor = System.Drawing.Color.LavenderBlush;
            this.liste_d.Location = new System.Drawing.Point(36, 245);
            this.liste_d.Name = "liste_d";
            this.liste_d.Size = new System.Drawing.Size(584, 383);
            this.liste_d.TabIndex = 8;
            // 
            // alim_iade_gosterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(705, 652);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.anasayfa);
            this.Controls.Add(this.liste_d);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "alim_iade_gosterim";
            this.Text = "alim_iade_gosterim";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.liste_d)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button arama_btn;
        private System.Windows.Forms.TextBox giris_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ozellik_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button anasayfa;
        private System.Windows.Forms.Button yukleme_btn;
        private System.Windows.Forms.DataGridView liste_d;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}