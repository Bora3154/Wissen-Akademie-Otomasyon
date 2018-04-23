namespace DersaneOtomasyonu
{
    partial class OgretmenBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgretmenBilgileri));
            this.grbOgretmenTarama = new System.Windows.Forms.GroupBox();
            this.txtNumaraTarama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOgretmenId = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtpostakodu = new System.Windows.Forms.TextBox();
            this.txtogrtmenEvTel = new System.Windows.Forms.MaskedTextBox();
            this.txtogrtmenCepTel = new System.Windows.Forms.MaskedTextBox();
            this.txtogrtmenTcKimlikNo = new System.Windows.Forms.MaskedTextBox();
            this.dgvogretmenbilgleri = new System.Windows.Forms.DataGridView();
            this.OgretmenID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sınıflar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenTcKimlikNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenCinsiyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenCepTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenEvTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenMailAdresi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenMaas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenSemt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenSehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgretmenPostaKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.btnKayitSil = new System.Windows.Forms.Button();
            this.btnGncl = new System.Windows.Forms.Button();
            this.txtogrtmenSehir = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtogrtmenSemt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtogrtmenMaas = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtogrtmenMail = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtogrtmenAdSoyad = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtogrtmenEvAdres = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.grbOgretmenTarama.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvogretmenbilgleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbOgretmenTarama
            // 
            this.grbOgretmenTarama.Controls.Add(this.txtNumaraTarama);
            this.grbOgretmenTarama.Controls.Add(this.label7);
            this.grbOgretmenTarama.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbOgretmenTarama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.grbOgretmenTarama.Location = new System.Drawing.Point(298, -1);
            this.grbOgretmenTarama.Name = "grbOgretmenTarama";
            this.grbOgretmenTarama.Size = new System.Drawing.Size(323, 114);
            this.grbOgretmenTarama.TabIndex = 73;
            this.grbOgretmenTarama.TabStop = false;
            this.grbOgretmenTarama.Text = "Öğretmen Tarama ";
            // 
            // txtNumaraTarama
            // 
            this.txtNumaraTarama.Location = new System.Drawing.Point(121, 46);
            this.txtNumaraTarama.Name = "txtNumaraTarama";
            this.txtNumaraTarama.Size = new System.Drawing.Size(152, 29);
            this.txtNumaraTarama.TabIndex = 0;
            this.txtNumaraTarama.TextChanged += new System.EventHandler(this.txtNumaraTarama_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(16, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tc Kimlik No :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtOgretmenId);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.txtpostakodu);
            this.groupBox1.Controls.Add(this.txtogrtmenEvTel);
            this.groupBox1.Controls.Add(this.txtogrtmenCepTel);
            this.groupBox1.Controls.Add(this.txtogrtmenTcKimlikNo);
            this.groupBox1.Controls.Add(this.dgvogretmenbilgleri);
            this.groupBox1.Controls.Add(this.txtBrans);
            this.groupBox1.Controls.Add(this.btnKayitSil);
            this.groupBox1.Controls.Add(this.btnGncl);
            this.groupBox1.Controls.Add(this.txtogrtmenSehir);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtogrtmenSemt);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtogrtmenMaas);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txtogrtmenMail);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtogrtmenAdSoyad);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.txtogrtmenEvAdres);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(92)))), ((int)(((byte)(170)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(871, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğretmen Bilgileri ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(20, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 75;
            this.label1.Text = "Öğretmen ID :";
            // 
            // txtOgretmenId
            // 
            this.txtOgretmenId.Enabled = false;
            this.txtOgretmenId.Location = new System.Drawing.Point(147, 71);
            this.txtOgretmenId.Name = "txtOgretmenId";
            this.txtOgretmenId.Size = new System.Drawing.Size(31, 26);
            this.txtOgretmenId.TabIndex = 74;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label22.Location = new System.Drawing.Point(20, 289);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 19);
            this.label22.TabIndex = 73;
            this.label22.Text = "Posta Kodu :";
            // 
            // txtpostakodu
            // 
            this.txtpostakodu.Location = new System.Drawing.Point(147, 289);
            this.txtpostakodu.Name = "txtpostakodu";
            this.txtpostakodu.Size = new System.Drawing.Size(167, 26);
            this.txtpostakodu.TabIndex = 5;
            // 
            // txtogrtmenEvTel
            // 
            this.txtogrtmenEvTel.Location = new System.Drawing.Point(147, 257);
            this.txtogrtmenEvTel.Mask = "00000000000";
            this.txtogrtmenEvTel.Name = "txtogrtmenEvTel";
            this.txtogrtmenEvTel.Size = new System.Drawing.Size(167, 26);
            this.txtogrtmenEvTel.TabIndex = 4;
            // 
            // txtogrtmenCepTel
            // 
            this.txtogrtmenCepTel.Location = new System.Drawing.Point(147, 224);
            this.txtogrtmenCepTel.Mask = "00000000000";
            this.txtogrtmenCepTel.Name = "txtogrtmenCepTel";
            this.txtogrtmenCepTel.Size = new System.Drawing.Size(168, 26);
            this.txtogrtmenCepTel.TabIndex = 3;
            // 
            // txtogrtmenTcKimlikNo
            // 
            this.txtogrtmenTcKimlikNo.Location = new System.Drawing.Point(147, 185);
            this.txtogrtmenTcKimlikNo.Mask = "00000000000";
            this.txtogrtmenTcKimlikNo.Name = "txtogrtmenTcKimlikNo";
            this.txtogrtmenTcKimlikNo.Size = new System.Drawing.Size(167, 26);
            this.txtogrtmenTcKimlikNo.TabIndex = 2;
            // 
            // dgvogretmenbilgleri
            // 
            this.dgvogretmenbilgleri.BackgroundColor = System.Drawing.Color.White;
            this.dgvogretmenbilgleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvogretmenbilgleri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OgretmenID,
            this.sınıflar,
            this.Brans,
            this.OgretmenAdi,
            this.OgretmenTcKimlikNo,
            this.OgretmenCinsiyet,
            this.OgretmenCepTel,
            this.OgretmenEvTel,
            this.OgretmenMailAdresi,
            this.OgretmenMaas,
            this.OgretmenAdres,
            this.OgretmenSemt,
            this.OgretmenSehir,
            this.OgretmenPostaKodu});
            this.dgvogretmenbilgleri.Location = new System.Drawing.Point(6, 317);
            this.dgvogretmenbilgleri.Name = "dgvogretmenbilgleri";
            this.dgvogretmenbilgleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvogretmenbilgleri.Size = new System.Drawing.Size(857, 163);
            this.dgvogretmenbilgleri.TabIndex = 12;
            this.dgvogretmenbilgleri.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvogretmenbilgleri_CellMouseClick);
            // 
            // OgretmenID
            // 
            this.OgretmenID.DataPropertyName = "OgretmenID";
            this.OgretmenID.HeaderText = "ID";
            this.OgretmenID.Name = "OgretmenID";
            // 
            // sınıflar
            // 
            this.sınıflar.DataPropertyName = "sınıflar";
            this.sınıflar.HeaderText = "Sınıf";
            this.sınıflar.Name = "sınıflar";
            // 
            // Brans
            // 
            this.Brans.DataPropertyName = "Brans";
            this.Brans.HeaderText = "Branş";
            this.Brans.Name = "Brans";
            // 
            // OgretmenAdi
            // 
            this.OgretmenAdi.DataPropertyName = "OgretmenAdi";
            this.OgretmenAdi.HeaderText = "Ad Soyad";
            this.OgretmenAdi.Name = "OgretmenAdi";
            // 
            // OgretmenTcKimlikNo
            // 
            this.OgretmenTcKimlikNo.DataPropertyName = "OgretmenTcKimlikNo";
            this.OgretmenTcKimlikNo.HeaderText = "TC Kimlik No";
            this.OgretmenTcKimlikNo.Name = "OgretmenTcKimlikNo";
            // 
            // OgretmenCinsiyet
            // 
            this.OgretmenCinsiyet.DataPropertyName = "OgretmenCinsiyet";
            this.OgretmenCinsiyet.HeaderText = "Cinsiyet";
            this.OgretmenCinsiyet.Name = "OgretmenCinsiyet";
            // 
            // OgretmenCepTel
            // 
            this.OgretmenCepTel.DataPropertyName = "OgretmenCepTel";
            this.OgretmenCepTel.HeaderText = "Cep Tel";
            this.OgretmenCepTel.Name = "OgretmenCepTel";
            // 
            // OgretmenEvTel
            // 
            this.OgretmenEvTel.DataPropertyName = "OgretmenEvTel";
            this.OgretmenEvTel.HeaderText = "Ev Tel";
            this.OgretmenEvTel.Name = "OgretmenEvTel";
            // 
            // OgretmenMailAdresi
            // 
            this.OgretmenMailAdresi.DataPropertyName = "OgretmenMailAdresi";
            this.OgretmenMailAdresi.HeaderText = "Mail Adresi";
            this.OgretmenMailAdresi.Name = "OgretmenMailAdresi";
            // 
            // OgretmenMaas
            // 
            this.OgretmenMaas.DataPropertyName = "OgretmenMaas";
            this.OgretmenMaas.HeaderText = "Maaş";
            this.OgretmenMaas.Name = "OgretmenMaas";
            // 
            // OgretmenAdres
            // 
            this.OgretmenAdres.DataPropertyName = "OgretmenAdres";
            this.OgretmenAdres.HeaderText = "Adress";
            this.OgretmenAdres.Name = "OgretmenAdres";
            // 
            // OgretmenSemt
            // 
            this.OgretmenSemt.DataPropertyName = "OgretmenSemt";
            this.OgretmenSemt.HeaderText = "Semt";
            this.OgretmenSemt.Name = "OgretmenSemt";
            // 
            // OgretmenSehir
            // 
            this.OgretmenSehir.DataPropertyName = "OgretmenSehir";
            this.OgretmenSehir.HeaderText = "Şehir";
            this.OgretmenSehir.Name = "OgretmenSehir";
            // 
            // OgretmenPostaKodu
            // 
            this.OgretmenPostaKodu.DataPropertyName = "OgretmenPostaKodu";
            this.OgretmenPostaKodu.HeaderText = "Posta Kodu";
            this.OgretmenPostaKodu.Name = "OgretmenPostaKodu";
            // 
            // txtBrans
            // 
            this.txtBrans.Enabled = false;
            this.txtBrans.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBrans.Location = new System.Drawing.Point(147, 106);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(168, 26);
            this.txtBrans.TabIndex = 0;
            // 
            // btnKayitSil
            // 
            this.btnKayitSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayitSil.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitSil.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKayitSil.Location = new System.Drawing.Point(507, 486);
            this.btnKayitSil.Name = "btnKayitSil";
            this.btnKayitSil.Size = new System.Drawing.Size(165, 39);
            this.btnKayitSil.TabIndex = 11;
            this.btnKayitSil.Text = "Kayıt Sil";
            this.btnKayitSil.UseVisualStyleBackColor = true;
            this.btnKayitSil.Click += new System.EventHandler(this.btnKayitSil_Click);
            // 
            // btnGncl
            // 
            this.btnGncl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGncl.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGncl.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGncl.Location = new System.Drawing.Point(678, 486);
            this.btnGncl.Name = "btnGncl";
            this.btnGncl.Size = new System.Drawing.Size(165, 39);
            this.btnGncl.TabIndex = 11;
            this.btnGncl.Text = "Güncelle";
            this.btnGncl.UseVisualStyleBackColor = true;
            this.btnGncl.Click += new System.EventHandler(this.btnGncl_Click);
            // 
            // txtogrtmenSehir
            // 
            this.txtogrtmenSehir.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtmenSehir.Location = new System.Drawing.Point(557, 285);
            this.txtogrtmenSehir.Name = "txtogrtmenSehir";
            this.txtogrtmenSehir.Size = new System.Drawing.Size(193, 26);
            this.txtogrtmenSehir.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(452, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 19);
            this.label10.TabIndex = 71;
            this.label10.Text = "Şehir :";
            // 
            // txtogrtmenSemt
            // 
            this.txtogrtmenSemt.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtmenSemt.Location = new System.Drawing.Point(557, 249);
            this.txtogrtmenSemt.Name = "txtogrtmenSemt";
            this.txtogrtmenSemt.Size = new System.Drawing.Size(193, 26);
            this.txtogrtmenSemt.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(452, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 19);
            this.label13.TabIndex = 69;
            this.label13.Text = "Semt :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(20, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 19);
            this.label14.TabIndex = 67;
            this.label14.Text = "Ev Telefonu :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(20, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 19);
            this.label15.TabIndex = 66;
            this.label15.Text = "Tc Kimlik No :";
            // 
            // txtogrtmenMaas
            // 
            this.txtogrtmenMaas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtmenMaas.Location = new System.Drawing.Point(557, 142);
            this.txtogrtmenMaas.Name = "txtogrtmenMaas";
            this.txtogrtmenMaas.Size = new System.Drawing.Size(193, 26);
            this.txtogrtmenMaas.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(452, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 19);
            this.label16.TabIndex = 64;
            this.label16.Text = "Maaş :";
            // 
            // txtogrtmenMail
            // 
            this.txtogrtmenMail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtmenMail.Location = new System.Drawing.Point(557, 106);
            this.txtogrtmenMail.Name = "txtogrtmenMail";
            this.txtogrtmenMail.Size = new System.Drawing.Size(193, 26);
            this.txtogrtmenMail.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(452, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 19);
            this.label17.TabIndex = 60;
            this.label17.Text = "Mail Adresi :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(452, 183);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 19);
            this.label18.TabIndex = 58;
            this.label18.Text = "Ev Adresi :";
            // 
            // txtogrtmenAdSoyad
            // 
            this.txtogrtmenAdSoyad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtmenAdSoyad.Location = new System.Drawing.Point(147, 149);
            this.txtogrtmenAdSoyad.Name = "txtogrtmenAdSoyad";
            this.txtogrtmenAdSoyad.Size = new System.Drawing.Size(168, 26);
            this.txtogrtmenAdSoyad.TabIndex = 1;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(20, 152);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 19);
            this.label19.TabIndex = 53;
            this.label19.Text = "Adı Soyadı :";
            // 
            // txtogrtmenEvAdres
            // 
            this.txtogrtmenEvAdres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtogrtmenEvAdres.Location = new System.Drawing.Point(557, 179);
            this.txtogrtmenEvAdres.Multiline = true;
            this.txtogrtmenEvAdres.Name = "txtogrtmenEvAdres";
            this.txtogrtmenEvAdres.Size = new System.Drawing.Size(265, 60);
            this.txtogrtmenEvAdres.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label20.Location = new System.Drawing.Point(20, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 19);
            this.label20.TabIndex = 49;
            this.label20.Text = "Cep Telefonu :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label21.Location = new System.Drawing.Point(20, 109);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 19);
            this.label21.TabIndex = 0;
            this.label21.Text = "Branş :";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(827, -1);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 95;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 30;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(858, -1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 25);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 94;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 30;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.groupBox1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // OgretmenBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(894, 562);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.grbOgretmenTarama);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OgretmenBilgileri";
            this.Text = "OgretmenBilgileri";
            this.Load += new System.EventHandler(this.OgretmenBilgileri_Load);
            this.grbOgretmenTarama.ResumeLayout(false);
            this.grbOgretmenTarama.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvogretmenbilgleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbOgretmenTarama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumaraTarama;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtpostakodu;
        private System.Windows.Forms.MaskedTextBox txtogrtmenEvTel;
        private System.Windows.Forms.MaskedTextBox txtogrtmenCepTel;
        private System.Windows.Forms.MaskedTextBox txtogrtmenTcKimlikNo;
        private System.Windows.Forms.DataGridView dgvogretmenbilgleri;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenID;
        private System.Windows.Forms.DataGridViewTextBoxColumn sınıflar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brans;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenTcKimlikNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenCinsiyet;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenCepTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenEvTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenMailAdresi;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenMaas;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenSemt;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenSehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgretmenPostaKodu;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.Button btnKayitSil;
        private System.Windows.Forms.Button btnGncl;
        private System.Windows.Forms.TextBox txtogrtmenSehir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtogrtmenSemt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtogrtmenMaas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtogrtmenMail;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtogrtmenAdSoyad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtogrtmenEvAdres;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOgretmenId;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
    }
}