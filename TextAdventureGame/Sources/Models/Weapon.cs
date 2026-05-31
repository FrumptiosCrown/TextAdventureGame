using System;
using System.Collections.Generic;
using System.Text;
using TextAdventureGame.Sources.Enums;

namespace TextAdventureGame.Sources.Models
{
    internal class Weapon : Item
    {
        public double strengthBoost {  get; set; }

        public Weapon(double durabilityparam, double strengthparam, RarityLevel rarity)
        {
            strengthBoost = strengthparam;
            durability = durabilityparam;
            raritylevel = rarity;
        }
        public double GetStrengthAmplifier() => strengthBoost;
    }
}
