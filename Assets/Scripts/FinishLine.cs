using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float LoadingTime = 1f;
    [SerializeField] ParticleSystem finishEffect;
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player"){
            finishEffect.Play();
            Invoke("RestartScene", LoadingTime);
            GetComponent<AudioSource>().Play();
        }
    }

    void RestartScene(){
        SceneManager.LoadScene(0);
    }
}
