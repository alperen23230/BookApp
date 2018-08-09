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
    public partial class YuksekPuanliKitaplar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");
            else
            {
                DataSet yuksekpuan = DBİslemler.puansiralama();
                GridView1.DataSource = yuksekpuan.Tables[0];
                GridView1.DataBind();
            }
        }
    }
}