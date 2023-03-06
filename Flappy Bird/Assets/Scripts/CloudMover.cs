using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 2f;  // cloud object speed
    [SerializeField] float deadZone = -49;  // X coordinate where the cloud move out of the screen. 


    // Update is called once per frame
    void Update()
    {
        if (BirdStatus.isAlive)
        {
            transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);  // Move the cloud along the negative x axis

            if (transform.position.x < deadZone) // Destroying the cloud when not visible
            {
                gameObject.SetActive(false);
            }
        }
    }
}
