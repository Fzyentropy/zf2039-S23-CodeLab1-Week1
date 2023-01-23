using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDController : MonoBehaviour
{

    public float forceAmount = 0;
    Rigidbody _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(forceAmount,0,0);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(0,0,forceAmount);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(-forceAmount,0,0);
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(0,0,-forceAmount);
        }
        

    }
}
