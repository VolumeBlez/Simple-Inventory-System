using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

namespace Assets.Script.InventorySystem
{
    public class ItemSlotView : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        [SerializeField] private Image _slotIcon;
        [SerializeField] private GameObject _slotTextPanel;
        [SerializeField] private TMP_Text _slotText; 

        private IItem _item;

        public void InitSlot(IItem item) 
        {
            _slotIcon.sprite = item.Icon;
            _item = item;
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            _slotText.text = $" {_item.Name} \n {_item.Description}";
            _slotTextPanel.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            _slotTextPanel.SetActive(false);
        }
    }
}