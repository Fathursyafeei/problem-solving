using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;


    public float speed = 10f;
    public float xForce;
    public float yForce;

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void PushBall()
    {
        float arahRandom = Random.Range(0, 2);
        if (arahRandom < 1.0f)
        {
            rigidbody2D.AddForce(new Vector2(-xForce, yForce));
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(xForce, -yForce));
        }
        Debug.Log(arahRandom);
    }

    private void FixedUpdate()
    {
        PushBall();
        //float randomDirection = Random.Range(0, 2);
        //rigidbody2D.velocity = new Vector2(randomDirection * speed, randomDirection * speed);
    }
}
