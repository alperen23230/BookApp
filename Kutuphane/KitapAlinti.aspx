<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KitapAlinti.aspx.cs" Inherits="Kutuphane.KitapAlinti" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Sayfa No:" Font-Size="X-Large"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Yapılacak Alıntı:" Font-Size="X-Large"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Yapılan Alıntıyı Kaydet" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
