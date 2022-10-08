using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiggerEnemy : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;

    private const string playerTag = "Player";
    private bool PlayerInZone;

    void Start()
    {
        Enemy.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {

                Enemy.gameObject.SetActive(true);
                

                PlayerInZone = true;
                
            }
            
        }
}
