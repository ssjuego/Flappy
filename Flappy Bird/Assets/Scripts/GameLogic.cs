using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    public TMP_Text scoreBoard;
    public GameObject gameOverScreen;
    public int score;

    
    
    public void addScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreBoard.text = score.ToString();
    }

    public void gameover()
    {
        gameOverScreen.SetActive(true);
    }
}
