using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kutuphane
{
    public partial class MesajGonder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string baslik = TextBox1.Text;
            string tarih = TextBox2.Text;
            string mesaj = TextBox3.Text;
            string gidenk = Session["bkullaniciadi"].ToString();
            string gonderenk = Session["KullaniciAdi"].ToString();
            DBİslemler.mesajgonder(gonderenk, gidenk, baslik, tarih, mesaj);
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Mesaj Gönderildi!');</script>");
            Response.Redirect("Profile.aspx");
        }
    }
}