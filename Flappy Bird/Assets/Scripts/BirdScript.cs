using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    [SerializeField] float flapjump = 10f;
    public GameLogic GameLogic;
    public bool birdIsAlive = true;
 

    // Start is called before the first frame update
    void Start()
    {
        GameLogic = GameObject.FindGameObjectWithTag("Player").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && birdIsAlive) {
            rigidBody2D.velocity = new Vector2( 0f , flapjump);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameLogic.gameover();
        birdIsAlive = false;
    }
}
