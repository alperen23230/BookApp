using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Kutuphane
{
    public partial class Adminekleme : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(Session["giris"]) != true)
                Response.Redirect("Giris.aspx?msg=Oncelikle giris yapmalisiniz");

            else
            {

                if (!IsPostBack)
                {
                    
                    DataSet yazarlar = DBİslemler.Yazarlaricek();
                    DropDownList1.DataTextField = "Ad";
                    DropDownList1.DataValueField = "YazarID";
                    DropDownList1.DataSource = yazarlar.Tables[0];
                    DropDownList1.DataBind();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string YazarAdi = TextBox1.Text;
            string YazarSoyadi = TextBox2.Text;
            string Hayati = TextBox9.Text;
            string DogumTarihi = TextBox10.Text;
            string DogumYeri = TextBox11.Text;
            DBİslemler.yazarekle(YazarAdi,YazarSoyadi,Hayati,DogumTarihi,DogumYeri);
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Yazar sisteme eklenmiştir.');</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox9.Text = "";
            TextBox10.Text = "";
            TextBox11.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string KitapAdi = TextBox3.Text;
            string KitapTuru = TextBox4.Text;
            string KitapSayfasi = TextBox5.Text;
            string Yayinevi = TextBox6.Text;
            int YazarID = Convert.ToInt32(DropDownList1.SelectedValue);
            if (FileUpload1.HasFile)
            {
                string fname = FileUpload1.FileName;
                FileUpload1.PostedFile.SaveAs(Server.MapPath(".") + "//KitapFotolar//" + fname);
                string Dosyayolu = "~//KitapFotolar//" + fname.ToString();
                DBİslemler.kitapekle(KitapAdi,KitapTuru,KitapSayfasi,Yayinevi,YazarID,Dosyayolu);
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Kitap sisteme eklenmiştir.');</script>");
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
            }
            else
            {
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Hata", "<script>alert('Lütfen bir fotoğraf yükleyiniz!');</script>");
            }
        }
    }
}