<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="KitapDetay.aspx.cs" Inherits="Kutuphane.KitapDetay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Kitap Detay</title>
    <style>
        body{
            margin:0;
            padding:0;
        }
        #Image1{
            width:200px;
            height:250px;
        }
        .islem{
            position:relative;
            left:150px;
            bottom:100px;
        }
        .islem2{
            position:relative;
            left:-70px;
            bottom:55px;
        }
        .islem3{
            position:relative;
            bottom:100px;
            padding-right:5px;
        }
        .islem4{
            position:relative;
            bottom:100px;
            left:55px;
            padding-right:20px;
            font-size:20px;
        }
        #Label15{
            position:relative;
            right:500px;
            top:30px;


        }
        #Label16{
            position:relative;
            left:500px;
            top:150px;
        }
        #Button2{
            position:relative;
            left:640px;
            bottom:200px;
        }  
        #GridView1{
            position:relative;
            left:500px;
            top:50px;
        }
        #GridView2{
            position:relative;
            left:400px;
            top:170px;
        }
        .kitapbilgi{
            position:relative;
            bottom:60px;
        }
        
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" />
            
            <asp:Label ID="Label11" runat="server" Text="Ortalama Puanı:" Font-Size="X-Large" CssClass="islem"></asp:Label>
            <asp:Label ID="Label12" runat="server" Text="0" Font-Size="X-Large" CssClass="islem"></asp:Label>
            
            <asp:Label ID="Label13" runat="server" Text="Okunma Sayısı:" Font-Size="X-Large" CssClass="islem2"></asp:Label>
            <asp:Label ID="Label14" runat="server" Text="Label" Font-Size="X-Large" CssClass="islem2"></asp:Label>
            
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="islem3">
                <asp:ListItem Value="1">1</asp:ListItem>
                <asp:ListItem Value="2">2</asp:ListItem>
                <asp:ListItem Value="3">3</asp:ListItem>
                <asp:ListItem Value="4">4</asp:ListItem>
                <asp:ListItem Value="5"></asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Puan Ver" class="islem3" OnClick="Button1_Click"/>

            <a href="KitapInceleme.aspx" class="islem4">İnceleme Yaz</a>
            <a href="KitapAlinti.aspx" class="islem4">Alıntı Yap</a>

            <asp:Label ID="Label15" runat="server" Text="Yapılan İncelemeler" Font-Size="XX-Large" CssClass="islem5" Font-Underline="True" ></asp:Label>
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>
            <asp:Label ID="Label16" runat="server" Text="Yapılan Alıntılar" Font-Size="XX-Large" CssClass="islem5" Font-Underline="True" ></asp:Label>
            <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>

            <asp:Button ID="Button2" runat="server" Text="Bu Kitabı Okudum" OnClick="Button2_Click"/>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Kitap Adı:" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Sayfa Sayısı:" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Label" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Kitap Türü:" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Label" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Yayın Evi:" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="Label" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <br />
            <asp:Label ID="Label9" runat="server" Text="Yazarı:" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="Label" Font-Size="X-Large" CssClass="kitapbilgi"></asp:Label>
            
            

        </div>
    </form>
</body>
</html>
