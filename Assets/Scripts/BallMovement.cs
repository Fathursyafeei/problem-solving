using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rigidbody2D;

    public float speed = 10f;
    public float xForce;
    public float yForce;

    float horizontal;
    float vertical;

    public ScoreController score;



    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    void PushBall()
    {
        float arahRandom = Random.Range(0, 2);
        if (arahRandom < 1.0f)
        {
            rigidbody2D.AddForce(new Vector2(-xForce, -yForce));
        }
        else
        {
            rigidbody2D.AddForce(new Vector2(xForce, -yForce));
        }
        
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

    }

    private void FixedUpdate()
    {
        PushBall();
        rigidbody2D.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            score.IncrementScore();
            Destroy(collision.gameObject);
            
        }
        if(collision.gameObject.tag == "Border")
        {
            transform.localScale += new Vector3(-0.1f, -0.1f, -0.1f);
            score.DecrementScore();
            
        }
    }

}
