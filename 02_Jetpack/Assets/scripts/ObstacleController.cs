using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Moves obstacles left and destroys them once they are far enough behind the player
public class ObstacleController : MonoBehaviour
{
    public float obstacleSpeed = 2f;
    public float removalDistance = 5f; 
    private Transform player;

    // Called once at the start to find the player
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Called once per frame to move the obstacle and check if it should be destroyed
    void Update()
    {
        transform.position += Vector3.left * obstacleSpeed * Time.deltaTime;

        if (transform.position.x < player.position.x - removalDistance)
        {
            Destroy(gameObject);
        }
    }
}
