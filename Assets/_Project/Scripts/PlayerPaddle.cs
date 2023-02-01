using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour
{
    public Rigidbody2D rigidbody2D;
    public float speed=10;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Vector2 force=Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            force=Vector2.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            force = Vector2.down;
        }
        
        
        rigidbody2D.AddForce(force*speed);

    }
}
