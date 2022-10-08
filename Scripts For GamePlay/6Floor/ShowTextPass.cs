using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTextPass : MonoBehaviour
{
    [SerializeField] private GameObject Text;
    private const string playerTag = "Player";
    private bool PlayerInZone;

    void Start()
    {
        Text.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {

                Text.gameObject.SetActive(true);
                

                PlayerInZone = true;
                
            }
            
        }

    void OnTriggerExit(Collider other)
        {
            if (other.CompareTag(playerTag))
            {

                Text.gameObject.SetActive(false);
                

                PlayerInZone = false;
                
            }
            
        }
}
