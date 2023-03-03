using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rigidBody2D;
    [SerializeField] int flapjump = 10;
    [SerializeField] int forwardspeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
            rigidBody2D.velocity = new Vector2( forwardspeed , flapjump);
        }
    }
}
