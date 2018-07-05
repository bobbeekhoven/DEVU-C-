using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                previousCalendar.SelectedDate = DateTime.Now.Date;
                startNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(14);
                endNewCalendar.SelectedDate = DateTime.Now.Date.AddDays(21);
            }
        }

        protected void assignButton_Click(object sender, EventArgs e)
        {
            // spies cost €500,- a day
            TimeSpan totalDurationOfAssignment = endNewCalendar.SelectedDate.Subtract(startNewCalendar.SelectedDate);
            double totalCost = totalDurationOfAssignment.TotalDays * 500.0;
            
            // if over 21 days then add €1000,-
            if (totalDurationOfAssignment.TotalDays > 21)
            {
                totalCost += 1000.0;
            }
            
            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. " +
                "Budget total: {2:C}", spyTextBox.Text, newTextBox.Text, totalCost);
            
            TimeSpan timeBetweenAssignments = startNewCalendar.SelectedDate.Subtract(previousCalendar.SelectedDate);

            if (timeBetweenAssignments.TotalDays < 14)
            {
                resultLabel.Text = String.Format("Error: Must allow at least two weeks between {0}'s " +
                    "previous assignment and new assignment!!!", spyTextBox.Text);

                DateTime earliestNewAssignmentDate = previousCalendar.SelectedDate.AddDays(14);

                startNewCalendar.SelectedDate = earliestNewAssignmentDate;
                startNewCalendar.VisibleDate = earliestNewAssignmentDate;
            }

            if (totalCost > 50000.0)
            {
                resultLabel.Text = "Budget exceeds €50000,-!!!!";
            }
        }
    }
}