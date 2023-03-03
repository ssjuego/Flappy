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
    // Start is called before the first frame update
    void Start()
    {
        CloudMaker();
    }

    // Update is called once per frame
    void Update()
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

    void CloudMaker()
    {
        float lowestPoint = transform.position.y - cloudOffSet;
        float highestPoint = transform.position.y + cloudOffSet;
        Instantiate(Cloud, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), zOffSet), transform.rotation);
    }

    void SpawnRateModifier()
    {
        spawnRate = (int)Random.Range(5f, 15f);
    }
}