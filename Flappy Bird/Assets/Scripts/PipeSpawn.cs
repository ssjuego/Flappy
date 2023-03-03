using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawn : MonoBehaviour
{
    [SerializeField] GameObject Pipes;
    [SerializeField] float spawnRate = 3;
    private float timer = 0;
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
        }
    }

    void PipeMaker()
    {
        Instantiate(Pipes, transform.position, transform.rotation);
    }
}