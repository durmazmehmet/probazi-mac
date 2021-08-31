using System.Windows.Forms;
using Microsoft.Win32;

namespace BaZi
{
    public partial class Form_about : Form
    {
        FingerPrint fgr = new FingerPrint();
        public Form_about()
        {
            InitializeComponent();
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\BaZi"); 
            if (key != null)  //şartların girişi
            {
                if (key.ValueCount > 0 && key.GetValue("Serial", null) != null && key.GetValue("Serial").ToString() == fgr.Value(fgr.Aktivasyon()).Substring(0, 24))
                {
                    txt_adsoyad.Text = key.GetValue("AdSoyad").ToString();
                    txt_serial.Text = key.GetValue("Serial").ToString();
                    key.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt Hatası");
                    this.Close();
                }
            }
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://en.wikipedia.org/wiki/Chinese_calendar");
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.journals.istanbul.edu.tr/iutarih/article/view/5000119516/5000110316");
        }

        private void LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.redrok.com/solar_position_algorithm.pdf");
        }

        private void LinkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Four_Pillars_of_Destiny");
        }
    }
}
