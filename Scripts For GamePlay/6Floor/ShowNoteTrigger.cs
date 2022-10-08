using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShowNoteTrigger : MonoBehaviour
{

    [SerializeField] private GameObject note;
    [SerializeField] private GameObject note1;
    [SerializeField] private GameObject noteAltert;
    [SerializeField] private AudioSource Altert;
    

    private bool PlayerInZone;

    private float timeElapse;
    private const string playerTag = "Player";

    
    // Start is called before the first frame update
    void Start()
    {
        note.gameObject.SetActive(false);
        note1.gameObject.SetActive(false);
        noteAltert.gameObject.SetActive(false);
    }

    private void Update()
    {
        
    }

    

    void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {

                StartCoroutine(Delay());
                PlayerInZone = true;
                
            }
            
        }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(2f);
        note.gameObject.SetActive(true);
                note1.gameObject.SetActive(true);
                noteAltert.gameObject.SetActive(true);
                Altert.Play();
        yield return new WaitForSeconds(3f); // Wait 1 seconds
        
        noteAltert.gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
