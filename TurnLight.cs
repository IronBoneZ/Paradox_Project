using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnLight : MonoBehaviour {

     public GameObject txtToDisplay;             //display the UI text
    
    private bool PlayerInZone;                  //check if the player is in trigger

    public GameObject lightorobj;
    public GameObject lightorobj1;

    private void Start()
    {

        PlayerInZone = false;                   //player not in zone       
        txtToDisplay.SetActive(false);
    }

    private void Update()
    {
        if (PlayerInZone && Input.GetKeyDown(KeyCode.E))           //if in zone and press F key
        {
            lightorobj.SetActive(!lightorobj.activeSelf);
            lightorobj1.SetActive(!lightorobj1.activeSelf);
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Animator>().Play("Switch");
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
}