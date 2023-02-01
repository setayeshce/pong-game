using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int playerScore;
    public int computerScore;
    public Ball ball;

    public TextMeshProUGUI playerText;
    public TextMeshProUGUI computerText;

    private void Start()
    {
        playerScore = computerScore = 0;
    }

 
    public void IncreasePlayerScore()
    {
        playerScore++;
        playerText.text = playerScore.ToString();
        ball.ResetPosition();
    }
    public void IncreaseComputerScore()
    {
        computerScore++;
        computerText.text = computerScore.ToString();
        ball.ResetPosition();
    }
    
    
}
