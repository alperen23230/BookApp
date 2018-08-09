<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MesajGonder.aspx.cs" Inherits="Kutuphane.MesajGonder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Başlık:" Font-Size="X-Large"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Tarih:" Font-Size="X-Large"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" TextMode="SingleLine"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Mesaj:" Font-Size="X-Large"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Mesaj Gönder" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
