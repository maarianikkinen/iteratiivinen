using System;

namespace Cursed
{
    public partial class Pasi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Nothing to do on page load
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            // Generate a random number between 1 and 1500
            Random rand = new Random();
            int randomNumber = rand.Next(1, 1501);

            // Display the random number in the mittari div
            mittari.InnerHtml = $"{randomNumber} Autoa tunnissa";
            if (randomNumber <= 500)
    {
        mittari.Style["background-color"] = "#00C108"; // Change to green if random number is <= 500
    }
    else if (randomNumber <= 1000)
    {
        mittari.Style["background-color"] = "#FEF606"; // Change to yellow if random number is <= 1000
    }
    else
    {
        mittari.Style["background-color"] = "#FD0B0B"; // Change to red if random number is > 1000
    } 
        }
    }
}
