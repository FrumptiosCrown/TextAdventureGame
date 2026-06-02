using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using TextAdventureGame.Sources.AI;

namespace TextAdventureGame.Sources.Manager
{
    public class GameManager
    {
        public PlayerManager playerManager;
        public Narrator gameNarrator;
        public EnemyManager enemyManager; 
        public NPCManager NPCManager;
        public GameManager()
        {
            playerManager = new();
        }
        public string getStats()
        {
            var stats = playerManager.player.playerStats;
            
            return $"Strength: {stats.strength}\n" +
                   $"Dexterity: {stats.dexterity}\n" +
                   $"Constitution: {stats.constitution}\n" +
                   $"Intelligence: {stats.intelligence}";
        }
    }
}
