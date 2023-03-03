using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    public GameLogic GameLogic;

    // Start is called before the first frame update
    void Start()
    {
        GameLogic = GameObject.FindGameObjectWithTag("Player").GetComponent<GameLogic>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameLogic.addScore(1);
    }
}
