using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;


    public float speed = 10f;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float randomDirection = Random.Range(0, 2);
        rigidbody2D.velocity = new Vector2(randomDirection * speed, randomDirection * speed);
    }
}
