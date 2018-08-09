using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kutuphane
{
    public partial class KitapInceleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string kitapadi = Session["KitapAdi"].ToString();
            int kitapID = DBİslemler.kitapIDcek(kitapadi);
            string kullaniciadi = Session["KullaniciAdi"].ToString();
            string yorum = TextBox1.Text;
            DBİslemler.incelemeekle(kullaniciadi, kitapID, yorum, kitapadi);
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('İncelemeniz Kaydedildi.');</script>");
            Response.Redirect("KitapDetay.aspx");
        }
    }
}