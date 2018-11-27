using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_053
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            var hero = new Character();
            hero.Name = "Elric";
            hero.CharacterType = CharacterType.Fighter;

            // In some other part of your code ...
            if (hero.CharacterType == CharacterType.Fighter)
            {
                resultLabel.Text = "Our hero is a fighter!";
            }
            */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var hero = new Character();
            hero.Name = heroNameTextBox.Text;

            CharacterType selection;
            if (Enum.TryParse(heroTypeDropDownList.SelectedValue , out selection))
            {
                hero.CharacterType = selection;
            }

            if (hero.CharacterType == CharacterType.Wizard)
            {
                resultLabel.Text = "You selected the wizard!";
            }
            else if (hero.CharacterType == CharacterType.Fighter)
            {
                resultLabel.Text = "You selected the fighter!";
            }
            else if (hero.CharacterType == CharacterType.Monster)
            {
                resultLabel.Text = "You selected the monster!";
            }
            else if (hero.CharacterType == CharacterType.Archer) 
            {
                resultLabel.Text = "You selected the archer!";
            }
            else if (hero.CharacterType == CharacterType.Thief)
            {
                resultLabel.Text = "You selected the thief!";
            }
            else if (hero.CharacterType == CharacterType.DarkWizard)
            {
                resultLabel.Text = "You selected the dark wizard!";
            }
            else
            {
                resultLabel.Text = "You selected nothing";
            }
        }
    }
}