using System.Collections.Generic;
using UnityEditor;

namespace CharacterUtilities.Inventory
{
    public class InventorySystem
    {
        private List<Item> _items;

        public virtual void AddItem(Item item)
        {
            _items.Add(item);
        }

        public virtual void RemoveItem(Item item)
        {
            _items.Remove(item);
        }

        public virtual bool HasItem(Item item)
        {
            return _items.Contains(item);
        }
        // Inventory specific methods
        
    }
}