using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using TextAdventureGame.Sources.Models;

namespace TextAdventureGame.Sources.Manager
{
    public class InventoryManager
    {
        public Inventory inventory = new();
        public InventoryManager() 
        { }
        public void AddItem(Item item) => inventory.itemsList.Add(item);
        public void RemoveItem(Item item)
        {
            if(inventory.itemsList.Exists(x => x == item))
                inventory.itemsList.Remove(item);
        }
        public List<Item> GetItemList()
        {
            return inventory.itemsList;
        }
    }
}
