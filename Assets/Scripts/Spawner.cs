using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnGameObject;
    public float spawnTimeMin = 1;
    public float spawnTimeMax = 3;

    float spawnTimer = 0;

	private void Start()
	{
        spawnTimer = Random.Range(spawnTimeMin, spawnTimeMax);
	}

	void Update()
    {
        //transform.childCount
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
		{
            spawnTimer = Random.Range(spawnTimeMin, spawnTimeMax);
            Instantiate(spawnGameObject, transform.position, transform.rotation, transform);
		}
    }
}
