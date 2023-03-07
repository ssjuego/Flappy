using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    
    public Rigidbody2D rigidBody2D;         // bird body
    [SerializeField] float flapjump = 10f;  // jumping magnitude
    public GameLogic GameLogic;             // object used to store other classes object. 
           // state of the bird
    public float xConstraint = -43f;        // Constraint coordinate on the players position in x axis to prevent player from leaving the screen
    private float yMax = 23f;
    private float yMin = -23f;
 

    // Start is called before the first frame update
    void Start()
    {
        GameLogic = GameObject.FindGameObjectWithTag("Player").GetComponent<GameLogic>(); // Accesssing Another gameobjects logic.
        BirdStatus.isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        
                    
            
            if (Input.GetKeyDown("space") && BirdStatus.isAlive)           // making the bird jump only when it is alive.
            {
                rigidBody2D.velocity = new Vector2(0f, flapjump);
            }


            if ((transform.position.x <= xConstraint) || (!((transform.position.y < yMax) && (transform.position.y > yMin))))              // X coordinate constraint  
            {
                GameLogic.gameover();
                BirdStatus.isAlive = false;
                gameObject.SetActive(false);
            }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)     // Bird collided with an object.
    {
        GameLogic.gameover();
        BirdStatus.isAlive = false;
    }
}
