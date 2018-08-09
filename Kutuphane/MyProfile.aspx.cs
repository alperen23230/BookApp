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
    public partial class MyProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");
            else
            {
                string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
                SqlConnection baglanti = new SqlConnection(baglantiYolu);
                string kullaniciadi = "'" + Convert.ToString(Session["KullaniciAdi"]) + "'";
                string sql = "select * from KullaniciTanim where KullaniciAdi=" + kullaniciadi;
                SqlDataAdapter adaptor = new SqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                adaptor.Fill(dt);
                Label1.Text = dt.Rows[0]["Ad"].ToString();
                Label2.Text = dt.Rows[0]["Soyad"].ToString();
                Image1.ImageUrl = dt.Rows[0]["ProfilFoto"].ToString();



                DataSet okunankitap = DBİslemler.okunankitap(kullaniciadi);
                GridView1.DataSource = okunankitap.Tables[0];
                GridView1.DataBind();

                DataSet verilenpuanlar = DBİslemler.verilenpuan(kullaniciadi);
                GridView2.DataSource = verilenpuanlar.Tables[0];
                GridView2.DataBind();

                DataSet yapilaninceleme = DBİslemler.yapilaninceleme(kullaniciadi);
                GridView3.DataSource = yapilaninceleme.Tables[0];
                GridView3.DataBind();

                DataSet yapilanalinti = DBİslemler.yapilanalinti(kullaniciadi);
                GridView4.DataSource = yapilanalinti.Tables[0];
                GridView4.DataBind();


            }


        }
    }
}