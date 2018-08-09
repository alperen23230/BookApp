using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kutuphane
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = TextBox1.Text;
            string Sifre = TextBox2.Text;
            bool varmi = DBİslemler.giriskontrol(KullaniciAdi, Sifre);
            bool varmiadmin = DBİslemler.giriskontroladmin(KullaniciAdi, Sifre);
            if (varmi == true)
            {
                Session["giris"] = true;
                Session["KullaniciAdi"] = KullaniciAdi;
                Response.Redirect("Anasayfa.aspx");
            }
            else if (varmiadmin == true)
            {
                Session["giris"] = true;
                Response.Redirect("Admin.aspx");
            }
            else
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Yanlış şifre ve/veya hatalı kullanıcı adı!');</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = TextBox3.Text;
            string Sifre = TextBox4.Text;
            string Ad = TextBox5.Text;
            string Soyad = TextBox6.Text;
            string DogumYeri = TextBox7.Text;
            string DogumTarihi = TextBox8.Text;
            if (FileUpload1.HasFile)
            {
                string fname = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//ProfilFotolar//" + fname);
                string Dosyayolu = "~//ProfilFotolar//" + fname.ToString();
                DBİslemler.uyeekle(KullaniciAdi, Sifre, Ad, Soyad, DogumYeri, DogumTarihi, Dosyayolu);
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Lütfen bir fotoğraf yükleyiniz!');</script>");
            }

        }
    }
}