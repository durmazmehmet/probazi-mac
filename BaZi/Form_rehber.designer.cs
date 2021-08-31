namespace BaZi
{
    partial class Form_rehber
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_rehber));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtDST_alt = new System.Windows.Forms.Label();
            this.txtCinsiyet_alt = new System.Windows.Forms.Label();
            this.txtEmail_alt = new System.Windows.Forms.Label();
            this.txtTelefon_alt = new System.Windows.Forms.Label();
            this.txtDogumTarihi_alt = new System.Windows.Forms.Label();
            this.txtSoyad_alt = new System.Windows.Forms.Label();
            this.txtAd_alt = new System.Windows.Forms.Label();
            this.txtCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtDST = new System.Windows.Forms.ComboBox();
            this.txtResim = new System.Windows.Forms.PictureBox();
            this.txtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtYorumlar = new System.Windows.Forms.RichTextBox();
            this.btn_Sag = new System.Windows.Forms.Button();
            this.btn_Sol = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiltre_txt = new System.Windows.Forms.Label();
            this.sonucYok = new System.Windows.Forms.TextBox();
            this.txtFiltre_temizle = new System.Windows.Forms.Label();
            this.txtFiltre_buyutec = new System.Windows.Forms.PictureBox();
            this.txtFiltre_ara = new System.Windows.Forms.TextBox();
            this.btn_RehberKapat = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.btn_Yeni = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResim)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltre_buyutec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtAd
            // 
            this.txtAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAd.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAd.ForeColor = System.Drawing.Color.Black;
            this.txtAd.Location = new System.Drawing.Point(127, 36);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(169, 15);
            this.txtAd.TabIndex = 1;
            this.txtAd.Tag = "Ad (zorunlu alan)";
            this.txtAd.Text = "Ad (zorunlu alan)";
            // 
            // txtSoyad
            // 
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtSoyad.ForeColor = System.Drawing.Color.Black;
            this.txtSoyad.Location = new System.Drawing.Point(127, 61);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(169, 15);
            this.txtSoyad.TabIndex = 2;
            this.txtSoyad.Tag = "Soyad (zorunlu alan)";
            this.txtSoyad.Text = "Soyad (zorunlu alan)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::BaZi.Properties.Resources.form_rehber_panel2;
            this.panel2.Controls.Add(this.txtDST_alt);
            this.panel2.Controls.Add(this.txtCinsiyet_alt);
            this.panel2.Controls.Add(this.txtEmail_alt);
            this.panel2.Controls.Add(this.txtTelefon_alt);
            this.panel2.Controls.Add(this.txtDogumTarihi_alt);
            this.panel2.Controls.Add(this.txtSoyad_alt);
            this.panel2.Controls.Add(this.txtAd_alt);
            this.panel2.Controls.Add(this.txtCinsiyet);
            this.panel2.Controls.Add(this.txtDST);
            this.panel2.Controls.Add(this.txtAd);
            this.panel2.Controls.Add(this.txtResim);
            this.panel2.Controls.Add(this.txtSoyad);
            this.panel2.Controls.Add(this.txtDogumTarihi);
            this.panel2.Controls.Add(this.txtTelefon);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtYorumlar);
            this.panel2.Controls.Add(this.btn_Sag);
            this.panel2.Controls.Add(this.btn_Sol);
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 541);
            this.panel2.TabIndex = 244;
            // 
            // txtDST_alt
            // 
            this.txtDST_alt.AutoSize = true;
            this.txtDST_alt.CausesValidation = false;
            this.txtDST_alt.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtDST_alt.Location = new System.Drawing.Point(125, 160);
            this.txtDST_alt.Name = "txtDST_alt";
            this.txtDST_alt.Size = new System.Drawing.Size(42, 16);
            this.txtDST_alt.TabIndex = 249;
            this.txtDST_alt.Text = "label6";
            // 
            // txtCinsiyet_alt
            // 
            this.txtCinsiyet_alt.AutoSize = true;
            this.txtCinsiyet_alt.CausesValidation = false;
            this.txtCinsiyet_alt.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtCinsiyet_alt.Location = new System.Drawing.Point(5, 160);
            this.txtCinsiyet_alt.Name = "txtCinsiyet_alt";
            this.txtCinsiyet_alt.Size = new System.Drawing.Size(42, 16);
            this.txtCinsiyet_alt.TabIndex = 248;
            this.txtCinsiyet_alt.Text = "label5";
            // 
            // txtEmail_alt
            // 
            this.txtEmail_alt.AutoSize = true;
            this.txtEmail_alt.CausesValidation = false;
            this.txtEmail_alt.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtEmail_alt.Location = new System.Drawing.Point(124, 132);
            this.txtEmail_alt.Name = "txtEmail_alt";
            this.txtEmail_alt.Size = new System.Drawing.Size(42, 16);
            this.txtEmail_alt.TabIndex = 247;
            this.txtEmail_alt.Text = "label4";
            // 
            // txtTelefon_alt
            // 
            this.txtTelefon_alt.AutoSize = true;
            this.txtTelefon_alt.CausesValidation = false;
            this.txtTelefon_alt.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtTelefon_alt.Location = new System.Drawing.Point(124, 108);
            this.txtTelefon_alt.Name = "txtTelefon_alt";
            this.txtTelefon_alt.Size = new System.Drawing.Size(42, 16);
            this.txtTelefon_alt.TabIndex = 246;
            this.txtTelefon_alt.Text = "label3";
            // 
            // txtDogumTarihi_alt
            // 
            this.txtDogumTarihi_alt.AutoSize = true;
            this.txtDogumTarihi_alt.CausesValidation = false;
            this.txtDogumTarihi_alt.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtDogumTarihi_alt.Location = new System.Drawing.Point(124, 84);
            this.txtDogumTarihi_alt.Name = "txtDogumTarihi_alt";
            this.txtDogumTarihi_alt.Size = new System.Drawing.Size(42, 16);
            this.txtDogumTarihi_alt.TabIndex = 245;
            this.txtDogumTarihi_alt.Text = "label2";
            // 
            // txtSoyad_alt
            // 
            this.txtSoyad_alt.AutoSize = true;
            this.txtSoyad_alt.CausesValidation = false;
            this.txtSoyad_alt.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtSoyad_alt.Location = new System.Drawing.Point(124, 61);
            this.txtSoyad_alt.Name = "txtSoyad_alt";
            this.txtSoyad_alt.Size = new System.Drawing.Size(42, 16);
            this.txtSoyad_alt.TabIndex = 244;
            this.txtSoyad_alt.Text = "label1";
            // 
            // txtAd_alt
            // 
            this.txtAd_alt.AutoSize = true;
            this.txtAd_alt.CausesValidation = false;
            this.txtAd_alt.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtAd_alt.Location = new System.Drawing.Point(124, 36);
            this.txtAd_alt.Name = "txtAd_alt";
            this.txtAd_alt.Size = new System.Drawing.Size(42, 16);
            this.txtAd_alt.TabIndex = 243;
            this.txtAd_alt.Text = "label1";
            // 
            // txtCinsiyet
            // 
            this.txtCinsiyet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCinsiyet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtCinsiyet.BackColor = System.Drawing.Color.White;
            this.txtCinsiyet.CausesValidation = false;
            this.txtCinsiyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCinsiyet.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtCinsiyet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCinsiyet.FormattingEnabled = true;
            this.txtCinsiyet.Items.AddRange(new object[] {
            "Bay",
            "Bayan"});
            this.txtCinsiyet.Location = new System.Drawing.Point(4, 156);
            this.txtCinsiyet.Name = "txtCinsiyet";
            this.txtCinsiyet.Size = new System.Drawing.Size(118, 24);
            this.txtCinsiyet.TabIndex = 242;
            this.txtCinsiyet.Tag = "Bay";
            this.txtCinsiyet.Text = "Bay";
            // 
            // txtDST
            // 
            this.txtDST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtDST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtDST.BackColor = System.Drawing.Color.White;
            this.txtDST.CausesValidation = false;
            this.txtDST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtDST.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtDST.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDST.FormattingEnabled = true;
            this.txtDST.Location = new System.Drawing.Point(124, 156);
            this.txtDST.Name = "txtDST";
            this.txtDST.Size = new System.Drawing.Size(173, 24);
            this.txtDST.TabIndex = 241;
            this.txtDST.Text = "Türkiye Saati";
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(2, 35);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(120, 118);
            this.txtResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtResim.TabIndex = 240;
            this.txtResim.TabStop = false;
            this.txtResim.Click += new System.EventHandler(this.TxtResim_Click);
            // 
            // txtDogumTarihi
            // 
            this.txtDogumTarihi.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.txtDogumTarihi.CausesValidation = false;
            this.txtDogumTarihi.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtDogumTarihi.Location = new System.Drawing.Point(125, 81);
            this.txtDogumTarihi.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.txtDogumTarihi.Name = "txtDogumTarihi";
            this.txtDogumTarihi.Size = new System.Drawing.Size(173, 22);
            this.txtDogumTarihi.TabIndex = 3;
            this.txtDogumTarihi.TabStop = false;
            this.txtDogumTarihi.Value = new System.DateTime(1983, 1, 1, 0, 0, 0, 0);
            // 
            // txtTelefon
            // 
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefon.CausesValidation = false;
            this.txtTelefon.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtTelefon.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtTelefon.Location = new System.Drawing.Point(127, 108);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(169, 15);
            this.txtTelefon.TabIndex = 4;
            this.txtTelefon.Tag = "Telefon";
            this.txtTelefon.Text = "Telefon";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.CausesValidation = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9.5F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtEmail.Location = new System.Drawing.Point(127, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(169, 15);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Tag = "E-Posta";
            this.txtEmail.Text = "E-Posta";
            // 
            // txtYorumlar
            // 
            this.txtYorumlar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYorumlar.CausesValidation = false;
            this.txtYorumlar.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtYorumlar.ForeColor = System.Drawing.Color.CadetBlue;
            this.txtYorumlar.Location = new System.Drawing.Point(2, 215);
            this.txtYorumlar.Name = "txtYorumlar";
            this.txtYorumlar.Size = new System.Drawing.Size(296, 324);
            this.txtYorumlar.TabIndex = 7;
            this.txtYorumlar.Tag = "Yorumlar";
            this.txtYorumlar.Text = "Yorumlar";
            // 
            // btn_Sag
            // 
            this.btn_Sag.AllowDrop = true;
            this.btn_Sag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Sag.CausesValidation = false;
            this.btn_Sag.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Sag.ForeColor = System.Drawing.Color.White;
            this.btn_Sag.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Sag.Location = new System.Drawing.Point(236, 4);
            this.btn_Sag.Name = "btn_Sag";
            this.btn_Sag.Size = new System.Drawing.Size(60, 26);
            this.btn_Sag.TabIndex = 8;
            this.btn_Sag.Text = "x";
            this.btn_Sag.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sag.UseVisualStyleBackColor = false;
            // 
            // btn_Sol
            // 
            this.btn_Sol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Sol.CausesValidation = false;
            this.btn_Sol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Sol.ForeColor = System.Drawing.Color.White;
            this.btn_Sol.Location = new System.Drawing.Point(4, 4);
            this.btn_Sol.Name = "btn_Sol";
            this.btn_Sol.Size = new System.Drawing.Size(60, 26);
            this.btn_Sol.TabIndex = 10;
            this.btn_Sol.Text = "Sil_İptal_Geri";
            this.btn_Sol.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::BaZi.Properties.Resources.form_rehber_panel1;
            this.panel1.Controls.Add(this.txtFiltre_txt);
            this.panel1.Controls.Add(this.sonucYok);
            this.panel1.Controls.Add(this.txtFiltre_temizle);
            this.panel1.Controls.Add(this.txtFiltre_buyutec);
            this.panel1.Controls.Add(this.txtFiltre_ara);
            this.panel1.Controls.Add(this.btn_RehberKapat);
            this.panel1.Controls.Add(this.Grid);
            this.panel1.Controls.Add(this.btn_Yeni);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 541);
            this.panel1.TabIndex = 243;
            // 
            // txtFiltre_txt
            // 
            this.txtFiltre_txt.AutoSize = true;
            this.txtFiltre_txt.BackColor = System.Drawing.Color.Transparent;
            this.txtFiltre_txt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.txtFiltre_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiltre_txt.ForeColor = System.Drawing.Color.DarkGray;
            this.txtFiltre_txt.Location = new System.Drawing.Point(149, 40);
            this.txtFiltre_txt.Name = "txtFiltre_txt";
            this.txtFiltre_txt.Size = new System.Drawing.Size(25, 15);
            this.txtFiltre_txt.TabIndex = 250;
            this.txtFiltre_txt.Text = "Ara";
            // 
            // sonucYok
            // 
            this.sonucYok.BackColor = System.Drawing.Color.White;
            this.sonucYok.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sonucYok.Enabled = false;
            this.sonucYok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonucYok.ForeColor = System.Drawing.Color.DarkGray;
            this.sonucYok.Location = new System.Drawing.Point(3, 288);
            this.sonucYok.Multiline = true;
            this.sonucYok.Name = "sonucYok";
            this.sonucYok.Size = new System.Drawing.Size(292, 48);
            this.sonucYok.TabIndex = 249;
            this.sonucYok.Text = "Sonuç Yok";
            this.sonucYok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiltre_temizle
            // 
            this.txtFiltre_temizle.AutoSize = true;
            this.txtFiltre_temizle.CausesValidation = false;
            this.txtFiltre_temizle.Location = new System.Drawing.Point(271, 41);
            this.txtFiltre_temizle.Name = "txtFiltre_temizle";
            this.txtFiltre_temizle.Size = new System.Drawing.Size(16, 13);
            this.txtFiltre_temizle.TabIndex = 248;
            this.txtFiltre_temizle.Text = "✖";
            this.txtFiltre_temizle.Visible = false;
            // 
            // txtFiltre_buyutec
            // 
            this.txtFiltre_buyutec.Image = global::BaZi.Properties.Resources.form_rehber_ara;
            this.txtFiltre_buyutec.Location = new System.Drawing.Point(126, 39);
            this.txtFiltre_buyutec.Name = "txtFiltre_buyutec";
            this.txtFiltre_buyutec.Size = new System.Drawing.Size(17, 17);
            this.txtFiltre_buyutec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txtFiltre_buyutec.TabIndex = 243;
            this.txtFiltre_buyutec.TabStop = false;
            // 
            // txtFiltre_ara
            // 
            this.txtFiltre_ara.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFiltre_ara.CausesValidation = false;
            this.txtFiltre_ara.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFiltre_ara.Location = new System.Drawing.Point(8, 40);
            this.txtFiltre_ara.Margin = new System.Windows.Forms.Padding(0);
            this.txtFiltre_ara.MaxLength = 30;
            this.txtFiltre_ara.Name = "txtFiltre_ara";
            this.txtFiltre_ara.Size = new System.Drawing.Size(282, 16);
            this.txtFiltre_ara.TabIndex = 242;
            // 
            // btn_RehberKapat
            // 
            this.btn_RehberKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_RehberKapat.CausesValidation = false;
            this.btn_RehberKapat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_RehberKapat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_RehberKapat.ForeColor = System.Drawing.Color.White;
            this.btn_RehberKapat.Location = new System.Drawing.Point(4, 4);
            this.btn_RehberKapat.Name = "btn_RehberKapat";
            this.btn_RehberKapat.Size = new System.Drawing.Size(60, 26);
            this.btn_RehberKapat.TabIndex = 245;
            this.btn_RehberKapat.Text = "Kapat";
            this.btn_RehberKapat.UseVisualStyleBackColor = false;
            this.btn_RehberKapat.Click += new System.EventHandler(this.Btn_RehberKapat_Click);
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.AllowUserToResizeColumns = false;
            this.Grid.AllowUserToResizeRows = false;
            this.Grid.BackgroundColor = System.Drawing.Color.White;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid.CausesValidation = false;
            this.Grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.Grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid.GridColor = System.Drawing.SystemColors.Window;
            this.Grid.Location = new System.Drawing.Point(2, 62);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Grid.RowHeadersVisible = false;
            this.Grid.RowTemplate.Height = 60;
            this.Grid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(295, 476);
            this.Grid.TabIndex = 241;
            this.Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_CellClick);
            this.Grid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_CellMouseDoubleClick);
            // 
            // btn_Yeni
            // 
            this.btn_Yeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Yeni.CausesValidation = false;
            this.btn_Yeni.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Yeni.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Yeni.ForeColor = System.Drawing.Color.White;
            this.btn_Yeni.Location = new System.Drawing.Point(236, 4);
            this.btn_Yeni.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Yeni.Name = "btn_Yeni";
            this.btn_Yeni.Size = new System.Drawing.Size(60, 26);
            this.btn_Yeni.TabIndex = 246;
            this.btn_Yeni.Text = "+ Ekle";
            this.btn_Yeni.UseVisualStyleBackColor = false;
            this.btn_Yeni.Click += new System.EventHandler(this.Btn_Yeni_Click);
            // 
            // Form_rehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(597, 470);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_rehber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Kişiler";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResim)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiltre_buyutec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Sol;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.DateTimePicker txtDogumTarihi;
        private System.Windows.Forms.PictureBox txtResim;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFiltre_ara;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox txtFiltre_buyutec;
        private System.Windows.Forms.Button btn_RehberKapat;
        private System.Windows.Forms.Button btn_Yeni;
        private System.Windows.Forms.RichTextBox txtYorumlar;
        private System.Windows.Forms.Button btn_Sag;
        private System.Windows.Forms.ComboBox txtDST;
        private System.Windows.Forms.ComboBox txtCinsiyet;
        private System.Windows.Forms.Label txtFiltre_temizle;
        private System.Windows.Forms.Label txtAd_alt;
        private System.Windows.Forms.Label txtDST_alt;
        private System.Windows.Forms.Label txtCinsiyet_alt;
        private System.Windows.Forms.Label txtEmail_alt;
        private System.Windows.Forms.Label txtTelefon_alt;
        private System.Windows.Forms.Label txtDogumTarihi_alt;
        private System.Windows.Forms.Label txtSoyad_alt;
        private System.Windows.Forms.TextBox sonucYok;
        private System.Windows.Forms.Label txtFiltre_txt;
    }
}

