
using Microsoft.Win32;
using System;
using System.Linq;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BaZi
{       
    public class Bazi_tool
    {      
        public string IlkHarfBuyuk(string giris)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(giris.ToLower());
 
        }
        public string SonHarfBuyuk(string giris)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            return textInfo.ToTitleCase(giris.ToLower());
        }
        public void RegSET(string reg_Teyitedilecek, string reg_teyidi)
        {
            try
            {
                using (RegistryKey keyC = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\BaZi", RegistryKeyPermissionCheck.ReadWriteSubTree))
                {
                    keyC.SetValue(reg_Teyitedilecek, reg_teyidi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
            }
        }
        public bool CheckREG(string regBak, string regIstenen)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\BaZi"))
                {
                    if (key != null)
                    {
                        if (key.ValueCount > 0 && key.GetValue(regBak, null) != null && key.GetValue(regBak).ToString() == regIstenen)
                        {
                            return true;
                        }                            
                        else
                        {
                            return false;
                        }                            
                    }
                    else
                    {
                        return false;
                    }                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());
                return false;
            }
        }       

        //image yeniden ebadlandırma
        public Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            nPercentW = ((float)Width / (float)sourceWidth);
            nPercentH = ((float)Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width - (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height - (sourceHeight * nPercent)) / 2);
            }
            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap bmPhoto = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);
            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.White);
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);
            grPhoto.Dispose();
            return bmPhoto;
        }
        //image to byte
        public byte[] ImageToByte(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }
        //byte to image
        public Image ByteToImage(byte[] imageBytes)
        {
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }
        // Return a Bitmap holding an image of the control.
        public Bitmap GetControlImage(Control ctl)
        {
            Bitmap bm = new Bitmap(ctl.Width, ctl.Height);
            ctl.DrawToBitmap(bm, new Rectangle(0, 0, ctl.Width, ctl.Height));
            return bm;
        }
        // Return the form's image without its borders and decorations.
        public Bitmap GetFormImageWithoutBorders(Form frm)
        {
            // Get the form's whole image.
            using (Bitmap whole_form = GetControlImage(frm))
            {
                // See how far the form's upper left corner is
                // from the upper left corner of its client area.
                Point origin = frm.PointToScreen(new Point(0, 0));
                int dx = origin.X - frm.Left;
                int dy = origin.Y - frm.Top;
                // Copy the client area into a new Bitmap.
                int wid = frm.ClientSize.Width;
                int hgt = frm.ClientSize.Height;
                Bitmap bm = new Bitmap(wid, hgt);
                using (Graphics gr = Graphics.FromImage(bm))
                {
                    gr.DrawImage(whole_form, 0, 0,
                        new Rectangle(dx, dy, wid, hgt),
                        GraphicsUnit.Pixel);
                }
                return bm;
            }
        }
        public void ResimYukle(PictureBox resimTutucu, string yerleştirilecekresim)
        {
            resimTutucu.Image = (Image)Properties.Resources.ResourceManager.GetObject(yerleştirilecekresim);
            resimTutucu.Image.Tag = yerleştirilecekresim[3].ToString(); ;
        }       

        public void pictureBoxRenklendir(string renk, int uyum, params PictureBox[] _label)
        {
            byte e_yesilTon = 240;
            byte e_kirmiziTon = 240;
            for(int i=0; i < _label.Length; i++)
            {
                if (renk == "yesil" && (uyum == 1 || uyum == 3))
                {
                    if (_label[i].BackColor.G == e_yesilTon) // yeşil ise daha da yeşillendir
                        _label[i].BackColor = Color.FromArgb(0, e_yesilTon, 0);

                    if (_label[i].BackColor == Color.White) // renklendirilmemiş ise yeşillendir
                        _label[i].BackColor = Color.FromArgb(0, e_yesilTon, 0);

                    if (_label[i].BackColor.R == e_kirmiziTon) // kırmızı ise turuncu yap
                        _label[i].BackColor = Color.FromArgb(255, 128, 0); //turuncu
                }
                if (renk == "kirmizi" && (uyum == 2 || uyum == 3))
                {
                    if (_label[i].BackColor.R == e_kirmiziTon) // kızıl ise daha da kızılla
                        _label[i].BackColor = Color.FromArgb(e_kirmiziTon, 0, 0);

                    if (_label[i].BackColor == Color.White) // renklendirilmemiş ise kızılla
                        _label[i].BackColor = Color.FromArgb(e_kirmiziTon, 0, 0);

                    if (_label[i].BackColor.G == e_yesilTon) // yeşil ise turuncu yap
                        _label[i].BackColor = Color.FromArgb(255, 128, 0); //turuncu
                }
            }
        }
        public void labelRenklendir(string renk, int uyum,Label _label)
        {
            byte e_yesilTon = 240;
            byte e_kirmiziTon = 240;
            {
                if (renk == "yesil" && (uyum == 1 || uyum == 3))
                {
                    if (_label.BackColor.G == e_yesilTon) // yeşil ise daha da yeşillendir
                        _label.BackColor = Color.FromArgb(0, e_yesilTon, 0);

                    if (_label.BackColor == Color.White) // renklendirilmemiş ise yeşillendir
                        _label.BackColor = Color.FromArgb(0, e_yesilTon, 0);

                    if (_label.BackColor.R == e_kirmiziTon) // kırmızı ise turuncu yap
                        _label.BackColor = Color.FromArgb(255, 128, 0); //turuncu
                }
                if (renk == "kirmizi" && (uyum == 2 || uyum == 3))
                {
                    if (_label.BackColor.R == e_kirmiziTon) // kızıl ise daha da kızılla
                        _label.BackColor = Color.FromArgb(e_kirmiziTon, 0, 0);

                    if (_label.BackColor == Color.White) // renklendirilmemiş ise kızılla
                        _label.BackColor = Color.FromArgb(e_kirmiziTon, 0, 0);

                    if (_label.BackColor.G == e_yesilTon) // yeşil ise turuncu yap
                        _label.BackColor = Color.FromArgb(255, 128, 0); //turuncu
                }
            }
        }
    }    
}