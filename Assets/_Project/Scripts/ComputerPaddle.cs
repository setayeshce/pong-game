using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : MonoBehaviour
{
    public GameObject ball;
    public float speed=10;
    public Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 force = Vector2.zero;   
        if (IsBallFaceToComputer())
        {
             var ballY= ball.transform.position.y;
             if (ballY> transform.position.y)
             {
                 force = Vector2.up;
             }
             else  if (ballY< transform.position.y)
             {
                 force = Vector2.down;
             }
        }
        else
        {
            if (transform.position.y<0)
            {
                force = Vector2.up;
            }
            else  if (transform.position.y>0)
            {
                force = Vector2.down;
            } 
        }
        
        
        rigidbody2D.AddForce(force*speed);
        
    }

    private bool IsBallFaceToComputer()
    {
        var velocity= ball.GetComponent<Rigidbody2D>().velocity;
        return velocity.x > 0;
    }
}
