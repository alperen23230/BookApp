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
    public partial class YazarDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");
            else
            {
                string baglantiYolu = ConfigurationManager.ConnectionStrings["by"].ToString();
                SqlConnection baglanti = new SqlConnection(baglantiYolu);
                string yazaradi = "'" + Convert.ToString(Session["YazarAdi"]) + "'";
                string sql = "select * from YazarTanim where Ad=" + yazaradi;
                SqlDataAdapter adaptor = new SqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                adaptor.Fill(dt);
                Label2.Text = dt.Rows[0]["Ad"].ToString();
                Label4.Text = dt.Rows[0]["Soyad"].ToString();
                Label6.Text = dt.Rows[0]["DogumYeri"].ToString();
                Label8.Text= dt.Rows[0]["DogumTarih"].ToString();
                Label10.Text= dt.Rows[0]["Hayati"].ToString();

                int yazarid =Convert.ToInt32( dt.Rows[0]["YazarID"]);

                DataSet yazarkitap = DBİslemler.yazarkitaplari(yazarid);
                GridView1.DataSource = yazarkitap.Tables[0];
                GridView1.DataBind();


            }
        }
    }
}