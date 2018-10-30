using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_049
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string result = "";

            /*
            Dictionary<string, Car> cars = new Dictionary<string, Car>();
            cars.Add("V1", new Car { Make = "Bmw", Model = "528i", Color = "Black", Year = 2010 });
            cars.Add("V2", new Car { Make = "Bmw", Model = "745li", Color = "Black", Year = 2005 });
            cars.Add("V3", new Car { Make = "Ford", Model = "Escape", Color = "White", Year = 2008 });
            cars.Add("V4", new Car { Make = "Saab", Model = "95", Color = "Grey", Year = 2001 });
            */

            Dictionary<string, Car> cars = new Dictionary<string, Car>()
            {
                { "V1", new Car { Make = "Bmw", Model = "528i", Color = "Black", Year = 2010 } },
                { "V2", new Car { Make = "Bmw", Model = "745li", Color = "Black", Year = 2005 } },
                { "V3", new Car { Make = "Ford", Model = "Escape", Color = "White", Year = 2008 } },
                { "V4", new Car { Make = "Saab", Model = "95", Color = "Grey", Year = 2001 } }
            };

            if (cars.Remove("V1"))
                result += "Succesfully removed V1<br/>";
            
            for (int i = 0; i < cars.Count; i++)
            {
                result += "<h2>" + cars.ElementAt(i).Key + "</h2>" 
                    + cars.ElementAt(i).Value.FormatDetailsForDisplay();
            }
            

            /*
            Car v4;
            if (cars.TryGetValue("V4", out v4))
                result += v4.FormatDetailsForDisplay();
            */



            resultLabel.Text = result;
        }
    }
}