using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject smallBox;
    public float min = 1f;
    public float max = 10f;

    private void Start() {
        Spawn(min, max);
    }

    public void Spawn(float min, float max){
        float random = Random.Range(min, max);
        float randomX, randomY;
        Vector3 pos;

        for(int i = 0; i < random; i++){
            randomX = Random.Range(-7, 7);
            randomY = Random.Range(-4, 4);

            pos = new Vector3(randomX, randomY, 0f);
            GameObject tes = Instantiate(smallBox, pos, transform.rotation, this.transform);
        }
    }
}
