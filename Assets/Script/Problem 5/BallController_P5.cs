using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController_P5 : MonoBehaviour
{
    public float speed = 10f;

    [Header("Control Type")]
    public bool useMouse;

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

        // Jika variabel useMouse bernilai false, 
        // maka kontrol bola akan menggunakan keyboard
        if(!useMouse)
            Move(x, y);
        else
            FollowMouse();
    }

    public void Move(float hor, float ver){
        movement.Set(hor, ver, 0f);

        movement = movement.normalized * speed * Time.deltaTime;

        ballRb.MovePosition(transform.position + movement);
    }

    // agar bola mengikuti mouse
    public void FollowMouse(){
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, speed * Time.deltaTime);
    }
}
