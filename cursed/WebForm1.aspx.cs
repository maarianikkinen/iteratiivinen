using System;
using System.Web.UI.WebControls;

namespace cursed
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load initial options for the second dropdown based on the first dropdown's selected value
                PopulateOptions(1); // Load options for Lahti by default
            }
        }

        protected void ddlCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            // When the city selection changes, load options for the selected city
            int selectedCityId = Convert.ToInt32(ddlCities.SelectedValue);
            PopulateOptions(selectedCityId);
        }

        private void PopulateOptions(int cityId)
        {
            ddlOptions.Items.Clear(); // Clear existing options

            // Add options based on the selected city
            switch (cityId)
            {
                case 1: // Lahti
                    ddlOptions.Items.Add(new ListItem("Option A1", "A1"));
                    ddlOptions.Items.Add(new ListItem("Option A2", "A2"));
                    ddlOptions.Items.Add(new ListItem("Option A3", "A3"));
                    break;
                case 2: // Turku
                    ddlOptions.Items.Add(new ListItem("Option B1", "B1"));
                    ddlOptions.Items.Add(new ListItem("Option B2", "B2"));
                    break;
                case 3: // Tampere
                    ddlOptions.Items.Add(new ListItem("Option C1", "C1"));
                    ddlOptions.Items.Add(new ListItem("Option C2", "C2"));
                    ddlOptions.Items.Add(new ListItem("Option C3", "C3"));
                    break;
                default:
                    break;
            }
        }
    }
}