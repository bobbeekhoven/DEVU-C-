using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_019
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            //string result = String.Format("Thank you, {0}, for your business",
            //    nameTextBox.Text);
            int ss = int.Parse(ssTextBox.Text);
            //string result = String.Format
            //    ("Thank you, {0}, for your business.
            //<br /> Your social security number is: {1:00 00 00 000}", 
            //    nameTextBox.Text, ss);

            int phone = int.Parse(phoneTextBox.Text);
            //string result = String.Format("Thank you {0}, for your business." +
            //    " <br /> Your social security number is: {1:00 00 00 000}." +
            //    " <br /> Phone: {2: 00-00 00 00 00}", nameTextBox.Text, ss, phone);

            //string result = String.Format("Thank you {0}, for your business." +
            //    " <br /> Your social security number is: {1:00 00 00 000}." +
            //    " <br /> Phone: {2: 00-00 00 00 00}" +
            //    " <br /> Loan Date: {3:dddd dd/MM/yyyy}",
            //    nameTextBox.Text, ss, phone, loanDateCalendar.SelectedDate);

            double salary = double.Parse(salaryTextBox.Text);
            string result = String.Format("Thank you {0}, for your business." +
                " <br /> Your social security number is: {1:00 00 00 000}." +
                " <br /> Phone: {2: 00-00 00 00 00}" +
                " <br /> Loan Date: {3:dddd dd/MM/yyyy}" +
                " <br /> Salary: {4:C}",
                nameTextBox.Text, ss, phone, loanDateCalendar.SelectedDate, salary);

            resultLabel.Text = result;
        }
    }
}