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
            // Handle search button click
            // This method will be called when the "Etsi tiedot" button is clicked
            // You can write your search logic here
            // For demonstration, let's display a message with the selected city and measurement
            string selectedCity = ddlCities.SelectedValue;
            string selectedMeasurement = ddlMeasurement.SelectedValue;
            string message = $"Searching data for {selectedMeasurement} in {selectedCity}";
            Response.Write($"<script>alert('{message}');</script>");
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