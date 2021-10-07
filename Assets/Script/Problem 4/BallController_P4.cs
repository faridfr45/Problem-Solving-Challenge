using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController_P4 : MonoBehaviour
{
    public float speed;

    Rigidbody2D ballRb;
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Move(x, y);
    }

    public void Move(float hor, float ver){
        movement.Set(hor, ver, 0f);

        movement = movement.normalized * speed * Time.deltaTime;

        ballRb.MovePosition(transform.position + movement);
    }
}
