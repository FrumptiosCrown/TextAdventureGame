using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame.Sources.Models
{
    internal class Inventory
    {
        public List<Item> itemsList = new();
        public Armor EquipedArmor { get; set; }
        public Weapon EquipedWeapon { get; set; }


    }
}
