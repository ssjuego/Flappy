using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] GameObject Pipes;          //
    [SerializeField] float spawnRate = 3;
    private float timer = 0;
    public float pipeOffSet = 5;
    private float lowestPoint = 0;
    private float highestPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        lowestPoint = transform.position.y - pipeOffSet;
        highestPoint = transform.position.y + pipeOffSet;
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
            PipeMaker();
            timer = 0;
        }
    }


    void PipeMaker()
    {
        GameObject pipeObstacle = ObjectPooler.SharedInstance.GetPooledObject();
        if (pipeObstacle != null)
        {
            pipeObstacle.transform.position = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint));
            pipeObstacle.SetActive(true);
        }
        
    }

  
}