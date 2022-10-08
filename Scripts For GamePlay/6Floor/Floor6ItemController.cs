using UnityEngine;

namespace ThemedKeySystem
{
    public class Floor6ItemController : MonoBehaviour
    {
        [SerializeField] private ItemType _itemType = ItemType.None;

        private Floor6KeyController keyController;
        private Floor6KeyDoorController doorController;

        private enum ItemType { None, Door, Key }

        private void Awake()
        {
            switch (_itemType)
            {
                case ItemType.Door:      
                    doorController = GetComponent<Floor6KeyDoorController>();
                    break;
                case ItemType.Key:
                    keyController = GetComponent<Floor6KeyController>();
                    break;
            }
        }

        public void ObjectInteract()
        {
            switch (_itemType)
            {
                case ItemType.Door:
                    doorController.CheckDoor();
                    break;
                case ItemType.Key:
                    keyController.KeyPickup();
                    break;
            }
        }
    }
}
