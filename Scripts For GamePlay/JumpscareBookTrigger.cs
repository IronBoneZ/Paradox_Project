using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareBookTrigger : MonoBehaviour
{
    public GameObject Obj;
    public GameObject ObjActive;

    [SerializeField] private AudioSource JumpSound;

    [SerializeField] private UnLock Unlock = null;

    void Awake()
    {
        Unlock.enabled = false;
    }
    void OnTriggerEnter(Collider player)
    {
        
        if(player.tag == "Player")
        {
            JumpSound.Play();
            Unlock.enabled = true;
            ObjActive.SetActive(true);
            StartCoroutine(DestroyObj());
            
        }
     
    }

    IEnumerator DestroyObj()
    {
        yield return new WaitForSeconds(1f);
        
        Destroy(gameObject);
    }
}
