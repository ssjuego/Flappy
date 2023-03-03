using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour
{
    public int score;
    public TMP_Text scoreBoard;


    [ContextMenu("Incrementer")]
    public void addScore(int scoreAdd)
    {
        score+= scoreAdd;
        scoreBoard.text = score.ToString();
    }
}
