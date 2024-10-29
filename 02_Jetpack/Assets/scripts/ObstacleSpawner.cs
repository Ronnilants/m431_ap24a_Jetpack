using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject bottomObstaclePrefab;  
    public GameObject topObstaclePrefab;     
    public float spawnRate = 2f;             
    public float minY = -2f;                
    public float maxY = 2f;                 
    public float gap = 2.5f;                 

    // starts spawning obstacle repeatedly after 1 second
    void Start()
    {
        InvokeRepeating("SpawnObstaclePair", 1f, spawnRate);
    }
    // Spawns a pair of obstacles at a random vertical position
    void SpawnObstaclePair()
    {
        float randomY = Random.Range(minY, maxY);
        Vector3 bottomPosition = new Vector3(transform.position.x, randomY, 0);
        Vector3 topPosition = new Vector3(transform.position.x, randomY + gap + Mathf.Abs(minY), 0);
        Instantiate(bottomObstaclePrefab, bottomPosition, Quaternion.identity);
        Instantiate(topObstaclePrefab, topPosition, Quaternion.identity);
    }
}
