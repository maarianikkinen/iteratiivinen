<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pasi.aspx.cs" Inherits="Cursed.Pasi" %>
<!DOCTYPE html>
<html>
<head>
    <title>Ruuhka.fi</title>
    <meta charset="UTF-8">
    <link rel="stylesheet" href="styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="ylin">
            <select name="Kaupunki" id="Kaupunki" onchange="this.form.submit()">
                <option value="Valitsekaupunki">Valitse kaupunki</option>
                <option value="Lahti" <% if(Request.Form["Kaupunki"] == "Lahti") { %> selected <% } %>>Lahti</option>
                <option value="Tampere" <% if(Request.Form["Kaupunki"] == "Tampere") { %> selected <% } %>>Tampere</option>
                <option value="Turku" <% if(Request.Form["Kaupunki"] == "Turku") { %> selected <% } %>>Turku</option>
            </select>
        </div>

        <div class="toka">
            <select name="Mittaus" id="Mittaus">
                <option value="Valitsemittauspiste">Valitse mittauspiste</option>
                <% 
                if (IsPostBack)
                {
                    string selectedCity = Request.Form["Kaupunki"];
                    switch (selectedCity)
                    {
                        case "Lahti":
                %>
                <option value='Kärpäsenmäki' <% if(Request.Form["Mittaus"] == "Kärpäsenmäki") { %> selected <% } %>>Kärpäsenmäki</option>
                <option value='Lotila' <% if(Request.Form["Mittaus"] == "Lotila") { %> selected <% } %>>Lotila</option>
                <%          break;
                        case "Tampere":
                %>
<option value='Onkiniemi' <% if(Request.Form["Mittaus"] == "Onkiniemi") { %> selected <% } %>>Onkiniemi</option>
                <option value='Petsamo' <% if(Request.Form["Mittaus"] == "Petsamo") { %> selected <% } %>>Petsamo</option>
                <%          break;
                        case "Turku":
                %>
                <option value='Kupittaa' <% if(Request.Form["Mittaus"] == "Kupittaa") { %> selected <% } %>>Kupittaa</option>
                <option value='Artukainen' <% if(Request.Form["Mittaus"] == "Artukainen") { %> selected <% } %>>Artukainen</option>
                <option value='Ihala' <% if(Request.Form["Mittaus"] == "Ihala") { %> selected <% } %>>Ihala</option>
                <%          break;
                        default:
                %>
                <option value='Valitsemittauspiste'>Valitse mittauspiste</option>
                <%          break;
                    }
                }
                %>
            </select>
        </div>

        <div class="kolmas">
            <asp:Button ID="btnGenerate" runat="server" CssClass="etsi" Text="Etsi tiedot" OnClick="btnGenerate_Click" />
        </div>
    </form>

    <div id="mittari" runat="server">
        <!-- Result will be displayed here -->
    </div>
</body>
</html>
