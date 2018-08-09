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
    public partial class KitapDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");
            else
            {



                string kitapadi = Convert.ToString(Session["KitapAdi"]);
                string baglan = ConfigurationManager.ConnectionStrings["by"].ToString();
                SqlConnection cnn = new SqlConnection(baglan);

                SqlCommand komut = new SqlCommand();
                cnn.Open();
                komut.Connection = cnn;
                komut.CommandText = "Select * from Kitaplar where KitapAdi = '" + kitapadi + "'";
                komut.ExecuteNonQuery();
                SqlDataReader dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    Label2.Text = dr["KitapAdi"].ToString();
                    Label4.Text = dr["KitapSayfasi"].ToString();
                    Label6.Text = dr["KitapTuru"].ToString();
                    Label8.Text = dr["KitapYayinevi"].ToString();
                    Image1.ImageUrl = dr["KitapResim"].ToString();
                    int yazarid = Convert.ToInt32(dr["YazarID"]);
                    string yazar = DBİslemler.yazarcek(yazarid);
                    Label10.Text = yazar;

                }
                cnn.Close();

                DataSet kitapinceleme = DBİslemler.yapilanincelemekitap(kitapadi);
                GridView1.DataSource = kitapinceleme.Tables[0];
                GridView1.DataBind();

                DataSet kitapalinti = DBİslemler.yapilanalintikitap(kitapadi);
                GridView2.DataSource = kitapalinti.Tables[0];
                GridView2.DataBind();

                Label14.Text = DBİslemler.okumasayisi(kitapadi).ToString();


                int toplampuan = DBİslemler.puantoplami(kitapadi);
                int toplamkisi = DBİslemler.kisisayisi(kitapadi);
                double ort = toplampuan / toplamkisi;
                Label12.Text = ort.ToString();


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int puan = Convert.ToInt32(DropDownList1.SelectedValue);
            string kitapadi = Session["KitapAdi"].ToString();
            int kitapID = DBİslemler.kitapIDcek(kitapadi);
            string kullaniciadi = Session["KullaniciAdi"].ToString();
            bool varmi = DBİslemler.puankontrol(kullaniciadi, kitapadi);
            if (varmi == true)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Kitaba daha önce puan verilmiş!');</script>");
            }

            else
            {
                DBİslemler.puanekle(kullaniciadi, kitapID, puan, kitapadi);
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Puanınız Kaydedildi.');</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string kitapadi = Session["KitapAdi"].ToString();
            string kullaniciadi = Session["KullaniciAdi"].ToString();
            int kitapID = DBİslemler.kitapIDcek(kitapadi);

            bool varmi = DBİslemler.okumakontrol(kullaniciadi, kitapadi);
            if (varmi == true)
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Kitap okunduğu daha önce belirtilmiş!');</script>");
            }
            else
            {
                DBİslemler.okumaekle(kullaniciadi, kitapID, kitapadi);
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Okuduğunuz kitaplara eklenmiştir.');</script>");
            }
        }
    }
}