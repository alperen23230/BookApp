<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Anasayfa.aspx.cs" Inherits="Kutuphane.Anasayfa" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Anasayfa</title>
    <style>
        body{
            margin:0;
            padding:0;
        }
        #navbar{
            width:1000px;
            margin:0 auto;
            
        }
        .adsoyad{
            position:relative;
            left:-75px;
            bottom:1px;
            
        }
        #navmenu{
            display:inline-block;
        }
        .navmenu{
            display:inline-block;
            position:relative;
            left:100px;
            bottom:7px;
            padding-right:30px;
            font-size:18px;
        }
        #arama{
            
            height:500px;
            width:346px;
            
            
        }
        #tavsiye{
            position:relative;
            left:350px;
            bottom:1120px;
            height:700px;
            width:910px;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="navbar">
            
            <asp:Label ID="Label1" runat="server" Text="Kütüphane Uygulaması" Font-Size="X-Large" CssClass="adsoyad"></asp:Label>
            
            <hr style="position:absolute;width:1px;height:57px;top:-4px;left:350px;"/>
            <ul id="navmenu">
                <li class="navmenu"><a href="PopulerKitaplar.aspx">Popüler Kitaplar</a></li>
                <li class="navmenu"><a href="YuksekPuanliKitaplar.aspx">Yüksek Puanlı Kitaplar</a></li>
                <li class="navmenu"><a href="PopulerYazarlar.aspx">Popüler Yazarlar</a></li>
                <li class="navmenu"><a href="MyProfile.aspx">Profilim</a></li>
               
            </ul>
        </div>
        <hr />
        <div id="content">
            <div id="arama">

                 <asp:Label ID="Label2" runat="server" Text="Kullanıcı Arama" Font-Size="X-Large" ></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Kullanıcı Ara" />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="KullaniciAdi" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="KullaniciAdi" HeaderText="KullaniciAdi" ReadOnly="True" SortExpression="KullaniciAdi" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KitapSiteConnectionString %>" SelectCommand="SELECT [KullaniciAdi] FROM [KullaniciTanim] WHERE ([KullaniciAdi] LIKE '%' + @KullaniciAdi + '%')">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox1" Name="KullaniciAdi" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
                <br />
                <asp:Button ID="Button3" runat="server" Text="Profile Git" OnClick="Button3_Click" />
            <br />
            <br />
                <asp:Label ID="Label3" runat="server" Text="Kitap Arama" Font-Size="X-Large" ></asp:Label>
                <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="Kitap Ara" />
            
           <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
               <Columns>
                   <asp:CommandField ShowSelectButton="True" />
                   <asp:BoundField DataField="KitapAdi" HeaderText="KitapAdi" SortExpression="KitapAdi" />
               </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KitapSiteConnectionString %>" SelectCommand="SELECT [KitapAdi] FROM [Kitaplar] WHERE ([KitapAdi] LIKE '%' + @KitapAdi + '%')">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TextBox2" Name="KitapAdi" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>

                <asp:Button ID="Button4" runat="server" Text="Kitap Detayına Git" OnClick="Button4_Click" />
                <br />
                <br />

                <asp:Label ID="Label4" runat="server" Text="Yazar Arama" Font-Size="X-Large" ></asp:Label>
                <br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button5" runat="server" Text="Yazar Ara" />
                <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" OnSelectedIndexChanged="GridView3_SelectedIndexChanged">
                    <Columns>
                        <asp:CommandField ShowSelectButton="True" />
                        <asp:BoundField DataField="Ad" HeaderText="Ad" SortExpression="Ad" />
                        <asp:BoundField DataField="Soyad" HeaderText="Soyad" SortExpression="Soyad" />
                    </Columns>
                 </asp:GridView>


                 <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:KitapSiteConnectionString %>" SelectCommand="SELECT [Ad], [Soyad] FROM [YazarTanim] WHERE ([Ad] LIKE '%' + @Ad + '%')">
                     <SelectParameters>
                         <asp:ControlParameter ControlID="TextBox3" Name="Ad" PropertyName="Text" Type="String" />
                     </SelectParameters>
                 </asp:SqlDataSource>
                <br />
                <asp:Button ID="Button6" runat="server" Text="Yazar Detayına Git" OnClick="Button6_Click" />



            </div>
            <hr style="width:1px;height:600px;position:relative;right:282px;bottom:522px;"/>
            <div id="tavsiye">
                <asp:Label ID="Label5" runat="server" Text="Kullanıcı Öneri 1" Font-Size="X-Large" Font-Underline="True"></asp:Label>
                <br />
                
                <asp:GridView ID="GridView4" runat="server"></asp:GridView>
                <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label6" runat="server" Text="Kullanıcı Öneri 2" Font-Size="X-Large" Font-Underline="True"></asp:Label>
                <br />
                <asp:GridView ID="GridView5" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
                 <br />
                <br />
                <br />
                <br />
                <asp:Label ID="Label7" runat="server" Text="Kitap Öneri" Font-Size="X-Large" Font-Underline="True"></asp:Label>
                <br />
                <asp:GridView ID="GridView6" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                    <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#0000A9" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#000065" />
                </asp:GridView>
            </div>

        </div>

    </form>
</body>
</html>
