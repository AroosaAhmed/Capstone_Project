using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEatenIncreaseScore : MonoBehaviour
{
    public AudioSource catVoice;
    void OnTriggerEnter(Collider other)
    {
        movement.Score++;
        catVoice.Play();
        Destroy(gameObject);
    }
    
}
