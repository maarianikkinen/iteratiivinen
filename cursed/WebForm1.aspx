<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="cursed.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dropdown Example</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlCities" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged">
            <asp:ListItem Text="Lahti" Value="1"></asp:ListItem>
            <asp:ListItem Text="Turku" Value="2"></asp:ListItem>
            <asp:ListItem Text="Tampere" Value="3"></asp:ListItem>
        </asp:DropDownList>

        <asp:DropDownList ID="ddlOptions" runat="server"></asp:DropDownList>
    </form>
</body>
</html>