using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyFollow : MonoBehaviour
{
    

    Transform tr_Player;
    public float within_range;
    public float f_RotSpeed=3.0f;
    public float f_MoveSpeed = 3.0f;

    [SerializeField] private GameObject Enemy;

    private const string playerTag = "Player";

 // Use this for initialization
    void Start () 
    {

    tr_Player = GameObject.FindGameObjectWithTag ("Player").transform;
  
    }
 
 // Update is called once per frame
    void Update () 
        {
            float dist = Vector3.Distance(tr_Player.position, transform.position);
            if(dist <= within_range)
            {
            /* Look at Player*/
            transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (tr_Player.position - transform.position), f_RotSpeed * Time.deltaTime);

            /* Move at Player*/
            transform.position += transform.forward * f_MoveSpeed * Time.deltaTime;
            }
        }

    void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag(playerTag))
            {

                SceneManager.LoadScene(1);

            }
            
        }
}


