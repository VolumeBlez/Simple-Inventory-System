using UnityEngine;

namespace Assets.Script.InventorySystem
{
    public interface IItem
    {
        public int ID { get; }
        public Sprite Icon { get; }
        public string Name { get; }
        public string Description { get; }
    }
}