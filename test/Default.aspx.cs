using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace test
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*
            int age = 18;
            string result = "";
            if (age <= 18) result = "You are a child";
            if (age >= 18) result = "You are an adult";
            */

            /*
            int input = 20;
            string result = "";

            if (input > 10)
                input += 1;
            result = "Greater than 10";
            */

            /*
            int input1 = 20;
            int input2 = 30;
            int input3 = 40;
            string result = "Starting ...";

            if (input1 > 15 || input2 < 35 && input3 > 50)
                result = "Got here!";
                */
            /*
            int input1 = 20;
            int input2 = 30;
            string result = "Starting ...";

            if ((input1 == input2) ? false : true)
                result = "Got here!";
            */

            //DateTime today = new DateTime("2/14/2015");
            //resultLabel.Text = today.ToString();

            /*
            DateTime today = DateTime.Parse("14/2/2015");
            DateTime later = today.Add(new TimeSpan(28, 5, 30));
            resultLabel.Text = later.Day.ToString();
            */

            //if (DateTime.Now.DayOfWeek == "Monday")
            //resultLabel.Text = "It's Monday!";

            DateTime myFirstDate = DateTime.Parse("15/2/2015");
            DateTime mySecondDate = DateTime.Parse("16/2/2015 14:30:0");
            TimeSpan span = mySecondDate.Subtract(myFirstDate);
            resultLabel.Text = span.TotalHours.ToString();

           // resultLabel.Text = result;
        }
    }
}