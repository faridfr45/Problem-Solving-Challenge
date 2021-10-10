using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
    public GameObject menu;
    public GameObject levelSelect;

    public void Play(){
        menu.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void Back(){
        menu.SetActive(true);
        levelSelect.SetActive(false);
    }
}
