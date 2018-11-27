using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_053
{
    public class Character
    {
        public string Name { get; set; }
        public CharacterType CharacterType { get; set; }

    }

    public enum CharacterType
    {
        Wizard,
        Fighter,
        Monster,
        Archer,
        Thief,
        DarkWizard
    }
}