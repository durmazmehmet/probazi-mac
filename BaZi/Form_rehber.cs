using System;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BaZi
{
    public partial class Form_rehber : Form
    {
        internal static class NativeMethods
        {
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool HideCaret(IntPtr hWnd);
            [DllImport("user32.dll")]
            [return: MarshalAs(UnmanagedType.Bool)]
            internal static extern bool ShowCaret(IntPtr hWnd);
        }

        Bazi_tool bazitool = new Bazi_tool();
        Db_tools Db = new Db_tools();
        bool formdan_gelen_kayit_bayragi = false;
        private int secilenId = 0; //BU ARKADAŞ ÖYLE ÖNEMLİ Kİ
        private int secilenSatir = 0; //BU ARKADAŞ ÖYLE ÖNEMLİ Kİ
        private DataTable baziDataTable = new DataTable();
        private TextBox[] kayitGirisSeti = new TextBox[4];
        private Label[] kayitGosterimSeti = new Label[7];
        public string[] ana_formdan_gelen_kayit;

        //---FORM BAŞLANGICINDA İŞLEMLER----------------------------------------------------------------------------------------------------------

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        public Form_rehber(params string[] yenikayit)
        {
            InitializeComponent();
            Db.Baglanti.Open();
            Db.CreateIfNotExists();
            Db.baziDataAdapter = new SQLiteDataAdapter(Db.ohSQLite, Db.Baglanti);
            Db.Baglanti.Close();
            LoadData(0);

            this.AutoValidate = AutoValidate.Disable;

            txtDogumTarihi.Format = DateTimePickerFormat.Custom;
            txtDogumTarihi.CustomFormat = "dd/MM/yyyy    HH:mm";

            rehberComponentOlustus();

            foreach (var tzi in TimeZoneInfo.GetSystemTimeZones())
            {
                txtDST.Items.Add(tzi.Id);
            }
            txtDST.Items[txtDST.Items.IndexOf("Turkey Standard Time")] = "Türkiye Saati";
            txtDST.Text = "Türkiye Saati";
            this.txtDST.DropDownStyle = ComboBoxStyle.DropDownList;
            this.txtCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            FiltreHazirla(true);
            if (yenikayit.Length > 0)
            {
                txtFiltre_ara.Text = yenikayit[0];
                txtFiltre_ara.Modified = true;
                FiltreFocusAl(txtFiltre_ara, "veriVar:)");
                FiltreData(txtFiltre_ara, yenikayit[1]);
                ana_formdan_gelen_kayit = yenikayit;
            }
        }

        //textbok ve label array
        public void rehberComponentOlustus()
        {
            kayitGosterimSeti[0] = (Label)panel2.Controls["txtAd_alt"];
            kayitGosterimSeti[1] = (Label)panel2.Controls["txtSoyad_alt"];
            kayitGosterimSeti[2] = (Label)panel2.Controls["txtDogumTarihi_alt"];
            kayitGosterimSeti[3] = (Label)panel2.Controls["txtTelefon_alt"];
            kayitGosterimSeti[4] = (Label)panel2.Controls["txtEmail_alt"];
            kayitGosterimSeti[5] = (Label)panel2.Controls["txtCinsiyet_alt"];
            kayitGosterimSeti[6] = (Label)panel2.Controls["txtDST_alt"];
            kayitGirisSeti[0] = (TextBox)panel2.Controls["txtAd"];
            kayitGirisSeti[1] = (TextBox)panel2.Controls["txtSoyad"];
            kayitGirisSeti[2] = (TextBox)panel2.Controls["txtTelefon"];
            kayitGirisSeti[3] = (TextBox)panel2.Controls["txtEmail"];
        }
        //---FORM BAŞLANGICINDA İŞLEMLER SON------------------------------------------------------------------------------------------------------

        private void LoadData(int id) //Grid'e veri yükleme, tazeleme ve sıralama ayrıca filtremeleme sonrası için
        {
            Db.baziDataSet.Reset();
            Db.baziDataAdapter.Fill(Db.baziDataSet);
            Db.baziDataSet.Tables[0].DefaultView.Sort = "ad ASC";
            baziDataTable = Db.baziDataSet.Tables[0];
            if (baziDataTable.Rows.Count == 0)
            {
                sonucYok.Text = @"Kayıt yok." + Environment.NewLine + "+Ekle ile ilk kaydı oluştur.";
                sonucYok.Visible = true;
            }
            else
            {
                sonucYok.Text = @"Sonuç Yok";
                sonucYok.Visible = false;
            }
            baziDataTable.PrimaryKey = new DataColumn[] { baziDataTable.Columns["id"] };
            Grid.DataSource = baziDataTable;
            Grid.Columns["id"].Visible =
                Grid.Columns["ad"].Visible =
                Grid.Columns["soyad"].Visible =
                Grid.Columns["soyad"].Visible =
                Grid.Columns["cinsiyet"].Visible =
                Grid.Columns["dogumtarihi"].Visible =
                Grid.Columns["telefon"].Visible =
                Grid.Columns["email"].Visible =
                Grid.Columns["DST"].Visible =
                Grid.Columns["yorum"].Visible =
                false;
            Grid.Columns["Resim"].DisplayIndex = 1;
            Grid.Columns["resim"].Width = 60;
            Grid.Columns["anasutun"].Width = 215;
            Grid.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            if (id > 0)
            {
                DataGridViewRow row = Grid.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["id"].Value.ToString().Equals(id.ToString()))
                    .First();
                if (Grid.Rows.Count > 8 && (row.Index > 8 || Grid.RowCount - row.Index < 8))
                    Grid.FirstDisplayedScrollingRowIndex = row.Index - 4;
                Grid.Update();
                Grid.Rows[row.Index].Selected = true;
            }
            if (id < 0) //secilen id belli silmeden önce yerini belli etmek için
            {
                DataGridViewRow row = Grid.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["id"].Value.ToString().Equals(secilenId.ToString()))
                    .First();
                secilenSatir = row.Index;
            }
        }

        //PANEL DÜĞMELERİ        
        //1. PANEL       
        private void Btn_RehberKapat_Click(object sender, EventArgs e) //Kapat Tuşu
        {
            this.Close();
        }
        private void Btn_Yeni_Click(object sender, EventArgs e)//Yeni tuşu 2. Paneli hazırla
        {
            KayitEyle(0);
        }
        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)//Grid tek tıkla hesaplama yap
        {
            formdan_gelen_kayit_bayragi = false;
            try
            {
                Int32.TryParse(Grid.Rows[e.RowIndex].Cells[0].Value.ToString(), out secilenId);
            }
            catch
            {
                // veri yokki
            }
            AnaFormaYukle(secilenId);
        }
        private void Grid_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)//Grid çift tıkla 2. panele geç
        {
            try
            {
                Int32.TryParse(Grid.Rows[e.RowIndex].Cells[0].Value.ToString(), out secilenId);
            }
            catch
            {
                // veri yokki
            }
            LoadData(secilenId);
            IkinciPaneliHazirla(); //2. paneli yükleme için hazırla. düzenle, hesapla ve sil butonlarını devreye al.
            IkinciPaneleYukle(); //true: sadece anaforma gönder, false: ikinci panele yükleme yap
            PanelAnimasyon(2);
        }
        //2. PANEL 
        private void TxtResim_Click(object sender, EventArgs e)//Resim işi
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Filter = "Resim Dosyası |*.jpg",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                RestoreDirectory = true,
                CheckFileExists = false,
                Title = "Resim Dosyası Seçiniz..",
                Multiselect = false
            };
            txtResim.Image = file.ShowDialog() == DialogResult.OK ? bazitool.FixedSize(Image.FromFile(file.FileName), 120, 120) : Properties.Resources.form_rehber_kisi;
        }
        // YENİ KAYIT DÜĞMELERİ
        private void KisilereGeriDon(object sender, EventArgs e)//Yeni Kayıttan Birinci Panele geri dön
        {
            SahteGercek(true);
            LoadData(secilenId);
            PanelAnimasyon(1);
            if (!string.IsNullOrWhiteSpace(txtFiltre_ara.Text))
            {
                FiltreData(txtFiltre_ara);
                txtFiltre_ara.Focus();
            }
            else
            {
                FiltreHazirla(false);
            }                
        }
        private void KayitEkle(object sender, EventArgs e) //Yeni Kayıttan kayıt ekle
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                SahteGercek(true);
                Db.VeriEkle(txtAd.Text, txtSoyad.Text, txtDogumTarihi.Text, txtCinsiyet.Text, txtTelefon.Text, txtEmail.Text, txtYorumlar.Text, txtDST.Text, bazitool.ImageToByte(txtResim.Image, ImageFormat.Jpeg));
                LoadData(0);
                SahteGercek(false);
                LoadData(Db.SonKayit());
                AnaFormaYukle(Db.SonKayit());
                IkinciPaneleYukle();
                PanelAnimasyon(1);
            }
        }
        private void KayitIptal(object sender, EventArgs e)//Yeni Kayıt işi iptal
        {
            SahteGercek(false);
            PanelAnimasyon(1);
        }
        private void Ekleden_kapat(object sender, EventArgs e)//ana formdan gelen Yeni Kayıt işi iptal
        {
            this.Close();
        }
        // KAYIT DÜZEN DÜĞMELERİ       
        private void KayitDuzen(object sender, EventArgs e) //düzenle düğmesi
        {
            KayitEyle(1);
        }
        private void KayitSil(object sender, EventArgs e) //kayıt sil düğmesi
        {
            DialogResult dialogResult = MessageBox.Show(txtAd.Text + " " + txtSoyad.Text + " isimli kaydı silmek istiyor musunuz?", "Kayıt Sil", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoadData(-1);
                //Db.VeriSil(secilenId);
                LoadData(0);
                if (Grid.RowCount - 1 < secilenSatir)
                    secilenSatir--;
                if (Grid.Rows.Count > 0)
                {
                    Int32.TryParse(Grid.Rows[secilenSatir].Cells[0].Value.ToString(), out secilenId);
                }
                else
                {
                    secilenId = 0;
                }
                AnaFormaYukle(secilenId);
                LoadData(secilenId);
                PanelAnimasyon(1);

                if (!string.IsNullOrWhiteSpace(txtFiltre_ara.Text))
                {
                    FiltreData(txtFiltre_ara);
                    txtFiltre_ara.Focus();
                }
                else
                {
                    FiltreHazirla(false);
                }
            }
            SahteGercek(false);
        }
        private void KayitGuncelle(object sender, EventArgs e)//(düzenleme) Bitti
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                Db.VeriGuncelle(secilenId, txtAd.Text, txtSoyad.Text, txtDogumTarihi.Text, txtCinsiyet.Text, txtTelefon.Text, txtEmail.Text, txtYorumlar.Text, txtDST.Text, bazitool.ImageToByte(txtResim.Image, ImageFormat.Jpeg));
                LoadData(secilenId);
                AnaFormaYukle(secilenId);
                IkinciPaneliHazirla(); //2. paneli yükleme için hazırla. düzenle, hesapla ve sil butonlarını devreye al.
                IkinciPaneleYukle(); //true: sadece anaforma gönder, false: ikinci panele yükleme yap
                SahteGercek(false);
                txtAd.Focus();
                txtAd.DeselectAll();
            }
            PanelAnimasyon(1);
        }


        //---PANEL GENEL UYGULAMALARI------------------------------------------------------------------------------------------------------------
        private void PanelAnimasyon(int sayfa)//ana forma gönder verileri gönder ve işlettir
        {
            int carpan = 0;
            if (sayfa == 1)
            {
                panel2.Location = new Point(0, 0);
                panel1.Location = new Point(-300, 0);
                carpan = 1;
            }
            if (sayfa == 2)
            {
                carpan = -1;
                panel2.Location = new Point(300, 0);
                panel1.Location = new Point(0, 0);
            }
            panel1.Location = new Point(panel1.Location.X + 300 * carpan, panel1.Location.Y);
            panel2.Location = new Point(panel2.Location.X + 300 * carpan, panel2.Location.Y);
        }
        private void AnaFormaYukle(int secilenId)//Verilerle anaformu doldur ve hesaplama yap)
        {
            if (secilenId == 0)
            {
                ((Form_main)this.Owner).RehberIsimAl = "Ad Soyad";
                ((Form_main)this.Owner).RehberTarihAl = DateTime.Now.ToString();
                ((Form_main)this.Owner).RehberBayAl = false;
                ((Form_main)this.Owner).RehberBayanAl = true;
                ((Form_main)this.Owner).RehberDSTAl = "Türkiye Saati";
            }
            if (secilenId != 0 && formdan_gelen_kayit_bayragi == false)
            {
                DataRow Drw = baziDataTable.Rows.Find(secilenId);
                ((Form_main)this.Owner).RehberIsimAl = Drw["ad"].ToString() + " " + Drw["soyad"].ToString();
                ((Form_main)this.Owner).RehberTarihAl = Drw["dogumtarihi"].ToString();
                ((Form_main)this.Owner).RehberBayAl = Drw["cinsiyet"].ToString() == "Bay" ? true : false;
                ((Form_main)this.Owner).RehberBayanAl = Drw["cinsiyet"].ToString() == "Bayan" ? true : false;
                ((Form_main)this.Owner).RehberDSTAl = Drw["DST"] == DBNull.Value ? "Türkiye Saati" : Drw["DST"].ToString();
            }
            ((Form_main)this.Owner).Hesapla();
        }
        private void BtnSıfırla(EventHandler btn0, EventHandler btn1, params string[] btntxt) //düğmeleri sıfırla
        {
            btn_Sol.Click -= new EventHandler(KayitSil);
            btn_Sol.Click -= new EventHandler(KayitIptal);
            btn_Sol.Click -= new EventHandler(KisilereGeriDon);
            btn_Sag.Click -= new EventHandler(KayitDuzen);
            btn_Sag.Click -= new EventHandler(KayitGuncelle);
            btn_Sag.Click -= new EventHandler(KayitEkle);

            btn_Sol.Click += btn0;
            btn_Sol.Text = btntxt[0];

            btn_Sag.Click += btn1;
            btn_Sag.Text = btntxt[1];
        }
        private void SahteGercek(bool mode) //true asıl olanları göster, //false yalan olanları
        {
            for (int i = 0; i < 4; i++)
                kayitGirisSeti[i].Visible = mode;
            txtDogumTarihi.Visible = mode;
            txtCinsiyet.Visible = mode;
            txtDST.Visible = mode;
            txtYorumlar.ReadOnly = !mode;
            txtResim.Enabled = mode;
            for (int i = 0; i < 7; i++)
                kayitGosterimSeti[i].Visible = !mode;
        }
        public void KayitEyle(int mode)//İkinci Panel  Düzenleme/yeni kayıt için hazırla (0: yeni kayit; 1: düzenle)
        {
            SahteGercek(true);
            All_txt_event_temizlik();

            for (int i = 0; i < 2; i++)
            {
                kayitGirisSeti[i].LostFocus += new EventHandler(All_txt_lostFocus);
                kayitGirisSeti[i].Validating += new CancelEventHandler(All_txt_Validating);
            }

            if (mode == 1)
            {
                this.Text = "Kişi Düzenle";
                BtnSıfırla(new EventHandler(KayitSil), new EventHandler(KayitGuncelle), "✖ Sil", "✔ Bitti");
                for (int i = 0; i < 4; i++)
                    kayitGirisSeti[i].GotFocus += new EventHandler(All_edit_txt_gotFocus);
                txtAd.Focus();
            }

            if (mode == 0)
            {
                this.Text = "Kişi Ekle";
                for (int i = 0; i < 4; i++)
                    kayitGirisSeti[i].GotFocus += new EventHandler(All_new_txt_gotFocus);

                BtnSıfırla(new EventHandler(KayitIptal), new EventHandler(KayitEkle), "✖ İptal", "✔ Bitti");

                int freshStart = 0;
                txtYorumlar.Clear();
                txtCinsiyet.Text = txtCinsiyet.Tag.ToString();
                txtDogumTarihi.Value = DateTime.Now;
                txtResim.Image = Properties.Resources.form_rehber_kisi;

                if (Grid.RowCount == 0 && !string.IsNullOrEmpty(txtFiltre_ara.Text) && !string.IsNullOrWhiteSpace(txtFiltre_ara.Text))
                {
                    string yenikayit_ad = string.Empty;
                    string yenikayit_soyad = string.Empty;
                    string[] ad_soyad = ana_formdan_gelen_kayit[0].Split(' ');
                    if (ad_soyad.Length >= 2)
                    {
                        for (int i = 0; i < ad_soyad.Length - 1; i++)
                            yenikayit_ad = yenikayit_ad + " " + ad_soyad[i];
                        yenikayit_ad = bazitool.IlkHarfBuyuk(yenikayit_ad.TrimStart().TrimEnd());
                        yenikayit_soyad = bazitool.IlkHarfBuyuk(ad_soyad[ad_soyad.Length - 1].TrimStart().TrimEnd());
                    }
                    else
                    {
                        yenikayit_ad = ad_soyad[0].TrimStart().TrimEnd();
                    }
                    txtAd.Text = yenikayit_ad;
                    txtSoyad.Text = yenikayit_soyad;
                    txtDogumTarihi.Text = ana_formdan_gelen_kayit[1];
                    txtCinsiyet.Text = ana_formdan_gelen_kayit[2];
                    txtDST.Text = ana_formdan_gelen_kayit[3];
                    freshStart = 4;
                }
                for (int i = freshStart; i < 4; i++)
                {
                    kayitGirisSeti[i].Clear();
                    kayitGirisSeti[i].ForeColor = Color.DarkGray;
                    kayitGirisSeti[i].BackColor = Color.White;
                    kayitGirisSeti[i].Text = kayitGirisSeti[i].Tag.ToString();
                    kayitGirisSeti[i].Font = new Font(new FontFamily("Arial"), 9.0f, FontStyle.Italic);
                }
                PanelAnimasyon(2);
                if (freshStart == 1)
                {
                    kayitGirisSeti[freshStart].Focus();
                }                    
                else
                {
                    txtDogumTarihi.Focus();
                }
            }
        }
        private void IkinciPaneleYukle()
        {
            SahteGercek(false);
            DataRow Drw = baziDataTable.Rows.Find(secilenId);
            if (secilenId != 0)
            {
                txtAd.Text = txtAd_alt.Text = Drw["ad"].ToString();
                txtSoyad.Text = txtSoyad_alt.Text = Drw["soyad"].ToString();
                txtDogumTarihi.Text = txtDogumTarihi_alt.Text = Drw["dogumtarihi"].ToString();
                txtCinsiyet.Text = txtCinsiyet_alt.Text = Drw["cinsiyet"].ToString();
                txtTelefon.Text = txtTelefon_alt.Text = Drw["telefon"].ToString();
                txtEmail.Text = txtEmail_alt.Text = Drw["email"].ToString();
                txtYorumlar.Text = Drw["yorum"] != DBNull.Value ? Drw["yorum"].ToString() : "Bu kişi ile ilgili not mevcut değil eğer isterseniz Düzenle düğmesine basıp yorum girişi yapabilirsiniz...";
                txtResim.Image = Drw["resim"] != DBNull.Value ? bazitool.ByteToImage((byte[])Drw["resim"]) : Properties.Resources.form_rehber_kisi;
                txtDST.Text = txtDST_alt.Text = Drw["DST"] == DBNull.Value ? "Türkiye Saati" : Drw["DST"].ToString();
            }
        } // ikinci panele yükleme yap       
        private void IkinciPaneliHazirla()//grid çift click ile gelen ve düzenleme yapılmayan kart hali
        {
            SahteGercek(false);
            this.Text = "Kişi İncele";
            BtnSıfırla(new EventHandler(KisilereGeriDon), new EventHandler(KayitDuzen), "< Kişiler", "Düzenle");
            txtResim.Enabled = false;
            for (int i = 0; i < 4; i++)
            {
                kayitGirisSeti[i].ForeColor = Color.Black;
                kayitGirisSeti[i].BackColor = Color.White;
                kayitGirisSeti[i].Font = new Font(new FontFamily("Arial"), 9.0f, FontStyle.Regular);
                kayitGirisSeti[i].Text = string.Empty;
            }
            txtYorumlar.BackColor = Color.White;
            txtYorumlar.ForeColor = Color.Black;
            txtYorumlar.Font = new Font(new FontFamily("Arial"), 9.0f, FontStyle.Regular);
        }
        private void All_new_txt_gotFocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.ToLower() == ((TextBox)sender).Tag.ToString().ToLower())
            {
                ((TextBox)sender).Clear();
                ((TextBox)sender).Font = new Font(new FontFamily("Arial"), 9.0f, FontStyle.Regular);
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }
        private void All_edit_txt_gotFocus(object sender, EventArgs e)
        {
            ((TextBox)sender).SelectAll();
        }
        private void All_txt_lostFocus(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(((TextBox)sender).Text) || ((TextBox)sender).Text.ToLower() != ((TextBox)sender).Tag.ToString().ToLower())
                ((TextBox)sender).Text = bazitool.IlkHarfBuyuk(((TextBox)sender).Text);
        }
        private void All_txt_Validating(object sender, CancelEventArgs e)
        {
            if (((TextBox)sender).Text.ToLower() == ((TextBox)sender).Tag.ToString().ToLower() || ((TextBox)sender).Text == string.Empty)
            {
                ((TextBox)sender).ForeColor = Color.Red;
                if (((TextBox)sender).Text == string.Empty)
                {
                    ((TextBox)sender).Text = ((TextBox)sender).Tag.ToString();
                }
                ((TextBox)sender).Font = new Font(new FontFamily("Arial"), 9.0f, FontStyle.Italic);
                e.Cancel = true;
            }
            else
            {
                ((TextBox)sender).Font = new Font(new FontFamily("Arial"), 9.0f, FontStyle.Regular);
                ((TextBox)sender).ForeColor = Color.Black;
                e.Cancel = false;
            }
        }
        private void All_txt_event_temizlik()
        {
            for (int i = 0; i < 4; i++)
            {
                kayitGirisSeti[i].GotFocus -= new EventHandler(All_new_txt_gotFocus);
                kayitGirisSeti[i].GotFocus -= new EventHandler(All_edit_txt_gotFocus);
                kayitGirisSeti[i].Validating -= new CancelEventHandler(All_txt_Validating);
                kayitGirisSeti[i].LostFocus -= new EventHandler(All_txt_lostFocus);
            }
        }

        //Filtre maharetleri
        private void FiltreHazirla(bool mode) //true: tam hazırlık false: lost focus w/o text topralanması
        {
            if (mode)
            {
                txtFiltre_ara.LostFocus += new EventHandler(FiltreLostFocus);
                txtFiltre_ara.GotFocus += new EventHandler(FiltreGotFocus);
                txtFiltre_ara.TextChanged += new EventHandler(FiltreTextChange);
                txtFiltre_buyutec.Click += new EventHandler(FiltreGiris);
                txtFiltre_txt.Click += new EventHandler(FiltreGiris);
                txtFiltre_temizle.Click += new EventHandler(FiltreTemizle);
            }
            txtFiltre_ara.Location = new Point(8, 40);
            txtFiltre_ara.Width = 282;
            txtFiltre_buyutec.Location = new Point(126, 39);
            txtFiltre_txt.Location = new Point(149, 40);
            txtFiltre_temizle.Visible = false;
            txtFiltre_txt.Visible = true;
            NativeMethods.HideCaret(txtFiltre_ara.Handle);
        }
        private void FiltreLostFocus(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(((TextBox)sender).Text)) && !(((TextBox)sender).Modified))
                FiltreHazirla(false);
        }
        private void FiltreGotFocus(object sender, EventArgs e)
        {
            FiltreFocusAl((TextBox)sender);
        }

        private void FiltreFocusAl(TextBox filtreAra, params string[] veriVar)
        {
            if ((string.IsNullOrEmpty(filtreAra.Text)) && !(filtreAra.Modified) || veriVar.Length > 0)
            {
                filtreAra.Width = 240;
                filtreAra.Location = new Point(28, 40);
                txtFiltre_buyutec.Location = new Point(9, 39);
                txtFiltre_txt.Location = new Point(30, 40);
                NativeMethods.ShowCaret(filtreAra.Handle);
            }
        }

        private void FiltreTextChange(object sender, EventArgs e)
        {
            FiltreData((TextBox)sender);
        }
        private void FiltreData(TextBox filtretext, params string[] extra)
        {
            if (!string.IsNullOrWhiteSpace(filtretext.Text))
            {
                filtretext.Modified = true;
                txtFiltre_txt.Visible = false;
                txtFiltre_temizle.Visible = true;
                NativeMethods.ShowCaret(filtretext.Handle);

                Grid.DataSource = Db.RehberFiltre(filtretext, baziDataTable, extra);
                Grid.Refresh();
                sonucYok.Visible = Grid.Rows.Count == 0 ? true : false;
            }
            else
            {
                filtretext.Modified = false;
                txtFiltre_txt.Visible = true;
                txtFiltre_temizle.Visible = false;
                NativeMethods.ShowCaret(filtretext.Handle);
            }
        }
        private void FiltreGiris(object sender, EventArgs e)
        {
            txtFiltre_ara.Focus();
        }
        private void FiltreTemizle(object sender, EventArgs e)
        {
            NativeMethods.HideCaret(txtFiltre_ara.Handle);
            txtFiltre_ara.Clear();
            LoadData(0);
            Grid.Refresh();
        }
    }
}
