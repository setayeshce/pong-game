using UnityEngine;

public class ScoreAreaComputer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameController gamecontroller;
    private void OnCollisionEnter2D(Collision2D other)
    {
        var ball= other.gameObject.GetComponent<Ball>();

        if (ball!=null)
        {
            gamecontroller.IncreasePlayerScore();
        }
    }
}