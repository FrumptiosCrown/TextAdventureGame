using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventureGame.Sources.Manager
{
    internal class GameManager
    {
        public PlayerManager playerManager;

        public GameManager()
        {
            playerManager = new();
        }
    }
}
