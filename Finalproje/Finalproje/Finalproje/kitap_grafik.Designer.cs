namespace Finalproje
{
    partial class kitap_grafik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kitap_grafik));
            this.anasayfa = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
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
            this.anasayfa.Location = new System.Drawing.Point(564, 44);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(66, 66);
            this.anasayfa.TabIndex = 8;
            this.anasayfa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "icons8-home-64.png");
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(29, 44);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(517, 325);
            this.zedGraphControl1.TabIndex = 9;
           
            // 
            // kitap_grafik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(647, 387);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.anasayfa);
            this.Name = "kitap_grafik";
            this.Text = "kitap_grafik";
            this.Load += new System.EventHandler(this.kitap_grafik_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button anasayfa;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}