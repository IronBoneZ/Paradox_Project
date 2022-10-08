using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show : MonoBehaviour
{
    [SerializeField] private GameObject Tigger;

    [SerializeField] private GameObject ShowOBj;

    [SerializeField] private GameObject HideOBj;
   

    private const string playerTag = "Player";
    private bool PlayerInZone;

    

    // Start is called before the first frame update
    void Start()
    {
        
        ShowOBj.gameObject.SetActive(false);
        Tigger.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
        {
            
            if (other.CompareTag(playerTag))
            {

                ShowOBj.SetActive(true);
                HideOBj.SetActive(false);
                
                Tigger.gameObject.SetActive(false);

                PlayerInZone = true;
                
            }
            
        }
}

