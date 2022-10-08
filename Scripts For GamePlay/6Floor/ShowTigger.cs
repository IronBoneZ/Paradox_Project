using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTigger : MonoBehaviour
{
    [SerializeField] private GameObject TiggerForKey;

    [SerializeField] private GameObject DummyForKey;

    private const string playerTag = "Player";
    private bool PlayerInZone;

    

    // Start is called before the first frame update
    void Start()
    {
        
        TiggerForKey.gameObject.SetActive(false);
        DummyForKey.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
        {
            
            if (other.CompareTag(playerTag))
            {

                TiggerForKey.gameObject.SetActive(true);
                DummyForKey.gameObject.SetActive(false);

                PlayerInZone = true;
                
            }
            
        }
}
