using InventoryManager.Domain.Inventory;
using InventoryManager.Domain.IRepositories;

namespace InventoryManager.Infrastructure.Repository
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<InventoryItem> inventoryItems;
        public List<InventoryItem> InventoryItems { get { return inventoryItems; } set { inventoryItems = value; } }
        public InventoryRepository()
        {
        }

        public Guid Save(InventoryItemDto inventoryItemDto)
        {
            var inventoryItem = new InventoryItem
            {
                Id = Guid.NewGuid(),
                Name = inventoryItemDto.Name,
                ExpirationDate = inventoryItemDto.ExpirationDate,
                Type = inventoryItemDto.Type,
            };
            if (InventoryItems == null)
                InventoryItems = new List<InventoryItem>();

            InventoryItems.Add(inventoryItem);
            return inventoryItem.Id;
        }

        public void Delete(Guid inventoryItemId)
        {
            var item = InventoryItems.FirstOrDefault(i => i.Id == inventoryItemId);

            if (item != null)
                InventoryItems.Remove(item);

        }
    }
}
