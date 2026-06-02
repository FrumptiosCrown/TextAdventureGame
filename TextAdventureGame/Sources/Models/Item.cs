using TextAdventureGame.Sources.Enums;

namespace TextAdventureGame.Sources.Models
{
    public class Item
    {
        public double durability { get; set; }
        public RarityLevel raritylevel { get; set; }
        public bool isBroken() => durability > 0;
        
    }
}