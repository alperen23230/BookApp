<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adminduzenleme.aspx.cs" Inherits="Kutuphane.Admindüzenleme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Düzenleme Silme</title>
    <style>
         body{
            margin:0;
            padding:0;
        }
        #navbar{
            width:1000px;
            margin:0 auto;
            
        }
         #kitapduzenle{
             margin:0 auto;
            margin-bottom:20px;
            width:500px;
            height:auto;
            position:relative;
            left:30px;

             }
        #yazarduzenle{
            margin:0 auto;
            width:500px;
            height:auto;
            position:relative;
            
            
        }
        #GridView1{
            position:relative;
            margin:0 auto;
            left:-150px;
        }
        #GridView2{
            position:relative;
            margin:0 auto;
            left:-120px;
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
            <div id="kitapduzenle">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="KitapID" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="KitapID" HeaderText="KitapID" InsertVisible="False" ReadOnly="True" SortExpression="KitapID" />
                        <asp:BoundField DataField="KitapAdi" HeaderText="KitapAdi" SortExpression="KitapAdi" />
                        <asp:BoundField DataField="KitapSayfasi" HeaderText="KitapSayfasi" SortExpression="KitapSayfasi" />
                        <asp:BoundField DataField="KitapTuru" HeaderText="KitapTuru" SortExpression="KitapTuru" />
                        <asp:BoundField DataField="YazarID" HeaderText="YazarID" SortExpression="YazarID" />
                        <asp:BoundField DataField="KitapResim" HeaderText="KitapResim" SortExpression="KitapResim" />
                        <asp:BoundField DataField="KitapYayinevi" HeaderText="KitapYayinevi" SortExpression="KitapYayinevi" />
                    </Columns>
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
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:KitapSiteConnectionString %>" DeleteCommand="DELETE FROM [Kitaplar] WHERE [KitapID] = @KitapID" InsertCommand="INSERT INTO [Kitaplar] ([KitapAdi], [KitapSayfasi], [KitapTuru], [YazarID], [KitapResim], [KitapYayinevi]) VALUES (@KitapAdi, @KitapSayfasi, @KitapTuru, @YazarID, @KitapResim, @KitapYayinevi)" SelectCommand="SELECT * FROM [Kitaplar]" UpdateCommand="UPDATE [Kitaplar] SET [KitapAdi] = @KitapAdi, [KitapSayfasi] = @KitapSayfasi, [KitapTuru] = @KitapTuru, [YazarID] = @YazarID, [KitapResim] = @KitapResim, [KitapYayinevi] = @KitapYayinevi WHERE [KitapID] = @KitapID">
                    <DeleteParameters>
                        <asp:Parameter Name="KitapID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="KitapAdi" Type="String" />
                        <asp:Parameter Name="KitapSayfasi" Type="String" />
                        <asp:Parameter Name="KitapTuru" Type="String" />
                        <asp:Parameter Name="YazarID" Type="Int32" />
                        <asp:Parameter Name="KitapResim" Type="String" />
                        <asp:Parameter Name="KitapYayinevi" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="KitapAdi" Type="String" />
                        <asp:Parameter Name="KitapSayfasi" Type="String" />
                        <asp:Parameter Name="KitapTuru" Type="String" />
                        <asp:Parameter Name="YazarID" Type="Int32" />
                        <asp:Parameter Name="KitapResim" Type="String" />
                        <asp:Parameter Name="KitapYayinevi" Type="String" />
                        <asp:Parameter Name="KitapID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
            </div>

           

            <div id="yazarduzenle">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="YazarID" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
                    <AlternatingRowStyle BackColor="#DCDCDC" />
                    <Columns>
                        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                        <asp:BoundField DataField="YazarID" HeaderText="YazarID" InsertVisible="False" ReadOnly="True" SortExpression="YazarID" />
                        <asp:BoundField DataField="Ad" HeaderText="Ad" SortExpression="Ad" />
                        <asp:BoundField DataField="Soyad" HeaderText="Soyad" SortExpression="Soyad" />
                        <asp:BoundField DataField="Hayati" HeaderText="Hayati" SortExpression="Hayati" />
                        <asp:BoundField DataField="DogumTarih" HeaderText="DogumTarih" SortExpression="DogumTarih" />
                        <asp:BoundField DataField="DogumYeri" HeaderText="DogumYeri" SortExpression="DogumYeri" />
                    </Columns>
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
              
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:KitapSiteConnectionString %>" DeleteCommand="DELETE FROM [YazarTanim] WHERE [YazarID] = @YazarID" InsertCommand="INSERT INTO [YazarTanim] ([Ad], [Soyad], [Hayati], [DogumTarih], [DogumYeri]) VALUES (@Ad, @Soyad, @Hayati, @DogumTarih, @DogumYeri)" SelectCommand="SELECT * FROM [YazarTanim]" UpdateCommand="UPDATE [YazarTanim] SET [Ad] = @Ad, [Soyad] = @Soyad, [Hayati] = @Hayati, [DogumTarih] = @DogumTarih, [DogumYeri] = @DogumYeri WHERE [YazarID] = @YazarID">
                    <DeleteParameters>
                        <asp:Parameter Name="YazarID" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Ad" Type="String" />
                        <asp:Parameter Name="Soyad" Type="String" />
                        <asp:Parameter Name="Hayati" Type="String" />
                        <asp:Parameter Name="DogumTarih" Type="String" />
                        <asp:Parameter Name="DogumYeri" Type="String" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Ad" Type="String" />
                        <asp:Parameter Name="Soyad" Type="String" />
                        <asp:Parameter Name="Hayati" Type="String" />
                        <asp:Parameter Name="DogumTarih" Type="String" />
                        <asp:Parameter Name="DogumYeri" Type="String" />
                        <asp:Parameter Name="YazarID" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>
              
            </div>

        </div>

    </form>
</body>
</html>
