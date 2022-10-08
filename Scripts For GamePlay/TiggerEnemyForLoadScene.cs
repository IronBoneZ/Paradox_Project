using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TiggerEnemyForLoadScene : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    
    

    

    private const string playerTag = "Player";
    

    void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {
                
                
                SceneManager.LoadScene("Dead");
                

            }
            
        }

    
    

}
