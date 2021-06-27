<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="WebWorkingDB.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ProductID:
            <asp:Label ID="lblId" runat="server" Text="Label"></asp:Label>
            <br />
            ProductName:
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            UnitPrice:
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Height="42px" OnClick="Button1_Click" Text="Edit" Width="110px" />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
