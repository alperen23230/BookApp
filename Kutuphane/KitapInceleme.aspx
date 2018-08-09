<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KitapInceleme.aspx.cs" Inherits="Kutuphane.KitapInceleme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="İnceleme Yazınız:" Font-Size="XX-Large"></asp:Label>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="İncelemeyi kaydet" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
