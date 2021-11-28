using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    public GameObject enemigo;

    public float spawnTime;
    public float spawnTimeRandom;

    private float spawnTimer;
    private UnityEngine.AI.NavMeshAgent nav;
    public Transform target;
    private Vector3 location;

    void Start()
    {
        enemigo = GameObject.FindGameObjectWithTag("enemigo");
        Vector3 location = new Vector3(5, 1, 23);

        ResetSpawnTimer();
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        target = GameObject.FindGameObjectWithTag("numero 1").transform;
        if (spawnTime <= 0.0f)
        {
            Instantiate(enemigo, location, Quaternion.identity);

            ResetSpawnTimer();
        }
    }

    void ResetSpawnTimer()
    {
        spawnTimer = (float)(spawnTime + Random.Range(0, spawnTimeRandom * 100) / 100.0);
    }
}
