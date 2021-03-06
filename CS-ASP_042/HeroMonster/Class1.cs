﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroMonster
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int DamageMaximum { get; set; }
        public bool AttackBonus { get; set; }

        public int Attack(Dice dice)
        {
            //Random random = new Random();
            //int damage = random.Next(this.DamageMaximum);


            dice.Sides = this.DamageMaximum;
            return dice.Roll();
        }

        public void Defend(int damage)
        {
            this.Health -= damage;
        }
    }

    public class Dice
    {
        public int Sides { get; set; }


        //public int MyProperty { get; private set; }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set {

        //        if (value > 1000)
        //            myVar = value;
        //        else
        //            throw new Exception();

        //        myVar = value; }
        //}
        

        Random random = new Random();
        public int Roll()
        {
            return random.Next(this.Sides);
        }
    }
}
