using BaZi.Properties;
using System;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

namespace BaZi
{
    public class Varibles
    {
        ResourceManager kaynak = Resources.ResourceManager;

        public string[] Burc_Sembol = new string[]
        {
            "Domuz,Hai,亥,KB", //ok
            "Fare,Zi,子,K", //ok
            "Öküz,Chou,丑,", //ok 
            "Kaplan,Yin,寅,KD", //ok
            "Tavşan,Mao,卯,D", //ok
            "Ejderha,Chen,辰,", //ok
            "Yılan,Si,巳,GD", //ok
            "At,Wu,午,G", //ok
            "Keçi,Wei,未,", //ok
            "Maymun,Shen,申,GB", //ok
            "Horoz,You,酉,B", //ok
            "Köpek,Xu,戌,", //ok
            "Domuz,Hai,亥,KB", //ok
            "Fare,Zi,子,K" //ok
        };

        public string[,] uclu_bak = new string[6, 4]
        {
            {"申", "子", "辰", "yesil"}, //9,1,5
			{"寅", "午", "戌", "yesil"}, //3,7,11
			{"亥", "卯", "未", "yesil"}, //0,4,8
			{"巳", "酉", "丑", "yesil"}, //6,10,2
			{"寅", "巳", "申", "kirmizi"}, //3,6,9
			{"丑", "戌", "未", "kirmizi"} //2,11,8                    
        };

        public string[] yinElement = new string[]
       {
           "Yin Su,Gui,癸", //ok
           "Yin Ağaç,Yi,乙", //ok
           "Yin Ağaç,Yi,乙", //ok
           "Yin Ateş,Ding,丁", //ok
           "Yin Ateş,Ding,丁", //ok
           "Yin Toprak,Ji,己", //ok
           "Yin Toprak,Ji,己", //ok
           "Yin Metal,Xin,辛", //ok
           "Yin Metal,Xin,辛", //ok
           "Yin Su,Gui,癸", //ok
           "Yin Su,Gui,癸" //ok
       };

        public string[] yangElement = new string[]
        {
            "Yang Su,Ren,壬", //ok
            "Yang Ağaç,Jia,甲", //ok
            "Yang Ağaç,Jia,甲", //ok
            "Yang Ateş,Bing,丙", //ok
            "Yang Ateş,Bing,丙", //ok
            "Yang Toprak,Wu,戊", //ok
            "Yang Toprak,Wu,戊", //ok
            "Yang Metal,Geng,庚", //ok
            "Yang Metal,Geng,庚", //ok
            "Yang Su,Ren,壬", //ok
            "Yang Su,Ren,壬" //ok
        };

        public string[] Element = new string[]
        {
            "Yang Metal,Geng,庚", //0
            "Yin Metal,Xin,辛",  //1
            "Yang Su,Ren,壬",    //2
            "Yin Su,Gui,癸",     //3
            "Yang Ağaç,Jia,甲",  //4
            "Yin Ağaç,Yi,乙",    //5
            "Yang Ateş,Bing,丙", //6
            "Yin Ateş,Ding,丁",  //7
            "Yang Toprak,Wu,戊", //8
            "Yin Toprak,Ji,己"   //9
        };

        public DateTime[] aySinirlari = new DateTime[]
        {
            new DateTime(1901,1,6,8,22,0),
            new DateTime(1901,2,4,20,8,0),
            new DateTime(1901,3,6,14,39,0),
            new DateTime(1901,4,5,20,13,0),
            new DateTime(1901,5,6,14,19,0),
            new DateTime(1901,6,6,19,5,0),
            new DateTime(1901,7,8,5,36,0),
            new DateTime(1901,8,8,15,15,0),
            new DateTime(1901,9,8,17,39,0),
            new DateTime(1901,10,9,8,35,0),
            new DateTime(1901,11,8,11,3,0),
            new DateTime(1901,12,8,3,21,0),
            new DateTime(1902,1,6,14,20,0),
            new DateTime(1902,2,4,2,7,0),
            new DateTime(1902,3,6,20,36,0),
            new DateTime(1902,4,5,2,6,0),
            new DateTime(1902,5,6,20,7,0),
            new DateTime(1902,6,6,0,48,0),
            new DateTime(1902,7,8,11,15,0),
            new DateTime(1902,8,8,20,51,0),
            new DateTime(1902,9,8,23,15,0),
            new DateTime(1902,10,9,14,14,0),
            new DateTime(1902,11,8,16,46,0),
            new DateTime(1902,12,7,9,10,0),
            new DateTime(1903,1,6,20,12,0),
            new DateTime(1903,2,5,8,0,0),
            new DateTime(1903,3,6,2,27,0),
            new DateTime(1903,4,6,7,55,0),
            new DateTime(1903,5,6,1,54,0),
            new DateTime(1903,6,7,6,36,0),
            new DateTime(1903,7,8,17,5,0),
            new DateTime(1903,8,8,2,44,0),
            new DateTime(1903,9,9,5,11,0),
            new DateTime(1903,10,9,20,10,0),
            new DateTime(1903,11,8,22,42,0),
            new DateTime(1903,12,8,15,4,0),
            new DateTime(1904,1,5,2,6,0),
            new DateTime(1904,2,6,13,53,0),
            new DateTime(1904,3,6,8,20,0),
            new DateTime(1904,4,5,13,48,0),
            new DateTime(1904,5,6,7,47,0),
            new DateTime(1904,6,6,12,30,0),
            new DateTime(1904,7,7,23,0,0),
            new DateTime(1904,8,8,8,41,0),
            new DateTime(1904,9,8,11,7,0),
            new DateTime(1904,10,9,2,4,0),
            new DateTime(1904,11,8,4,33,0),
            new DateTime(1904,12,7,20,54,0),
            new DateTime(1905,1,6,7,56,0),
            new DateTime(1905,2,4,19,44,0),
            new DateTime(1905,3,6,14,14,0),
            new DateTime(1905,4,5,19,43,0),
            new DateTime(1905,5,6,13,43,0),
            new DateTime(1905,6,6,18,22,0),
            new DateTime(1905,7,8,4,49,0),
            new DateTime(1905,8,8,14,23,0),
            new DateTime(1905,9,8,16,50,0),
            new DateTime(1905,10,9,7,48,0),
            new DateTime(1905,11,8,10,18,0),
            new DateTime(1905,12,8,2,39,0),
            new DateTime(1906,1,6,13,42,0),
            new DateTime(1906,2,4,1,33,0),
            new DateTime(1906,3,6,20,5,0),
            new DateTime(1906,4,5,1,36,0),
            new DateTime(1906,5,6,19,37,0),
            new DateTime(1906,6,7,0,18,0),
            new DateTime(1906,7,8,10,44,0),
            new DateTime(1906,8,8,20,20,0),
            new DateTime(1906,9,8,22,45,0),
            new DateTime(1906,10,9,13,44,0),
            new DateTime(1906,11,8,16,16,0),
            new DateTime(1906,12,7,8,38,0),
            new DateTime(1907,1,6,19,40,0),
            new DateTime(1907,2,5,7,28,0),
            new DateTime(1907,3,6,1,56,0),
            new DateTime(1907,4,6,7,23,0),
            new DateTime(1907,5,6,1,22,0),
            new DateTime(1907,6,7,6,2,0),
            new DateTime(1907,7,8,16,28,0),
            new DateTime(1907,8,8,2,5,0),
            new DateTime(1907,9,9,4,31,0),
            new DateTime(1907,10,9,19,31,0),
            new DateTime(1907,11,8,22,5,0),
            new DateTime(1907,12,8,14,28,0),
            new DateTime(1908,1,6,1,30,0),
            new DateTime(1908,2,5,13,16,0),
            new DateTime(1908,3,6,7,42,0),
            new DateTime(1908,4,5,13,9,0),
            new DateTime(1908,5,6,7,7,0),
            new DateTime(1908,6,6,11,48,0),
            new DateTime(1908,7,7,22,17,0),
            new DateTime(1908,8,8,7,55,0),
            new DateTime(1908,9,8,10,21,0),
            new DateTime(1908,10,9,1,20,0),
            new DateTime(1908,11,8,3,51,0),
            new DateTime(1908,12,7,20,12,0),
            new DateTime(1909,1,6,7,14,0),
            new DateTime(1909,2,4,19,1,0),
            new DateTime(1909,3,6,13,30,0),
            new DateTime(1909,4,5,18,58,0),
            new DateTime(1909,5,6,13,0,0),
            new DateTime(1909,6,6,17,43,0),
            new DateTime(1909,7,8,4,13,0),
            new DateTime(1909,8,8,13,51,0),
            new DateTime(1909,9,8,16,15,0),
            new DateTime(1909,10,9,7,12,0),
            new DateTime(1909,11,8,9,42,0),
            new DateTime(1909,12,8,2,4,0),
            new DateTime(1910,1,6,13,7,0),
            new DateTime(1910,2,4,0,56,0),
            new DateTime(1910,3,6,19,25,0),
            new DateTime(1910,4,5,0,52,0),
            new DateTime(1910,5,6,18,48,0),
            new DateTime(1910,6,6,23,25,0),
            new DateTime(1910,7,8,9,50,0),
            new DateTime(1910,8,8,19,26,0),
            new DateTime(1910,9,8,21,51,0),
            new DateTime(1910,10,9,12,50,0),
            new DateTime(1910,11,8,15,22,0),
            new DateTime(1910,12,7,7,46,0),
            new DateTime(1911,1,6,18,50,0),
            new DateTime(1911,2,5,6,39,0),
            new DateTime(1911,3,6,1,8,0),
            new DateTime(1911,4,6,6,33,0),
            new DateTime(1911,5,6,0,29,0),
            new DateTime(1911,6,7,5,7,0),
            new DateTime(1911,7,8,15,34,0),
            new DateTime(1911,8,8,1,13,0),
            new DateTime(1911,9,9,3,42,0),
            new DateTime(1911,10,9,18,44,0),
            new DateTime(1911,11,8,21,16,0),
            new DateTime(1911,12,8,13,36,0),
            new DateTime(1912,1,6,0,36,0),
            new DateTime(1912,2,5,12,22,0),
            new DateTime(1912,3,6,6,50,0),
            new DateTime(1912,4,5,12,17,0),
            new DateTime(1912,5,6,6,16,0),
            new DateTime(1912,6,6,10,56,0),
            new DateTime(1912,7,7,21,26,0),
            new DateTime(1912,8,8,7,6,0),
            new DateTime(1912,9,8,9,35,0),
            new DateTime(1912,10,9,0,36,0),
            new DateTime(1912,11,8,3,7,0),
            new DateTime(1912,12,7,19,28,0),
            new DateTime(1913,1,6,6,27,0),
            new DateTime(1913,2,4,18,11,0),
            new DateTime(1913,3,6,12,38,0),
            new DateTime(1913,4,5,18,5,0),
            new DateTime(1913,5,6,12,3,0),
            new DateTime(1913,6,6,16,42,0),
            new DateTime(1913,7,8,3,8,0),
            new DateTime(1913,8,8,12,45,0),
            new DateTime(1913,9,8,15,11,0),
            new DateTime(1913,10,9,6,12,0),
            new DateTime(1913,11,8,8,47,0),
            new DateTime(1913,12,8,1,10,0),
            new DateTime(1914,1,6,12,12,0),
            new DateTime(1914,2,4,23,58,0),
            new DateTime(1914,3,6,18,25,0),
            new DateTime(1914,4,5,23,51,0),
            new DateTime(1914,5,6,17,49,0),
            new DateTime(1914,6,6,22,29,0),
            new DateTime(1914,7,8,8,56,0),
            new DateTime(1914,8,8,18,34,0),
            new DateTime(1914,9,8,21,1,0),
            new DateTime(1914,10,9,12,4,0),
            new DateTime(1914,11,8,14,40,0),
            new DateTime(1914,12,7,7,6,0),
            new DateTime(1915,1,5,18,9,0),
            new DateTime(1915,2,5,5,54,0),
            new DateTime(1915,3,7,0,17,0),
            new DateTime(1915,4,6,5,38,0),
            new DateTime(1915,5,6,23,32,0),
            new DateTime(1915,6,7,4,9,0),
            new DateTime(1915,7,8,14,37,0),
            new DateTime(1915,8,9,0,17,0),
            new DateTime(1915,9,9,2,46,0),
            new DateTime(1915,10,9,17,50,0),
            new DateTime(1915,11,8,20,27,0),
            new DateTime(1915,12,8,12,53,0),
            new DateTime(1916,1,6,23,57,0),
            new DateTime(1916,2,5,11,43,0),
            new DateTime(1916,3,6,6,6,0),
            new DateTime(1916,4,5,11,27,0),
            new DateTime(1916,5,6,5,19,0),
            new DateTime(1916,6,6,9,55,0),
            new DateTime(1916,7,7,20,21,0),
            new DateTime(1916,8,8,6,3,0),
            new DateTime(1916,9,8,8,33,0),
            new DateTime(1916,10,8,23,36,0),
            new DateTime(1916,11,8,2,10,0),
            new DateTime(1916,12,6,18,34,0),
            new DateTime(1917,1,6,5,37,0),
            new DateTime(1917,2,4,17,25,0),
            new DateTime(1917,3,6,11,53,0),
            new DateTime(1917,4,5,17,18,0),
            new DateTime(1917,5,6,11,14,0),
            new DateTime(1917,6,6,15,51,0),
            new DateTime(1917,7,8,1,18,0),
            new DateTime(1917,8,8,10,8,0),
            new DateTime(1917,9,8,13,27,0),
            new DateTime(1917,10,9,4,30,0),
            new DateTime(1917,11,8,7,5,0),
            new DateTime(1917,12,7,23,29,0),
            new DateTime(1918,1,6,11,32,0),
            new DateTime(1918,2,4,23,21,0),
            new DateTime(1918,3,6,17,49,0),
            new DateTime(1918,4,5,23,13,0),
            new DateTime(1918,5,6,17,6,0),
            new DateTime(1918,6,6,19,39,0),
            new DateTime(1918,7,8,6,0,0),
            new DateTime(1918,8,8,15,35,0),
            new DateTime(1918,9,8,18,3,0),
            new DateTime(1918,10,9,10,8,0),
            new DateTime(1918,11,8,12,47,0),
            new DateTime(1918,12,8,5,14,0),
            new DateTime(1919,1,6,16,19,0),
            new DateTime(1919,2,5,4,7,0),
            new DateTime(1919,3,6,22,33,0),
            new DateTime(1919,4,6,3,57,0),
            new DateTime(1919,5,6,21,50,0),
            new DateTime(1919,6,7,1,25,0),
            new DateTime(1919,7,8,12,20,0),
            new DateTime(1919,8,8,21,58,0),
            new DateTime(1919,9,9,1,28,0),
            new DateTime(1919,10,9,16,13,0),
            new DateTime(1919,11,8,19,11,0),
            new DateTime(1919,12,8,11,38,0),
            new DateTime(1920,1,6,22,41,0),
            new DateTime(1920,2,5,10,26,0),
            new DateTime(1920,3,6,4,51,0),
            new DateTime(1920,4,5,10,15,0),
            new DateTime(1920,5,6,4,11,0),
            new DateTime(1920,6,6,8,50,0),
            new DateTime(1920,7,7,19,19,0),
            new DateTime(1920,8,8,4,58,0),
            new DateTime(1920,9,8,7,27,0),
            new DateTime(1920,10,8,22,29,0),
            new DateTime(1920,11,8,1,5,0),
            new DateTime(1920,12,7,17,30,0),
            new DateTime(1921,1,6,4,34,0),
            new DateTime(1921,2,4,16,20,0),
            new DateTime(1921,3,6,9,45,0),
            new DateTime(1921,4,5,14,9,0),
            new DateTime(1921,5,6,8,4,0),
            new DateTime(1921,6,6,12,41,0),
            new DateTime(1921,7,7,23,7,0),
            new DateTime(1921,8,8,8,43,0),
            new DateTime(1921,9,8,12,10,0),
            new DateTime(1921,10,9,4,11,0),
            new DateTime(1921,11,8,6,45,0),
            new DateTime(1921,12,7,23,11,0),
            new DateTime(1922,1,6,10,17,0),
            new DateTime(1922,2,4,22,6,0),
            new DateTime(1922,3,6,16,34,0),
            new DateTime(1922,4,5,21,58,0),
            new DateTime(1922,5,6,15,53,0),
            new DateTime(1922,6,6,20,30,0),
            new DateTime(1922,7,8,6,57,0),
            new DateTime(1922,8,8,16,37,0),
            new DateTime(1922,9,8,19,6,0),
            new DateTime(1922,10,9,11,9,0),
            new DateTime(1922,11,8,13,45,0),
            new DateTime(1922,12,8,6,11,0),
            new DateTime(1923,1,6,17,14,0),
            new DateTime(1923,2,5,5,0,0),
            new DateTime(1923,3,5,23,24,0),
            new DateTime(1923,4,5,4,46,0),
            new DateTime(1923,5,5,22,38,0),
            new DateTime(1923,6,7,3,14,0),
            new DateTime(1923,7,8,13,42,0),
            new DateTime(1923,8,8,23,24,0),
            new DateTime(1923,9,9,1,57,0),
            new DateTime(1923,10,9,17,3,0),
            new DateTime(1923,11,8,19,40,0),
            new DateTime(1923,12,8,12,5,0),
            new DateTime(1924,1,6,23,6,0),
            new DateTime(1924,2,5,10,50,0),
            new DateTime(1924,3,6,5,12,0),
            new DateTime(1924,4,5,10,33,0),
            new DateTime(1924,5,6,4,26,0),
            new DateTime(1924,6,6,9,2,0),
            new DateTime(1924,7,7,19,29,0),
            new DateTime(1924,8,8,5,12,0),
            new DateTime(1924,9,8,7,46,0),
            new DateTime(1924,10,8,22,52,0),
            new DateTime(1924,11,8,1,29,0),
            new DateTime(1924,12,7,17,53,0),
            new DateTime(1925,1,6,4,53,0),
            new DateTime(1925,2,4,16,37,0),
            new DateTime(1925,3,6,11,0,0),
            new DateTime(1925,4,5,16,22,0),
            new DateTime(1925,5,6,10,18,0),
            new DateTime(1925,6,6,14,56,0),
            new DateTime(1925,7,8,1,25,0),
            new DateTime(1925,8,8,11,7,0),
            new DateTime(1925,9,8,13,40,0),
            new DateTime(1925,10,9,4,47,0),
            new DateTime(1925,11,8,7,26,0),
            new DateTime(1925,12,7,23,52,0),
            new DateTime(1926,1,6,10,54,0),
            new DateTime(1926,2,4,22,38,0),
            new DateTime(1926,3,6,17,0,0),
            new DateTime(1926,4,5,22,18,0),
            new DateTime(1926,5,6,16,8,0),
            new DateTime(1926,6,6,20,42,0),
            new DateTime(1926,7,8,7,6,0),
            new DateTime(1926,8,8,16,44,0),
            new DateTime(1926,9,8,19,16,0),
            new DateTime(1926,10,9,10,25,0),
            new DateTime(1926,11,8,13,8,0),
            new DateTime(1926,12,8,5,39,0),
            new DateTime(1927,1,6,16,45,0),
            new DateTime(1927,2,5,4,30,0),
            new DateTime(1927,3,6,22,50,0),
            new DateTime(1927,4,6,4,6,0),
            new DateTime(1927,5,6,21,53,0),
            new DateTime(1927,6,7,2,25,0),
            new DateTime(1927,7,8,12,50,0),
            new DateTime(1927,8,8,22,31,0),
            new DateTime(1927,9,9,1,5,0),
            new DateTime(1927,10,9,16,15,0),
            new DateTime(1927,11,8,18,15,0),
            new DateTime(1927,12,8,11,26,0),
            new DateTime(1928,1,6,22,31,0),
            new DateTime(1928,2,5,10,16,0),
            new DateTime(1928,3,6,4,37,0),
            new DateTime(1928,4,5,9,55,0),
            new DateTime(1928,5,6,3,43,0),
            new DateTime(1928,6,6,8,17,0),
            new DateTime(1928,7,7,18,44,0),
            new DateTime(1928,8,8,4,27,0),
            new DateTime(1928,9,8,7,2,0),
            new DateTime(1928,10,8,22,10,0),
            new DateTime(1928,11,8,0,49,0),
            new DateTime(1928,12,7,17,17,0),
            new DateTime(1929,1,6,4,22,0),
            new DateTime(1929,2,4,16,9,0),
            new DateTime(1929,3,6,10,32,0),
            new DateTime(1929,4,5,15,51,0),
            new DateTime(1929,5,6,9,40,0),
            new DateTime(1929,6,6,14,11,0),
            new DateTime(1929,7,6,0,32,0),
            new DateTime(1929,8,8,10,9,0),
            new DateTime(1929,9,8,12,40,0),
            new DateTime(1929,10,9,3,47,0),
            new DateTime(1929,11,8,6,27,0),
            new DateTime(1929,12,7,22,56,0),
            new DateTime(1930,1,6,10,3,0),
            new DateTime(1930,2,4,21,52,0),
            new DateTime(1930,3,6,16,17,0),
            new DateTime(1930,4,5,21,38,0),
            new DateTime(1930,5,6,15,28,0),
            new DateTime(1930,6,6,19,58,0),
            new DateTime(1930,7,8,5,20,0),
            new DateTime(1930,8,8,14,58,0),
            new DateTime(1930,9,8,17,29,0),
            new DateTime(1930,10,9,8,38,0),
            new DateTime(1930,11,8,11,21,0),
            new DateTime(1930,12,8,3,51,0),
            new DateTime(1931,1,6,14,56,0),
            new DateTime(1931,2,5,2,41,0),
            new DateTime(1931,3,6,21,3,0),
            new DateTime(1931,4,6,2,21,0),
            new DateTime(1931,5,6,20,10,0),
            new DateTime(1931,6,7,0,42,0),
            new DateTime(1931,7,4,11,6,0),
            new DateTime(1931,8,8,20,45,0),
            new DateTime(1931,9,8,23,18,0),
            new DateTime(1931,10,9,14,27,0),
            new DateTime(1931,11,8,17,10,0),
            new DateTime(1931,12,8,9,41,0),
            new DateTime(1932,1,6,20,46,0),
            new DateTime(1932,2,5,8,30,0),
            new DateTime(1932,3,6,2,50,0),
            new DateTime(1932,4,5,8,7,0),
            new DateTime(1932,5,6,1,55,0),
            new DateTime(1932,6,6,6,28,0),
            new DateTime(1932,7,7,16,53,0),
            new DateTime(1932,8,8,2,32,0),
            new DateTime(1932,9,8,5,3,0),
            new DateTime(1932,10,8,20,10,0),
            new DateTime(1932,11,7,22,50,0),
            new DateTime(1932,12,7,15,19,0),
            new DateTime(1933,1,6,2,24,0),
            new DateTime(1933,2,4,14,10,0),
            new DateTime(1933,3,6,8,32,0),
            new DateTime(1933,4,5,13,51,0),
            new DateTime(1933,5,6,7,42,0),
            new DateTime(1933,6,6,12,18,0),
            new DateTime(1933,7,7,22,45,0),
            new DateTime(1933,8,8,8,26,0),
            new DateTime(1933,9,8,10,58,0),
            new DateTime(1933,10,9,2,8,0),
            new DateTime(1933,11,8,4,4,0),
            new DateTime(1933,12,8,21,12,0),
            new DateTime(1934,1,7,8,17,0),
            new DateTime(1934,2,4,20,4,0),
            new DateTime(1934,3,5,14,27,0),
            new DateTime(1934,4,5,19,44,0),
            new DateTime(1934,5,6,13,31,0),
            new DateTime(1934,6,6,18,2,0),
            new DateTime(1934,7,8,4,25,0),
            new DateTime(1934,8,8,14,4,0),
            new DateTime(1934,9,8,16,37,0),
            new DateTime(1934,10,9,7,45,0),
            new DateTime(1934,11,8,10,27,0),
            new DateTime(1934,12,8,2,57,0),
            new DateTime(1935,1,6,14,3,0),
            new DateTime(1935,2,5,1,49,0),
            new DateTime(1935,3,6,20,11,0),
            new DateTime(1935,4,6,1,27,0),
            new DateTime(1935,5,6,19,12,0),
            new DateTime(1935,6,6,23,42,0),
            new DateTime(1935,7,8,10,6,0),
            new DateTime(1935,8,8,19,48,0),
            new DateTime(1935,9,8,22,25,0),
            new DateTime(1935,10,9,13,36,0),
            new DateTime(1935,11,8,16,18,0),
            new DateTime(1935,12,8,8,45,0),
            new DateTime(1936,1,6,19,47,0),
            new DateTime(1936,2,5,7,30,0),
            new DateTime(1936,3,6,1,50,0),
            new DateTime(1936,4,5,7,7,0),
            new DateTime(1936,5,6,0,57,0),
            new DateTime(1936,6,6,5,31,0),
            new DateTime(1936,7,7,15,59,0),
            new DateTime(1936,8,8,1,43,0),
            new DateTime(1936,9,8,4,21,0),
            new DateTime(1936,10,8,19,33,0),
            new DateTime(1936,11,7,22,15,0),
            new DateTime(1936,12,7,14,43,0),
            new DateTime(1937,1,6,1,44,0),
            new DateTime(1937,2,4,13,26,0),
            new DateTime(1937,3,6,7,45,0),
            new DateTime(1937,4,5,13,2,0),
            new DateTime(1937,5,6,6,51,0),
            new DateTime(1937,6,6,11,23,0),
            new DateTime(1937,7,7,21,46,0),
            new DateTime(1937,8,8,7,26,0),
            new DateTime(1937,9,8,10,0,0),
            new DateTime(1937,10,9,1,11,0),
            new DateTime(1937,11,8,3,56,0),
            new DateTime(1937,12,7,20,27,0),
            new DateTime(1938,1,6,7,32,0),
            new DateTime(1938,2,4,19,15,0),
            new DateTime(1938,3,6,13,34,0),
            new DateTime(1938,4,5,18,49,0),
            new DateTime(1938,5,6,12,36,0),
            new DateTime(1938,6,6,17,7,0),
            new DateTime(1938,7,8,3,32,0),
            new DateTime(1938,8,8,13,13,0),
            new DateTime(1938,9,8,15,49,0),
            new DateTime(1938,10,9,7,2,0),
            new DateTime(1938,11,8,9,49,0),
            new DateTime(1938,12,8,2,23,0),
            new DateTime(1939,1,6,13,28,0),
            new DateTime(1939,2,5,1,11,0),
            new DateTime(1939,3,6,19,27,0),
            new DateTime(1939,4,6,0,38,0),
            new DateTime(1939,5,6,18,21,0),
            new DateTime(1939,6,6,22,52,0),
            new DateTime(1939,7,8,9,19,0),
            new DateTime(1939,8,8,19,4,0),
            new DateTime(1939,9,8,21,42,0),
            new DateTime(1939,10,9,12,57,0),
            new DateTime(1939,11,8,15,40,0),
            new DateTime(1939,12,8,8,18,0),
            new DateTime(1940,1,6,19,24,0),
            new DateTime(1940,2,5,7,8,0),
            new DateTime(1940,3,6,1,24,0),
            new DateTime(1940,4,5,6,35,0),
            new DateTime(1940,5,6,0,16,0),
            new DateTime(1940,6,6,4,44,0),
            new DateTime(1940,7,7,15,8,0),
            new DateTime(1940,8,8,0,52,0),
            new DateTime(1940,9,8,3,30,0),
            new DateTime(1940,10,8,18,43,0),
            new DateTime(1940,11,7,21,27,0),
            new DateTime(1940,12,7,13,58,0),
            new DateTime(1941,1,6,1,4,0),
            new DateTime(1941,2,4,12,50,0),
            new DateTime(1941,3,6,7,10,0),
            new DateTime(1941,4,5,12,25,0),
            new DateTime(1941,5,6,6,10,0),
            new DateTime(1941,6,6,10,40,0),
            new DateTime(1941,7,7,21,3,0),
            new DateTime(1941,8,8,6,46,0),
            new DateTime(1941,9,8,9,24,0),
            new DateTime(1941,10,9,0,39,0),
            new DateTime(1941,11,8,3,25,0),
            new DateTime(1941,12,7,19,57,0),
            new DateTime(1942,1,6,7,3,0),
            new DateTime(1942,2,4,18,49,0),
            new DateTime(1942,3,6,13,10,0),
            new DateTime(1942,4,5,18,24,0),
            new DateTime(1942,5,6,12,7,0),
            new DateTime(1942,6,6,16,37,0),
            new DateTime(1942,7,8,2,52,0),
            new DateTime(1942,8,8,12,31,0),
            new DateTime(1942,9,8,15,7,0),
            new DateTime(1942,10,9,6,22,0),
            new DateTime(1942,11,8,9,12,0),
            new DateTime(1942,12,8,1,47,0),
            new DateTime(1943,1,6,12,55,0),
            new DateTime(1943,2,5,0,43,0),
            new DateTime(1943,3,6,18,59,0),
            new DateTime(1943,4,6,0,12,0),
            new DateTime(1943,5,6,17,54,0),
            new DateTime(1943,6,6,22,19,0),
            new DateTime(1943,7,8,8,39,0),
            new DateTime(1943,8,8,18,19,0),
            new DateTime(1943,9,8,20,56,0),
            new DateTime(1943,10,9,12,11,0),
            new DateTime(1943,11,8,14,59,0),
            new DateTime(1943,12,8,7,33,0),
            new DateTime(1944,1,6,18,40,0),
            new DateTime(1944,2,5,6,23,0),
            new DateTime(1944,3,6,0,41,0),
            new DateTime(1944,4,5,5,54,0),
            new DateTime(1944,5,5,23,40,0),
            new DateTime(1944,6,6,4,11,0),
            new DateTime(1944,7,7,14,37,0),
            new DateTime(1944,8,8,0,19,0),
            new DateTime(1944,9,8,2,56,0),
            new DateTime(1944,10,8,18,9,0),
            new DateTime(1944,11,7,20,55,0),
            new DateTime(1944,12,7,13,28,0),
            new DateTime(1945,1,6,0,35,0),
            new DateTime(1945,2,4,12,20,0),
            new DateTime(1945,3,6,6,38,0),
            new DateTime(1945,4,5,11,52,0),
            new DateTime(1945,5,6,5,37,0),
            new DateTime(1945,6,6,10,6,0),
            new DateTime(1945,7,7,20,27,0),
            new DateTime(1945,8,8,6,6,0),
            new DateTime(1945,9,8,8,39,0),
            new DateTime(1945,10,8,23,50,0),
            new DateTime(1945,11,8,2,35,0),
            new DateTime(1945,12,7,19,8,0),
            new DateTime(1946,1,6,6,17,0),
            new DateTime(1946,2,4,18,5,0),
            new DateTime(1946,3,6,12,25,0),
            new DateTime(1946,4,5,17,39,0),
            new DateTime(1946,5,6,11,22,0),
            new DateTime(1946,6,6,15,49,0),
            new DateTime(1946,7,8,2,11,0),
            new DateTime(1946,8,8,11,52,0),
            new DateTime(1946,9,8,14,28,0),
            new DateTime(1946,10,9,5,42,0),
            new DateTime(1946,11,8,8,28,0),
            new DateTime(1946,12,8,1,1,0),
            new DateTime(1947,1,6,12,11,0),
            new DateTime(1947,2,4,23,55,0),
            new DateTime(1947,3,6,18,12,0),
            new DateTime(1947,4,5,23,23,0),
            new DateTime(1947,5,6,17,5,0),
            new DateTime(1947,6,6,21,33,0),
            new DateTime(1947,7,8,7,56,0),
            new DateTime(1947,8,8,17,39,0),
            new DateTime(1947,9,8,20,17,0),
            new DateTime(1947,10,9,11,32,0),
            new DateTime(1947,11,8,14,19,0),
            new DateTime(1947,12,8,6,53,0),
            new DateTime(1948,1,6,18,1,0),
            new DateTime(1948,2,5,5,43,0),
            new DateTime(1948,3,5,23,58,0),
            new DateTime(1948,4,5,5,10,0),
            new DateTime(1948,5,5,22,53,0),
            new DateTime(1948,6,6,3,21,0),
            new DateTime(1948,7,7,13,44,0),
            new DateTime(1948,8,7,23,27,0),
            new DateTime(1948,9,8,2,6,0),
            new DateTime(1948,10,8,17,21,0),
            new DateTime(1948,11,7,20,7,0),
            new DateTime(1948,12,7,12,38,0),
            new DateTime(1949,1,5,23,42,0),
            new DateTime(1949,2,4,11,23,0),
            new DateTime(1949,3,6,5,40,0),
            new DateTime(1949,4,5,10,52,0),
            new DateTime(1949,5,6,4,37,0),
            new DateTime(1949,6,6,9,7,0),
            new DateTime(1949,7,7,19,32,0),
            new DateTime(1949,8,8,5,16,0),
            new DateTime(1949,9,8,7,55,0),
            new DateTime(1949,10,8,23,12,0),
            new DateTime(1949,11,8,2,0,0),
            new DateTime(1949,12,7,18,34,0),
            new DateTime(1950,1,6,5,39,0),
            new DateTime(1950,2,4,17,21,0),
            new DateTime(1950,3,6,11,36,0),
            new DateTime(1950,4,5,16,45,0),
            new DateTime(1950,5,6,10,25,0),
            new DateTime(1950,6,6,14,52,0),
            new DateTime(1950,7,8,1,14,0),
            new DateTime(1950,8,8,10,56,0),
            new DateTime(1950,9,8,13,34,0),
            new DateTime(1950,10,9,4,52,0),
            new DateTime(1950,11,8,7,44,0),
            new DateTime(1950,12,8,0,22,0),
            new DateTime(1951,1,6,11,31,0),
            new DateTime(1951,2,4,23,14,0),
            new DateTime(1951,3,6,17,27,0),
            new DateTime(1951,4,5,22,33,0),
            new DateTime(1951,5,6,16,10,0),
            new DateTime(1951,6,6,20,33,0),
            new DateTime(1951,7,8,6,54,0),
            new DateTime(1951,8,8,16,38,0),
            new DateTime(1951,9,8,19,19,0),
            new DateTime(1951,10,9,10,37,0),
            new DateTime(1951,11,8,13,27,0),
            new DateTime(1951,12,8,6,3,0),
            new DateTime(1952,1,6,17,10,0),
            new DateTime(1952,2,5,4,54,0),
            new DateTime(1952,3,5,23,8,0),
            new DateTime(1952,4,5,4,16,0),
            new DateTime(1952,5,5,21,54,0),
            new DateTime(1952,6,6,2,21,0),
            new DateTime(1952,7,7,12,45,0),
            new DateTime(1952,8,7,22,32,0),
            new DateTime(1952,9,8,1,4,0),
            new DateTime(1952,10,8,16,33,0),
            new DateTime(1952,11,7,19,22,0),
            new DateTime(1952,12,7,11,56,0),
            new DateTime(1953,1,5,23,3,0),
            new DateTime(1953,2,4,10,46,0),
            new DateTime(1953,3,6,5,3,0),
            new DateTime(1953,4,5,16,13,0),
            new DateTime(1953,5,6,3,53,0),
            new DateTime(1953,6,6,8,17,0),
            new DateTime(1953,7,7,18,36,0),
            new DateTime(1953,8,8,4,15,0),
            new DateTime(1953,9,8,6,54,0),
            new DateTime(1953,10,8,22,11,0),
            new DateTime(1953,11,8,1,2,0),
            new DateTime(1953,12,7,17,38,0),
            new DateTime(1954,1,6,4,46,0),
            new DateTime(1954,2,4,16,31,0),
            new DateTime(1954,3,6,10,49,0),
            new DateTime(1954,4,5,16,0,0),
            new DateTime(1954,5,6,9,39,0),
            new DateTime(1954,6,6,14,2,0),
            new DateTime(1954,7,8,0,20,0),
            new DateTime(1954,8,8,10,0,0),
            new DateTime(1954,9,8,12,39,0),
            new DateTime(1954,10,9,3,58,0),
            new DateTime(1954,11,8,6,51,0),
            new DateTime(1954,12,7,23,29,0),
            new DateTime(1955,1,6,10,36,0),
            new DateTime(1955,2,4,22,18,0),
            new DateTime(1955,3,6,16,32,0),
            new DateTime(1955,4,5,21,39,0),
            new DateTime(1955,5,6,15,18,0),
            new DateTime(1955,6,6,19,44,0),
            new DateTime(1955,7,8,6,7,0),
            new DateTime(1955,8,8,15,50,0),
            new DateTime(1955,9,8,18,32,0),
            new DateTime(1955,10,9,9,53,0),
            new DateTime(1955,11,8,12,46,0),
            new DateTime(1955,12,8,5,23,0),
            new DateTime(1956,1,6,16,31,0),
            new DateTime(1956,2,5,4,13,0),
            new DateTime(1956,3,5,22,25,0),
            new DateTime(1956,4,5,3,32,0),
            new DateTime(1956,5,5,21,11,0),
            new DateTime(1956,6,6,1,36,0),
            new DateTime(1956,7,7,11,59,0),
            new DateTime(1956,8,7,21,41,0),
            new DateTime(1956,9,8,0,20,0),
            new DateTime(1956,10,8,15,37,0),
            new DateTime(1956,11,7,18,27,0),
            new DateTime(1956,12,7,11,3,0),
            new DateTime(1957,1,5,22,11,0),
            new DateTime(1957,2,4,9,56,0),
            new DateTime(1957,3,6,4,11,0),
            new DateTime(1957,4,5,9,19,0),
            new DateTime(1957,5,6,2,59,0),
            new DateTime(1957,6,6,7,25,0),
            new DateTime(1957,7,7,17,49,0),
            new DateTime(1957,8,8,3,33,0),
            new DateTime(1957,9,8,6,13,0),
            new DateTime(1957,10,8,21,31,0),
            new DateTime(1957,11,8,0,21,0),
            new DateTime(1957,12,7,16,57,0),
            new DateTime(1958,1,6,4,5,0),
            new DateTime(1958,2,4,15,50,0),
            new DateTime(1958,3,6,10,6,0),
            new DateTime(1958,4,5,15,13,0),
            new DateTime(1958,5,6,8,50,0),
            new DateTime(1958,6,6,13,13,0),
            new DateTime(1958,7,7,23,34,0),
            new DateTime(1958,8,8,9,18,0),
            new DateTime(1958,9,8,12,0,0),
            new DateTime(1958,10,9,3,20,0),
            new DateTime(1958,11,8,6,13,0),
            new DateTime(1958,12,7,22,50,0),
            new DateTime(1959,1,6,9,59,0),
            new DateTime(1959,2,4,21,43,0),
            new DateTime(1959,3,6,15,57,0),
            new DateTime(1959,4,5,21,4,0),
            new DateTime(1959,5,6,14,39,0),
            new DateTime(1959,6,6,19,1,0),
            new DateTime(1959,7,8,5,21,0),
            new DateTime(1959,8,8,15,5,0),
            new DateTime(1959,9,8,17,49,0),
            new DateTime(1959,10,9,9,11,0),
            new DateTime(1959,11,8,12,3,0),
            new DateTime(1959,12,8,4,38,0),
            new DateTime(1960,1,6,15,43,0),
            new DateTime(1960,2,5,3,23,0),
            new DateTime(1960,3,5,21,36,0),
            new DateTime(1960,4,5,2,44,0),
            new DateTime(1960,5,5,20,23,0),
            new DateTime(1960,6,6,0,49,0),
            new DateTime(1960,7,7,11,13,0),
            new DateTime(1960,8,7,21,0,0),
            new DateTime(1960,9,7,23,46,0),
            new DateTime(1960,10,8,15,9,0),
            new DateTime(1960,11,7,18,2,0),
            new DateTime(1960,12,7,10,38,0),
            new DateTime(1961,1,5,21,43,0),
            new DateTime(1961,2,4,9,23,0),
            new DateTime(1961,3,6,3,35,0),
            new DateTime(1961,4,5,8,42,0),
            new DateTime(1961,5,6,2,21,0),
            new DateTime(1961,6,6,6,46,0),
            new DateTime(1961,7,7,17,7,0),
            new DateTime(1961,8,8,2,49,0),
            new DateTime(1961,9,8,5,29,0),
            new DateTime(1961,10,8,20,51,0),
            new DateTime(1961,11,7,23,46,0),
            new DateTime(1961,12,7,16,26,0),
            new DateTime(1962,1,6,3,35,0),
            new DateTime(1962,2,4,15,18,0),
            new DateTime(1962,3,6,9,30,0),
            new DateTime(1962,4,5,14,34,0),
            new DateTime(1962,5,6,8,10,0),
            new DateTime(1962,6,6,12,31,0),
            new DateTime(1962,7,7,22,51,0),
            new DateTime(1962,8,8,8,34,0),
            new DateTime(1962,9,8,11,16,0),
            new DateTime(1962,10,9,2,38,0),
            new DateTime(1962,11,8,5,35,0),
            new DateTime(1962,12,7,22,17,0),
            new DateTime(1963,1,6,9,27,0),
            new DateTime(1963,2,4,21,8,0),
            new DateTime(1963,3,6,15,17,0),
            new DateTime(1963,4,5,20,19,0),
            new DateTime(1963,5,6,13,52,0),
            new DateTime(1963,6,6,18,15,0),
            new DateTime(1963,7,8,4,38,0),
            new DateTime(1963,8,8,14,26,0),
            new DateTime(1963,9,8,17,12,0),
            new DateTime(1963,10,9,8,36,0),
            new DateTime(1963,11,8,11,32,0),
            new DateTime(1963,12,8,4,13,0),
            new DateTime(1964,1,6,15,22,0),
            new DateTime(1964,2,5,3,5,0),
            new DateTime(1964,3,5,21,6,0),
            new DateTime(1964,4,5,2,18,0),
            new DateTime(1964,5,5,19,51,0),
            new DateTime(1964,6,6,0,12,0),
            new DateTime(1964,7,7,10,32,0),
            new DateTime(1964,8,7,20,16,0),
            new DateTime(1964,9,7,23,0,0),
            new DateTime(1964,10,8,14,22,0),
            new DateTime(1964,11,7,17,15,0),
            new DateTime(1964,12,7,9,53,0),
            new DateTime(1965,1,5,21,2,0),
            new DateTime(1965,2,4,8,46,0),
            new DateTime(1965,3,6,3,1,0),
            new DateTime(1965,4,5,8,7,0),
            new DateTime(1965,5,6,1,42,0),
            new DateTime(1965,6,6,6,2,0),
            new DateTime(1965,7,7,16,22,0),
            new DateTime(1965,8,8,2,5,0),
            new DateTime(1965,9,8,4,48,0),
            new DateTime(1965,10,8,20,11,0),
            new DateTime(1965,11,7,23,7,0),
            new DateTime(1965,12,7,15,46,0),
            new DateTime(1966,1,6,2,55,0),
            new DateTime(1966,2,4,14,38,0),
            new DateTime(1966,3,3,5,20,0),
            new DateTime(1966,4,5,13,57,0),
            new DateTime(1966,5,6,7,31,0),
            new DateTime(1966,6,6,11,50,0),
            new DateTime(1966,7,7,22,7,0),
            new DateTime(1966,8,8,7,49,0),
            new DateTime(1966,9,8,10,32,0),
            new DateTime(1966,10,9,1,57,0),
            new DateTime(1966,11,8,4,56,0),
            new DateTime(1966,12,7,21,38,0),
            new DateTime(1967,1,6,8,48,0),
            new DateTime(1967,2,4,20,11,0),
            new DateTime(1967,3,6,14,42,0),
            new DateTime(1967,4,5,19,45,0),
            new DateTime(1967,5,6,13,18,0),
            new DateTime(1967,6,6,17,36,0),
            new DateTime(1967,7,8,3,54,0),
            new DateTime(1967,8,8,13,35,0),
            new DateTime(1967,9,8,16,18,0),
            new DateTime(1967,10,9,7,42,0),
            new DateTime(1967,11,8,10,38,0),
            new DateTime(1967,12,8,3,18,0),
            new DateTime(1968,1,6,14,26,0),
            new DateTime(1968,2,5,2,8,0),
            new DateTime(1968,3,5,20,18,0),
            new DateTime(1968,4,5,1,21,0),
            new DateTime(1968,5,5,18,56,0),
            new DateTime(1968,6,5,23,19,0),
            new DateTime(1968,7,7,9,42,0),
            new DateTime(1968,8,7,19,27,0),
            new DateTime(1968,9,7,22,12,0),
            new DateTime(1968,10,8,13,35,0),
            new DateTime(1968,11,7,16,29,0),
            new DateTime(1968,12,7,9,9,0),
            new DateTime(1969,1,5,20,17,0),
            new DateTime(1969,2,4,7,59,0),
            new DateTime(1969,3,6,2,11,0),
            new DateTime(1969,4,5,7,15,0),
            new DateTime(1969,5,6,0,50,0),
            new DateTime(1969,6,6,5,12,0),
            new DateTime(1969,7,7,15,32,0),
            new DateTime(1969,8,8,1,14,0),
            new DateTime(1969,9,8,3,56,0),
            new DateTime(1969,10,8,19,17,0),
            new DateTime(1969,11,7,22,12,0),
            new DateTime(1969,12,7,14,51,0),
            new DateTime(1970,1,6,1,59,0),
            new DateTime(1970,2,4,13,46,0),
            new DateTime(1970,3,6,7,58,0),
            new DateTime(1970,4,5,13,2,0),
            new DateTime(1970,5,6,6,28,0),
            new DateTime(1970,6,6,10,51,0),
            new DateTime(1970,7,7,21,14,0),
            new DateTime(1970,8,8,6,58,0),
            new DateTime(1970,9,8,9,42,0),
            new DateTime(1970,10,9,1,6,0),
            new DateTime(1970,11,8,4,1,0),
            new DateTime(1970,12,7,20,41,0),
            new DateTime(1971,1,6,7,45,0),
            new DateTime(1971,2,4,19,26,0),
            new DateTime(1971,3,6,13,35,0),
            new DateTime(1971,4,5,18,36,0),
            new DateTime(1971,5,6,12,8,0),
            new DateTime(1971,6,6,16,29,0),
            new DateTime(1971,7,8,2,51,0),
            new DateTime(1971,8,8,12,40,0),
            new DateTime(1971,9,8,15,30,0),
            new DateTime(1971,10,9,6,59,0),
            new DateTime(1971,11,8,9,57,0),
            new DateTime(1971,12,8,2,36,0),
            new DateTime(1972,1,6,13,43,0),
            new DateTime(1972,2,5,1,20,0),
            new DateTime(1972,3,5,19,28,0),
            new DateTime(1972,4,5,0,29,0),
            new DateTime(1972,5,5,18,1,0),
            new DateTime(1972,6,5,22,22,0),
            new DateTime(1972,7,7,8,43,0),
            new DateTime(1972,8,7,18,29,0),
            new DateTime(1972,9,7,21,15,0),
            new DateTime(1972,10,8,12,42,0),
            new DateTime(1972,11,7,15,40,0),
            new DateTime(1972,12,7,8,19,0),
            new DateTime(1973,1,5,19,26,0),
            new DateTime(1973,2,4,7,4,0),
            new DateTime(1973,3,6,1,13,0),
            new DateTime(1973,4,5,6,14,0),
            new DateTime(1973,5,5,23,47,0),
            new DateTime(1973,6,6,4,7,0),
            new DateTime(1973,7,7,14,28,0),
            new DateTime(1973,8,8,0,13,0),
            new DateTime(1973,9,8,3,0,0),
            new DateTime(1973,10,8,18,27,0),
            new DateTime(1973,11,7,21,28,0),
            new DateTime(1973,12,7,14,11,0),
            new DateTime(1974,1,6,1,20,0),
            new DateTime(1974,2,4,13,0,0),
            new DateTime(1974,3,6,7,7,0),
            new DateTime(1974,4,5,12,5,0),
            new DateTime(1974,5,6,5,34,0),
            new DateTime(1974,6,6,9,52,0),
            new DateTime(1974,7,7,20,13,0),
            new DateTime(1974,8,8,5,57,0),
            new DateTime(1974,9,8,8,45,0),
            new DateTime(1974,10,9,0,15,0),
            new DateTime(1974,11,8,3,18,0),
            new DateTime(1974,12,7,20,5,0),
            new DateTime(1975,1,6,7,18,0),
            new DateTime(1975,2,4,18,59,0),
            new DateTime(1975,3,6,13,6,0),
            new DateTime(1975,4,5,18,2,0),
            new DateTime(1975,5,6,11,27,0),
            new DateTime(1975,6,6,15,42,0),
            new DateTime(1975,7,8,2,0,0),
            new DateTime(1975,8,8,11,45,0),
            new DateTime(1975,9,8,14,33,0),
            new DateTime(1975,10,9,6,2,0),
            new DateTime(1975,11,8,9,3,0),
            new DateTime(1975,12,8,1,46,0),
            new DateTime(1976,1,6,12,58,0),
            new DateTime(1976,2,5,0,40,0),
            new DateTime(1976,3,5,18,48,0),
            new DateTime(1976,4,4,23,47,0),
            new DateTime(1976,5,5,17,15,0),
            new DateTime(1976,6,5,21,31,0),
            new DateTime(1976,7,7,7,51,0),
            new DateTime(1976,8,7,17,39,0),
            new DateTime(1976,9,7,20,28,0),
            new DateTime(1976,10,8,11,58,0),
            new DateTime(1976,11,7,14,59,0),
            new DateTime(1976,12,7,7,41,0),
            new DateTime(1977,1,5,18,51,0),
            new DateTime(1977,2,4,6,34,0),
            new DateTime(1977,3,6,0,44,0),
            new DateTime(1977,4,5,5,46,0),
            new DateTime(1977,5,5,23,16,0),
            new DateTime(1977,6,6,3,32,0),
            new DateTime(1977,7,7,13,48,0),
            new DateTime(1977,8,7,23,30,0),
            new DateTime(1977,9,8,2,16,0),
            new DateTime(1977,10,8,17,44,0),
            new DateTime(1977,11,7,20,46,0),
            new DateTime(1977,12,7,13,31,0),
            new DateTime(1978,1,6,0,43,0),
            new DateTime(1978,2,4,12,27,0),
            new DateTime(1978,3,6,6,38,0),
            new DateTime(1978,4,5,11,39,0),
            new DateTime(1978,5,6,5,9,0),
            new DateTime(1978,6,6,9,23,0),
            new DateTime(1978,7,7,19,37,0),
            new DateTime(1978,8,8,5,18,0),
            new DateTime(1978,9,8,8,3,0),
            new DateTime(1978,10,8,23,31,0),
            new DateTime(1978,11,8,2,34,0),
            new DateTime(1978,12,7,19,20,0),
            new DateTime(1979,1,6,6,32,0),
            new DateTime(1979,2,4,18,13,0),
            new DateTime(1979,3,6,12,20,0),
            new DateTime(1979,4,5,17,18,0),
            new DateTime(1979,5,6,10,47,0),
            new DateTime(1979,6,6,15,5,0),
            new DateTime(1979,7,8,1,25,0),
            new DateTime(1979,8,8,11,11,0),
            new DateTime(1979,9,8,14,0,0),
            new DateTime(1979,10,9,5,30,0),
            new DateTime(1979,11,8,8,33,0),
            new DateTime(1979,12,8,1,18,0),
            new DateTime(1980,1,6,12,29,0),
            new DateTime(1980,2,5,0,10,0),
            new DateTime(1980,3,5,18,17,0),
            new DateTime(1980,4,4,23,15,0),
            new DateTime(1980,5,5,16,45,0),
            new DateTime(1980,6,5,21,4,0),
            new DateTime(1980,7,7,7,24,0),
            new DateTime(1980,8,7,7,9,0),
            new DateTime(1980,9,7,19,54,0),
            new DateTime(1980,10,8,11,19,0),
            new DateTime(1980,11,7,14,18,0),
            new DateTime(1980,12,7,7,2,0),
            new DateTime(1981,1,5,18,13,0),
            new DateTime(1981,2,4,5,56,0),
            new DateTime(1981,3,6,0,5,0),
            new DateTime(1981,4,5,5,5,0),
            new DateTime(1981,5,5,22,35,0),
            new DateTime(1981,6,6,2,53,0),
            new DateTime(1981,7,7,13,12,0),
            new DateTime(1981,8,7,22,57,0),
            new DateTime(1981,9,8,1,43,0),
            new DateTime(1981,10,8,17,10,0),
            new DateTime(1981,11,7,20,9,0),
            new DateTime(1981,12,7,12,51,0),
            new DateTime(1982,1,6,0,3,0),
            new DateTime(1982,2,4,11,46,0),
            new DateTime(1982,3,6,5,55,0),
            new DateTime(1982,4,5,10,53,0),
            new DateTime(1982,5,6,4,20,0),
            new DateTime(1982,6,6,8,36,0),
            new DateTime(1982,7,7,18,55,0),
            new DateTime(1982,8,8,4,42,0),
            new DateTime(1982,9,8,7,32,0),
            new DateTime(1982,10,8,23,2,0),
            new DateTime(1982,11,8,2,4,0),
            new DateTime(1982,12,7,18,48,0),
            new DateTime(1983,1,6,5,59,0),
            new DateTime(1983,2,4,17,40,0),
            new DateTime(1983,3,6,11,47,0),
            new DateTime(1983,4,5,16,45,0),
            new DateTime(1983,5,6,10,11,0),
            new DateTime(1983,6,6,14,26,0),
            new DateTime(1983,7,8,0,43,0),
            new DateTime(1983,8,8,10,30,0),
            new DateTime(1983,9,8,13,20,0),
            new DateTime(1983,10,9,4,51,0),
            new DateTime(1983,11,8,7,53,0),
            new DateTime(1983,12,8,0,34,0),
            new DateTime(1984,1,6,11,41,0),
            new DateTime(1984,2,4,23,19,0),
            new DateTime(1984,3,5,17,25,0),
            new DateTime(1984,4,4,22,22,0),
            new DateTime(1984,5,5,15,51,0),
            new DateTime(1984,6,5,20,9,0),
            new DateTime(1984,7,7,6,29,0),
            new DateTime(1984,8,7,16,18,0),
            new DateTime(1984,9,7,19,10,0),
            new DateTime(1984,10,8,10,43,0),
            new DateTime(1984,11,7,13,45,0),
            new DateTime(1984,12,7,6,28,0),
            new DateTime(1985,1,5,17,35,0),
            new DateTime(1985,2,4,5,12,0),
            new DateTime(1985,3,5,23,16,0),
            new DateTime(1985,4,5,4,14,0),
            new DateTime(1985,5,5,21,43,0),
            new DateTime(1985,6,6,2,0,0),
            new DateTime(1985,7,7,12,19,0),
            new DateTime(1985,8,7,22,4,0),
            new DateTime(1985,9,8,0,53,0),
            new DateTime(1985,10,8,16,25,0),
            new DateTime(1985,11,7,19,29,0),
            new DateTime(1985,12,7,12,16,0),
            new DateTime(1986,1,5,23,39,0),
            new DateTime(1986,2,4,11,8,0),
            new DateTime(1986,3,6,5,12,0),
            new DateTime(1986,4,5,10,6,0),
            new DateTime(1986,5,6,3,30,0),
            new DateTime(1986,6,6,7,44,0),
            new DateTime(1986,7,7,18,1,0),
            new DateTime(1986,8,8,3,46,0),
            new DateTime(1986,9,8,6,34,0),
            new DateTime(1986,10,8,22,6,0),
            new DateTime(1986,11,8,1,13,0),
            new DateTime(1986,12,7,18,1,0),
            new DateTime(1987,1,6,5,13,0),
            new DateTime(1987,2,4,16,52,0),
            new DateTime(1987,3,6,10,53,0),
            new DateTime(1987,4,5,15,44,0),
            new DateTime(1987,5,6,9,5,0),
            new DateTime(1987,6,6,13,19,0),
            new DateTime(1987,7,7,23,39,0),
            new DateTime(1987,8,8,9,30,0),
            new DateTime(1987,9,8,12,25,0),
            new DateTime(1987,10,9,4,0,0),
            new DateTime(1987,11,8,7,6,0),
            new DateTime(1987,12,7,23,53,0),
            new DateTime(1988,1,6,11,4,0),
            new DateTime(1988,2,4,22,44,0),
            new DateTime(1988,3,5,16,47,0),
            new DateTime(1988,4,4,21,40,0),
            new DateTime(1988,5,5,15,2,0),
            new DateTime(1988,6,5,19,15,0),
            new DateTime(1988,7,7,5,34,0),
            new DateTime(1988,8,7,15,21,0),
            new DateTime(1988,9,7,18,12,0),
            new DateTime(1988,10,8,9,45,0),
            new DateTime(1988,11,7,12,50,0),
            new DateTime(1988,12,7,5,35,0),
            new DateTime(1989,1,5,16,46,0),
            new DateTime(1989,2,4,4,28,0),
            new DateTime(1989,3,5,22,35,0),
            new DateTime(1989,4,5,3,30,0),
            new DateTime(1989,5,5,20,54,0),
            new DateTime(1989,6,6,1,5,0),
            new DateTime(1989,7,7,11,19,0),
            new DateTime(1989,8,7,21,4,0),
            new DateTime(1989,9,8,23,54,0),
            new DateTime(1989,10,8,15,28,0),
            new DateTime(1989,11,7,18,34,0),
            new DateTime(1989,12,7,11,22,0),
            new DateTime(1990,1,5,22,34,0),
            new DateTime(1990,2,4,10,55,0),
            new DateTime(1990,3,6,4,20,0),
            new DateTime(1990,4,5,9,13,0),
            new DateTime(1990,5,6,2,36,0),
            new DateTime(1990,6,6,6,47,0),
            new DateTime(1990,7,7,17,1,0),
            new DateTime(1990,8,8,2,46,0),
            new DateTime(1990,9,8,5,37,0),
            new DateTime(1990,10,8,21,14,0),
            new DateTime(1990,11,8,0,24,0),
            new DateTime(1990,12,7,17,19,0),
            new DateTime(1991,1,6,4,29,0),
            new DateTime(1991,2,4,16,9,0),
            new DateTime(1991,3,6,10,13,0),
            new DateTime(1991,4,5,15,5,0),
            new DateTime(1991,5,6,8,27,0),
            new DateTime(1991,6,6,12,38,0),
            new DateTime(1991,7,7,22,53,0),
            new DateTime(1991,8,8,8,38,0),
            new DateTime(1991,9,8,11,28,0),
            new DateTime(1991,10,9,3,2,0),
            new DateTime(1991,11,8,6,8,0),
            new DateTime(1991,12,7,22,56,0),
            new DateTime(1992,1,6,10,9,0),
            new DateTime(1992,2,4,21,49,0),
            new DateTime(1992,3,5,15,52,0),
            new DateTime(1992,4,4,20,45,0),
            new DateTime(1992,5,5,14,9,0),
            new DateTime(1992,6,5,18,23,0),
            new DateTime(1992,7,7,4,40,0),
            new DateTime(1992,8,7,14,27,0),
            new DateTime(1992,9,7,17,18,0),
            new DateTime(1992,10,8,8,52,0),
            new DateTime(1992,11,7,11,58,0),
            new DateTime(1992,12,7,4,45,0),
            new DateTime(1993,1,5,15,57,0),
            new DateTime(1993,2,4,3,38,0),
            new DateTime(1993,3,5,21,43,0),
            new DateTime(1993,4,5,2,37,0),
            new DateTime(1993,5,5,20,2,0),
            new DateTime(1993,6,6,0,16,0),
            new DateTime(1993,7,7,10,32,0),
            new DateTime(1993,8,7,20,18,0),
            new DateTime(1993,9,7,23,8,0),
            new DateTime(1993,10,8,14,40,0),
            new DateTime(1993,11,7,17,46,0),
            new DateTime(1993,12,7,10,34,0),
            new DateTime(1994,1,5,21,49,0),
            new DateTime(1994,2,4,9,31,0),
            new DateTime(1994,3,6,3,38,0),
            new DateTime(1994,4,5,8,32,0),
            new DateTime(1994,5,6,1,54,0),
            new DateTime(1994,6,6,6,5,0),
            new DateTime(1994,7,7,16,19,0),
            new DateTime(1994,8,8,2,5,0),
            new DateTime(1994,9,8,4,55,0),
            new DateTime(1994,10,8,20,29,0),
            new DateTime(1994,11,7,23,36,0),
            new DateTime(1994,12,7,16,23,0),
            new DateTime(1995,1,6,3,34,0),
            new DateTime(1995,2,4,15,13,0),
            new DateTime(1995,3,6,9,16,0),
            new DateTime(1995,4,5,14,8,0),
            new DateTime(1995,5,6,7,30,0),
            new DateTime(1995,6,6,11,43,0),
            new DateTime(1995,7,7,22,1,0),
            new DateTime(1995,8,8,7,52,0),
            new DateTime(1995,9,8,10,49,0),
            new DateTime(1995,10,9,2,28,0),
            new DateTime(1995,11,8,5,36,0),
            new DateTime(1995,12,7,22,23,0),
            new DateTime(1996,1,6,9,32,0),
            new DateTime(1996,2,4,21,8,0),
            new DateTime(1996,3,5,15,10,0),
            new DateTime(1996,4,4,20,2,0),
            new DateTime(1996,5,5,13,26,0),
            new DateTime(1996,6,5,17,41,0),
            new DateTime(1996,7,7,4,0,0),
            new DateTime(1996,8,7,13,49,0),
            new DateTime(1996,9,7,16,43,0),
            new DateTime(1996,10,8,8,19,0),
            new DateTime(1996,11,7,11,27,0),
            new DateTime(1996,12,7,4,14,0),
            new DateTime(1997,1,5,15,25,0),
            new DateTime(1997,2,4,3,2,0),
            new DateTime(1997,3,5,21,5,0),
            new DateTime(1997,4,5,1,57,0),
            new DateTime(1997,5,5,19,20,0),
            new DateTime(1997,6,5,23,33,0),
            new DateTime(1997,7,7,9,50,0),
            new DateTime(1997,8,7,19,36,0),
            new DateTime(1997,9,7,22,29,0),
            new DateTime(1997,10,8,14,6,0),
            new DateTime(1997,11,7,17,15,0),
            new DateTime(1997,12,7,10,5,0),
            new DateTime(1998,1,5,21,19,0),
            new DateTime(1998,2,4,8,57,0),
            new DateTime(1998,3,6,2,58,0),
            new DateTime(1998,4,5,7,45,0),
            new DateTime(1998,5,6,1,3,0),
            new DateTime(1998,6,6,5,13,0),
            new DateTime(1998,7,7,15,31,0),
            new DateTime(1998,8,8,1,20,0),
            new DateTime(1998,9,8,4,16,0),
            new DateTime(1998,10,8,19,56,0),
            new DateTime(1998,11,7,23,9,0),
            new DateTime(1998,12,7,16,2,0),
            new DateTime(1999,1,6,3,10,0),
            new DateTime(1999,2,4,14,58,0),
            new DateTime(1999,3,6,8,58,0),
            new DateTime(1999,4,5,13,45,0),
            new DateTime(1999,5,6,7,1,0),
            new DateTime(1999,6,6,11,9,0),
            new DateTime(1999,7,7,21,25,0),
            new DateTime(1999,8,8,7,15,0),
            new DateTime(1999,9,8,10,11,0),
            new DateTime(1999,10,9,1,49,0),
            new DateTime(1999,11,8,4,58,0),
            new DateTime(1999,12,7,21,48,0),
            new DateTime(2000,1,6,9,1,0),
            new DateTime(2000,2,4,20,41,0),
            new DateTime(2000,3,5,14,43,0),
            new DateTime(2000,4,4,19,32,0),
            new DateTime(2000,5,5,12,51,0),
            new DateTime(2000,6,5,16,59,0),
            new DateTime(2000,7,7,3,14,0),
            new DateTime(2000,8,7,13,3,0),
            new DateTime(2000,9,7,16,0,0),
            new DateTime(2000,10,8,7,39,0),
            new DateTime(2000,11,7,10,49,0),
            new DateTime(2000,12,7,3,38,0),
            new DateTime(2001,1,5,14,51,0),
            new DateTime(2001,2,4,2,30,0),
            new DateTime(2001,3,5,20,34,0),
            new DateTime(2001,4,5,1,26,0),
            new DateTime(2001,5,5,18,46,0),
            new DateTime(2001,6,5,22,56,0),
            new DateTime(2001,7,7,9,8,0),
            new DateTime(2001,8,7,18,53,0),
            new DateTime(2001,9,7,21,47,0),
            new DateTime(2001,10,8,13,26,0),
            new DateTime(2001,11,7,16,38,0),
            new DateTime(2001,12,7,9,30,0),
            new DateTime(2002,1,5,20,45,0),
            new DateTime(2002,2,4,8,26,0),
            new DateTime(2002,3,6,2,29,0),
            new DateTime(2002,4,5,7,19,0),
            new DateTime(2002,5,6,0,39,0),
            new DateTime(2002,6,6,4,46,0),
            new DateTime(2002,7,7,14,57,0),
            new DateTime(2002,8,8,0,41,0),
            new DateTime(2002,9,8,3,32,0),
            new DateTime(2002,10,8,19,11,0),
            new DateTime(2002,11,7,22,23,0),
            new DateTime(2002,12,7,15,16,0),
            new DateTime(2003,1,6,2,29,0),
            new DateTime(2003,2,4,14,7,0),
            new DateTime(2003,3,6,8,6,0),
            new DateTime(2003,4,5,12,54,0),
            new DateTime(2003,5,6,6,12,0),
            new DateTime(2003,6,6,10,21,0),
            new DateTime(2003,7,7,20,37,0),
            new DateTime(2003,8,8,6,26,0),
            new DateTime(2003,9,8,9,22,0),
            new DateTime(2003,10,9,1,2,0),
            new DateTime(2003,11,8,4,15,0),
            new DateTime(2003,12,7,21,7,0),
            new DateTime(2004,1,6,8,20,0),
            new DateTime(2004,2,4,19,58,0),
            new DateTime(2004,3,5,13,57,0),
            new DateTime(2004,4,4,18,44,0),
            new DateTime(2004,5,5,12,4,0),
            new DateTime(2004,6,5,16,15,0),
            new DateTime(2004,7,7,2,33,0),
            new DateTime(2004,8,7,12,21,0),
            new DateTime(2004,9,7,15,14,0),
            new DateTime(2004,10,8,6,51,0),
            new DateTime(2004,11,7,10,0,0),
            new DateTime(2004,12,7,2,50,0),
            new DateTime(2005,1,5,14,5,0),
            new DateTime(2005,2,4,1,45,0),
            new DateTime(2005,3,5,19,47,0),
            new DateTime(2005,4,5,0,36,0),
            new DateTime(2005,5,5,17,54,0),
            new DateTime(2005,6,5,22,3,0),
            new DateTime(2005,7,7,8,18,0),
            new DateTime(2005,8,7,18,4,0),
            new DateTime(2005,9,7,20,58,0),
            new DateTime(2005,10,8,12,35,0),
            new DateTime(2005,11,7,15,44,0),
            new DateTime(2005,12,7,8,34,0),
            new DateTime(2006,1,5,19,49,0),
            new DateTime(2006,2,4,7,29,0),
            new DateTime(2006,3,6,1,30,0),
            new DateTime(2006,4,5,6,17,0),
            new DateTime(2006,5,5,23,32,0),
            new DateTime(2006,6,6,3,38,0),
            new DateTime(2006,7,7,13,53,0),
            new DateTime(2006,8,7,23,42,0),
            new DateTime(2006,9,8,2,40,0),
            new DateTime(2006,10,8,18,23,0),
            new DateTime(2006,11,7,21,36,0),
            new DateTime(2006,12,7,14,28,0),
            new DateTime(2007,1,6,1,42,0),
            new DateTime(2007,2,4,13,20,0),
            new DateTime(2007,3,6,7,19,0),
            new DateTime(2007,4,5,12,6,0),
            new DateTime(2007,5,6,5,21,0),
            new DateTime(2007,6,6,9,28,0),
            new DateTime(2007,7,7,19,43,0),
            new DateTime(2007,8,8,10,38,0),
            new DateTime(2007,9,8,8,31,0),
            new DateTime(2007,10,9,0,13,0),
            new DateTime(2007,11,8,3,25,0),
            new DateTime(2007,12,7,20,16,0),
            new DateTime(2008,1,6,7,26,0),
            new DateTime(2008,2,4,19,2,0),
            new DateTime(2008,3,5,13,5,0),
            new DateTime(2008,4,4,17,47,0),
            new DateTime(2008,5,5,11,5,0),
            new DateTime(2008,6,5,15,13,0),
            new DateTime(2008,7,7,1,28,0),
            new DateTime(2008,8,7,11,17,0),
            new DateTime(2008,9,7,14,15,0),
            new DateTime(2008,10,8,5,58,0),
            new DateTime(2008,11,7,9,12,0),
            new DateTime(2008,12,7,2,4,0),
            new DateTime(2009,1,5,13,16,0),
            new DateTime(2009,2,4,0,51,0),
            new DateTime(2009,3,5,18,49,0),
            new DateTime(2009,4,4,23,35,0),
            new DateTime(2009,5,5,16,52,0),
            new DateTime(2009,6,5,21,0,0),
            new DateTime(2009,7,7,7,15,0),
            new DateTime(2009,8,7,17,2,0),
            new DateTime(2009,9,7,19,59,0),
            new DateTime(2009,10,8,11,41,0),
            new DateTime(2009,11,7,14,58,0),
            new DateTime(2009,12,7,7,54,0),
            new DateTime(2010,1,5,19,10,0),
            new DateTime(2010,2,4,6,49,0),
            new DateTime(2010,3,6,8,48,0),
            new DateTime(2010,4,5,5,32,0),
            new DateTime(2010,5,5,22,45,0),
            new DateTime(2010,6,6,2,51,0),
            new DateTime(2010,7,7,13,4,0),
            new DateTime(2010,8,7,22,50,0),
            new DateTime(2010,9,8,1,46,0),
            new DateTime(2010,10,8,12,28,0),
            new DateTime(2010,11,7,20,44,0),
            new DateTime(2010,12,7,13,40,0),
            new DateTime(2011,1,6,0,56,0),
            new DateTime(2011,2,4,12,34,0),
            new DateTime(2011,3,6,6,31,0),
            new DateTime(2011,4,5,11,13,0),
            new DateTime(2011,5,6,4,25,0),
            new DateTime(2011,6,6,8,28,0),
            new DateTime(2011,7,7,18,43,0),
            new DateTime(2011,8,8,4,35,0),
            new DateTime(2011,9,8,7,36,0),
            new DateTime(2011,10,8,23,20,0),
            new DateTime(2011,11,8,2,37,0),
            new DateTime(2011,12,7,19,30,0),
            new DateTime(2012,1,6,6,45,0),
            new DateTime(2012,2,4,18,24,0),
            new DateTime(2012,3,5,12,23,0),
            new DateTime(2012,4,4,17,7,0),
            new DateTime(2012,5,5,10,21,0),
            new DateTime(2012,6,5,14,27,0),
            new DateTime(2012,7,7,0,42,0),
            new DateTime(2012,8,7,10,32,0),
            new DateTime(2012,9,7,13,30,0),
            new DateTime(2012,10,8,5,13,0),
            new DateTime(2012,11,7,8,27,0),
            new DateTime(2012,12,7,1,21,0),
            new DateTime(2013,1,5,12,35,0),
            new DateTime(2013,2,4,0,15,0),
            new DateTime(2013,3,5,18,16,0),
            new DateTime(2013,4,4,23,4,0),
            new DateTime(2013,5,5,16,20,0),
            new DateTime(2013,6,5,20,24,0),
            new DateTime(2013,7,7,6,36,0),
            new DateTime(2013,8,7,16,22,0),
            new DateTime(2013,9,7,19,18,0),
            new DateTime(2013,10,8,11,0,0),
            new DateTime(2013,11,7,14,15,0),
            new DateTime(2013,12,7,7,10,0),
            new DateTime(2014,1,5,18,26,0),
            new DateTime(2014,2,4,6,5,0),
            new DateTime(2014,3,6,0,4,0),
            new DateTime(2014,4,5,4,48,0),
            new DateTime(2014,5,5,22,1,0),
            new DateTime(2014,6,6,2,4,0),
            new DateTime(2014,7,7,12,16,0),
            new DateTime(2014,8,7,22,4,0),
            new DateTime(2014,9,8,1,3,0),
            new DateTime(2014,10,8,16,49,0),
            new DateTime(2014,11,7,20,8,0),
            new DateTime(2014,12,7,13,6,0),
            new DateTime(2015,1,6,0,22,0),
            new DateTime(2015,2,4,12,0,0),
            new DateTime(2015,3,6,5,57,0),
            new DateTime(2015,4,5,10,40,0),
            new DateTime(2015,5,6,3,54,0),
            new DateTime(2015,6,6,8,0,0),
            new DateTime(2015,7,7,18,13,0),
            new DateTime(2015,8,8,4,3,0),
            new DateTime(2015,9,8,7,1,0),
            new DateTime(2015,10,8,22,44,0),
            new DateTime(2015,11,8,2,0,0),
            new DateTime(2015,12,7,18,55,0),
            new DateTime(2016,1,6,6,10,0),
            new DateTime(2016,2,4,17,48,0),
            new DateTime(2016,3,5,11,45,0),
            new DateTime(2016,4,4,16,29,0),
            new DateTime(2016,5,5,9,43,0),
            new DateTime(2016,6,5,13,50,0),
            new DateTime(2016,7,7,0,5,0),
            new DateTime(2016,8,7,9,54,0),
            new DateTime(2016,9,7,12,53,0),
            new DateTime(2016,10,8,4,35,0),
            new DateTime(2016,11,7,7,49,0),
            new DateTime(2016,12,7,0,43,0),
            new DateTime(2017,1,5,11,57,0),
            new DateTime(2017,2,3,23,36,0),
            new DateTime(2017,3,5,17,34,0),
            new DateTime(2017,4,4,22,19,0),
            new DateTime(2017,5,5,15,33,0),
            new DateTime(2017,6,5,19,38,0),
            new DateTime(2017,7,7,5,52,0),
            new DateTime(2017,8,7,15,41,0),
            new DateTime(2017,9,7,18,40,0),
            new DateTime(2017,10,8,10,24,0),
            new DateTime(2017,11,7,13,39,0),
            new DateTime(2017,12,7,6,34,0),
            new DateTime(2018,1,5,17,50,0),
            new DateTime(2018,2,4,5,30,0),
            new DateTime(2018,3,5,23,30,0),
            new DateTime(2018,4,5,4,14,0),
            new DateTime(2018,5,5,21,27,0),
            new DateTime(2018,6,6,1,31,0),
            new DateTime(2018,7,7,11,43,0),
            new DateTime(2018,8,7,21,32,0),
            new DateTime(2018,9,8,0,31,0),
            new DateTime(2018,10,8,16,16,0),
            new DateTime(2018,11,7,19,33,0),
            new DateTime(2018,12,7,17,30,0),
            new DateTime(2019,1,5,12,28,0),
            new DateTime(2019,2,4,23,41,0),
            new DateTime(2019,3,6,11,16,0),
            new DateTime(2019,4,5,9,53,0),
            new DateTime(2019,5,6,3,4,0),
            new DateTime(2019,6,6,7,8,0),
            new DateTime(2019,7,7,17,22,0),
            new DateTime(2019,8,8,3,14,0),
            new DateTime(2019,9,8,6,19,0),
            new DateTime(2019,10,8,22,7,0),
            new DateTime(2019,11,8,1,26,0),
            new DateTime(2019,12,7,18,20,0),
            new DateTime(2020,1,6,5,32,0),
            new DateTime(2020,2,4,17,5,0),
            new DateTime(2020,3,5,10,59,0),
            new DateTime(2020,4,4,15,40,0),
            new DateTime(2020,5,5,8,53,0),
            new DateTime(2020,6,5,13,0,0),
            new DateTime(2020,7,6,23,16,0),
            new DateTime(2020,8,7,9,8,0),
            new DateTime(2020,9,7,12,9,0),
            new DateTime(2020,10,8,3,57,0),
            new DateTime(2020,11,7,7,16,0),
            new DateTime(2020,12,7,0,11,0),
            new DateTime(2021,1,5,11,25,0),
            new DateTime(2021,2,3,23,0,0),
            new DateTime(2021,3,5,16,55,0),
            new DateTime(2021,4,4,21,37,0),
            new DateTime(2021,5,5,14,49,0),
            new DateTime(2021,6,5,18,53,0),
            new DateTime(2021,7,7,5,7,0),
            new DateTime(2021,8,7,14,55,0),
            new DateTime(2021,9,7,17,55,0),
            new DateTime(2021,10,8,9,41,0),
            new DateTime(2021,11,7,13,0,0),
            new DateTime(2021,12,7,5,59,0),
            new DateTime(2022,1,5,17,16,0),
            new DateTime(2022,2,4,4,52,0),
            new DateTime(2022,3,5,22,45,0),
            new DateTime(2022,4,5,3,22,0),
            new DateTime(2022,5,5,20,27,0),
            new DateTime(2022,6,6,0,27,0),
            new DateTime(2022,7,7,10,39,0),
            new DateTime(2022,8,7,20,30,0),
            new DateTime(2022,9,7,23,34,0),
            new DateTime(2022,10,8,15,24,0),
            new DateTime(2022,11,7,18,47,0),
            new DateTime(2022,12,7,11,48,0),
            new DateTime(2023,1,5,23,6,0),
            new DateTime(2023,2,4,10,44,0),
            new DateTime(2023,3,6,4,38,0),
            new DateTime(2023,4,5,9,14,0),
            new DateTime(2023,5,6,2,20,0),
            new DateTime(2023,6,6,6,20,0),
            new DateTime(2023,7,7,16,32,0),
            new DateTime(2023,8,8,2,24,0),
            new DateTime(2023,9,8,5,28,0),
            new DateTime(2023,10,8,21,17,0),
            new DateTime(2023,11,8,0,37,0),
            new DateTime(2023,12,7,17,35,0),
            new DateTime(2024,1,6,4,51,0),
            new DateTime(2024,2,4,16,29,0),
            new DateTime(2024,3,5,10,24,0),
            new DateTime(2024,4,4,15,4,0),
            new DateTime(2024,5,5,8,12,0),
            new DateTime(2024,6,5,12,11,0),
            new DateTime(2024,7,6,2,21,0),
            new DateTime(2024,8,7,8,11,0),
            new DateTime(2024,9,7,11,13,0),
            new DateTime(2024,10,8,3,2,0),
            new DateTime(2024,11,7,6,22,0),
            new DateTime(2024,12,6,23,19,0),
            new DateTime(2025,1,5,10,35,0),
            new DateTime(2025,2,3,22,12,0),
            new DateTime(2025,3,5,16,9,0),
            new DateTime(2025,4,4,20,50,0),
            new DateTime(2025,5,5,13,59,0),
            new DateTime(2025,6,5,17,58,0),
            new DateTime(2025,7,7,4,6,0),
            new DateTime(2025,8,7,13,53,0),
            new DateTime(2025,9,7,16,53,0),
            new DateTime(2025,10,8,8,43,0),
            new DateTime(2025,11,7,12,6,0),
            new DateTime(2025,12,7,5,6,0),
            new DateTime(2026,1,5,16,25,0),
            new DateTime(2026,2,4,4,4,0),
            new DateTime(2026,3,5,22,0,0),
            new DateTime(2026,4,5,2,42,0),
            new DateTime(2026,5,5,19,50,0),
            new DateTime(2026,6,5,23,50,0),
            new DateTime(2026,7,7,9,8,0),
            new DateTime(2026,8,7,19,44,0),
            new DateTime(2026,9,7,22,43,0),
            new DateTime(2026,10,8,14,31,0),
            new DateTime(2026,11,7,17,54,0),
            new DateTime(2026,12,7,10,54,0),
            new DateTime(2027,1,5,22,12,0),
            new DateTime(2027,2,4,9,48,0),
            new DateTime(2027,3,6,3,41,0),
            new DateTime(2027,4,5,8,19,0),
            new DateTime(2027,5,6,1,26,0),
            new DateTime(2027,6,6,5,27,0),
            new DateTime(2027,7,7,15,38,0),
            new DateTime(2027,8,8,1,28,0),
            new DateTime(2027,9,8,4,30,0),
            new DateTime(2027,10,8,20,18,0),
            new DateTime(2027,11,7,23,40,0),
            new DateTime(2027,12,7,16,39,0),
            new DateTime(2028,1,6,3,56,0),
            new DateTime(2028,2,4,15,33,0),
            new DateTime(2028,3,5,9,26,0),
            new DateTime(2028,4,4,14,5,0),
            new DateTime(2028,5,5,7,13,0),
            new DateTime(2028,6,5,11,17,0),
            new DateTime(2028,7,6,21,32,0),
            new DateTime(2028,8,7,7,22,0),
            new DateTime(2028,9,7,10,23,0),
            new DateTime(2028,10,8,2,10,0),
            new DateTime(2028,11,7,5,29,0),
            new DateTime(2028,12,6,22,26,0),
            new DateTime(2029,1,5,9,44,0),
            new DateTime(2029,2,3,21,22,0),
            new DateTime(2029,3,5,15,19,0),
            new DateTime(2029,4,4,20,0,0),
            new DateTime(2029,5,5,13,9,0),
            new DateTime(2029,6,5,17,11,0),
            new DateTime(2029,7,7,3,24,0),
            new DateTime(2029,8,7,13,13,0),
            new DateTime(2029,9,7,16,13,0),
            new DateTime(2029,10,8,8,0,0),
            new DateTime(2029,11,7,11,18,0),
            new DateTime(2029,12,7,4,15,0),
            new DateTime(2030,1,5,15,32,0),
            new DateTime(2030,2,4,3,18,0),
            new DateTime(2030,3,5,21,14,0),
            new DateTime(2030,4,5,1,50,0),
            new DateTime(2030,5,5,18,52,0),
            new DateTime(2030,6,5,23,0,0),
            new DateTime(2030,7,7,9,9,0),
            new DateTime(2030,8,7,19,7,0),
            new DateTime(2030,9,7,22,6,0),
            new DateTime(2030,10,8,14,1,0),
            new DateTime(2030,11,7,17,19,0),
            new DateTime(2030,12,7,10,18,0),
            new DateTime(2031,1,5,21,27,0),
            new DateTime(2031,2,4,9,3,0),
            new DateTime(2031,3,6,2,55,0),
            new DateTime(2031,4,5,7,33,0),
            new DateTime(2031,5,6,9,41,0),
            new DateTime(2031,6,6,4,40,0),
            new DateTime(2031,7,7,14,52,0),
            new DateTime(2031,8,8,0,48,0),
            new DateTime(2031,9,8,3,54,0),
            new DateTime(2031,10,8,19,48,0),
            new DateTime(2031,11,7,23,10,0),
            new DateTime(2031,12,7,16,8,0),
            new DateTime(2032,1,6,3,21,0),
            new DateTime(2032,2,4,14,53,0),
            new DateTime(2032,3,5,8,44,0),
            new DateTime(2032,4,4,13,22,0),
            new DateTime(2032,5,5,6,31,0),
            new DateTime(2032,6,5,10,33,0),
            new DateTime(2032,7,6,20,47,0),
            new DateTime(2032,8,7,6,35,0),
            new DateTime(2032,9,7,9,43,0),
            new DateTime(2032,10,8,1,34,0),
            new DateTime(2032,11,7,5,1,0),
            new DateTime(2032,12,6,21,58,0),
            new DateTime(2033,1,5,9,11,0),
            new DateTime(2033,2,3,20,44,0),
            new DateTime(2033,3,5,14,35,0),
            new DateTime(2033,4,4,19,11,0),
            new DateTime(2033,5,5,12,16,0),
            new DateTime(2033,6,5,16,16,0),
            new DateTime(2033,7,7,2,28,0),
            new DateTime(2033,8,7,12,18,0),
            new DateTime(2033,9,7,15,23,0),
            new DateTime(2033,10,8,7,17,0),
            new DateTime(2033,11,7,10,46,0),
            new DateTime(2033,12,7,3,48,0),
            new DateTime(2034,1,5,15,7,0),
            new DateTime(2034,2,4,2,44,0),
            new DateTime(2034,3,5,20,35,0),
            new DateTime(2034,4,5,1,9,0),
            new DateTime(2034,5,5,18,12,0),
            new DateTime(2034,6,5,22,9,0),
            new DateTime(2034,7,7,8,20,0),
            new DateTime(2034,8,7,18,12,0),
            new DateTime(2034,9,7,21,17,0),
            new DateTime(2034,10,8,13,10,0),
            new DateTime(2034,11,7,16,37,0),
            new DateTime(2034,12,7,9,39,0),
            new DateTime(2035,1,5,20,58,0),
            new DateTime(2035,2,4,8,34,0),
            new DateTime(2035,3,6,2,24,0),
            new DateTime(2035,4,5,6,57,0),
            new DateTime(2035,5,5,23,58,0),
            new DateTime(2035,6,6,3,51,0),
            new DateTime(2035,7,7,14,4,0),
            new DateTime(2035,8,7,23,57,0),
            new DateTime(2035,9,8,3,5,0),
            new DateTime(2035,10,8,19,0,0),
            new DateTime(2035,11,7,22,26,0),
            new DateTime(2035,12,7,15,28,0),
            new DateTime(2036,1,6,2,46,0),
            new DateTime(2036,2,4,14,22,0),
            new DateTime(2036,3,5,8,14,0),
            new DateTime(2036,4,4,12,49,0),
            new DateTime(2036,5,5,5,52,0),
            new DateTime(2036,6,5,9,49,0),
            new DateTime(2036,7,6,19,59,0),
            new DateTime(2036,8,7,5,52,0),
            new DateTime(2036,9,7,8,58,0),
            new DateTime(2036,10,8,0,52,0),
            new DateTime(2036,11,7,4,17,0),
            new DateTime(2036,12,6,21,19,0),
            new DateTime(2037,1,5,8,37,0),
            new DateTime(2037,2,3,20,14,0),
            new DateTime(2037,3,5,14,9,0),
            new DateTime(2037,4,4,18,47,0),
            new DateTime(2037,5,5,11,52,0),
            new DateTime(2037,6,5,15,49,0),
            new DateTime(2037,7,7,1,58,0),
            new DateTime(2037,8,7,11,46,0),
            new DateTime(2037,9,7,14,46,0),
            new DateTime(2037,10,8,6,39,0),
            new DateTime(2037,11,7,10,7,0),
            new DateTime(2037,12,7,3,9,0),
            new DateTime(2038,1,5,14,29,0),
            new DateTime(2038,2,4,2,6,0),
            new DateTime(2038,3,5,19,58,0),
            new DateTime(2038,4,5,0,32,0),
            new DateTime(2038,5,5,17,34,0),
            new DateTime(2038,6,5,21,28,0),
            new DateTime(2038,7,7,7,35,0),
            new DateTime(2038,8,7,17,24,0),
            new DateTime(2038,9,7,20,29,0),
            new DateTime(2038,10,8,12,24,0),
            new DateTime(2038,11,7,15,54,0),
            new DateTime(2038,12,7,8,59,0),
            new DateTime(2039,1,5,8,19,0),
            new DateTime(2039,2,4,7,56,0),
            new DateTime(2039,3,6,1,46,0),
            new DateTime(2039,4,5,6,18,0),
            new DateTime(2039,5,5,23,21,0),
            new DateTime(2039,6,6,3,18,0),
            new DateTime(2039,7,7,13,29,0),
            new DateTime(2039,8,7,23,21,0),
            new DateTime(2039,9,8,2,27,0),
            new DateTime(2039,10,8,18,19,0),
            new DateTime(2039,11,7,21,46,0),
            new DateTime(2039,12,7,14,48,0),
            new DateTime(2040,1,6,2,6,0),
            new DateTime(2040,2,4,13,42,0),
            new DateTime(2040,3,5,7,34,0),
            new DateTime(2040,4,4,12,8,0),
            new DateTime(2040,5,5,5,12,0),
            new DateTime(2040,6,5,9,11,0),
            new DateTime(2040,7,6,19,22,0),
            new DateTime(2040,8,7,5,13,0),
            new DateTime(2040,9,7,8,17,0),
            new DateTime(2040,10,8,0,8,0),
            new DateTime(2040,11,7,3,32,0),
            new DateTime(2040,12,6,20,33,0)
        };

        public string[,] trDSTExceptions = new string[,] //Vatanımın DST Uygulamaları
		{
            {"1919-04-10 12:00","1919-10-02 00:00","1"},
            {"1920-03-01 12:00","1920-11-01 01:00","1"},
            {"1921-03-15 13:00","1921-11-01 01:00","1"},
            {"1922-03-15 13:00","1922-11-01 01:00","1"},
			// 2 sene uygulanmamış
			{"1924-05-13 13:00","1924-10-01 00:00","1"},
            {"1925-05-01 13:00","1924-10-01 00:00","1"},
			// cumhuriyet kuruldu sonra
			{"1940-07-01 01:00","1940-10-06 22:59","1"},
            {"1940-12-01 01:00","1941-09-20 22:59","1"},
			// extra 1 saat daha geri uygulaması
			{"1941-09-21 01:00","1942-04-01 22:59","-1"},
			//3 Senelik ileri saat uygulaması
			{"1942-04-01 01:00","1945-10-08 22:59","1"},
			// Senelik ileri saat uygulaması            
			{"1946-06-01 01:00","1946-10-01 22:59","1"},
            {"1947-04-20 01:00","1947-10-05 22:59","1"},
            {"1948-04-18 01:00","1948-10-03 22:59","1"},
            {"1949-04-10 01:00","1949-10-02 22:59","1"},
            {"1950-04-16 01:00","1950-10-08 22:59","1"},
            {"1951-04-22 01:00","1951-10-07 22:59","1"},
			// ara vermeler
			{"1962-07-15 01:00","1963-10-30 22:59","1"},
            {"1964-05-15 01:00","1964-10-01 22:59","1"},
			// darbe arası
			{"1973-06-03 02:00","1973-11-04 00:59","1"},
            {"1974-03-31 03:00","1974-11-03 00:59","1"},
            {"1975-03-22 03:00","1975-11-02 00:59","1"},
            {"1976-03-21 03:00","1976-10-31 00:59","1"},
            {"1977-04-03 03:00","1977-10-16 00:59","1"},
			// GMT +3'e geçiş
			{"1978-04-02 03:00","1983-07-31 00:59","1"},
			// GMT +4'e geçiş            
			{"1983-07-31 03:00","1983-10-02 00:59","2"},
			// GMT +3'e geçiş            
			{"1983-10-02 03:00","1984-11-01 00:59","1"},
			// GMT +2'e geçiş            
			//{"1984-11-01 03:00","1985-04-20 00:59","1"}, hata
			// avrupa düzeni öncesi
			{"1985-04-20 02:00","1985-09-28 00:59","1"},
			// avrupa düzeni ama saati yanlış zamanlarda almışız 1986-2006
			{"1986-03-30 02:00","1986-09-28 00:59","1"},
            {"1987-03-29 02:00","1987-09-27 00:59","1"},
            {"1988-03-27 02:00","1988-09-25 00:59","1"},
            {"1989-03-26 02:00","1989-09-24 00:59","1"},
            {"1990-03-25 02:00","1990-09-30 00:59","1"},
            {"1991-03-31 02:00","1991-09-29 00:59","1"},
            {"1992-03-29 02:00","1992-09-27 00:59","1"},
            {"1993-03-28 02:00","1993-09-26 00:59","1"},
            {"1994-03-20 02:00","1994-09-25 00:59","1"},
            {"1995-03-26 02:00","1995-09-24 00:59","1"},
            {"1996-03-31 02:00","1996-10-27 00:59","1"},
            {"1997-03-30 02:00","1997-10-26 00:59","1"},
            {"1998-03-29 02:00","1998-10-25 00:59","1"},
            {"1999-03-28 02:00","1999-10-31 00:59","1"},
            {"2000-03-26 02:00","2000-10-29 00:59","1"},
            {"2001-03-25 02:00","2001-10-28 00:59","1"},
            {"2002-03-31 02:00","2002-10-27 00:59","1"},
            {"2003-03-30 02:00","2003-10-26 00:59","1"},
            {"2004-03-28 02:00","2004-10-31 00:59","1"},
            {"2005-03-27 02:00","2005-10-30 00:59","1"},
            {"2006-03-26 02:00","2006-10-29 00:59","1"},
			// GMT +3'e geçiş tekrar geçiş
			{"2016-10-02 03:00","2023-10-02 00:59","1"},
        };

        // Metodlar
        public string[] ElementBul(string kutup)
        {
            string[] gon = new string[11];
            switch (kutup)
            {
                case "Yin": gon = yinElement; break;
                case "Yang": gon = yangElement; break;
            }
            return gon;
        }

        public string Kutupbul(int num) { return Convert.ToBoolean((Convert.ToInt32(num) % 2)) ? "Yang" : "Yin"; }

        public string[] YilElementBul(int yil) { return Element[(yil % 10)].Split(','); }

        public string[] YilBurcBul(int yil) { return Burc_Sembol[((yil - 4) % 12) + 1].Split(','); }

        public string SembolikYildizBul(string burc, string nevereyimAbime)
        {
            string _temp = null;
            string rr = null;
            string[] nevericeksinBana = new string[3];
            switch (burc)
            {
                case "申":   //Maymun
                case "子":   //Fare
                case "辰":   //Ejderha
                    if (nevereyimAbime == "ask") _temp = Burc_Sembol[10];
                    if (nevereyimAbime == "seyahat") _temp = Burc_Sembol[3];
                    if (nevereyimAbime == "sanat") _temp = Burc_Sembol[5];
                    if (nevereyimAbime == "ölüm") _temp = Burc_Sembol[0];
                    break;
                case "亥":   //Domuz
                case "卯":   //Tavşan
                case "未":   //Keçi
                    if (nevereyimAbime == "ask") _temp = Burc_Sembol[1];
                    if (nevereyimAbime == "seyahat") _temp = Burc_Sembol[6];
                    if (nevereyimAbime == "sanat") _temp = Burc_Sembol[8];
                    if (nevereyimAbime == "ölüm") _temp = Burc_Sembol[3];
                    break;
                case "寅":  //Kaplan
                case "午":      //At
                case "戌":   //Köpek
                    if (nevereyimAbime == "ask") _temp = Burc_Sembol[4];
                    if (nevereyimAbime == "seyahat") _temp = Burc_Sembol[9];
                    if (nevereyimAbime == "sanat") _temp = Burc_Sembol[11];
                    if (nevereyimAbime == "ölüm") _temp = Burc_Sembol[6];
                    break;
                case "巳":   //Yılan
                case "酉":   //Horoz
                case "丑":    //Öküz
                    if (nevereyimAbime == "ask") _temp = Burc_Sembol[7];
                    if (nevereyimAbime == "seyahat") _temp = Burc_Sembol[0];
                    if (nevereyimAbime == "sanat") _temp = Burc_Sembol[2];
                    if (nevereyimAbime == "ölüm") _temp = Burc_Sembol[9];
                    break;
            }
            rr = _temp.Split(',')[0] + " " + _temp.Split(',')[2];
            if (_temp.Split(',')[3] != "")
                rr = rr + " (" + _temp.Split(',')[3] + ")";
            return rr;
        }

        public string KoruyucuMelek(string element)
        {
            string _temp1 = null;
            string _temp2 = null;
            string[] nevericeksinBana = new string[3];
            switch (element)
            {
                case "甲":   //Yang Ağaç
                case "戊":   //Yang Toprak
                case "庚":   //Yang Metal
                    _temp1 = Burc_Sembol[2];
                    _temp2 = Burc_Sembol[8];
                    break;
                case "乙":   //Yin Ağaç
                case "己":   //Yin Toprak
                    _temp1 = Burc_Sembol[1];
                    _temp2 = Burc_Sembol[9];
                    break;
                case "丙":   //Yang Ateş
                case "丁":   //Yin Ateş
                    _temp1 = Burc_Sembol[0];
                    _temp2 = Burc_Sembol[10];
                    break;
                case "壬":   //Yang Su
                case "癸":   //Yin Su
                    _temp1 = Burc_Sembol[4];
                    _temp2 = Burc_Sembol[6];
                    break;
                case "辛":   //Yin Metal
                    _temp1 = Burc_Sembol[7];
                    _temp2 = Burc_Sembol[3];
                    break;
            }
            return _temp1.Split(',')[0] + " " + _temp1.Split(',')[2] + ", " + _temp2.Split(',')[0] + " " + _temp2.Split(',')[2];
        }

        public string ErdemYildiz(string ayBurc)
        {
            string _temp = null;
            switch (ayBurc)
            {
                case "亥": _temp = Element[5]; break;        //domuz
                case "子": _temp = Burc_Sembol[5]; break;     //fare
                case "丑": _temp = Element[0]; break;         //öküz
                case "寅": _temp = Element[7]; break;       //kaplan
                case "卯": _temp = Burc_Sembol[9]; break;   //tavşan
                case "辰": _temp = Element[2]; break;      //ejderha
                case "巳": _temp = Element[1]; break;        //yılan
                case "午": _temp = Burc_Sembol[0]; break;       //at
                case "未": _temp = Element[4]; break;         //keçi
                case "申": _temp = Element[3]; break;       //maymun
                case "酉": _temp = Burc_Sembol[3]; break;    //horoz
                case "戌": _temp = Element[6]; break;        //köpek
            }
            return _temp.Split(',')[0] + " " + _temp.Split(',')[2];
        }

        public string GizliElement(string Burc)
        {
            string _temp = null;
            string ara_sonuc = null;
            string sonuc = null;
            switch (Burc)
            {
                case "子": _temp = "3"; break;        //Fare
                case "午": _temp = "7,9"; break;        //At
                case "卯": _temp = "5"; break;      //Tavşan
                case "酉": _temp = "1"; break;       //Horoz           
                case "寅": _temp = "4,6,8"; break;  //Kaplan
                case "申": _temp = "0,2,8"; break;  //Maymun
                case "巳": _temp = "6,8,0"; break;   //Yılan
                case "亥": _temp = "2,4"; break;     //Domuz
                case "辰": _temp = "8,5,3"; break; //Ejderha
                case "戌": _temp = "8,1,7"; break;   //Köpek
                case "丑": _temp = "9,3,1"; break;    //Öküz
                case "未": _temp = "9,7,5"; break;    //Keçi
            }
            for (int i = 0; i < _temp.Split(',').Length; i++)
            {
                ara_sonuc = Element[Convert.ToInt32(_temp.Split(',')[i])];
                sonuc = sonuc + ara_sonuc.Split(',')[2] + " " + ara_sonuc.Split(',')[0] + "\n";
            }
            return sonuc;
        }

        public string YanlizYildiz(string yilBurc)
        {
            string _temp1 = null;
            string _temp2 = null;
            switch (yilBurc)
            {
                case "寅":  //Kaplan
                case "卯":  //Tavşan
                case "辰": //Ejderha
                    _temp1 = Burc_Sembol[2];
                    _temp2 = Burc_Sembol[6];
                    break;
                case "巳":   //Yılan
                case "午":   //At
                case "未":   //Keçi
                    _temp1 = Burc_Sembol[5];
                    _temp2 = Burc_Sembol[9];
                    break;
                case "申":  //Maymun
                case "酉":   //Horoz
                case "戌":   //Köpek
                    _temp1 = Burc_Sembol[8];
                    _temp2 = Burc_Sembol[0];
                    break;
                case "亥":   //Domuz
                case "子":    //Fare
                case "丑":    //Öküz
                    _temp1 = Burc_Sembol[11];
                    _temp2 = Burc_Sembol[3];
                    break;
            }
            return _temp1.Split(',')[0] + " " + _temp1.Split(',')[2] + ", " + _temp2.Split(',')[0] + " " + _temp2.Split(',')[2];
        }

        public string AkademikYildiz(string element)
        {
            string _temp = null;
            string[] _tempArr = new string[3];
            switch (element) // uyum
            {
                case "甲": _temp = Burc_Sembol[6]; break;  //Yang Ağaç
                case "乙": _temp = Burc_Sembol[7]; break;  //Yin Ağaç
                case "壬": _temp = Burc_Sembol[3]; break;  //Yin Su
                case "癸": _temp = Burc_Sembol[4]; break;  //Yang Metal
                case "庚": _temp = Burc_Sembol[0]; break;  //Yin Metal
                case "辛": _temp = Burc_Sembol[1]; break;  //Yang Ateş
                case "丙": _temp = Burc_Sembol[9]; break;  //Yang Ateş
                case "丁": _temp = Burc_Sembol[10]; break; //Yin Ateş
                case "戊": _temp = Burc_Sembol[9]; break;  //Yang Toprak
                case "己": _temp = Burc_Sembol[10]; break; //Yin Toprak
            }
            return _temp.Split(',')[0] + " " + _temp.Split(',')[2];
        }

        public string Zit2uyum(string _label1Text, string _label2Text)
        {
            string z_temp = ",,";
            string u_temp = ",,";
            string renk = "";
            switch (_label1Text) // uyum
            {
                case "甲":
                    u_temp = Element[9];//Yang Ağaç
                    z_temp = Element[0];
                    break;
                case "乙":
                    u_temp = Element[0];//Yin Ağaç
                    z_temp = Element[1];
                    break;
                case "壬":
                    u_temp = Element[7];//Yang Su
                    z_temp = Element[6];
                    break;
                case "癸":
                    u_temp = Element[8];//Yin Su
                    z_temp = Element[6];
                    break;
                case "庚":
                    u_temp = Element[5];//Yang Metal
                    z_temp = Element[4];
                    break;
                case "辛":
                    u_temp = Element[6];//Yin Metal
                    z_temp = Element[5];
                    break;
                case "丙":
                    u_temp = Element[1];//Yang Ateş
                    z_temp = Element[2];
                    break;
                case "丁":
                    u_temp = Element[2];//Yin Ateş
                    z_temp = Element[3];
                    break;
                case "戊":
                    u_temp = Element[3];//Yang Toprak
                    break;
                case "己":
                    u_temp = Element[4];//Yin Toprak
                    break;
                case "午":
                    u_temp = Burc_Sembol[8];//At - Keçi
                    z_temp = Burc_Sembol[1];//At - Fare
                    break;
                case "未":
                    u_temp = Burc_Sembol[7];//Keçi - At
                    z_temp = Burc_Sembol[2];//Keçi - Öküz
                    break;
                case "申":
                    u_temp = Burc_Sembol[6];//Maymun - Yılan
                    z_temp = Burc_Sembol[3];//Maymun - Kaplan
                    break;
                case "酉":
                    u_temp = Burc_Sembol[5];//Horoz - Ejder
                    z_temp = Burc_Sembol[4];//Horoz - Tavşan
                    break;
                case "戌":
                    u_temp = Burc_Sembol[4];//Köpek - Tavşan
                    z_temp = Burc_Sembol[5];//Köpek - Ejderha
                    break;
                case "亥":
                    u_temp = Burc_Sembol[3];//Domuz - Kaplan
                    z_temp = Burc_Sembol[6];//Domuz - Yılan
                    break;
                case "子":
                    u_temp = Burc_Sembol[2];//Fare - Öküz
                    z_temp = Burc_Sembol[7];//Fare - At
                    break;
                case "丑":
                    u_temp = Burc_Sembol[1];//Öküz - Fare
                    z_temp = Burc_Sembol[8];//Öküz - Keçi
                    break;
                case "寅":
                    u_temp = Burc_Sembol[0];//Kaplan - Domuz
                    z_temp = Burc_Sembol[9];//Kaplan - Maymun
                    break;
                case "卯":
                    u_temp = Burc_Sembol[11];//Tavşan - Köpek
                    z_temp = Burc_Sembol[10];//Tavşan - Horoz
                    break;
                case "辰":
                    u_temp = Burc_Sembol[10];//Ejderha - Horoz
                    z_temp = Burc_Sembol[11];//Ejderha - Köpek
                    break;
                case "巳":
                    u_temp = Burc_Sembol[9];//Yılan - Maymun
                    z_temp = Burc_Sembol[12];//Yılan - Domuz
                    break;
            }
            if (_label2Text == u_temp.Split(',')[2]) // uyum
            {
                renk = "yesil";
            }
            if (_label2Text == z_temp.Split(',')[2]) //zitlik
            {
                renk = "kirmizi";
            }
            return renk;
        }
        //her src.uclu_bak elementi için frekans döner int=3 ise renklendirme yap demek. 
        //indis sırası src.ucluBak ile eslesir
        //simgeler indis sırası verdiğin elementin sırası
        public int[] UcluUyumZitlik(params string[] burcSimgeler)
        {
            int UcluBakIcindeBaslangic = 0;
            int UcluBakIcindeBitis = 5;
            int[] master_frekans = new int[6];
            for (int UcluBakIcindeSayac = UcluBakIcindeBaslangic; UcluBakIcindeSayac < UcluBakIcindeBitis + 1; UcluBakIcindeSayac++) //master sayac 5 adet uyum - ceza için aramayı kasteder
            {
                string[] analiz_match_array = new string[3]; //3 adet simgeyi tarayarak, [,ucluIcindeElement] her simgesi için frekans ekler
                for (int analizSayac = 0; analizSayac < 3; analizSayac++)
                {//her analizde paketin 3 simgesini simgesini tek tek ele alıyoruz.
                    for (int ucluIcindeElement = 0; ucluIcindeElement < 3; ucluIcindeElement++)
                    { // src.uclu_bak içindeki her burc ile ele alınan paket simgesini karşılaştır.
                        if (burcSimgeler[analizSayac] == uclu_bak[UcluBakIcindeSayac, ucluIcindeElement]) //Eğer src.uclu_bak ile uyuşma varsa;  
                        { // eşleşme varsa analiz_match_array içine +1 frekans ekle.
                            analiz_match_array[ucluIcindeElement] = (Convert.ToInt32(analiz_match_array[ucluIcindeElement]) + 1).ToString(); //eşleşme olduğunda frekansı artır.
                        }
                    }
                }
                for (int frekansToplamaSayaci = 0; frekansToplamaSayaci < 3; frekansToplamaSayaci++)
                {   // eklenen Frekanslara göre her src.uclu_bak elementi için master_Frekans içinde frekansları birbirinin üzerine bindir. 
                    if (Convert.ToInt32(analiz_match_array[frekansToplamaSayaci]) == 1)
                    {
                        master_frekans[UcluBakIcindeSayac]++;
                    }
                }
            }
            return master_frekans;
        }   
        
        public string KendineCeza(string _label1Text, string _label2Text)
        {
            string z_temp = ",,";
            string renk = "";
            switch (_label1Text) // uyum
            {
                case "亥":                 
                    z_temp = Burc_Sembol[0]; //Domuz
                    break;
                case "辰":
                    z_temp = Burc_Sembol[5]; //Ejderha
                    break;
                case "午":
                    z_temp = Burc_Sembol[7]; //At
                    break;
                case "酉":
                    z_temp = Burc_Sembol[10]; //Horoz
                    break;
            }
            if (_label2Text == z_temp.Split(',')[2]) //zitlik
            {
                renk = "kirmizi";
            }
            return renk;
        }
    }
}
