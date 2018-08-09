<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="Kutuphane.Admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Sayfası</title>
    <style>
         body{
            margin:0;
            padding:0;
        }
        #navbar{
            width:1000px;
            margin:0 auto;
            
        }
        #Label1{
            margin-left:20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="navbar">
            <h1 style="text-align:center;">Admin Sayfası</h1>
        </div>
        <hr />

        <asp:Label ID="Label1" runat="server" Text="Label"  Font-Size="XX-Large">İşlemler</asp:Label>
        <br />
        <br />
        <a href="Adminekleme.aspx">Kitap/Yazar Ekle</a>
        <br />
        <br />
       <a href="Adminduzenleme.aspx">Kitap/Yazar Düzenle/Sil</a>
        
       

    </form>
</body>
</html>
