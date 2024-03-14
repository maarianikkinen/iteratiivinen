<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pekka.aspx.cs" Inherits="RuuhkaC_.Pekka" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles.css">
    <meta charset="UTF-8">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="ylin">
            <asp:DropDownList ID="ddlCities" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCities_SelectedIndexChanged">
                <asp:ListItem Text="Valitse kaupunki" Value=""></asp:ListItem>
                <asp:ListItem Text="Lahti" Value="Lahti"></asp:ListItem>
                <asp:ListItem Text="Tampere" Value="Tampere"></asp:ListItem>
                <asp:ListItem Text="Turku" Value="Turku"></asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <div class="toka">
            <asp:DropDownList ID="ddlMeasurement" runat="server">
                <asp:ListItem Text="Valitse mittauspiste" Value=""></asp:ListItem>
            </asp:DropDownList>
        </div>
        
        <div class="kolmas">
            <asp:Button ID="btnSearch" runat="server" CssClass="etsi" Text="Etsi tiedot" OnClick="btnSearch_Click" />
        </div>
    </form>
<div id="mittari" runat="server">
    </div>
</body>
</html>
