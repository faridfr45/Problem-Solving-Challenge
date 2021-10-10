using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    private static ScoreManager _instance = null;
    public static ScoreManager Instance 
    { 
        get 
        { 
            if (_instance == null) 
            { 
                _instance = FindObjectOfType<ScoreManager> (); 
            } 
            return _instance; 
        } 
    } 

    public Text scoreText;
    private float score = 0f;

    private void Start() {
        scoreText.text = $"Skor : {score}";
    }

    public void AddScore(){
        score++;
        scoreText.text = $"Skor : {score}";
    }
}
