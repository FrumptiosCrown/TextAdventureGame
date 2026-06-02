using System;
using System.Collections.Generic;
using System.Text;
using TextAdventureGame.Sources.Models;

namespace TextAdventureGame.Sources.Manager
{
    public class PlayerManager
    {
        public Player player = new();
        public PlayerManager()
        {
        }
        public double GetDmg()
        {
            double dmg = player.playerStats.strength; // Equiped Waffe noch hinzufügen
            return dmg;
        }
        public void ApplyDmg(double dmg)
        {
            player.TakeDmg(dmg);
        }
    }
}
