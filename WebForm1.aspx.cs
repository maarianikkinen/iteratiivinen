using System;
using System.Web.UI.WebControls;

namespace moi
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // You can initialize data here if needed
            }
        }

        protected void Kaupunki_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear existing items
            Mittaus.Items.Clear();

            // Populate second dropdown based on selected city
            switch (Kaupunki.SelectedValue)
            {
                case "Lahti":
                    Mittaus.Items.Add(new ListItem("Mittauspiste", "Mittauspiste"));
                    Mittaus.Items.Add(new ListItem("Lotila", "Lotila"));
                    Mittaus.Items.Add(new ListItem("Kärpäsenmäki", "Kärpäsenmäki"));
                    break;
                case "Tampere":
                Mittaus.Items.Add(new ListItem("Mittauspiste", "Mittauspiste"));
                    Mittaus.Items.Add(new ListItem("Onkiniemi", "Onkiniemi"));
                    Mittaus.Items.Add(new ListItem("Petsamo", "Petsamo"));
                    
                    break;
                case "Turku":
                Mittaus.Items.Add(new ListItem("Mittauspiste", "Mittauspiste"));
                    Mittaus.Items.Add(new ListItem("Kupittaa", "Kupittaa"));
                    Mittaus.Items.Add(new ListItem("Artukainen", "Artukainen"));
                    Mittaus.Items.Add(new ListItem("Ihala", "Ihala"));
                    break;
                default:
                    // Do nothing
                    break;
            }
        }
    }
}
