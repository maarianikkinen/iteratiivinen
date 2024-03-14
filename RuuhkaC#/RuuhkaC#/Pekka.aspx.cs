using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RuuhkaC_
{
    public partial class Pekka : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize dropdowns
                PopulateMeasurementDropdown("Lahti"); // Default to Lahti
                ddlMeasurement.Items.Insert(0, new ListItem("Valitse mittauspiste", ""));
            }
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When city selection changes, populate the measurement dropdown
            PopulateMeasurementDropdown(ddlCities.SelectedValue);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
        Random rand = new Random();
    int randomNumber = rand.Next(1, 1500);
    mittari.InnerHtml = $"{randomNumber} Autoa tunnissa";
    if (randomNumber <= 500)
    {
        mittari.Style["background-color"] = "green"; // Change to green if random number is <= 500
    }
    else if (randomNumber <= 1000)
    {
        mittari.Style["background-color"] = "yellow"; // Change to yellow if random number is <= 1000
    }
    else
    {
        mittari.Style["background-color"] = "red"; // Change to red if random number is > 1000
    }
        }

        private void PopulateMeasurementDropdown(string city)
        {
            ddlMeasurement.Items.Clear(); // Clear existing items

            // Populate measurement dropdown based on the selected city
            switch (city)
            {
                case "Lahti":
                    ddlMeasurement.Items.Add(new ListItem("Kärpäsenmäki", "Kärpäsenmäki"));
                    ddlMeasurement.Items.Add(new ListItem("Lotila", "Lotila"));
                    break;
                case "Tampere":
                    ddlMeasurement.Items.Add(new ListItem("Onkiniemi", "Onkiniemi"));
                    ddlMeasurement.Items.Add(new ListItem("Petsamo", "Petsamo"));
                    break;
                case "Turku":
                    ddlMeasurement.Items.Add(new ListItem("Kupittaa", "Kupittaa"));
                    ddlMeasurement.Items.Add(new ListItem("Artukainen", "Artukainen"));
                    ddlMeasurement.Items.Add(new ListItem("Ihala", "Ihala"));
                    break;
                default:
                    break;
            }
        }
    }
}