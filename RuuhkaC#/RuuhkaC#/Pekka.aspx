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
        <div>
        </div>
    </form>
    <div class="ylin">

      
                <select name="Kaupunki" id="Kaupunki">
                <option value ="Valitsekaupunki">Valitse kaupunki</option>    
                <option value="Lahti">Lahti</option>
                <option value="Tampere">Tampere </option>
                <option value="Turku">Turku</option>
                </select>
         <%  switch (Kaupunki) {
  case "Lahti" %>
        </div>
        
    </div>
    <div class ="toka">
        <select name="Mittaus" id="Mittaus">
            <option value ="Valitsemittauspiste"> Mittauspiste</option>    
            <option value="Kärpäsenmäki">Kärpäsenmäki</option>
            <option value="Lotila">Lotila </option>

            </select>
        
        </div><label for ="Dropbtn2" id="Dropbtn2"></label>
        
    </div>
    <div class ="kolmas">
        <button class = etsi> Etsi tiedot</button>
    </div>

    
    <div id="mittari">
    </div>







</body>
</html>

