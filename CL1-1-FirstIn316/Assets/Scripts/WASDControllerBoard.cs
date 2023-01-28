using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WASDControllerBoard : MonoBehaviour
{

    [SerializeField]
    private float sensitiveness = 1f;

    [SerializeField] 
    private float rotationBoundary = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ((Input.GetKey(KeyCode.A))&(transform.rotation.z<rotationBoundary))
        {
            transform.Rotate(0,0,sensitiveness);
        }
            
        if ((Input.GetKey(KeyCode.D))&&(transform.rotation.z>-rotationBoundary))
        {
            transform.Rotate(0,0,-sensitiveness);
        }
        
        if ((Input.GetKey(KeyCode.W))&&(transform.rotation.x<rotationBoundary))
        {
            transform.Rotate(sensitiveness,0,0);
        }
        if ((Input.GetKey(KeyCode.S))&&(transform.rotation.x>-rotationBoundary))
        {
            transform.Rotate(-sensitiveness,0,0);
        }
    }
}
