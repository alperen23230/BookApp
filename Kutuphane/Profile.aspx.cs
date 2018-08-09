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
    public partial class Profil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");
            else
            {


                
                string kullaniciadi = Convert.ToString(Session["bkullaniciadi"]) ;
                string baglan = ConfigurationManager.ConnectionStrings["by"].ToString();
                SqlConnection cnn = new SqlConnection(baglan);
                
                SqlCommand komut = new SqlCommand();
                cnn.Open();
                komut.Connection = cnn;
                komut.CommandText = "Select * from KullaniciTanim where KullaniciAdi = '" + kullaniciadi + "'";
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Label1.Text = dr["Ad"].ToString();
                    Label2.Text = dr["Soyad"].ToString();
                    Image1.ImageUrl = dr["ProfilFoto"].ToString();

                }

                string Kullaniciadi= "'" + Convert.ToString(Session["bkullaniciadi"]) + "'";

                DataSet okunankitap = DBİslemler.okunankitap(Kullaniciadi);
                GridView1.DataSource = okunankitap.Tables[0];
                GridView1.DataBind();

                DataSet verilenpuanlar = DBİslemler.verilenpuan(Kullaniciadi);
                GridView2.DataSource = verilenpuanlar.Tables[0];
                GridView2.DataBind();

                DataSet yapilaninceleme = DBİslemler.yapilaninceleme(Kullaniciadi);
                GridView3.DataSource = yapilaninceleme.Tables[0];
                GridView3.DataBind();

                DataSet yapilanalinti = DBİslemler.yapilanalinti(Kullaniciadi);
                GridView4.DataSource = yapilanalinti.Tables[0];
                GridView4.DataBind();
            }
        }
    }
}