<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="WAPP_K215480106063.TrangChu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TrangChu</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.min.js"></script>
    <style type="text/css">
        .banghienthi {
            position:absolute;
            top: 134px;
            left: 276px;
        }

        .auto-style2 {}
        .auto-style3 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server" BackColor="#FFFF99" Height="800px" Width="100%" CssClass="auto-style3">
                <asp:Button ID="nut_them_sv" runat="server" Text="Them sinh vien" OnClick="Them_SV_Click" />
                <asp:Button ID="nut_xoa_sv" runat="server" OnClick="Xoa_SV_Click" Text="Xoa sinh vien" />
                <asp:Button ID="nut_chinhsua_sv" runat="server" OnClick="ChinhSua_SV_Click" Text="Chinh sua" />

                <asp:GridView ID="GridView1" runat="server" 
                    BackColor="White" 
                    BorderColor="#DEDFDE" 
                    BorderStyle="None" 
                    BorderWidth="1px"
                    CellPadding="4" 
                    EnableModelValidation="True" 
                    ForeColor="Black" 
                    GridLines="Vertical" 
                    CssClass="banghienthi" 
                    Height="280px" 
                    Width="627px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="ID" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="ID" />
                        <asp:BoundField DataField="MaSinhVien" HeaderText="MaSinhVien" SortExpression="MaSinhVien" />
                        <asp:BoundField DataField="HoTen" HeaderText="HoTen" SortExpression="HoTen" />
                        <asp:BoundField DataField="NgaySinh" HeaderText="NgaySinh" SortExpression="NgaySinh" />
                        <asp:BoundField DataField="Lop" HeaderText="Lop" SortExpression="Lop" />
                        <asp:BoundField DataField="XepLoaiHocLuc" HeaderText="XepLoaiHocLuc" SortExpression="XepLoaiHocLuc" />
                    </Columns>
                    <FooterStyle BackColor="#CCCC99" />
                    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                    <RowStyle BackColor="#F7F7DE" />
                    <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                </asp:GridView>

                <br />
                MaSinhVien<br />
                <asp:TextBox ID="TextBox_MaSinhVien" runat="server" CssClass="auto-style2" Width="205px"></asp:TextBox>
                <br />
                TenSinhVien<br />
                <asp:TextBox ID="TextBox_HoTen" runat="server" CssClass="auto-style2" Width="205px"></asp:TextBox>
                <br />
                NgaySinh<br />
                <asp:TextBox ID="TextBox_NgaySinh" runat="server" CssClass="auto-style2" Width="205px"></asp:TextBox>
                <br />
                Lop<br />
                <asp:TextBox ID="TextBox_Lop" runat="server" CssClass="auto-style2" Width="205px"></asp:TextBox>
                <br />
                XepLoaiHocLuc<br />
                <asp:TextBox ID="TextBox_XepLoaiHocLuc" runat="server" CssClass="auto-style2" Width="205px"></asp:TextBox>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
