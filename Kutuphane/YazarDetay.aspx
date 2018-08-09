<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="YazarDetay.aspx.cs" Inherits="Kutuphane.YazarDetay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Yazar Adı:" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Yazar Soyadı:" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Doğum Yeri:" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Doğum Tarihi:" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Hayatı:" Font-Size="X-Large"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="Label" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label11" runat="server" Text="Yazdığı Kitaplar" Font-Underline="True" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#CCCC99" />
                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle BackColor="#F7F7DE" />
                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                <SortedAscendingHeaderStyle BackColor="#848384" />
                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                <SortedDescendingHeaderStyle BackColor="#575357" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
