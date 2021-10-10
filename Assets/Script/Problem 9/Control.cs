using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    public BallController_P5 ball;
    public GameObject Keyboard;
    public GameObject Mouse;

    public void UseMouse(){
        Mouse.SetActive(true);
        Keyboard.SetActive(false);
        ball.useMouse = true;
    }

    public void UseKB(){
        Mouse.SetActive(false);
        Keyboard.SetActive(true);
        ball.useMouse = false;
    }
}
