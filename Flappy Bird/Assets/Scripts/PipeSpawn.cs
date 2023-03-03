using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] GameObject Pipes;          //
    [SerializeField] float spawnRate = 3;
    private float timer = 0;
    [SerializeField] float pipeOffSet = 5;
    // Start is called before the first frame update
    void Start()
    {
        PipeMaker();
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
            PipeOffsetModifier();
        }
    }

    void PipeMaker()
    {
        float lowestPoint = transform.position.y - pipeOffSet;
        float highestPoint = transform.position.y + pipeOffSet;
        Instantiate(Pipes, new Vector3(transform.position.x, Random.Range(lowestPoint,highestPoint)), transform.rotation);
    }

    void PipeOffsetModifier()
    {
        pipeOffSet = (int)Random.Range(2f, 6f);
    }
}