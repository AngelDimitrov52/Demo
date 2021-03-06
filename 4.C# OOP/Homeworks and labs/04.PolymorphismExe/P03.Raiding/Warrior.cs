﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P03.Raiding
{
    public class Warrior : BaseHero
    {
        private const int power = 100;

        public Warrior(string name)
            : base(name, power)
        {

        }

        public override string CastAbility()
        {
            return $"{nameof(Warrior)} - {Name} hit for {Power} damage";
        }
    }
}
