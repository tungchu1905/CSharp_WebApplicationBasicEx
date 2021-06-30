<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebWorkingDB.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Category Name"></asp:Label>
            :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCategory" runat="server" Height="16px" OnSelectedIndexChanged="ddlCategory_SelectedIndexChanged" style="margin-left: 0px" Width="171px" AutoPostBack="True">
            </asp:DropDownList>
        </div>
        <asp:GridView ID="gvProduct" runat="server" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="ProductID" HeaderText="Mã Sản Phẩm" SortExpression="ProductID" />
                <asp:BoundField DataField="ProductName" HeaderText="Tên Sản Phẩm" SortExpression="ProductName" />
                <asp:BoundField DataField="UnitPrice" HeaderText="Gía sản phẩm" SortExpression="UnitPrice" />
                <asp:HyperLinkField DataNavigateUrlFields="ProductID,ProductName" DataNavigateUrlFormatString="Edit.aspx?pid={0}&amp;name={1}" HeaderText="Cap Nhat" Text="Cap nhat" />
                <asp:HyperLinkField DataNavigateUrlFields="ProductID" DataNavigateUrlFormatString="Delete.aspx?pid={0}" HeaderText="Dele" Text="xoa" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        </asp:GridView>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
    </form>
</body>
</html>
