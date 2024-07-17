using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1f;
    private float timer = 0;
    public float minHeight = -1;
    public float maxHeight = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
            timer += Time.deltaTime;
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        GameObject prefab = Instantiate(pipe, transform.position, Quaternion.identity);
        prefab.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
    }
}
