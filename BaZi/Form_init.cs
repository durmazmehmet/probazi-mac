using System;
using System.Windows.Forms;
using System.Linq;
using Microsoft.Win32;

namespace BaZi
{
    public partial class Form_init : Form
    {
        public Form_init()
        {
            InitializeComponent();
            FingerPrint fgr = new FingerPrint();
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.MaxLength == 4)
                {
                    tb.TextChanged += new EventHandler(Maxlimitbak);
                    tb.GotFocus += new EventHandler(OnDefocus);
                    tb.MouseDown += new MouseEventHandler(Secimkarar);
                }
            }
            txt_aktivasyon.Text = fgr.Aktivasyon();
        }

        private void Maxlimitbak(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 3)
                this.SelectNextControl((TextBox)sender, true, true, true, true);
        }

        private void Secimkarar(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
                ((TextBox)sender).SelectAll();
        }

        private void OnDefocus(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length > 0)
                ((TextBox)sender).SelectAll();
        }

        private void Devam_Click(object sender, EventArgs e)
        {
            FingerPrint test = new FingerPrint();
            string adsoyad = Environment.UserName;
            string serial = textBox1.Text + "-" + textBox2.Text + "-" + textBox3.Text + "-" + textBox4.Text + "-" + textBox5.Text;
            if (serial == test.Value(txt_aktivasyon.Text).Substring(0, 24))
            {
                try
                {
                    using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BaZi", RegistryKeyPermissionCheck.ReadWriteSubTree))
                    {
                        key.SetValue("AdSoyad", adsoyad);
                        key.SetValue("Serial", serial);
                        key.SetValue("isSaat", "True");
                        key.SetValue("isYildiz", "True");
                        key.SetValue("isBirth", "True");
                        key.SetValue("isUTC", "True");
                        MessageBox.Show("Etkinleştirme başarılı, yazılım yeniden başlatılıyor");
                        Application.Restart();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Etkinleştirme başarısız, kayıt yetkisi verilmedi! " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Aktivasyon Kodu Geçersiz!");
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txt_aktivasyon.Text);
        }
    }
}
