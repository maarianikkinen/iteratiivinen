<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="moi.WebForm1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="styles.css">
    <meta charset="UTF-8">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="ylin">
                <asp:DropDownList ID="Kaupunki" runat="server" AutoPostBack="true" OnSelectedIndexChanged="Kaupunki_SelectedIndexChanged">
                    <asp:ListItem Value="Valitsekaupunki">Valitse kaupunki</asp:ListItem>    
                    <asp:ListItem Value="Lahti">Lahti</asp:ListItem>
                    <asp:ListItem Value="Tampere">Tampere</asp:ListItem>
                    <asp:ListItem Value="Turku">Turku</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class ="toka">
                <asp:DropDownList ID="Mittaus" runat="server">
                    <asp:ListItem Value="Valitsemittauspiste">Mittauspiste</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class ="kolmas">
                <button class="etsi">Etsi tiedot</button>
            </div>
        </div>
    </form>

    <div id="mittari">
    </div>
</body>
</html>

