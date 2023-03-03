using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float deadZone = -49;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if(transform.position.x < deadZone)
        {
            Debug.Log("Pipe Deleted");
            Destroy(gameObject);
        }
    }
}
