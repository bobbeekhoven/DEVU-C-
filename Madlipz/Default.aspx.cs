using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Madlipz
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Food_TextBox(object sender, EventArgs e)
        {

        }

        protected void Animal_TextBox(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            string foodBox = food.Text;
            string animalBox = animal.Text;

            string result = "Every day a " + foodBox + " eats a " + animalBox + ".";

            resultLabel.Text = result;
        }
    }
}