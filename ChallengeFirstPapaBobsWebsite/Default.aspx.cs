using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeFirstPapaBobsWebsite
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            double total;

            if (babyButton.Checked)
                total = 10.0;
            else if (mamaButton.Checked)
                total = 13.0;
            else
                total = 16.0;

            if (deepButton.Checked)
                total += 2.0;

            total = (pepperoniCheckBox.Checked) ? total + 1.5 : total;
            total = (onionsCheckBox.Checked) ? total + .75 : total;
            total = (greenPeppersCheckBox.Checked) ? total + .5 : total;
            total = (redPeppersCheckBox.Checked) ? total + .75 : total;
            total = (anchoviesCheckBox.Checked) ? total + 2.0 : total;
            
            if ((pepperoniCheckBox.Checked 
                && greenPeppersCheckBox.Checked 
                && anchoviesCheckBox.Checked) 
                || (pepperoniCheckBox.Checked 
                && redPeppersCheckBox.Checked 
                && onionsCheckBox.Checked))
                
            {
                total -= 2.0;
            }

            resultLabel.Text = "$" + total.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            babyButton.Checked = false;
            mamaButton.Checked = false;
            papaButton.Checked = false;
            thinButton.Checked = false;
            deepButton.Checked = false;
            pepperoniCheckBox.Checked = false;
            onionsCheckBox.Checked = false;
            greenPeppersCheckBox.Checked = false;
            redPeppersCheckBox.Checked = false;
            anchoviesCheckBox.Checked = false;
            resultLabel.Text = "$0.00";
        }
    }
}