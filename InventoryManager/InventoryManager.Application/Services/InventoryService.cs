using InventoryManager.Domain.Inventory;
using InventoryManager.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Services
{
    public class InventoryService : IInventoryService
    {
        public IInventoryRepository inventoryRepository { get; set; }
        public InventoryService(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public Guid Save(InventoryItemDto inventoryItemDto)
        {
            return this.inventoryRepository.Save(inventoryItemDto);
        }

        public void Delete(Guid inventoryItemId)
        {
            this.inventoryRepository.Delete(inventoryItemId);
        }
    }
}
