using System;
using System.Collections.Generic;
using System.Globalization;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace BaZi
{
    public class FingerPrint
    {
        private string anahtar = string.Empty;
        private string kilit = string.Empty;
        private char[] chars = new char[16];
        private string memoli = string.Empty;

        public string Aktivasyon()
        {
            return GetHash(CpuId() + BaseId() + DiskId(), false);
        }

        public string Value(string xkilit)
        {
            memoli = string.Empty;
            chars[0] = (char)77;
            chars[1] = (char)69;
            chars[2] = (char)76;
            chars[3] = (char)84;
            chars[4] = (char)69;
            chars[5] = (char)77;
            chars[6] = (char)77;
            chars[7] = (char)73;
            chars[8] = (char)78;
            chars[9] = (char)78;
            chars[10] = (char)79;
            chars[11] = (char)83;
            chars[12] = (char)50;
            chars[13] = (char)48;
            chars[14] = (char)57;
            chars[15] = (char)51;
            //mel....min....20..
            foreach (char c in chars)
            {
                memoli += c;
            }                
            if (string.IsNullOrEmpty(anahtar))
            {
                return GetHash(memoli + xkilit, true);
            }  
            else
            {
                return string.Empty;
            }
        }

        private static string GetHash(string s, bool aktiv)
        {
            MD5 sec = new MD5CryptoServiceProvider(); //Initialize a new MD5 Crypto Service Provider in order to generate a hash            
            byte[] bt = Encoding.ASCII.GetBytes(s); //Grab the bytes of the variable 's'            
            return aktiv ? GetHexString(sec.ComputeHash(bt), true) : GetHexString(sec.ComputeHash(bt), false); //Grab the Hexadecimal value of the MD5 hash
        }

        private static string GetHexString(IList<byte> bt, bool mode)
        {
            string s = string.Empty;
            int kademe = mode ? bt.Count : Convert.ToInt32(bt.Count / 3);
            for (int i = 0; i < kademe; i++)
            {
                byte b = bt[i];
                int n = b;
                int n1 = n & 15;
                int n2 = (n >> 4) & 15;
                s += (n2 > 9) ? ((char)(n2 - 10 + 'A')).ToString(CultureInfo.InvariantCulture) : n2.ToString(CultureInfo.InvariantCulture);
                s += (n1 > 9) ? ((char)(n1 - 10 + 'A')).ToString(CultureInfo.InvariantCulture) : n1.ToString(CultureInfo.InvariantCulture);
                if ((i + 1) != bt.Count && (i + 1) % 2 == 0) s += "-";
            }
            return s;
        }      
       
        private static string CpuId()
        {
            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                return mo["ProcessorID"].ToString();
            }                
            return id;
        }

        private static string DiskId()
        {
            ManagementObject dsk = new ManagementObject(@"win32_logicaldisk.deviceid=""c:""");
            dsk.Get();
            return dsk["VolumeSerialNumber"].ToString();            
        }

        private static string BaseId()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection moc = mos.Get();
            string serial = "";
            foreach (ManagementObject mo in moc)
            {
                serial = (string)mo["SerialNumber"];
            }                
            return serial;
        }
    }
}




        