using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Mainmenu(){
        SceneManager.LoadScene(0);
    }

    public void Problem_1(){
        SceneManager.LoadScene(1);
    }

    public void Problem_2(){
        SceneManager.LoadScene(2);
    }

    public void Problem_3(){
        SceneManager.LoadScene(3);
    }

    public void Problem_4(){
        SceneManager.LoadScene(4);
    }

    public void Problem_5(){
        SceneManager.LoadScene(5);
    }

    public void Problem_6(){
        SceneManager.LoadScene(6);
    }

    public void Problem_7(){
        SceneManager.LoadScene(7);
    }

    public void Problem_8(){
        SceneManager.LoadScene(8);
    }

    public void Problem_9(){
        SceneManager.LoadScene(9);
    }

    public void Exit(){
        Application.Quit();
    }
}
