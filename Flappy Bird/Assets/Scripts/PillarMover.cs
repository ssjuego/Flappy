using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8f;  // Pillar object speed
    [SerializeField] float deadZone = -49;  // X coordinate where the pillars move out of the screen. 
    //private GameObject spawnerLocation;
   // public float offsetY = 7;

    private void Start()
    {
       // spawnerLocation = GameObject.FindGameObjectWithTag("PipeSpawner");
       // offsetY = spawnerLocation.pipeOffSet;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);  // Move the pillar along the negative x axis

        if(transform.position.x < deadZone) // Destroying the pillars when not visible
        {

            gameObject.SetActive(false);

            // float lowestPoint = transform.position.y - offsetY;
           // float highestPoint = transform.position.y + offsetY;
           // transform.position = new Vector3( spawnerLocation.transform.position.x , Random.Range(lowestPoint, highestPoint));
        }
    }
}
