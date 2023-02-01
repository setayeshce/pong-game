using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAreaPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameController gamecontroller;
    private void OnCollisionEnter2D(Collision2D other)
    {
       var ball= other.gameObject.GetComponent<Ball>();

       if (ball!=null)
       {
           gamecontroller.IncreaseComputerScore();
       }
    }
}