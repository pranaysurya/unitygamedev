//@author Pranay Surya
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 5;
    public float timer = 0;
    public float heightOffset = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer = timer + Time.deltaTime;
        }else
        {
            spawnPipe();
            timer = 0;
        }

        
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float hightestPoint = transform.position.y + heightOffset;


        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, hightestPoint), 0), transform.rotation);
    }
}
