using InventoryManager.Domain.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Application.Services
{
    public interface IInventoryService
    {
        Guid Save(InventoryItemDto inventoryItemDto);
        void Delete(Guid inventoryItemId);
    }
}
