//
//  ViewController.swift
//  proBaziMac
//
//  Created by Mehmet Durmaz on 9.02.2019.
//  Copyright © 2019 Mehmet Durmaz. All rights reserved.
//

import Cocoa

class ViewController: NSViewController {

    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }

    override var representedObject: Any? {
        didSet {
        // Update the view, if already loaded.
        }
    }
   /*
    func hesapla() {
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
        
    }*/


}

