using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        PushBall();
    }

    // Bola akan bergerak ke arah yang random dengan kecepatan yang konstan
    void PushBall(){
        float x = Random.Range(-100, 100);
        float y = Random.Range(-100, 100);

        rb.AddForce(new Vector2(x, y).normalized * 50);
    }
}
