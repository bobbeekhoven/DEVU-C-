using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ageBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void moneyBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Fortune_Click(object sender, EventArgs e)
        {
            string ageBox = ageBoxTextBox.Text;
            string moneyBox = moneyBoxTextBox.Text;

            string result = "At " + ageBox + " years old, I would have expected you to have more than $" + moneyBox + " in your pocket.";

            resultLabel.Text = result;
        }
    }
}