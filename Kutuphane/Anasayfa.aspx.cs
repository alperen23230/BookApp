using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace Kutuphane
{
    public partial class Anasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");
            else
            {
                string kullaniciadi =  Convert.ToString(Session["KullaniciAdi"]);
                DataSet oneri1 = DBİslemler.KullaniciOneriBir(kullaniciadi);
                GridView4.DataSource = oneri1.Tables[0];
                GridView4.DataBind();

                DataSet oneri2 = DBİslemler.KullaniciOneriİki(kullaniciadi);
                GridView5.DataSource = oneri2.Tables[0];
                GridView5.DataBind();

                DataSet oneri3 = DBİslemler.KullaniciOneriUc(kullaniciadi);
                GridView6.DataSource = oneri3.Tables[0];
                GridView6.DataBind();

            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secili;
            secili = GridView1.SelectedIndex;
            GridViewRow row = GridView1.Rows[secili];
            string bkullaniciadi = row.Cells[1].Text;
            Session["bkullaniciadi"] = bkullaniciadi;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/profile.aspx");
            Response.Redirect("profile.aspx");
        }

        protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secili;
            secili = GridView2.SelectedIndex;
            GridViewRow row = GridView2.Rows[secili];
            string kitapadi = row.Cells[1].Text;
            Session["KitapAdi"] = kitapadi;
           
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/KitapDetay.aspx");
            Response.Redirect("KitapDetay.aspx");
        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            int secili;
            secili = GridView3.SelectedIndex;
            GridViewRow row = GridView3.Rows[secili];
            string yazaradi = row.Cells[1].Text;
            Session["YazarAdi"] = yazaradi;
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Server.Transfer("~/YazarDetay.aspx");
            Response.Redirect("YazarDetay.aspx");
        }
    }
}