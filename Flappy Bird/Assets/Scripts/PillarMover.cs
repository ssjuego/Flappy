using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8f;  // Pillar object speed
    [SerializeField] float deadZone = -49;  // X coordinate where the pillars move out of the screen. 
    

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);  // Move the pillar along the negative x axis

        if(transform.position.x < deadZone) // Destroying the pillars when not visible
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
