<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="Kutuphane.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Giriş</title>
    <style>
        body{
            margin:0;
            padding:0;
        }
        #navbar{
            width:1000px;
            margin:0 auto;
            
        }
        #giris{
            width:500px;
            height:500px;
            position:absolute;
            left:30px;
             
        }
        #kayit{
            width:500px;
            height:500px;
            position:absolute;
            left:650px;
            top:90px;
        }
        #Label2{
            position:absolute;
            top:50px;
            left:20px;
        }
        #Label3{
            position:absolute;
            top:95px;
            left:95px;
        }
        #TextBox1{
            position:absolute;
            top:50px;
            left:175px;
        }
        #TextBox2{
            position:absolute;
            top:95px;
            left:175px;
        }
        #Button1{
            position:relative;
            left:150px;
            top:150px;

        }
       
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="navbar">
            <h1 style="text-align:center;">Kütüphane Uygulaması</h1>
        </div>
        <hr />

        <div id="content">
            <div id="giris">
            <asp:Label ID="Label1" runat="server" Text="Giriş" Font-Size="XX-Large"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Kullanıcı Adı:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Text="Şifre:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>

                <asp:Button ID="Button1" runat="server" Text="Giriş" OnClick="Button1_Click" />
            </div>

            <hr style="height:500px;width:1px; position:absolute; left:600px;"/>

            <div id="kayit">
                <asp:Label ID="Label4" runat="server" Text="Kayıt Ol" Font-Size="XX-Large"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label5" runat="server" Text="Kullanıcı Adı:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Şifre:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Ad:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label8" runat="server" Text="Soyad:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label9" runat="server" Text="Doğum Yeri:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label10" runat="server" Text="Doğum Tarihi:" Font-Size="X-Large"></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" Text="Profil Fotoğrafı:" Font-Size="X-Large"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" />
                <br />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Kayıt Ol" OnClick="Button2_Click" />
            </div>

        </div>
    </form>
</body>
</html>
