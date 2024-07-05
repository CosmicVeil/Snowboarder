using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem trailEffect;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground"){
            trailEffect.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if(other.gameObject.tag == "Ground"){
            trailEffect.Stop();
        }
    }
}
