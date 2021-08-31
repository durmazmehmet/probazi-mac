using BaZi.Properties;
using IronPdf;
using System;
using System.Collections;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Resources;
using System.Windows.Forms;
//using System.Runtime.InteropServices;

/* changeLog
2.8
DST Türkiye için ince ayarı

2.6 DST Türkiye için ince ayarı
2.5 - 26.02.2016
- lisanssız yazılımda seçenekler açık kalacak
2.4 
- ad soyad girişi kullanım kolaylığı
- resim olarak kayıt
2.7
- çakışma renklerini tonlandır
- şans yıldızlarına çince simge
- gizli elementler ***
- kader çizelgesine de çakışma ekle ***
*/
namespace BaZi
{
    public partial class Form_main : Form
    {
        //Classlardan türet
        FingerPrint fgr = new FingerPrint();
        Bazi_tool tools = new Bazi_tool();
        Db_tools db = new Db_tools();
        DataTable baziDataTable = new DataTable();
        Varibles src = new Varibles();

        //Hesaplama değişkenleri
        string dil = "tr";
        ResourceManager kaynak = Resources.ResourceManager;
        string[,] DS = new string[2, 4]; //0:ele, 1:burc - 0:saat, 1:gün, 2:ay, 3:yil
        string[,] SD = new string[2, 8]; //0:ele, 1:burc | 0-7 periyot
        ArrayList zamanBolge = new ArrayList();
        int[] gl_Yy = new int[8];
        double LP = 0;
        bool runOnce = true;

        //Komponentler
        RadioButton[] DSHeader = new RadioButton[4];
        PictureBox[,] DSHolder = new PictureBox[2, 4];
        Label[] GSHolder = new Label[4];
        Label[] SDHeader = new Label[8];
        PictureBox[,] SDHolder = new PictureBox[2, 8]; //Büyük Hayat Döngüsü (element,burc), sutun 8
        Label[,,] KC = new Label[3, 8, 10]; //Yılların Döngüsü (element,burc,yil), sutun 8 sekme, satır 10 yıl = toplam 80 yıl        

        //Analiz
        string secKader;
        int SecIndx = 0;
        int secUyum = 3; //0: renksiz 1: sadece uyum 2: sadece zitlik 3: hepsi 
        int secEleBurc = 3; //0: gösterme 1: sadece elementler 2: burclar 3: hepsi
        string[] analizSecenekleri = new string[]
        {
            "--- Analiz Yok ---", //0
            "Gök / Yer Hanesi İkili", //1
            "Gök / Yer Hanesi - Şans Dönemi İkili", //2
            "Gök / Yer Hanesi - Yıllar İkili", //3
            "Yer Hanesi Üçlü Analiz", //4
            "Yer Hanesi - Şans Dönemi Üçlü", //5
            "Yer Hanesi - Yıllar Üçlü", //6
            "Yer Hanesi - Şans Dönemi - Yıllar Üçlü", //7
            "Kendine Ceza", //8
        };

        //Switchler
        bool isSaat, isYildiz, isBirth, isUTC, isDST;
        bool isStart = true;
        bool overHesap = true;

        //Güvenlik Parametreleri
        bool isElleriSev = false;
        FileInfo fileInfo = new FileInfo(Environment.GetFolderPath(System.Environment.SpecialFolder.Windows) + @"\bootstat.dat");

        // Ana fonksiyonlar   //analiz_Status
        public Form_main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Left = 10;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            ComponentOlustur();
            // bitti
            Guvenlik();
            IsElleriSevCheck();
            IsSaatCheck();
            IsYildizCheck();
            // bitti
            dateTimePicker1.Value = (DateTime.Compare(DateTime.Now, fileInfo.LastWriteTime) < 0) ? fileInfo.LastWriteTime : dateTimePicker1.Value;
            dateTimePicker1.Refresh();
            Panel_kaderSutun.Enabled = false;
            Hesapla();
            anamenu.Show();
            isStart = false;
        }
        private void Guvenlik()
        {
            dynamicButton.Click -= new EventHandler(SHesapla);
            manu_about.Click -= new EventHandler(Frm3Run);
            btn_yazdir.Click -= new EventHandler(Belge_kaydet);
            menu_Rehber.Click -= new EventHandler(FrmRehberRun);
            dynamicButton.Click += new EventHandler(Frm2Run);
            manu_about.Click += new EventHandler(Frm2Run);
            btn_yazdir.Click += new EventHandler(Frm2Run);
            menu_Rehber.Click += new EventHandler(Frm2Run);
            string heyValue = fgr.Value(fgr.Aktivasyon()).Substring(0, 24);
            if (tools.CheckREG("Serial", heyValue))
            {
                dynamicButton.Click -= new EventHandler(Frm2Run);
                manu_about.Click -= new EventHandler(Frm2Run);
                btn_yazdir.Click -= new EventHandler(Frm2Run);
                menu_Rehber.Click -= new EventHandler(Frm2Run);
                dynamicButton.Click += new EventHandler(SHesapla);
                manu_about.Click += new EventHandler(Frm3Run);
                btn_yazdir.Click += new EventHandler(Belge_kaydet);
                menu_Rehber.Click += new EventHandler(FrmRehberRun);
                isElleriSev = true;
                this.Text = "Profesyonel BaZi Hesaplayıcı 3.1 - Lisanslı Yazılım: " + heyValue;
                dynamicButton.Visible = true;
            }
            if (isStart)
            {
                isSaat = saatSwitch.Checked = tools.CheckREG("isSaat", "True") ? true : false;
                isYildiz = starSwitch.Checked = tools.CheckREG("isYildiz", "True") ? true : false;
                isBirth = birthSwitch.Checked = tools.CheckREG("isBirth", "True") ? true : false;
                isUTC = UTCSwitch.Checked = tools.CheckREG("isBirth", "True") ? true : false;
                isDST = dstSwitch.Checked = tools.CheckREG("isDST", "True") ? true : false;
            }
        }
        public void Frm2Run(object sender, EventArgs e)
        {
            Form_init frm2 = new Form_init();
            frm2.ShowDialog(this);
            frm2.Dispose();
        }
        public void Frm3Run(object sender, EventArgs e)
        {
            Form_about frm3 = new Form_about();
            frm3.ShowDialog(this);
            frm3.Dispose();
        }
        public void SHesapla(object sender, EventArgs e)
        {
            if (!overHesap)
            {
                Hesapla();
                Guvenlik();
                overHesap = true;
            }
        }
        public void OverHesapCheck(object sender, EventArgs e) { overHesap = false; }

        public void ComponentOlustur()
        {
            txt_adsoyad.GotFocus += new EventHandler(Adsoyad_temizle);
            txt_adsoyad.Click += new EventHandler(Adsoyad_temizle);
            dateTimePicker1.Value = DateTime.Now.Date;
            foreach (var tzi in TimeZoneInfo.GetSystemTimeZones())
            {
                comboBox1.Items.Add(tzi.Id);
                zamanBolge.Add(tzi.Id);
            }
            comboBox1.Items[comboBox1.Items.IndexOf("Turkey Standard Time")] = "Türkiye Saati";
            comboBox1.Text = "Türkiye Saati";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            // Önce hepsini açıver duruma göre kapanır
            isSaat = saatSwitch.Checked = true;
            isYildiz = starSwitch.Checked = true;
            isBirth = birthSwitch.Checked = true;
            isUTC = UTCSwitch.Checked = true;
            isDST = dstSwitch.Checked = true;

            //Kaderin 4 Sütunu Başlıkları ve resim yer tutucuları
            for (int i = 0; i < 4; i++)
            {
                DSHeader[i] = (RadioButton)this.Panel_kaderSutun.Controls["L_" + i.ToString()];
                DSHolder[0, i] = (PictureBox)this.Controls["L_" + i.ToString() + "Element"];
                DSHolder[1, i] = (PictureBox)this.Controls["L_" + i.ToString() + "Burc"];
                GSHolder[i] = (Label)this.Controls["L_" + i.ToString() + "Gizli"];
            }

            //Büyük Hayat Döngüsünü kayıt altına al
            for (int i = 0; i < 8; i++)
            {			
                SDHeader[i] = (Label)this.Controls["L_" + ((i * 10) + 5).ToString() + "Cizelge"];
                SDHolder[0, i] = (PictureBox)this.Controls["L_" + ((i * 10) + 5).ToString() + "CizelgeElement"];
                SDHolder[1, i] = (PictureBox)this.Controls["L_" + ((i * 10) + 5).ToString() + "CizelgeBurc"];
            }

            // Yılların döngüsünü oluştur ve kayıt altına al
            int yil_sol_pos = 414;
            int burc_sol_pos = 470;
            int element_sol_pos = 453;
            int ust_pos;
            for (int i = 7; i >= 0; i--)
            {
                ust_pos = 283;
                yil_sol_pos += 76;
                burc_sol_pos += 76;
                element_sol_pos += 76;
                for (int j = 0; j < 10; j++)
                {
                    Label yil_tmp_label = new Label();
                    Label burc_tmp_label = new Label();
                    Label element_tmp_label = new Label();
                    ust_pos += 18;
                    //isimler
                    element_tmp_label.Name = "L_" + ((i * 10) + 5).ToString() + "CizelgeList" + j.ToString() + "Element";
                    burc_tmp_label.Name = "L_" + ((i * 10) + 5).ToString() + "CizelgeList" + j.ToString() + "Burc";
                    yil_tmp_label.Name = "L_" + ((i * 10) + 5).ToString() + "CizelgeList" + j.ToString() + "_Yil";
                    //lokasyon
                    yil_tmp_label.Location = new Point(yil_sol_pos, ust_pos);
                    burc_tmp_label.Location = new Point(burc_sol_pos, ust_pos);
                    element_tmp_label.Location = new Point(element_sol_pos, ust_pos);
                    //ebadı
                    yil_tmp_label.Size = new Size(40, 18);
                    burc_tmp_label.Size = element_tmp_label.Size = new Size(18, 18);
                    //diğerleri hep eşit görünümler
                    yil_tmp_label.BackColor = burc_tmp_label.BackColor = element_tmp_label.BackColor = Color.White;
                    yil_tmp_label.Font = burc_tmp_label.Font = element_tmp_label.Font = new Font(yil_tmp_label.Font.FontFamily, 10);
                    yil_tmp_label.ForeColor = burc_tmp_label.ForeColor = element_tmp_label.ForeColor = Color.Black;
                    yil_tmp_label.AutoSize = burc_tmp_label.AutoSize = element_tmp_label.AutoSize = false;
                    //malı ekle
                    this.Controls.Add(yil_tmp_label);
                    this.Controls.Add(burc_tmp_label);
                    this.Controls.Add(element_tmp_label);
                    KC[0, i, j] = (Label)this.Controls[element_tmp_label.Name];
                    KC[1, i, j] = (Label)this.Controls[burc_tmp_label.Name];
                    KC[2, i, j] = (Label)this.Controls[yil_tmp_label.Name];
                }
            }
        }

        public void Hesapla()
        {
            DateTime date = (isDST && isSaat) ? CheckDate() : dateTimePicker1.Value;
            //KARA KUTU REVİZYONU
            bool ayGecisVar = false;
            int ayGecisFark = 0;
            for (var j = 0; j < 1680; j++)
            {
                if (src.aySinirlari[j].Year == date.Year && src.aySinirlari[j].Month == date.Month && date.Day == src.aySinirlari[j].Day)
                {
                    ayGecisVar = true;
                    ayGecisFark = (DateTime.Compare(date, src.aySinirlari[j]) < 0) ? -1 : 1;
                }
            }
            //KARA KUTU REVİZYONU
            /*  Julyen Tarihi Hesaplama
                Giriş verileri---------------------> date, cinsiyet check
                Diğer hesaplamalar aktarılacaklar--> L, JZJD */
            var gc = new GregorianCalendar(); //miladi girilen takvimi almak için            
            int Yy = gc.GetYear(date);
            int Ay = gc.GetMonth(date);
            int Gn = gc.GetDayOfMonth(date);
            int Sa = gc.GetHour(date);
            int Dk = gc.GetMinute(date);
            // Miladi Tarihe göre güneşin boylamını hesaplayıp çin güneş takviminden dolayı hesaplıyor
            // L= 315'de çin yılı dönüyor Lmax 360 derece geometri gereği, JD = Julyen Tarihi   
            int Cins = (bayan.Checked) ? -1 : 1;    //cinsiyeti al                                      
            Sa = Sa + (Dk / 60);                    //Saat hesabı (dakikaları küsürlu olarak saate katar)
            double JD = -1 * Math.Floor(7 * (Math.Floor((Convert.ToDouble(Ay) + 9) / 12) + Yy) / 4);
            int S = ((Ay - 9) < 0) ? -1 : 1;
            int A = Math.Abs(Ay - 9);
            double J1 = Math.Floor(Yy + S * Math.Floor(Convert.ToDouble(A) / 7));
            J1 = -1 * Math.Floor((Math.Floor(J1 / 100) + 1) * 3 / 4);
            double saatIcinJD = JD + Math.Floor(275 * Convert.ToDouble(Ay) / 9) + Gn + J1 + 1721027 + 2 + 367 * Yy - 0.5;
            double JZJD = saatIcinJD + (Sa / 24);
            //KARA KUTU REVİZYONU:  
            int revGn = gc.GetDayOfMonth(date.AddDays(ayGecisFark));
            int gunJD = ayGecisVar ? revGn : Gn;
            JD = JD + Math.Floor(275 * Convert.ToDouble(Ay) / 9) + gunJD + J1 + 1721027 + 2 + 367 * Yy - 0.5;
            //KARA KUTU REVİZYONU: 
            JD = JD + (Sa / 24); // - (TZ/24);
            double T = (JD - 2451545) / 36525;
            double d = 2 * Math.PI / 360;
            double M = 357.52910 + 35999.05030 * T - 0.0001559 * T * T - 0.00000048 * T * T * T;
            double L0 = 280.46645 + 36000.76983 * T + 0.0003032 * T * T;
            double DL = (1.914600 - 0.004817 * T - 0.000014 * T * T) * Math.Sin(d * M) + (0.019993 - 0.000101 * T) * Math.Sin(d * 2 * M) + 0.000290 * Math.Sin(d * 3 * M);
            double L = (L0 + DL) % 360;
            L = L < 0 ? Math.Round((L + 360), 0) : Math.Round(L, 0); ; //L negatif ise 360 üstü              

            /*  YIL HESAPLARI
                Giriş verileri---------------------> L: yıl döngüsü, Ay, Yy : ay ve yıl
                Çıkış verileri---------------------> DS[]
                Diğer hesaplamalar aktarılacaklar--> ys0 (ay hesap), FW (ay ve SDHolder) */
            int ys0 = (((L < 315) && (Ay == 1 || Ay == 2)) ? (Yy - 4) : (Yy - 3)) % 10;
            int FW = (ys0 % 2 == 0) ? (-1 * Cins) : (1 * Cins);                    // Cinsiyete göre tarama ileri veya geri gider ve   
            int yb0 = (((L < 315) && (Ay == 1 || Ay == 2)) ? (Yy - 4) : (Yy - 3)) % 12;
            DS[0, 3] = src.ElementBul(src.Kutupbul(ys0))[ys0].Split(',')[2];
            DS[1, 3] = src.Burc_Sembol[yb0].Split(',')[2];

            /*  AY HESAPLARI
                 Giriş verileri---------------------> ys0 ,  FW  , L                    
                 Çıkış verileri---------------------> DS[]
                 Diğer hesaplamalar aktarılacaklar--> ms0 (günler için), lpb0 (SDHolder), LP (Yılların Döngüsü) */
            int ms0 = 1; //çin ay sıralması için çevrim hesapları
            for (var i = 0; i < 6; i++)
                if ((ys0 == i) || (ys0 == i + 5)) { ms0 = ms0 + (i * 2); }
            LP = 0;
            int lpb0 = 0;
            if (L >= 315 && L < 345) // çin takvimine göre güneş yörünge açısı 315 - 345 arasında ise
            {
                lpb0 = 3;
                LP = (FW == 1) ? ((344 - L) / 3) : ((L - 315) / 3);
            }
            if (L >= 345 || L < 15) // çin takvimine göre güneş yörünge açısı 345 - 15 arasında ise
            {
                lpb0 = 4;
                ms0 = ms0 + 1;
                LP = (FW == 1) ? ((374 - L) / 3) : ((L - 345) / 3);
                LP = (LP > 11) ? (LP - 120) : LP;
                LP = (LP < 0) ? (LP + 120) : LP;
            }
            for (int i = 0; i < 10; i++)            // çin takvimine göre güneş yörünge açısı 15 - 315 arasında ise kalabalık olmasın diye loop ile
                if (L >= ((i * 30) + 15) && L < (((i + 1) * 30) + 15))
                {
                    lpb0 = 5 + i;
                    ms0 = ms0 + 2 + i;
                    LP = (FW == 1) ? ((((i + 1) * 30 + 14) - L) / 3) : ((L - (i * 30 + 14)) / 3);
                }
            lpb0 = lpb0 % 12 == 0 ? 12 : lpb0 % 12;
            ms0 = ms0 % 10;
            DS[0, 2] = src.ElementBul(src.Kutupbul(ms0))[ms0].Split(',')[2];
            DS[1, 2] = src.Burc_Sembol[lpb0].Split(',')[2];

            /*  GÜN HESAPLARI
                Giriş verileri---------------------> ms0, JZJD                    
                Çıkış verileri---------------------> DS[]
                Diğer hesaplamalar aktarılacaklar--> ds_temp (saat için) */
            int lps0 = ms0;
            int ds0 = Convert.ToInt32(Math.Floor(JZJD + 0.5));
            int ds_temp = Convert.ToInt32((ds0.ToString()).Substring(6, 1));
            int db0 = Convert.ToInt32(Math.Floor(JZJD - 12 * Math.Floor((JZJD + 0.5) / 12) + 0.5) + 2);
            DS[0, 1] = src.ElementBul(src.Kutupbul(ds_temp))[ds_temp].Split(',')[2];
            DS[1, 1] = src.Burc_Sembol[db0].Split(',')[2];

            /*  SAAT HESAPLARI
                Giriş verileri---------------------> ds_temp, Sa               
                Çıkış verileri---------------------> DS[]  */
            int hs0 = 1;
            int hs1 = 0;
            for (var i = 1; i < 5; i++)
            {
                hs1 = (ds_temp == i || ds_temp == i + 5) ? hs0 : hs1;
                hs0 = hs0 + 2;
            }
            hs1 = (ds_temp == 0 || ds_temp == 5) ? 9 : hs1;
            hs1 = (Sa >= 23 && Sa < 24) ? (hs1 + 2) : hs1;
            DS[1, 0] = ((Sa >= 23 && Sa <= 24) || (Sa >= 0 && Sa < 1)) ? src.Burc_Sembol[1].Split(',')[2] : "";
            int hb0 = 2;
            for (var i = 1; i < 23; i++)
            {
                if ((Sa >= i && Sa < i + 2))
                {
                    DS[1, 0] = src.Burc_Sembol[hb0].Split(',')[2];
                    hs1 = hs1 + hb0 - 1;
                }
                i = i + 1;
                hb0 = hb0 + 1;
            }
            hs1 = hs1 % 10;
            DS[0, 0] = src.ElementBul(src.Kutupbul(hs1))[hs1].Split(',')[2];

            /*  Büyük Hayat Döngüsü Hesabı   
                Giriş verileri---------------------> lpb0, FW   
                Çıkış verileri---------------------> SD  */
            for (int i = 0; i < 8; i++)
            {
                lpb0 = lpb0 + FW;
                lpb0 = ((lpb0 > 12) || (lpb0 < 0)) ? (lpb0 - 12 * FW) : lpb0;
                SD[1, i] = src.Burc_Sembol[lpb0].Split(',')[2];
                lps0 = lps0 + FW;
                lps0 = ((lps0 > 10) || (lps0 < 0)) ? (lps0 - 10 * FW) : lps0;
                SD[0, i] = src.ElementBul(src.Kutupbul(lps0))[lps0].Split(',')[2];
                gl_Yy[i] = Convert.ToInt32(LP) + (i * 10) + Yy;
            }

            LP = Math.Round((Math.Floor(LP * 100) / 100), 0);

            if (runOnce)
            {
                hangi_yil.Text = src.ElementBul(src.Kutupbul(ys0))[ys0].Split(',')[2] + " "
                    + src.ElementBul(src.Kutupbul(ys0))[ys0].Split(',')[0] + " "
                    + src.Burc_Sembol[yb0].Split(',')[2] + " "
                    + src.Burc_Sembol[yb0].Split(',')[0] + " "
                    + "Yılı ";
                runOnce = false;
            }

            //Yerleştir
            DegerleriYerlestir();
            //Analiz Restore
            Analiz_Action();
        }

        public void DegerleriYerlestir()
        {
            /*4 sutün Elementleri, burclari, gizli element, Şans Dönemleri, Kader Çizelgesi ve Şany Yıldızlarını yerleştir.
            Giriş verileri---------------------> LP, DS, Yy
            Çıkış verileri--------------------->KC, SD, DSHolder, SDHolder  */
            for (int i = 0; i < 4; i++)
            {
                tools.ResimYukle(DSHolder[0, i], dil + "_" + DS[0, i]);
                tools.ResimYukle(DSHolder[1, i], dil + "_" + DS[1, i]);
                GSHolder[i].Text = src.GizliElement(DS[1, i]);
            }

            for (int i = 0; i < 8; i++)
            {
                SDHeader[i].Text = gl_Yy[i].ToString() + "(" + (LP + i * 10).ToString() + ")";
                tools.ResimYukle(SDHolder[0, i], dil + "_" + SD[0, i]);
                tools.ResimYukle(SDHolder[1, i], dil + "_" + SD[1, i]);
                for (int j = 0; j < 10; j++)
                {
                    KC[0, i, j].Text = src.YilElementBul(gl_Yy[i] + j)[2];
                    KC[1, i, j].Text = src.YilBurcBul(gl_Yy[i] + j)[2];
                    KC[2, i, j].Text = (gl_Yy[i] + j).ToString();
                }
            }
            secKader = Panel_kaderSutun.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();
            //Yıldızları belirle ve yerleştir.
            askcicegi.Text = "Aşk Çiçeği:\n" + "Yıl: " + src.SembolikYildizBul(DS[1, 3], "ask") + "\nGün: " + src.SembolikYildizBul(DS[1, 1], "ask");
            seyahatat.Text = "Seyahat Atı:\n" + "Yıl: " + src.SembolikYildizBul(DS[1, 3], "seyahat") + "\nGün: " + src.SembolikYildizBul(DS[1, 1], "seyahat");
            kmelek.Text = "Koruyucu Melek:\n" + "Yıl: " + src.KoruyucuMelek(DS[0, 3]) + "\nGün: " + src.KoruyucuMelek(DS[0, 1]);
            syildiz.Text = "Sanat Yıldızı:\n" + "Yıl: " + src.SembolikYildizBul(DS[1, 3], "sanat") + "\nGün: " + src.SembolikYildizBul(DS[1, 1], "sanat");
            ayildizyil.Text = "Akademik Yıldız:\n" + "Yıl: " + src.AkademikYildiz(DS[0, 3]) + "\nGün: " + src.AkademikYildiz(DS[0, 1]);
            yyildiz.Text = "Yanlızlık Yıldızı:\n" + src.YanlizYildiz(DS[1, 3]) + "\n";
            eyildiz.Text = "Erdem Yıldızı:\n" + src.ErdemYildiz(DS[1, 2]) + "\n";

            analiz_Status.Text = analizSecenekleri[SecIndx];
        }

        // Yan fonksiyonlar   
        public DateTime CheckDate() //dst ile ileri alınan saati çıkarmak için
        {
            DateTime date = dateTimePicker1.Value;
            var gcc = new GregorianCalendar();  //tarihi ve saatleri ayrıştır miladi girilen takvimi almak için            
            int Yy = gcc.GetYear(date);
            string timeSelected = (comboBox1.SelectedIndex > -1) ? zamanBolge[comboBox1.SelectedIndex].ToString() : TimeZoneInfo.Local.StandardName;
            TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeSelected);

            if ((Yy < 2007 || Yy > 2016) && timeSelected == "Turkey Standard Time") //Klasik şekilde DST uyguladığımız zamanı hariç tutaraK
            {
                for (int i = 0; i < 48; i++)
                {
                    int sumD = DateTime.Compare(date, DateTime.Parse(src.trDSTExceptions[i, 0])) + DateTime.Compare(date, DateTime.Parse(src.trDSTExceptions[i, 1]));
                    if (sumD >= -1 && sumD <= 1) { date = date.AddHours(-1 * Int32.Parse(src.trDSTExceptions[i, 2])); }
                }
            }
            else { date = (timeZone.IsDaylightSavingTime(date)) ? date.AddHours(-1) : date; }
            return date;
        }

        //MENU: Ad Soyad Giriş
        private void Adsoyad_txt_Click(object sender, EventArgs e) { txt_adsoyad.Focus(); }
        private void Adsoyad_temizle(object sender, EventArgs e) { txt_adsoyad.SelectAll(); }
        private void TxtAdsoyad_temizle_Click(object sender, EventArgs e)
        {
            overHesap = false;
            txt_adsoyad.Clear();
            txt_adsoyad.Focus();
        }
        private void Txt_adsoyad_TextChanged(object sender, EventArgs e)
        {
            bool adsoyadBosmu = !string.IsNullOrWhiteSpace(txt_adsoyad.Text);
            adsoyad_txt.Visible = overHesap = !adsoyadBosmu;
            txtAdsoyad_temizle.Visible = txt_adsoyad.Modified = adsoyadBosmu;
        }

        //MENU: Seçenekler Fonksiyonları
        private void SecenekCheckedChanged(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Tag.ToString())
            {
                case "saatSwitch":
                    isSaat = saatSwitch.Checked;
                    IsSaatCheck();
                    break;
                case "UTCSwitch":
                    isUTC = UTCSwitch.Checked;
                    break;
                case "birthSwitch":
                    isBirth = UTCSwitch.Enabled = birthSwitch.Checked;
                    break;
                case "dstSwitch":
                    isDST = dstSwitch.Checked;
                    Hesapla();
                    break;
                case "starSwitch":
                    isYildiz = starSwitch.Checked;
                    IsYildizCheck();
                    break;
            }
        }
        private void IsElleriSevCheck() { if (!isElleriSev) { this.Text = "Profesyonel BaZi Hesaplayıcı 3.1 - Lisanssız Yazılım: "; } }
        private void IsSaatCheck()
        {
            UTCSwitch.Enabled =
                dstSwitch.Enabled =
                L_0.Enabled =
                L_0Element.Visible =
                L_0Burc.Visible =
                L_0Gizli.Visible =
                comboBox1.Visible = isSaat;
            dateTimePicker1.CustomFormat = isSaat ? "dd/MM/yyyy HH:mm" : "dd/MM/yyyy 00:00";
            if (!isSaat && L_0.Checked) { L_1.Checked = true; }
        }
        private void IsYildizCheck() { starBox.Visible = isYildiz; }

        //MENU: Analiz Fonksiyonları      
        void RenkSifirla()
        {
            for (int both = 0; both < 2; both++)
            {
                for (int i = 0; i < 4; i++)
                {
                    DSHolder[both, i].BackColor = Color.White;
                }
                for (int i = 0; i < 8; i++)
                {
                    SDHolder[both, i].BackColor = Color.White;
                    for (int j = 0; j < 10; j++)
                    {
                        KC[both, i, j].BackColor = Color.White;
                    }
                }
            }
        }

        private void Analiz_Yon_Click(object sender, EventArgs e)
        {
            switch (((ToolStripButton)sender).Tag.ToString())
            {
                case "analiz_left": SecIndx = SecIndx == 0 ? analizSecenekleri.Length - 1 : SecIndx - 1; break;
                case "analiz_right": SecIndx = SecIndx == analizSecenekleri.Length - 1 ? 0 : SecIndx + 1; break;
            }
            Analiz_Action();
        }

        private void GroupGLorKader_CheckedChanged(object sender, EventArgs e)
        {
            secKader = Panel_kaderSutun.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Tag.ToString();
            Analiz_Action();
        }

        private void Sec_CheckedChanged(object sender, EventArgs e)
        {
            if (!sec_Ele.Checked && !sec_Burc.Checked) { secEleBurc = 0; } // boş
            if (sec_Ele.Checked && !sec_Burc.Checked) { secEleBurc = 1; } // ele
            if (!sec_Ele.Checked && sec_Burc.Checked) { secEleBurc = 2; } // burc
            if (sec_Ele.Checked && sec_Burc.Checked) { secEleBurc = 3; } // ele + burc
            if (!sec_Uyum.Checked && !sec_Zit.Checked) { secUyum = 0; } // boş
            if (sec_Uyum.Checked && !sec_Zit.Checked) { secUyum = 1; } // uyum
            if (!sec_Uyum.Checked && sec_Zit.Checked) { secUyum = 2; } // zitlik
            if (sec_Uyum.Checked && sec_Zit.Checked) { secUyum = 3; } //uyum + zitlik
            Analiz_Action();
        }

        public void analizSecenekAyarla(bool kaderPanel, bool eleBurcSec, bool secPanel)
        {
            sec_Ele.Enabled = sec_Burc.Enabled = eleBurcSec;
            Panel_EleBurc.Enabled = secPanel;
            Panel_kaderSutun.Visible = kaderPanel;
            Panel_kaderSutun.Enabled = kaderPanel;
        }

        //Analiz_Action();
        public void Analiz_Action()
        {
            analiz_Status.Text = analizSecenekleri[SecIndx];
            RenkSifirla();
            int itr_basla = isSaat ? 0 : 1;   //iterasyon saat göstermiyorsa  +1 başlar 
            string[] analizPaket = new string[3];
            int[] sonuclar = new int[6];
            int itr = 0;
            PictureBox fromObject;

            if (SecIndx == 0) { analizSecenekAyarla(false, false, false); }

            if (SecIndx == 1) //"Gök ve Yer Hanesi İkili"
            {
                analizSecenekAyarla(false, true, true);
                itr = 3; //her öbek için analiz 2 iterasyonda biter          
                for (int itrSayac = itr_basla; itrSayac < itr; itrSayac++)
                {
                    if (secEleBurc == 1 || secEleBurc == 3)
                    {
                        tools.pictureBoxRenklendir(src.Zit2uyum(DS[0, itrSayac], DS[0, itrSayac + 1]),
                            secUyum, DSHolder[0, itrSayac], DSHolder[0, itrSayac + 1]);
                    }
                    if (secEleBurc == 2 || secEleBurc == 3)
                    {
                        tools.pictureBoxRenklendir(src.Zit2uyum(DS[1, itrSayac], DS[1, itrSayac + 1]),
                            secUyum, DSHolder[1, itrSayac], DSHolder[1, itrSayac + 1]);
                    }
                }
            }

            if (SecIndx == 2) //"Gök ve Yer Hanesi - Şans Dönemi İkili"
            {
                analizSecenekAyarla(true, true, true);
                for (int i = 0; i < 8; i++)
                {
                    if (secEleBurc == 1 || secEleBurc == 3)
                    {
                        fromObject = (PictureBox)this.Controls[secKader + "Element"];
                        tools.pictureBoxRenklendir(src.Zit2uyum(fromObject.Image.Tag.ToString(), SD[0, i]), secUyum, fromObject, SDHolder[0, i]);
                    }
                    if (secEleBurc == 2 || secEleBurc == 3)
                    {
                        fromObject = (PictureBox)this.Controls[secKader + "Burc"];
                        tools.pictureBoxRenklendir(src.Zit2uyum(fromObject.Image.Tag.ToString(), SD[1, i]), secUyum, fromObject, SDHolder[1, i]);
                    }
                }
            }

            if (SecIndx == 3) //"Gök ve Yer Hanesi - Yıllar İkili Uyum - Zıtlık"
            {
                analizSecenekAyarla(true, true, true);
                for (int SDSayac = 0; SDSayac < 8; SDSayac++)
                {
                    for (int KCSayac = 0; KCSayac < 10; KCSayac++)
                    {
                        if (secEleBurc == 1 || secEleBurc == 3)
                        {
                            fromObject = (PictureBox)this.Controls[secKader + "Element"];
                            string yillarElementRenk = src.Zit2uyum(fromObject.Image.Tag.ToString(), KC[0, SDSayac, KCSayac].Text);
                            tools.pictureBoxRenklendir(yillarElementRenk, secUyum, fromObject);
                            tools.labelRenklendir(yillarElementRenk, secUyum, KC[0, SDSayac, KCSayac]);
                        }
                        if (secEleBurc == 2 || secEleBurc == 3)
                        {
                            fromObject = (PictureBox)this.Controls[secKader + "Burc"];
                            string YillarBurcRenk = src.Zit2uyum(fromObject.Image.Tag.ToString(), KC[1, SDSayac, KCSayac].Text);
                            tools.pictureBoxRenklendir(YillarBurcRenk, secUyum, fromObject);
                            tools.labelRenklendir(YillarBurcRenk, secUyum, KC[1, SDSayac, KCSayac]);
                        }
                    }
                }
            }

            if (SecIndx == 4) //"Yer Hanesi Üçlü Uyum - Zıtlık"
            {
                analizSecenekAyarla(false, false, true);
                itr = 2; //her öbek için analiz 2 iterasyonda biter          
                for (int itrSayac = itr_basla; itrSayac < itr; itrSayac++)
                {
                    for (int analizSayac = 0; analizSayac < 3; analizSayac++)
                    {
                        analizPaket[analizSayac] = DS[1, itrSayac + analizSayac];
                    }
                    sonuclar = src.UcluUyumZitlik(analizPaket);
                    for (int sonucAnalizSayac = 0; sonucAnalizSayac < 6; sonucAnalizSayac++)
                    {
                        if (sonuclar[sonucAnalizSayac] == 3)
                        { //İLGİLİ 3LÜ ÖBEĞİN MASTER FREKANSI PEAK = 3 ise uyum-zıtlık vardr, RENKLENDİRMEYE BAŞLA
                            for (int renkSayac = 0; renkSayac < 3; renkSayac++)
                            {
                                tools.pictureBoxRenklendir(src.uclu_bak[sonucAnalizSayac, 3], secUyum, DSHolder[1, itrSayac + renkSayac]);
                            }
                        }
                    }
                }
            }

            if (SecIndx == 5) //"Yer Hanesi - Şans Dönemi Üçlü Uyum - Zıtlık"
            {
                analizSecenekAyarla(false, false, true);
                itr = 3; //her öbek için analiz 2 iterasyonda biter      
                for (int SDSayac = 0; SDSayac < 8; SDSayac++)
                {
                    for (int itrSayac = itr_basla; itrSayac < itr; itrSayac++)
                    {
                        for (int analizSayac = 0; analizSayac < 2; analizSayac++)
                        {
                            analizPaket[analizSayac] = DS[1, itrSayac + analizSayac];
                        }
                        analizPaket[2] = SDHolder[1, SDSayac].Image.Tag.ToString();
                        sonuclar = src.UcluUyumZitlik(analizPaket);
                        for (int sonucAnalizSayac = 0; sonucAnalizSayac < 6; sonucAnalizSayac++)
                        {
                            if (sonuclar[sonucAnalizSayac] == 3)
                            { //İLGİLİ 3LÜ ÖBEĞİN MASTER FREKANSI PEAK = 3 ise uyum-zıtlık vardr, RENKLENDİRMEYE BAŞLA
                                for (int renkSayac = 0; renkSayac < 2; renkSayac++)
                                {
                                    tools.pictureBoxRenklendir(src.uclu_bak[sonucAnalizSayac, 3], secUyum, DSHolder[1, itrSayac + renkSayac]);
                                }
                                tools.pictureBoxRenklendir(src.uclu_bak[sonucAnalizSayac, 3], secUyum, SDHolder[1, SDSayac]);
                            }
                        }
                    }
                }
            }

            if (SecIndx == 6) //"Yer Hanesi - Yıllar Üçlü Uyum - Zıtlık"
            {
                analizSecenekAyarla(false, false, true);
                itr = 3; //her öbek için analiz 2 iterasyonda biter      
                for (int SDSayac = 0; SDSayac < 8; SDSayac++)
                {
                    for (int KCSayac = 0; KCSayac < 10; KCSayac++)
                    {
                        for (int itrSayac = itr_basla; itrSayac < itr; itrSayac++)
                        {
                            for (int analizSayac = 0; analizSayac < 2; analizSayac++)
                            {
                                analizPaket[analizSayac] = DS[1, itrSayac + analizSayac];
                            }
                            analizPaket[2] = KC[1, SDSayac, KCSayac].Text;
                            sonuclar = src.UcluUyumZitlik(analizPaket);
                            for (int sonucAnalizSayac = 0; sonucAnalizSayac < 6; sonucAnalizSayac++)
                            {
                                if (sonuclar[sonucAnalizSayac] == 3)
                                { //İLGİLİ 3LÜ ÖBEĞİN MASTER FREKANSI PEAK = 3 ise uyum-zıtlık vardr, RENKLENDİRMEYE BAŞLA
                                    for (int renkSayac = 0; renkSayac < 2; renkSayac++)
                                    {
                                        tools.pictureBoxRenklendir(src.uclu_bak[sonucAnalizSayac, 3], secUyum, DSHolder[1, itrSayac + renkSayac]);
                                    }
                                    tools.labelRenklendir(src.uclu_bak[sonucAnalizSayac, 3], secUyum, KC[1, SDSayac, KCSayac]);
                                }
                            }
                        }
                    }
                }
            }

            if (SecIndx == 7) //"Yer Hanesi - Şans Dönemi - Yıllar Üçlü  Uyum - Zıtlık"
            {
                analizSecenekAyarla(true, false, true);
                fromObject = (PictureBox)this.Controls[secKader + "Burc"];
                for (int SDSayac = 0; SDSayac < 8; SDSayac++)
                {
                    analizPaket[0] = fromObject.Image.Tag.ToString();
                    analizPaket[1] = SDHolder[1, SDSayac].Image.Tag.ToString();
                    for (int KCSayac = 0; KCSayac < 10; KCSayac++)
                    {
                        analizPaket[2] = KC[1, SDSayac, KCSayac].Text;
                        sonuclar = src.UcluUyumZitlik(analizPaket);
                        for (int sonucAnalizSayac = 0; sonucAnalizSayac < 6; sonucAnalizSayac++)
                        {
                            if (sonuclar[sonucAnalizSayac] == 3)
                            { //İLGİLİ 3LÜ ÖBEĞİN MASTER FREKANSI PEAK = 3 ise uyum-zıtlık vardr, RENKLENDİRMEYE BAŞLA
                                tools.pictureBoxRenklendir(src.uclu_bak[sonucAnalizSayac, 3], secUyum, fromObject, SDHolder[1, SDSayac]);
                                tools.labelRenklendir(src.uclu_bak[sonucAnalizSayac, 3], secUyum, KC[1, SDSayac, KCSayac]);
                            }
                        }
                    }
                }
            }

            if (SecIndx == 8) //"Kendine Ceza"
            {
                analizSecenekAyarla(false, false, false);
                for (int SDSayac = 0; SDSayac < 8; SDSayac++)
                {
                    for (int KCSayac = 0; KCSayac < 10; KCSayac++)
                    {
                        string yillarBurcRenk = src.KendineCeza(DS[1,1], KC[1, SDSayac, KCSayac].Text);
                        tools.pictureBoxRenklendir(yillarBurcRenk, secUyum, L_1Burc);
                        tools.labelRenklendir(yillarBurcRenk, secUyum, KC[1, SDSayac, KCSayac]);                      
                    }
                }
            }
        }

        //MENU: Belge Kaydetme ve Yazdırma Menusu Fonksiyonları
        private Stream streamToPrint;
        string streamType;
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Image imageEkran = Image.FromStream(this.streamToPrint);
            int x = 30;// e.MarginBounds.X;
            int y = 30;// e.MarginBounds.Y;
            int height = e.MarginBounds.Height;
            int width = imageEkran.Width * (e.MarginBounds.Height / imageEkran.Height);
            Rectangle destRect = new Rectangle(x, y, width, height);
            e.Graphics.DrawImage(imageEkran, destRect, 0, 0, imageEkran.Width, imageEkran.Height, GraphicsUnit.Pixel);
        }
        public void StartPrint(Stream streamToPrint, string streamType)
        {
            this.printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);
            this.streamToPrint = streamToPrint;
            this.streamType = streamType;
            this.printDocument1.DefaultPageSettings.Landscape = true;
            if (printDialog1.ShowDialog() == DialogResult.OK) { printDocument1.Print(); }
        }
        private void Belge_kaydet(object sender, EventArgs e)
        {
            // Ekran görüntüsü için gerekli gizlemeleri yap
            dynamicButton.Hide();
            anamenu.Visible = !isElleriSev;
            dateTimePicker1.Visible = comboBox1.Visible = L_info02.Visible = isBirth;
            comboBox1.Visible = isUTC;
            // pdf ve yazıcı geçici, resim için kalıcı ekran görüntüsü oluştur
            string saveFilenamePathAndName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + txt_adsoyad.Text + " " + dateTimePicker1.Value.ToShortDateString();
            Image MyImage = new Bitmap(tools.GetFormImageWithoutBorders(this));
            // tercihe göre kayıt sekansı
            if (((ToolStripMenuItem)sender).Tag.ToString() != "kaydetResim")
            {
                string tempImageFilenamePath = Path.GetTempFileName();
                MyImage.Save(tempImageFilenamePath, ImageFormat.Jpeg);
                if (((ToolStripMenuItem)sender).Tag.ToString() == "kaydetPDF")
                {
                    ImageToPdfConvetrer.ImageToPdf(MyImage).SaveAs(saveFilenamePathAndName + ".pdf");
                    MessageBox.Show("PDF masaüstü klasörünüze kaydedildi");
                }
                if (((ToolStripMenuItem)sender).Tag.ToString() == "kaydetYazici")
                {
                    FileStream fileStream = new FileStream(tempImageFilenamePath, FileMode.Open, FileAccess.Read);
                    StartPrint(fileStream, "image");
                    fileStream.Close();
                    if (File.Exists(tempImageFilenamePath)) { File.Delete(tempImageFilenamePath); }
                }
            }
            else
            {
                MyImage.Save(saveFilenamePathAndName + ".jpg", ImageFormat.Jpeg);
                MessageBox.Show("Resim masaüstü klasörünüze kaydedildi");
            }
            //Gizlemeleri geri aç
            anamenu.Show();
            dynamicButton.Show();
            anamenu.Show();
            dateTimePicker1.Show();
            L_info02.Show();
            comboBox1.Visible = isSaat;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tools.RegSET("isSaat", isSaat.ToString());
            tools.RegSET("isYildiz", isYildiz.ToString());
            tools.RegSET("isBirth", isBirth.ToString());
            tools.RegSET("isUTC", isUTC.ToString());
            tools.RegSET("isDST", isDST.ToString());
        }

        //MENU: REHBER Fonksiyonları
        private void FrmRehberRun(object sender, EventArgs e)
        {
            string filtre_adsoyad = tools.IlkHarfBuyuk(txt_adsoyad.Text.TrimStart().TrimEnd());
            string cinsiyet_sec = "";
            if (bay.Checked) { cinsiyet_sec = "Bay"; }
            if (bayan.Checked) { cinsiyet_sec = "Bayan"; }
            Form_rehber rehber = (!string.IsNullOrWhiteSpace(txt_adsoyad.Text) && txt_adsoyad.Text != "Ad Soyad") ?
                rehber = new Form_rehber(filtre_adsoyad, dateTimePicker1.Text, cinsiyet_sec, comboBox1.Text) : rehber = new Form_rehber();
            rehber.StartPosition = FormStartPosition.Manual;
            rehber.Size = new Size(305, this.Height);
            rehber.Location = new Point(this.Right - rehber.Width, this.Top);
            rehber.ShowDialog(this);
            if (rehber.DialogResult == DialogResult.None) { Hesapla(); }
            rehber.Dispose();
        }

        public string RehberIsimAl
        {
            get { return txt_adsoyad.Text; }
            set { txt_adsoyad.Text = value; }
        }

        public string RehberTarihAl
        {
            get { return dateTimePicker1.Text; }
            set { dateTimePicker1.Text = value; }
        }

        public string RehberDSTAl
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        public bool RehberBayAl
        {
            get { return bay.Checked; }
            set { bay.Checked = value; }
        }
        public bool RehberBayanAl
        {
            get { return bayan.Checked; }
            set { bayan.Checked = value; }
        }

        //           s  0  1  2  3| 4  5  6  7  8  9  10 11|12|13 14 15 16 17 18 19 20 21 22                 
        //Ayarlanmis(3, 1, 1, 1, 1, 9, 1, 1, 1, 1, 1, 1, 1, 0, 5, 5, 1, 5, 5, 5, 5, 5, 5, 5);  
        public void Ayarlanmis(int senaryo, params int[] sec)
        {
            if (senaryo == 1 || senaryo == 2 || senaryo == 3)
            {
                //9,5,1
                DS[1, 0] = src.Burc_Sembol[sec[0]].Split(',')[2]; //1
                DS[1, 1] = src.Burc_Sembol[sec[1]].Split(',')[2]; //2
                DS[1, 2] = src.Burc_Sembol[sec[2]].Split(',')[2]; //3
                DS[1, 3] = src.Burc_Sembol[sec[3]].Split(',')[2]; //4
            }
            if (senaryo == 2 || senaryo == 3)
            {
                SD[1, 0] = src.Burc_Sembol[sec[4]].Split(',')[2]; //4
                SD[1, 1] = src.Burc_Sembol[sec[5]].Split(',')[2]; //5
                SD[1, 2] = src.Burc_Sembol[sec[6]].Split(',')[2]; //6
                SD[1, 3] = src.Burc_Sembol[sec[7]].Split(',')[2]; //7
                SD[1, 4] = src.Burc_Sembol[sec[8]].Split(',')[2]; //8
                SD[1, 5] = src.Burc_Sembol[sec[9]].Split(',')[2]; //9
                SD[1, 6] = src.Burc_Sembol[sec[10]].Split(',')[2]; //10
                SD[1, 7] = src.Burc_Sembol[sec[11]].Split(',')[2]; //11
            }
            DegerleriYerlestir();
            if (senaryo == 3)
            {
                //Label[,,]KC = new Label[3, 8, 10]; //Yılların Döngüsü (element,burc,yil), sutun 8 sekme, satır 10 yıl = toplam 80 yıl    
                KC[1, sec[12], 0].Text = src.Burc_Sembol[sec[13]].Split(',')[2]; //12
                KC[1, sec[12], 1].Text = src.Burc_Sembol[sec[14]].Split(',')[2]; //13
                KC[1, sec[12], 2].Text = src.Burc_Sembol[sec[15]].Split(',')[2]; //14
                KC[1, sec[12], 3].Text = src.Burc_Sembol[sec[16]].Split(',')[2]; //15
                KC[1, sec[12], 4].Text = src.Burc_Sembol[sec[17]].Split(',')[2]; //16
                KC[1, sec[12], 5].Text = src.Burc_Sembol[sec[18]].Split(',')[2]; //17
                KC[1, sec[12], 6].Text = src.Burc_Sembol[sec[19]].Split(',')[2]; //18
                KC[1, sec[12], 7].Text = src.Burc_Sembol[sec[20]].Split(',')[2]; //19
                KC[1, sec[12], 8].Text = src.Burc_Sembol[sec[21]].Split(',')[2]; //20
                KC[1, sec[12], 9].Text = src.Burc_Sembol[sec[22]].Split(',')[2]; //21
            }
        }
    }
}
