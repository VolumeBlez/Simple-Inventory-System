using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.InventorySystem
{
    public class Inventory : IInventory
    {
        private readonly List<IItem> _items;
        private readonly int _capacity;
        private Action _onInventoryChanged;

        public IEnumerable<IItem> Items => _items;
        public int Capacity => _capacity;
        public Action OnInventoryChanged 
        { 
            get => _onInventoryChanged; 
            set => _onInventoryChanged += value; 
        }

        public Inventory(int capacity)
        {
            this._capacity = capacity;
            _items = new(_capacity);
        }

        public void AddItem(IItem item)
        {
            if(_items.Contains(item))
            {
                Debug.LogWarning("That item already exist in inventory");
                return;
            }
            else if(_items.Count == _capacity)
            {
                Debug.LogWarning("Inventory Is Full");
                return;
            }

            _items.Add(item);
            OnInventoryChanged?.Invoke();
        }

        public bool IsItemExist(IItem item)
        {
            if(_items.Contains(item))
                return true;
            
            return false;
        }

        public void RemoveItem(IItem item)
        {
            _items.Remove(item);
            OnInventoryChanged?.Invoke();
        }
    }
}