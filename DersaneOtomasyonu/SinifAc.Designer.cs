namespace DersaneOtomasyonu
{
    partial class SinifAc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinifAc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpbitis = new System.Windows.Forms.DateTimePicker();
            this.CbOgretmenBrans = new System.Windows.Forms.ComboBox();
            this.txtYeniSinifAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbOgretmenAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgrenciSayisi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbsinifi = new System.Windows.Forms.ComboBox();
            this.dgvsinif = new System.Windows.Forms.DataGridView();
            this.Brans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DerslerinBaslangici = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DerslerinBitisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SinifBransi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.txtBaslangic);
            this.groupBox1.Controls.Add(this.dtpbitis);
            this.groupBox1.Controls.Add(this.CbOgretmenBrans);
            this.groupBox1.Controls.Add(this.txtYeniSinifAdi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbOgretmenAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOgrenciSayisi);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbsinifi);
            this.groupBox1.Controls.Add(this.dgvsinif);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(836, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sınıf Aç / Kapat";
            // 
            // btnSil
            // 
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSil.Location = new System.Drawing.Point(678, 269);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(152, 39);
            this.btnSil.TabIndex = 74;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKaydet.Location = new System.Drawing.Point(520, 269);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(152, 39);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtBaslangic
            // 
            this.txtBaslangic.Location = new System.Drawing.Point(602, 23);
            this.txtBaslangic.Name = "txtBaslangic";
            this.txtBaslangic.Size = new System.Drawing.Size(221, 25);
            this.txtBaslangic.TabIndex = 4;
            // 
            // dtpbitis
            // 
            this.dtpbitis.Location = new System.Drawing.Point(602, 60);
            this.dtpbitis.Name = "dtpbitis";
            this.dtpbitis.Size = new System.Drawing.Size(221, 25);
            this.dtpbitis.TabIndex = 5;
            // 
            // CbOgretmenBrans
            // 
            this.CbOgretmenBrans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOgretmenBrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CbOgretmenBrans.FormattingEnabled = true;
            this.CbOgretmenBrans.Location = new System.Drawing.Point(246, 55);
            this.CbOgretmenBrans.Name = "CbOgretmenBrans";
            this.CbOgretmenBrans.Size = new System.Drawing.Size(199, 27);
            this.CbOgretmenBrans.TabIndex = 2;
            this.CbOgretmenBrans.SelectedIndexChanged += new System.EventHandler(this.CbOgretmenBrans_SelectedIndexChanged);
            // 
            // txtYeniSinifAdi
            // 
            this.txtYeniSinifAdi.Location = new System.Drawing.Point(88, 88);
            this.txtYeniSinifAdi.Multiline = true;
            this.txtYeniSinifAdi.Name = "txtYeniSinifAdi";
            this.txtYeniSinifAdi.Size = new System.Drawing.Size(152, 27);
            this.txtYeniSinifAdi.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 65;
            this.label4.Text = "Sınıf Adı :";
            // 
            // cbOgretmenAdi
            // 
            this.cbOgretmenAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOgretmenAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOgretmenAdi.FormattingEnabled = true;
            this.cbOgretmenAdi.Location = new System.Drawing.Point(88, 56);
            this.cbOgretmenAdi.Name = "cbOgretmenAdi";
            this.cbOgretmenAdi.Size = new System.Drawing.Size(152, 27);
            this.cbOgretmenAdi.TabIndex = 1;
            this.cbOgretmenAdi.SelectedIndexChanged += new System.EventHandler(this.cbOgretmenAdi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Öğretmen :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Öğrenci Sayısı :";
            // 
            // txtOgrenciSayisi
            // 
            this.txtOgrenciSayisi.Enabled = false;
            this.txtOgrenciSayisi.Location = new System.Drawing.Point(128, 279);
            this.txtOgrenciSayisi.Name = "txtOgrenciSayisi";
            this.txtOgrenciSayisi.Size = new System.Drawing.Size(100, 25);
            this.txtOgrenciSayisi.TabIndex = 55;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEkle.Location = new System.Drawing.Point(362, 269);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(152, 39);
            this.btnEkle.TabIndex = 49;
            this.btnEkle.Text = "GÜNCELLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(473, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 19);
            this.label15.TabIndex = 54;
            this.label15.Text = "Bitiş Tarihi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(473, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 19);
            this.label12.TabIndex = 53;
            this.label12.Text = "Başlangıç Tarihi :";
            // 
            // cbsinifi
            // 
            this.cbsinifi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsinifi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbsinifi.FormattingEnabled = true;
            this.cbsinifi.Location = new System.Drawing.Point(88, 18);
            this.cbsinifi.Name = "cbsinifi";
            this.cbsinifi.Size = new System.Drawing.Size(152, 27);
            this.cbsinifi.TabIndex = 3;
            this.cbsinifi.SelectedIndexChanged += new System.EventHandler(this.cbsinifi_SelectedIndexChanged);
            // 
            // dgvsinif
            // 
            this.dgvsinif.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsinif.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsinif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsinif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Brans,
            this.OgretmenAdi,
            this.DerslerinBaslangici,
            this.DerslerinBitisi,
            this.SinifBransi});
            this.dgvsinif.Location = new System.Drawing.Point(12, 121);
            this.dgvsinif.Name = "dgvsinif";
            this.dgvsinif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsinif.Size = new System.Drawing.Size(818, 142);
            this.dgvsinif.TabIndex = 2;
            this.dgvsinif.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvsinif_CellMouseClick);
            // 
            // Brans
            // 
            this.Brans.DataPropertyName = "Brans";
            this.Brans.HeaderText = "Branşlar";
            this.Brans.Name = "Brans";
            // 
            // OgretmenAdi
            // 
            this.OgretmenAdi.DataPropertyName = "OgretmenAdi";
            this.OgretmenAdi.HeaderText = "Öğretmen (Adı Soyadı)";
            this.OgretmenAdi.Name = "OgretmenAdi";
            // 
            // DerslerinBaslangici
            // 
            this.DerslerinBaslangici.DataPropertyName = "DerslerinBaslangici";
            this.DerslerinBaslangici.HeaderText = "Ders Başlangıcı";
            this.DerslerinBaslangici.Name = "DerslerinBaslangici";
            // 
            // DerslerinBitisi
            // 
            this.DerslerinBitisi.DataPropertyName = "DerslerinBitisi";
            this.DerslerinBitisi.HeaderText = "Ders Bitişi";
            this.DerslerinBitisi.Name = "DerslerinBitisi";
            // 
            // SinifBransi
            // 
            this.SinifBransi.DataPropertyName = "SinifBransi";
            this.SinifBransi.HeaderText = "Sınıf";
            this.SinifBransi.Name = "SinifBransi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "Sınıfı :";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(793, -2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 74;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 30;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(824, -2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 73;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 30;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.groupBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // SinifAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(858, 338);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SinifAc";
            this.Text = "Sını Aç";
            this.Load += new System.EventHandler(this.SinifAc_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsinif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvsinif;
        private System.Windows.Forms.ComboBox cbsinifi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgrenciSayisi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeniSinifAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbOgretmenAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brans;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DerslerinBaslangici;
        private System.Windows.Forms.DataGridViewTextBoxColumn DerslerinBitisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SinifBransi;
        private System.Windows.Forms.ComboBox CbOgretmenBrans;
        private System.Windows.Forms.DateTimePicker txtBaslangic;
        private System.Windows.Forms.DateTimePicker dtpbitis;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
    }
}