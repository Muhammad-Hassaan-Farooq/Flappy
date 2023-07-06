using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPipe : MonoBehaviour
{
    [SerializeField] private GameObject pipePrefab;
    [SerializeField] private float timeSpawn = 3f;
    private float timer = 0f;
    private float heightOffset = 10f;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > timeSpawn)
        {
            spawnPipe();
            timer = 0f;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    void spawnPipe()

    {
        float randomHeight = Random.Range(transform.position.y - heightOffset, transform.position.y + heightOffset);
        GameObject pipe = Instantiate(pipePrefab, new Vector3(transform.position.x, randomHeight, 0), Quaternion.identity);
    }
}
