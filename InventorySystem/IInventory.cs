using System;
using System.Collections.Generic;

namespace Assets.Script.InventorySystem
{
    public interface IInventory
    {
        public IEnumerable<IItem> Items { get; }
        public Action OnInventoryChanged { get; set; }
        public int Capacity { get; }

        public void AddItem(IItem item);
        public void RemoveItem(IItem item);
        public bool IsItemExist(IItem item);
    }
}