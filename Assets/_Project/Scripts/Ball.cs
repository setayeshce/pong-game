using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
   
    public float speed;
    public float maxSpeed;
    public float increasedSpeed;
    public float firstSpeed;
    public Rigidbody2D rigidbody2D;

    private Vector2 v;
    void Start()
    {
        AddStartingForce(true);
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Paddle" || collision.gameObject.name == "ComputerPaddle")
        {
            Debug.Log("game speed increase");
            IncreaseBallSpeed();
        }
     //   if (collision.gameObject.name == "RightWall" || collision.gameObject.name == "LeftWall")
      //  {
       //     ResetPosition();
       //     AddStartingForce(true);
      //  }
    }
    
    public void AddStartingForce(bool isFirst)
    {
        if (isFirst)
        {
            var x = Random.Range(0, 1f) > 0.5 ? -1 : 1;
            var y = Random.Range(0, 1f) > 0.5 ? Random.Range(0, 1f) :
                Random.Range(-1f, 0);
            v = new Vector2(x, y);
            rigidbody2D.AddForce(v * speed);
        }
        else
        {
            rigidbody2D.AddForce(rigidbody2D.velocity * increasedSpeed);
        }
       
    }

    public void ResetPosition()
    { 
        Debug.Log("game position reset");
        rigidbody2D.transform.position =  Vector2.zero;
        rigidbody2D.velocity = Vector2.zero;
        Debug.Log("game continue");
        AddStartingForce(true);
    }
    
    public void IncreaseBallSpeed()
    {
        AddStartingForce(false);
    }

 
}
