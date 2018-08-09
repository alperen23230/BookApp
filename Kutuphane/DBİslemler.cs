using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Kutuphane
{
    public class DBİslemler
    {
        public static bool giriskontrol(string kullaniciadi,string sifre)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "Select * from KullaniciTanim where KullaniciAdi=@pkullaniciadi and Sifre=@psifre";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pkullaniciadi",kullaniciadi);
            komut.Parameters.AddWithValue("@psifre", sifre);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            baglanti.Open();
            adaptor.Fill(sonucDS);
            baglanti.Close();
            bool sonuc = false;
            if (sonucDS.Tables[0].Rows.Count > 0)
                sonuc = true;
            else
                sonuc = false;
            return sonuc;
        }
        public static bool giriskontroladmin(string kullaniciadi, string sifre)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "Select * from YoneticiTanim where KullaniciAdi=@pkullaniciadi and Sifre=@psifre";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pkullaniciadi", kullaniciadi);
            komut.Parameters.AddWithValue("@psifre", sifre);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            baglanti.Open();
            adaptor.Fill(sonucDS);
            baglanti.Close();
            bool sonuc = false;
            if (sonucDS.Tables[0].Rows.Count > 0)
                sonuc = true;
            else
                sonuc = false;
            return sonuc;
        }

        public static void uyeekle(string kullaniciadi,string sifre,string ad,string soyad,string dogumyeri,string dogumtarihi,string dosyayolu)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "insert into KullaniciTanim(KullaniciAdi,Sifre,Ad,Soyad,DogumYeri,DogumTarihi,ProfilFoto) values (@pkullaniciadi,@psifre,@pad,@psoyad,@pdogumyeri,@pdogumtarihi,@pdosyayolu)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pkullaniciadi",kullaniciadi);
            komut.Parameters.AddWithValue("@psifre", sifre);
            komut.Parameters.AddWithValue("@pad", ad);
            komut.Parameters.AddWithValue("@psoyad", soyad);
            komut.Parameters.AddWithValue("@pdogumyeri", dogumyeri);
            komut.Parameters.AddWithValue("@pdogumtarihi", dogumtarihi);
            komut.Parameters.AddWithValue("@pdosyayolu", dosyayolu);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public static void yazarekle(string yazaradi,string yazarsoyadi,string hayati,string dogumtarihi,string dogumyeri)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "insert into YazarTanim(Ad,Soyad,Hayati,DogumTarih,DogumYeri) values(@pyazaradi,@pyazarsoyadi,@phayati,@pdogumtarihi,@pdogumyeri)";
            SqlCommand komut = new SqlCommand(sql,baglanti);
            komut.Parameters.AddWithValue("@pyazaradi", yazaradi);
            komut.Parameters.AddWithValue("@pyazarsoyadi", yazarsoyadi);
            komut.Parameters.AddWithValue("@phayati", hayati);
            komut.Parameters.AddWithValue("@pdogumtarihi", dogumtarihi);
            komut.Parameters.AddWithValue("@pdogumyeri", dogumyeri);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static DataSet Yazarlaricek()
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select * from YazarTanim";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            DataSet yazarlarDS = new DataSet();
            baglanti.Open();
            adaptor.Fill(yazarlarDS);
            baglanti.Close();
            return yazarlarDS;

        }
        public static void kitapekle(string kitapadi, string kitapturu, string kitapsayfasi, string yayinevi, int yazarid,string dosyayolu)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "insert into Kitaplar(KitapAdi,KitapSayfasi,KitapTuru,YazarID,KitapResim,KitapYayinevi) values (@pkitapadi,@pkitapsayfasi,@pkitapturu,@pyazarid,@pkitapresim,@pyayinevi)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pkitapadi", kitapadi);
            komut.Parameters.AddWithValue("@pkitapsayfasi", kitapsayfasi);
            komut.Parameters.AddWithValue("@pkitapturu", kitapturu);
            komut.Parameters.AddWithValue("@pyazarid", yazarid);
            komut.Parameters.AddWithValue("@pyayinevi", yayinevi);
            komut.Parameters.AddWithValue("@pkitapresim", dosyayolu);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static DataSet okunankitap(string kullaniciadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select * from KitapOkuma where KullaniciAdi=" + kullaniciadi;
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet bilgilerDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(bilgilerDS);
            baglanti.Close();
            return bilgilerDS;

        }
        public static DataSet verilenpuan(string kullaniciadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select * from KitapPuan where KullaniciAdi=" + kullaniciadi;
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet puanlarDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(puanlarDS);
            baglanti.Close();
            return puanlarDS;

        }

        public static DataSet yapilaninceleme(string kullaniciadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select * from KitapYorum where KullaniciAdi=" + kullaniciadi;
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet incelemeDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(incelemeDS);
            baglanti.Close();
            return incelemeDS;

        }
        public static DataSet yapilanalinti(string kullaniciadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select * from KitapAlinti where KullaniciAdi=" + kullaniciadi;
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet alintiDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(alintiDS);
            baglanti.Close();
            return alintiDS;

        }
        public static DataSet yazarkitaplari(int yazarid)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select KitapAdi,KitapSayfasi,KitapTuru,KitapYayinevi from Kitaplar where YazarID=" + yazarid;
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet yazarkitapDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(yazarkitapDS);
            baglanti.Close();
            return yazarkitapDS;

        }


        public static string yazarcek(int yazarid)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select * from YazarTanim where YazarID=" + yazarid;
            SqlDataAdapter adaptor = new SqlDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            string yazaradi = dt.Rows[0]["Ad"].ToString();
            string yazarsoyad = dt.Rows[0]["Soyad"].ToString();
            return yazaradi + "" + yazarsoyad;
        }

        public static DataSet yapilanincelemekitap(string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select KullaniciAdi,Yorum from KitapYorum where KitapAdi= '"+ kitapadi +"'";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet kitapincelemeDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(kitapincelemeDS);
            baglanti.Close();
            return kitapincelemeDS;

        }
        public static DataSet yapilanalintikitap(string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select KullaniciAdi,SayfaNo,Cumle from KitapAlinti where KitapAdi= '" + kitapadi + "'";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet kitapalintiDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(kitapalintiDS);
            baglanti.Close();
            return kitapalintiDS;

        }

        public static void incelemeekle(string kullaniciadi,int kitapID,string yorum,string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "insert into KitapYorum(KullaniciAdi,KitapID,Yorum,KitapAdi) values (@pkullaniciadi,@pkitapID,@pyorum,@pkitapadi)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pkitapadi", kitapadi);
            komut.Parameters.AddWithValue("@pkullaniciadi", kullaniciadi);
            komut.Parameters.AddWithValue("@pkitapID", kitapID);
            komut.Parameters.AddWithValue("@pyorum", yorum);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static int kitapIDcek(string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select * from Kitaplar where KitapAdi= '"+ kitapadi+"'";
            SqlDataAdapter adaptor = new SqlDataAdapter(sql, baglanti);
            DataTable dt = new DataTable();
            adaptor.Fill(dt);
            int kitapID = Convert.ToInt32(dt.Rows[0]["KitapID"]);
            return kitapID;
            
        }
        public static void alintiekle(string kullaniciadi, int kitapID,int sayfano, string cumle, string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "insert into KitapAlinti(KullaniciAdi,KitapID,Cumle,KitapAdi,SayfaNo) values (@pkullaniciadi,@pkitapID,@pcumle,@pkitapadi,@psayfano)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pkitapadi", kitapadi);
            komut.Parameters.AddWithValue("@pkullaniciadi", kullaniciadi);
            komut.Parameters.AddWithValue("@pkitapID", kitapID);
            komut.Parameters.AddWithValue("@pcumle", cumle);
            komut.Parameters.AddWithValue("@psayfano", sayfano);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public static void puanekle(string kullaniciadi, int kitapID, int puan ,string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "insert into KitapPuan(KullaniciAdi,KitapID,Puan,KitapAdi) values (@pkullaniciadi,@pkitapID,@ppuan,@pkitapadi)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pkitapadi", kitapadi);
            komut.Parameters.AddWithValue("@pkullaniciadi", kullaniciadi);
            komut.Parameters.AddWithValue("@pkitapID", kitapID);
            komut.Parameters.AddWithValue("@ppuan", puan);
            
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public static bool puankontrol(string kullaniciadi, string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "Select * from KitapPuan where KullaniciAdi=@pkullaniciadi and KitapAdi=@pkitapadi";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pkullaniciadi", kullaniciadi);
            komut.Parameters.AddWithValue("@pkitapadi", kitapadi);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            baglanti.Open();
            adaptor.Fill(sonucDS);
            baglanti.Close();
            bool sonuc = false;
            if (sonucDS.Tables[0].Rows.Count > 0)
                sonuc = true;
            else
                sonuc = false;
            return sonuc;
        }

        public static void okumaekle(string kullaniciadi, int kitapID, string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "insert into KitapOkuma(KullaniciAdi,KitapID,KitapAdi) values (@pkullaniciadi,@pkitapID,@pkitapadi)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pkitapadi", kitapadi);
            komut.Parameters.AddWithValue("@pkullaniciadi", kullaniciadi);
            komut.Parameters.AddWithValue("@pkitapID", kitapID);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static bool okumakontrol(string kullaniciadi, string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "Select * from KitapOkuma where KullaniciAdi=@pkullaniciadi and KitapAdi=@pkitapadi";
            SqlCommand komut = new SqlCommand();
            komut.CommandText = sql;
            komut.Connection = baglanti;
            komut.Parameters.AddWithValue("@pkullaniciadi", kullaniciadi);
            komut.Parameters.AddWithValue("@pkitapadi", kitapadi);
            DataSet sonucDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            adaptor.SelectCommand = komut;
            baglanti.Open();
            adaptor.Fill(sonucDS);
            baglanti.Close();
            bool sonuc = false;
            if (sonucDS.Tables[0].Rows.Count > 0)
                sonuc = true;
            else
                sonuc = false;
            return sonuc;
        }

        public static int okumasayisi(string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            baglanti.Open();
            string sql = "Select COUNT(KitapAdi) as okumasayi FROM KitapOkuma WHERE KitapAdi= '"+kitapadi+"' ";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            int count = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return count;
        }
        public static int kisisayisi(string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            baglanti.Open();
            string sql = "Select COUNT(KullaniciAdi) FROM KitapPuan WHERE KitapAdi= '" + kitapadi + "' ";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            int count = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return count;
        }

        public static int puantoplami(string kitapadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            baglanti.Open();
            string sql = "Select SUM(Puan) FROM KitapPuan WHERE KitapAdi= '" + kitapadi + "' ";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            int toplam = Convert.ToInt32(komut.ExecuteScalar());
            baglanti.Close();
            return toplam;
        }

        public static void mesajgonder(string gonderenadi, string gidenadi, string baslik, string tarih, string mesaj)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "insert into Mesajlar(GonderenAdi,GidenAdi,Baslik,Tarih,Mesaj) values (@pgonderenadi,@pgidenadi,@pbaslik,@ptarih,@pmesaj)";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.Parameters.AddWithValue("@pgonderenadi", gonderenadi);
            komut.Parameters.AddWithValue("@pgidenadi", gidenadi);
            komut.Parameters.AddWithValue("@pbaslik", baslik);
            komut.Parameters.AddWithValue("@ptarih", tarih);
            komut.Parameters.AddWithValue("@pmesaj", mesaj);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public static DataSet mesajcek(string gidenadi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select GonderenAdi,Baslik,Tarih,Mesaj from Mesajlar where GidenAdi= '" + gidenadi + "'";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet mesajDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(mesajDS);
            baglanti.Close();
            return mesajDS;

        }
        public static DataSet populerkitap()
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "SELECT KitapAdi, COUNT(KullaniciAdi) AS OkunmaSayi FROM KitapOkuma GROUP BY KitapAdi ORDER BY OkunmaSayi DESC";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet kitapDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(kitapDS);
            baglanti.Close();
            return kitapDS;

        }
        public static DataSet puansiralama()
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "select KitapAdi,AVG(Puan) AS OrtalamaPuan FROM KitapPuan GROUP BY KitapAdi ORDER BY OrtalamaPuan DESC";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet kitapDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(kitapDS);
            baglanti.Close();
            return kitapDS;

        }
        public static DataSet yazarpopuler()
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "SELECT YazarID ,COUNT(YazarID) AS OkunmaSayisi FROM KitapOkuma INNER JOIN Kitaplar ON KitapOkuma.KitapAdi = Kitaplar.KitapAdi GROUP BY YazarID ORDER BY OkunmaSayisi DESC";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet kitapDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(kitapDS);
            baglanti.Close();
            return kitapDS;

        }
        public static DataSet KullaniciOneriBir(string KullaniciAdi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "Select KitapOkuma.KullaniciAdi,Count(KitapOkuma.KitapID) as OrtakKitapSayisi from KitapOkuma where KitapOkuma.KitapID IN(Select KitapOkuma.KitapID FROM KitapOkuma WHERE KitapOkuma.KullaniciAdi = '" + KullaniciAdi + "') and KullaniciAdi!= '" + KullaniciAdi + "'group by KitapOkuma.KullaniciAdi";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet bilgilerDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(bilgilerDS);
            baglanti.Close();
            return bilgilerDS;
        }



        public static DataSet KullaniciOneriİki(string KullaniciAdi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "Select KullaniciAdi From KullaniciTanim WHERE KullaniciTanim.KullaniciAdi IN ( Select KitapPuan.KullaniciAdi from KitapPuan where KitapPuan.Puan In(Select Puan FROM KitapPuan WHERE KitapPuan.KullaniciAdi = '" + KullaniciAdi + "') and KitapPuan.KullaniciAdi != '" + KullaniciAdi + "' INTERSECT Select KullaniciAdi from  KitapPuan where KitapPuan.KitapID In(Select KitapPuan.KitapID FROM KitapPuan WHERE KitapPuan.KullaniciAdi= '" + KullaniciAdi + "') and KullaniciAdi!= '" + KullaniciAdi + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet bilgilerDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(bilgilerDS);
            baglanti.Close();
            return bilgilerDS;
        }


        public static DataSet KullaniciOneriUc(string KullaniciAdi)
        {
            string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
            SqlConnection baglanti = new SqlConnection(baglantiYolu);
            string sql = "Select * From Kitaplar where Kitaplar.KitapID Not in(Select Distinct(KitapOkuma.KitapID) From KitapOkuma where KitapOkuma.KullaniciAdi in (Select KitapOkuma.KullaniciAdi from KitapOkuma, KullaniciTanim where KitapOkuma.KitapID in (Select KitapOkuma.KitapID FROM KitapOkuma WHERE KitapOkuma.KullaniciAdi = '" + KullaniciAdi + "')group by KitapOkuma.KullaniciAdi Union(Select KullaniciAdi From KullaniciTanim WHERE KullaniciTanim.KullaniciAdi IN (Select KitapPuan.KullaniciAdi from KitapPuan where KitapPuan.Puan In(Select Puan FROM KitapPuan WHERE KitapPuan.KullaniciAdi= '" + KullaniciAdi + "') and KitapPuan.KullaniciAdi != '" + KullaniciAdi + "' INTERSECT Select KullaniciAdi from  KitapPuan where KitapPuan.KitapID In(Select KitapPuan.KitapID FROM KitapPuan WHERE KitapPuan.KullaniciAdi= '" + KullaniciAdi + "') and KullaniciAdi!= '" + KullaniciAdi + "'))))";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            DataSet bilgilerDS = new DataSet();
            SqlDataAdapter adaptor = new SqlDataAdapter(komut);
            baglanti.Open();
            adaptor.Fill(bilgilerDS);
            baglanti.Close();
            return bilgilerDS;
        }



    }
}