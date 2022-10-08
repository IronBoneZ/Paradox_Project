using UnityEngine;
using AdventurePuzzleKit;

namespace ThemedKeySystem
{
    public class Floor6KeyInventoryController : MonoBehaviour
    {
        [HideInInspector] public bool hasRoom601Key;
        [HideInInspector] public bool hasRoom602Key;
        [HideInInspector] public bool hasRoom603Key;
        [HideInInspector] public bool hasRoom604Key;
        [HideInInspector] public bool hasRoom605Key;
        [HideInInspector] public bool hasRoom606Key;
        [HideInInspector] public bool hasRoom607Key;
        [HideInInspector] public bool hasRoom608Key;
        [HideInInspector] public bool hasRoom609Key;
        [HideInInspector] public bool hasRoom610Key;
        [HideInInspector] public bool hasRoom611Key;
        [HideInInspector] public bool hasRoom612Key;


        [Header("Key Icon UI")]
        [SerializeField] private GameObject room601FullUI = null;
        [SerializeField] private GameObject room602FullUI = null;
        [SerializeField] private GameObject room603FullUI = null;
        [SerializeField] private GameObject room604FullUI = null;
        [SerializeField] private GameObject room605FullUI = null;
        [SerializeField] private GameObject room606FullUI = null;
        [SerializeField] private GameObject room607FullUI = null;
        [SerializeField] private GameObject room608FullUI = null;
        [SerializeField] private GameObject room609FullUI = null;
        [SerializeField] private GameObject room610FullUI = null;
        [SerializeField] private GameObject room611FullUI = null;
        [SerializeField] private GameObject room612FullUI = null;

        
        private bool isOpen;

        public static Floor6KeyInventoryController instance;

        void Awake()
        {
            if (instance != null) { Destroy(gameObject); }
            else { instance = this; DontDestroyOnLoad(gameObject); }
        }

        public void UpdateInventory(string keyName)
        {
            if (keyName == "Room601")
            {
                hasRoom601Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room601FullUI.SetActive(true);
            }

            else if (keyName == "Room602")
            {
                hasRoom602Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room602FullUI.SetActive(true);
            }

            else if (keyName == "Room603")
            {
                hasRoom603Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room603FullUI.SetActive(true);
            }

            else if (keyName == "Room604")
            {
                hasRoom604Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room604FullUI.SetActive(true);
            }

            else if (keyName == "Room605")
            {
                hasRoom605Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room605FullUI.SetActive(true);
            }

            else if (keyName == "Room606")
            {
                hasRoom606Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room606FullUI.SetActive(true);
            }

            else if (keyName == "Room607")
            {
                hasRoom607Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room607FullUI.SetActive(true);
            }

            else if (keyName == "Room608")
            {
                hasRoom608Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room608FullUI.SetActive(true);
            }

            else if (keyName == "Room609")
            {
                hasRoom609Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room609FullUI.SetActive(true);
            }

            else if (keyName == "Room610")
            {
                hasRoom610Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room610FullUI.SetActive(true);
            }

            else if (keyName == "Room611")
            {
                hasRoom611Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room611FullUI.SetActive(true);
            }

            else if (keyName == "Room612")
            {
                hasRoom612Key = true;
                AKUIManager.instance.hasFloor6Key = true;
                room612FullUI.SetActive(true);
            }

            

        }

        
    }
}
