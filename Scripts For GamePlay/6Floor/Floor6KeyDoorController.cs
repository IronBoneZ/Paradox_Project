using AdventurePuzzleKit;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace ThemedKeySystem
{
    public class Floor6KeyDoorController : MonoBehaviour
    {
        [Header("Door Properties")]
        [SerializeField] private DoorType _doorType = DoorType.None;
        private enum DoorType { None, Room601Door, Room602Door, Room603Door, Room604Door, Room605Door, Room606Door, Room607Door, Room608Door, Room609Door, Room610Door,Room611Door,Room612Door }
        [Space(5)]
        [Tooltip("Add the gameobject of the animated key assosiated with the door, the keys should be parented to your door")]
        [SerializeField] private GameObject animatedDoorKey = null;

        [Header("Sound Delays - Edit to increase delay")]
        [Tooltip("This should be a very small delay, it is to delay the sound for when the key is inserted keyhole. Default is 0.5")]
        [SerializeField] private float keyAudioDelay = 0.5f;
        [Tooltip("This is the delay before the door opens, to allow the key animation to play. Default is 1.5")]
        [SerializeField] private float doorOpenDelay = 1.5f;

        [Header("Key Animation Name")]
        [SerializeField] private string keyAnimation = "HeartKey_Anim_Unlock";

        [Header("Door Sounds")]
        [SerializeField] private string doorOpenSound = "ThemedKeyDoorOpen";
        [SerializeField] private string lockedDoorSound = "ThemedKeyLockedDoor";
        [SerializeField] private string unlockDoorSound = "ThemedKeyInsertKey";

        [Header("Animation Event")]
        [SerializeField] private UnityEvent onUnlock = null;

        private Animator anim;

        private void Start()
        {
            anim = animatedDoorKey.GetComponent<Animator>();
        }

        public void CheckDoor()
        {
            switch (_doorType)
            {
                case DoorType.Room601Door:
                    if (Floor6KeyInventoryController.instance.hasRoom601Key)
                    {
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room602Door:
                    if (Floor6KeyInventoryController.instance.hasRoom602Key)
                    {
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room603Door:
                    if (Floor6KeyInventoryController.instance.hasRoom603Key)
                    {
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room604Door:
                    if (Floor6KeyInventoryController.instance.hasRoom604Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room605Door:
                    if (Floor6KeyInventoryController.instance.hasRoom605Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room606Door:
                    if (Floor6KeyInventoryController.instance.hasRoom606Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room607Door:
                    if (Floor6KeyInventoryController.instance.hasRoom607Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room608Door:
                    if (Floor6KeyInventoryController.instance.hasRoom608Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room609Door:
                    if (Floor6KeyInventoryController.instance.hasRoom609Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room610Door:
                    if (Floor6KeyInventoryController.instance.hasRoom610Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room611Door:
                    if (Floor6KeyInventoryController.instance.hasRoom611Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
                case DoorType.Room612Door:
                    if (Floor6KeyInventoryController.instance.hasRoom612Key)
                    {                      
                        StartCoroutine(PlayAnimation());
                    }
                    else
                    {
                        LockedDoorSound();
                    }
                    break;
            }
        }

        public IEnumerator PlayAnimation()
        {
            gameObject.tag = "Untagged";
            animatedDoorKey.SetActive(true);
            anim.Play(keyAnimation, 0, 0.0f);

            yield return new WaitForSeconds(keyAudioDelay);
            UnlockSound();
            yield return new WaitForSeconds(doorOpenDelay);

            animatedDoorKey.SetActive(false);
            onUnlock.Invoke();
            DoorOpenSound();            
        }

        public void DoorOpenSound()
        {
            AKAudioManager.instance.Play(doorOpenSound);
        }

        public void LockedDoorSound()
        {
            AKAudioManager.instance.Play(lockedDoorSound);
        }

        public void UnlockSound()
        {
            AKAudioManager.instance.Play(unlockDoorSound);
        }
    }
}
