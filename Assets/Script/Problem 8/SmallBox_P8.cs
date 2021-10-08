using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBox_P8 : MonoBehaviour
{
    private void OnDisable() {
        Invoke("SpawnRandom", 3);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Player"){

            this.gameObject.SetActive(false);
            ScoreManager.Instance.AddScore();
        }
    }

    private void SpawnRandom(){
        float randomX, randomY;
        Vector3 newPos;
        bool spawned = false;
        GameObject ball = GameObject.FindGameObjectWithTag("Player");

        // saya menggunakan while untuk spawn box
        while(!spawned){
            randomX = Random.Range(-7, 7);
            randomY = Random.Range(-4, 4);

            newPos = new Vector3(randomX, randomY, 0f);
            this.transform.position = newPos;

            // jika posisi smallBox terlalu dekat ataupun didalam lingkaran
            // maka posisi yang baru akan dicari
            if((transform.position - ball.transform.position).magnitude < 2){
                continue;
            }else{
                spawned = true;
            }
        }
        this.gameObject.SetActive(true);
    }

}
