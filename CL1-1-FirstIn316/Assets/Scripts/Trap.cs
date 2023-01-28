using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject ball;
    public GameObject startPoint;
    
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

    void moveToStart()
    {
        Vector3 Pos = startPoint.transform.position;
        ball.transform.position = Pos;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == ball)
        {
            moveToStart();
        }
    }
}
