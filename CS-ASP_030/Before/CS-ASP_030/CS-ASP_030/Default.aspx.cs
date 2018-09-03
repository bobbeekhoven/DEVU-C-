using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_030
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultLabel.Text = "";
        }

        protected void battleButton_Click(object sender, EventArgs e)
        {
            int heroHealth = 150;
            int monsterHealth = 100;


            displayBattleHeader();

            // Hero gets bonus first attack 
            monsterHealth = performAttack(monsterHealth, 50, "Barbarian", "Dark Elf");

            while (heroHealth > 0 && monsterHealth > 0)
            {
                displayRoundHeader();

                // Perform battle here!
                heroHealth = performAttack(heroHealth, 20, "Dark Elf", "Barbarian");
                monsterHealth = performAttack(monsterHealth, 10, "Barbarian", "Dark Elf");

            }

            displayResult(heroHealth, monsterHealth);
        }


        private void displayBattleHeader()
        {
            resultLabel.Text += "<h3>Battle Between the Barbarian (you) and the Dark Elf (bad guy)</h3>";
        }

        private void displayRoundHeader()
        {
            resultLabel.Text += "<hr /><p>Round begins ...</p>";
        }

        private int performAttack(int defenderHealth, int attackerDamageMax, string attackerName, string defenderName)
        {
            Random random = new Random();
            int damage = random.Next(1, attackerDamageMax);
            defenderHealth -= damage;

            describeRound(attackerName, defenderName, defenderHealth);

            return defenderHealth;
        }

        private void describeRound(string attackerName, string defenderName, int defenderHealth)
        {
            if (defenderHealth <= 0)
                resultLabel.Text += String.Format("<br />{0} attacks {1} and vanquishes the {2}.", attackerName, defenderName, defenderName);
            else
                resultLabel.Text += String.Format("<br />{0} attacks {1}, leaving {2} with {3} health.", attackerName, defenderName, defenderName, defenderHealth);
        }

        private void displayResult(int heroHealth, int monsterHealth)
        {
            if (heroHealth <= 0)
                resultLabel.Text += "<h3>Dark Elf wins!</h3>";
            else if (monsterHealth <= 0)
                resultLabel.Text += "<h3>Barbarian wins!</h3>";
            else
                resultLabel.Text += "<h3>They are both losers!</h3>";
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "";
        }
    }
}