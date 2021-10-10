using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject gameover;
    public BallController_P5 ball;

    private static GameOver _instance = null;
    public static GameOver Instance 
    { 
        get 
        { 
            if (_instance == null) 
            { 
                _instance = FindObjectOfType<GameOver> (); 
            } 
            return _instance; 
        } 
    }

    public void End(){
        gameover.SetActive(true);
        ball.enabled = false;
        Invoke("Reset", 3);
    }

    private void Reset() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
