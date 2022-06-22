using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Inventory
{
    public class InventoryItemDto
    {
        public string Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        public InventoryItemType Type { get; set; }

        public InventoryItemDto(string name, DateTime expirationDate, InventoryItemType type)
        {
            Name = name;
            ExpirationDate = expirationDate;
            Type = type;
        }
    }
}
