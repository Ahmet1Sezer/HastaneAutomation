namespace HastaneOtomasyonu
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnHastaGiriş = new System.Windows.Forms.Button();
            this.btnDoktorGiriş = new System.Windows.Forms.Button();
            this.BtnSekreterGiriş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHastaGiriş
            // 
            this.btnHastaGiriş.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHastaGiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaGiriş.BackgroundImage")));
            this.btnHastaGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHastaGiriş.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHastaGiriş.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHastaGiriş.Location = new System.Drawing.Point(29, 22);
            this.btnHastaGiriş.Name = "btnHastaGiriş";
            this.btnHastaGiriş.Size = new System.Drawing.Size(151, 116);
            this.btnHastaGiriş.TabIndex = 0;
            this.btnHastaGiriş.UseVisualStyleBackColor = false;
            this.btnHastaGiriş.Click += new System.EventHandler(this.btnHastaGiriş_Click);
            // 
            // btnDoktorGiriş
            // 
            this.btnDoktorGiriş.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDoktorGiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGiriş.BackgroundImage")));
            this.btnDoktorGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoktorGiriş.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDoktorGiriş.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoktorGiriş.Location = new System.Drawing.Point(218, 22);
            this.btnDoktorGiriş.Name = "btnDoktorGiriş";
            this.btnDoktorGiriş.Size = new System.Drawing.Size(151, 116);
            this.btnDoktorGiriş.TabIndex = 1;
            this.btnDoktorGiriş.UseVisualStyleBackColor = false;
            this.btnDoktorGiriş.Click += new System.EventHandler(this.btnDoktorGiriş_Click);
            // 
            // BtnSekreterGiriş
            // 
            this.BtnSekreterGiriş.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BtnSekreterGiriş.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGiriş.BackgroundImage")));
            this.BtnSekreterGiriş.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSekreterGiriş.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSekreterGiriş.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSekreterGiriş.Location = new System.Drawing.Point(408, 22);
            this.BtnSekreterGiriş.Name = "BtnSekreterGiriş";
            this.BtnSekreterGiriş.Size = new System.Drawing.Size(151, 116);
            this.BtnSekreterGiriş.TabIndex = 2;
            this.BtnSekreterGiriş.UseVisualStyleBackColor = false;
            this.BtnSekreterGiriş.Click += new System.EventHandler(this.BtnSekreterGiriş_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(69, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(247, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(432, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(143, 223);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(311, 100);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 413);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGiriş);
            this.Controls.Add(this.btnDoktorGiriş);
            this.Controls.Add(this.btnHastaGiriş);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGiriş;
        private System.Windows.Forms.Button btnDoktorGiriş;
        private System.Windows.Forms.Button BtnSekreterGiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

