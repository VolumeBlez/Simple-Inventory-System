using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.InventorySystem
{
    public class InventoryView : MonoBehaviour
    {
        [SerializeField] private Test _testPlayer;
        [SerializeField] private ItemSlotView _slotPrefab;

        private IInventory _inventory;
        private List<ItemSlotView> _slots;
        
        private void Start()
        {
            _slots = new();

            _inventory = _testPlayer.Inventory;
            _inventory.OnInventoryChanged += UpdateInventoryViewSlot;
        }

        private void UpdateInventoryViewSlot() 
        {
            foreach (var slot in _slots)
            {
                Destroy(slot.gameObject);
            }

            _slots.Clear();

            foreach (var item in _inventory.Items)
            {
                var newSlot = Instantiate(_slotPrefab, this.transform);
                newSlot.InitSlot(item);
                _slots.Add(newSlot);
            }
        }
    }
}