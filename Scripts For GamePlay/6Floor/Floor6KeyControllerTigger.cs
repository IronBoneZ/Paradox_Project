using UnityEngine;
using AdventurePuzzleKit;

namespace ThemedKeySystem
{
    public class Floor6KeyControllerTigger : MonoBehaviour
    {
        [Header("Type of Key")]
        [SerializeField] private KeyTheme keyType = KeyTheme.None;

        [Header("Key Pickup Sound")]
        [SerializeField] private string keySound = "ThemedKeyPickup";

        private const string playerTag = "Player";

        public enum KeyTheme { None, Room601, Room602, Room603, Room604, Room605, Room606, Room607, Room608, Room609, Room610, Room611, Room612}

        void OnTriggerEnter(Collider other)
        {
            
            if (other.CompareTag(playerTag))
            {

                switch (keyType)
            {
                
                case KeyTheme.Room601:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room601");
                    break;
                case KeyTheme.Room602:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room602");
                    break;
                case KeyTheme.Room603:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room603");
                    break;
                case KeyTheme.Room604:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room604");
                    break;
                case KeyTheme.Room605:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room605");
                    break;
                case KeyTheme.Room606:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room606");
                    break;
                case KeyTheme.Room607:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room607");
                    break;
                case KeyTheme.Room608:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room608");
                    break;
                case KeyTheme.Room609:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room609");
                    break;
                case KeyTheme.Room610:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room610");
                    break;
                case KeyTheme.Room611:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room611");
                    break;
                case KeyTheme.Room612:
                    Floor6KeyInventoryController.instance.UpdateInventory("Room612");
                    break;
                
                
            }
            
            gameObject.SetActive(false);
                
            }
            
        }
        

        void PickupSound()
        {
            AKAudioManager.instance.Play(keySound);
        }

        
    }
}
