using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Domain.Inventory
{
    public class InventoryItem
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public DateTime ExpirationDate { get; set; }
        public InventoryItemType Type { get; set; }
    }
}
