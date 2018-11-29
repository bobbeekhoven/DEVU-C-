using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS_ASP_054
{
    public class Character
    {
        public string Name { get; set; }
        public CharacterType Type { get; set; }

    }

    public enum CharacterType
    {
        Wizard,
        Fighter,
        Monster
    }
}