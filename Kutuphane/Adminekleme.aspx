<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminekleme.aspx.cs" Inherits="Kutuphane.Adminekleme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Ekleme</title>
<style>
    body{
            margin:0;
            padding:0;
        }
        #navbar{
            width:1000px;
            margin:0 auto;
            
        }
        #yazarekle{
            width:500px;
            height:500px;
            position:absolute;
            left:30px;
             
        }
        #kitapekle{
            width:500px;
            height:500px;
            position:absolute;
            left:650px;
            top:90px;
        }
</style>
</head>
<body>
    <form id="form1" runat="server">
       <div id="navbar">
            <h1 style="text-align:center;">Admin Sayfası</h1>
        </div>
        <hr />

        <div id="content">
            <div id="yazarekle">
            <asp:Label ID="Label1" runat="server" Text="Yazar Ekle" Font-Size="XX-Large"></asp:Label>
                <br />
                <br />
            <asp:Label ID="Label2" runat="server" Text="Yazar Adı:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <br />
            <asp:Label ID="Label3" runat="server" Text="Yazar Soyadı:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label12" runat="server" Text="Hayatı:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server" TextMode="MultiLine"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label13" runat="server" Text="Doğum Tarihi:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label14" runat="server" Text="Doğum Yeri" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="Button1" runat="server" Text="Yazar Ekle" OnClick="Button1_Click" />
            </div>

            <hr style="height:500px;width:1px; position:absolute; left:600px;"/>

            <div id="kitapekle">
                <asp:Label ID="Label4" runat="server" Text="Kitap Ekle" Font-Size="XX-Large"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Kitap Adı:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Kitap Türü" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Sayfa Sayısı:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" Text="Yayınevi:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                <br />               
                <asp:Label ID="Label11" runat="server" Text="Kitap Fotoğrafı:" Font-Size="X-Large"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <br />
                <asp:Label ID="Label9" runat="server" Text="Yazarı"></asp:Label>
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Kitap Ekle" OnClick="Button2_Click"  />
            </div>

        </div>
    </form>
</body>
</html>
