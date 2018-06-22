using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            if (myCalendar1.SelectedDate > myCalendar2.SelectedDate)
            {
                resultLabel.Text = myCalendar1.SelectedDate
                .Subtract(myCalendar2.SelectedDate)
                .TotalDays.ToString();
            }
            else
            {
                resultLabel.Text = myCalendar2.SelectedDate
                .Subtract(myCalendar1.SelectedDate)
                .TotalDays.ToString();
            }
            
            


        }
    }
}