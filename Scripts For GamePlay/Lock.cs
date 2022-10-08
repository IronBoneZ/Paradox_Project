using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{

    Rigidbody m_rigidbody;
    
    // Start is called before the first frame update
    void Awake()
    {
        
        m_rigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        m_rigidbody.constraints = RigidbodyConstraints.FreezeAll;
    }

    
}
