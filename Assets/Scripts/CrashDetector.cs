using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float LoadingTime = 1f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool isCrashed = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground" && !isCrashed){
            isCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            Invoke("RestartScene", LoadingTime);
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
        }
    }

    void RestartScene(){
        SceneManager.LoadScene(0);
        isCrashed = false;
    }
}
