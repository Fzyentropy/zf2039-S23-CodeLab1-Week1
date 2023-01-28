using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    
    public GameObject ball;
    public GameObject startPoint;
    public GameObject txt;
    
    // Start is called before the first frame update
    void Start()
    {
        if (ball == null)
            {
                ball = GameObject.Find("Ball");
            }

            if (startPoint == null)
            {
                startPoint = GameObject.Find("startPoint");
            }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            txt.SetActive(true);
        }
    }
}
