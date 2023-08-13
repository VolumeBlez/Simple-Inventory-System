using Assets.Script.InventorySystem;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Item _testItemOne;
    [SerializeField] private Item _testItemTwo;
    [SerializeField] private int _capacity;
    private Inventory _inventory;

    public IInventory Inventory => _inventory;

    void Awake()
    {
        _inventory = new(_capacity);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            _inventory.AddItem(_testItemOne);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            _inventory.AddItem(_testItemTwo);
        }

        else if(Input.GetKeyDown(KeyCode.E))
        {
            _inventory.RemoveItem(_testItemTwo);
        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            _inventory.RemoveItem(_testItemOne);
        }
    }
}
