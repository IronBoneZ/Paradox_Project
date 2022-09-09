using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Raycasting : MonoBehaviour
{
    [SerializeField] private float range = 5;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.forward;
        Ray theRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range));

        if(Physics.Raycast(theRay, out RaycastHit hit, range))
        {
            if(hit.collider.tag == "Image")
            {
                SceneManager.LoadScene("Dead");
            }
        }
    }
    

    //void InteractRaycast()
    //{
        //Vector3 playerPosition = transform.position;
        //Vector3 fowardDirection = transform.forward;

        //Ray interactionRay = new Ray(playerPosition, fowardDirection);
       // RaycastHit interactionRayHit;
        //float interactionRayLength = 5.0f;

        //Vector3 interactionRayEndpoint = fowardDirection * interactionRayLength;
        //Physics.Raycast(interactionRay, out interactionRayHit, interactionRayLength);
        //Debug.DrawLine(playerPosition, interactionRayEndpoint);
        
        //bool hitFound = Physics.Raycast(interactionRay, out interactionRayHit, interactionRayLength);
        //if(hitFound)
        //{
            //GameObject hitGameObject = interactionRayHit.transform.gameObject;
            //string hitFeedback = hitGameObject.name;
            //Debug.Log(hitFeedback);
        //}
        //else
        //{
            //string nothingHitFeedback = "-";
            //Debug.Log(nothingHitFeedback);  
        //}

    
}
