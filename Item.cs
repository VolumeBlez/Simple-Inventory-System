using UnityEngine;

namespace Assets.Script.InventorySystem
{
    [CreateAssetMenu(fileName = "Item")]
    public class Item : ScriptableObject, IItem
    {
        [SerializeField] private int _id;
        [SerializeField] private Sprite _icon;
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        
        public int ID => _id;
        public Sprite Icon => _icon;
        public string Name => _name;
        public string Description => _description;
    }
}