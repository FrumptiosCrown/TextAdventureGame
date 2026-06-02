using System.Runtime.CompilerServices;
using TextAdventureGame.Sources.Manager;

namespace TextAdventureGame.Sources.Models
{
    public class Player
    {
        public Stats playerStats;
        public InventoryManager inventoryManager = new();
        public Player()
        {
            playerStats = new Stats(3, 3, 3, 3);
        }
        public void TakeDmg(double dmg)
        {
            playerStats.constitution -= dmg;
            if (IsAlive())
                return;
            // Player died
        }
        public void Heal(double healing) => playerStats.constitution += healing;
        public bool IsAlive() => playerStats.constitution > 0;
    }
}
