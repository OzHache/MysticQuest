using ExternalAPI;

namespace CharacterUtilities.Inventory
{
    public class InventoryAPIAdapter : InventorySystem
    {
        private ExternalInventoryAPI _externalAPI = new ExternalInventoryAPI();

        public override void AddItem(Item item) {
            _externalAPI.StoreItem(item.Id);
        }

        public override void RemoveItem(Item item) {
            _externalAPI.RetrieveItem(item.Id);
        }
    }
}