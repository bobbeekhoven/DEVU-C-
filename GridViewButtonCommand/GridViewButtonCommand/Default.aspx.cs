using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GridViewButtonCommand
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cars = new List<Car>() {
                new Car { CarId=Guid.NewGuid(), Make="BMW", Model="528i", Year=2010 },
                new Car {CarId=Guid.NewGuid(), Make="Toyota", Model="4Runner", Year=2010},
                new Car {CarId=Guid.NewGuid(), Make="Hyundai", Model="Elantra", Year=2013}
            };

            GridView1.DataSource = cars;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //e.CommandArgument

            int index = Convert.ToInt32(e.CommandArgument);
            //var row = GridView1.Rows[index];
            GridViewRow row = GridView1.Rows[index];

            // This is a bit risky ... take great caution.
            string make = row.Cells[1].Text;
            string model = row.Cells[2].Text;
            string value = row.Cells[4].Text;

            // You would probably want to convert it to it's original type
            var carId = Guid.Parse(value);

            // Print out result to screen
            resultLabel.Text = String.Format("{0} {1} {2}",
                make,
                model,
                carId);
;
        }
    }
}