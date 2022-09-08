using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShowNoteTrigger : MonoBehaviour
{

    [SerializeField] private GameObject note;
    [SerializeField] private GameObject noteAltert;

    

    private bool PlayerInZone;

    private float timeElapse;
    private const string playerTag = "Player";

    
    // Start is called before the first frame update
    void Start()
    {
        note.gameObject.SetActive(false);
        noteAltert.gameObject.SetActive(false);
    }

    private void Update()
    {
        timeElapse += Time.deltaTime;
        
        if (PlayerInZone == true)           //if in zone and press F key
        {
            
            StartCoroutine(Delay());
            
        }
    }

    

    void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {

                note.gameObject.SetActive(true);
                noteAltert.gameObject.SetActive(true);

                PlayerInZone = true;
                
            }
            
        }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(3f); // Wait 1 seconds
        
        noteAltert.gameObject.SetActive(false);
    }
}
