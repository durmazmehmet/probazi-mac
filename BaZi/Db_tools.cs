using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace BaZi
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public class Db_tools
    {
        public SQLiteDataAdapter baziDataAdapter;
        public DataSet baziDataSet = new DataSet();
        public SQLiteConnection Baglanti = new SQLiteConnection("Data Source=probazicontacts.db;Version=3;New=False;Compress=True;");
        public string ohSQLite = "select id, ad || ' ' || soyad || char(10) || dogumtarihi as anasutun, " +
            "ad, soyad, dogumtarihi, cinsiyet, telefon, email, yorum, DST, resim from proBazi_kisiler";

        public void KomutCalistir(SQLiteCommand cmd)
        {
            if (Baglanti != null && Baglanti.State == ConnectionState.Closed)
                Baglanti.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc1)
            {
                MessageBox.Show(exc1.Message);
            }
            Baglanti.Close();
        }

        public void CreateIfNotExists() // veritabanına ulaş yoksa yeniden aç, tabloya ulaş yoksa yeniden oluştur
        {
            SQLiteCommand olustur = Baglanti.CreateCommand();
            olustur.CommandText = "CREATE TABLE IF NOT EXISTS `proBazi_kisiler` (" +
                "`id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, " +
                "`ad` TEXT NOT NULL, " +
                "`soyad` TEXT NOT NULL, " +
                "`dogumtarihi` TEXT NOT NULL, " +
                "`cinsiyet`	TEXT NOT NULL, " +
                "`telefon` TEXT, " +
                "`email` TEXT, " +
                "`yorum` TEXT, " +
                "`DST` TEXT, " +
                "`resim` BLOB " +
                ");";
            KomutCalistir(olustur);
        }

        public void VeriSil(params object[] values)
        {
            SQLiteCommand sil = Baglanti.CreateCommand();
            sil.CommandText = "delete from proBazi_kisiler where id = @p0";
            sil.Parameters.Add(new SQLiteParameter("@p0", values[0]));
            KomutCalistir(sil);
        }

        public void VeriEkle(params object[] values)
        {
            SQLiteCommand ekle = Baglanti.CreateCommand();
            ekle.CommandText = "insert into proBazi_kisiler(ad, soyad, dogumtarihi, cinsiyet, telefon, email, yorum, DST, resim) values(@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8);";
            for (int i = 0; i < values.Length - 1; i++)
            {
                ekle.Parameters.Add(new SQLiteParameter("@p" + i.ToString(), values[i]));
            }
            SQLiteParameter resim = new SQLiteParameter("@p" + (values.Length - 1).ToString(), DbType.Binary)
            {
                Value = values[values.Length - 1]
            };
            ekle.Parameters.Add(resim);
            KomutCalistir(ekle);
        }

        public void VeriGuncelle(params object[] values)
        {
            SQLiteCommand guncelle = Baglanti.CreateCommand();
            guncelle.CommandText = "update proBazi_kisiler set ad = @p1 , soyad = @p2, dogumtarihi = @p3, cinsiyet = @p4, telefon = @p5, email = @p6, yorum = @p7, DST = @p8, resim = @p9 where id = @p0";
            for (int i = 0; i < values.Length - 1; i++)
            {
                guncelle.Parameters.Add(new SQLiteParameter("@p" + i.ToString(), values[i]));
            }
            SQLiteParameter resim = new SQLiteParameter("@p" + (values.Length - 1).ToString(), DbType.Binary)
            {
                Value = values[values.Length - 1]
            };
            guncelle.Parameters.Add(resim);
            KomutCalistir(guncelle);
        }

        public int SonKayit()//en son kaydın id'sini döndür
        {
            int sonuc;
            Baglanti.Open();
            SQLiteCommand son = Baglanti.CreateCommand();
            son.CommandText = "SELECT id FROM proBazi_kisiler ORDER BY id DESC LIMIT 1; ";
            int.TryParse(son.ExecuteScalar().ToString(), out sonuc);
            Baglanti.Close();
            return sonuc;
        }

        public DataView RehberFiltre(TextBox filtreText, DataTable data, params string[] extra)
        {
            DataView dv = new DataView(data);
            string[] filtre_str = filtreText.Text.TrimStart().TrimEnd().Split(' ');
            filtre_str = filtre_str.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Array.Resize(ref filtre_str, 4);
            if (extra.Length > 0)
            {
                dv.RowFilter = string.Format(
                "anasutun LIKE '%{0}%' AND " +
                "anasutun LIKE '%{1}%' AND " +
                "anasutun LIKE '%{2}%' AND " +
                "anasutun LIKE '%{3}%' AND " +
                "dogumtarihi LIKE '%{4}%'",
                filtre_str[0],
                filtre_str[1],
                filtre_str[2],
                filtre_str[3],
                extra[0]);
            }
            else
            {
                dv.RowFilter = string.Format(
                "anasutun LIKE '%{0}%' AND " +
                "anasutun LIKE '%{1}%' AND " +
                "anasutun LIKE '%{2}%' AND " +
                "anasutun LIKE '%{3}%'",
                filtre_str[0],
                filtre_str[1],
                filtre_str[2],
                filtre_str[3]);
            }
            dv.Sort = " anasutun ASC";
            return dv;
        }

        public int MainFiltre(DataTable data, params string[] filterTxt)
        {
            DataView dv = new DataView(data)
            {
                RowFilter = string.Format(
                "anasutun LIKE '%{0}%' AND " +
                "dogumtarihi LIKE '{1}' AND " +
                "cinsiyet LIKE '{2}' AND " +
                "DST LIKE '{3}'",
                filterTxt[0],
                filterTxt[1],
                filterTxt[2],
                filterTxt[3]),
                //MessageBox.Show(filterTxt[0] + " "  + filterTxt[1] + " " + filterTxt[2] + " " + filterTxt[3] + " " + dv.Count.ToString());
                Sort = " anasutun ASC"
            };
            int idVer = 0;
            if (dv.Count != 0)
            {
                Int32.TryParse(dv[0][0].ToString(), out idVer);
            }                
            else
            {
                idVer = 0;
            }
            return idVer;
        }

    }
}
