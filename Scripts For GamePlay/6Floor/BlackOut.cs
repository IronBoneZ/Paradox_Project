using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOut : MonoBehaviour
{
    [SerializeField] private GameObject allLight;
    
    [SerializeField] private float Dely = 1;
    // Start is called before the first frame update
    private const string playerTag = "Player";
    
    

    void OnTriggerEnter(Collider other)
        {
            
            if (other.gameObject.tag == "Player")
            {
                StartCoroutine(DelayBlackOut());
                
            }

            
            
        }

    IEnumerator DelayBlackOut()
    {
        
        gameObject.GetComponent<AudioSource>().Play();
        
            allLight.gameObject.SetActive(false);
            yield return new WaitForSeconds(0.2f);
            allLight.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            allLight.gameObject.SetActive(true);
            yield return new WaitForSeconds(0.2f);
            allLight.gameObject.SetActive(false);
            yield return new WaitForSeconds(Dely);
            
            Destroy(this);
    }
}
