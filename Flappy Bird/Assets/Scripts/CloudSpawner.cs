using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField] GameObject Cloud;          // cloud object
    [SerializeField] float spawnRate = 10;      // 
    private float timer = 0;
    private float zOffSet = 5f;
    [SerializeField] float cloudOffSet = 10;
    private float lowestPoint = 0;
    private float highestPoint = 0;
    // Start is called before the first frame update
    void Start()
    {
        lowestPoint = transform.position.y - cloudOffSet;
        highestPoint = transform.position.y + cloudOffSet;
        CloudMaker();
    }

    // Update is called once per frame
    void Update()
    {
        if (BirdStatus.isAlive )
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                CloudMaker();
                timer = 0;
                SpawnRateModifier();
            }
        }
    }

    void CloudMaker()
    {
        GameObject pipeObstacle = ObjectPool.SharedInstance.GetPooledObject();
        if (pipeObstacle != null)
        {
            pipeObstacle.transform.position = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),zOffSet);
            pipeObstacle.SetActive(true);
        }
    }

    void SpawnRateModifier()
    {
        spawnRate = (int)Random.Range(5f, 15f);
    }
}