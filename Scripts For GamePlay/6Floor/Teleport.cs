using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleport : MonoBehaviour
{
    public GameObject txtToDisplay;

    private bool PlayerInZone;

    public GameObject Player;

    public GameObject TPLoc;
    
    [SerializeField] private float delay = 3f;

    [SerializeField] private string NameScene;


    private float timeElapse;

    private void Start()
    {

        PlayerInZone = false;     
        txtToDisplay.SetActive(false);
    }

    private void Update()
    {
        timeElapse += Time.deltaTime;
        
        if (PlayerInZone && Input.GetKeyDown(KeyCode.E))           //if in zone and press F key
        {
            
            StartCoroutine(DelayTeleport());
            
        }
    }

     private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            txtToDisplay.SetActive(true);
            PlayerInZone = true;
        }
     }
    

    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            txtToDisplay.SetActive(false);
        }
    }

    IEnumerator DelayTeleport()
    {
        yield return new WaitForSeconds(delay); // Wait 1 seconds
        gameObject.GetComponent<AudioSource>().Play();
            // Player.transform.position = TPLoc.transform.position;
        SceneManager.LoadScene(NameScene);
        
    }
}