using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JetpackController : MonoBehaviour
{
    public float jetpackBoost = 5f;
    private Rigidbody2D rb; 
    private bool isDead = false; 

    // Start gravity when the game starts
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 1;
    }
    // Boost with the jetpack on mouse click or spacebar press
    void Update()
    {
        if ((Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space)) && !isDead)
        {
            ActivateJetpack();
        }
    }

    // Reset velocity for a consistent boost
    void ActivateJetpack()
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(Vector2.up * jetpackBoost, ForceMode2D.Impulse);
    }
    // If the rider hits something, mark them as dead
    void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        rb.velocity = Vector2.zero;
    }
}
