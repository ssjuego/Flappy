using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public GameLogic gameLogic;

    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("Player").GetComponent<GameLogic>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameLogic.addScore(1);
    }
}
