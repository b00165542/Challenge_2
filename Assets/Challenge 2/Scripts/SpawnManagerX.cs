using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    public float timer;

    private float minTime = 1.5f;
    private float maxTime = 6.0f;
    public float spawnTimeInterval;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimeInterval = Random.Range(minTime, maxTime);
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnTimeInterval)
        {
            // Call function to spawn a random ball
            SpawnRandomBall();

            // Reset timer and spawn interval
            spawnTimeInterval = Random.Range(minTime, maxTime);
            timer = 0.0f;
        }
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Generate random ball index
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        // Instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}

