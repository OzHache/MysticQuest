namespace CharacterUtilities.Inventory
{
    public class InventoryFacade
    {
        private InventorySystem inventorySystem;
        private EquipmentSystem equipmentSystem;
    
        public InventoryFacade() {
            inventorySystem = new InventorySystem();
            equipmentSystem = new EquipmentSystem();
        }

        public void AddItemToInventory(Item item) {
            inventorySystem.AddItem(item);
        }

        public void EquipItem(Item item) {
            if (inventorySystem.HasItem(item)) {
                equipmentSystem.EquipItem(item);
                inventorySystem.RemoveItem(item);
            }
        }

        // Other simplified methods for inventory management
    }
}