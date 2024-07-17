using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManagerScript : MonoBehaviour
{
    private int score;
    private void increaseScore()
    {
        score++;
    }

    private void gameOver()
    {
        Debug.Log("Game Over!");
    }
}
