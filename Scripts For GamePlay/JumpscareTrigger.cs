using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareTrigger : MonoBehaviour
{
    
    [SerializeField] private AudioSource JumpSound;
    [SerializeField] private GameObject JumpObj;
    
    void Start()
    {
        JumpObj.SetActive(false);
    }
    void OnTriggerEnter(Collider player)
    {
        if(player.tag == "Player")
        {
            JumpSound.Play();
            JumpObj.SetActive(true);
            StartCoroutine(DestroyObj());
            
        }
    }

    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(2f);
        
        Destroy(gameObject);
    }
}
