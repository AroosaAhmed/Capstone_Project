using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSoundWhenColideWithTree : MonoBehaviour
{
    
    AudioSource mySound;

    bool isObjectStillInsideColider = false;
    void OnTriggerEnter(Collider col)
    {
        isObjectStillInsideColider = true;
        if((this.gameObject.tag == "Player") && (isObjectStillInsideColider == true) && (col.gameObject.tag == "walls"))
        {
            mySound = GetComponent<AudioSource>();
            mySound.Play();
            movement.Lives--;
            
        }      
        
    }
    void OnTriggerStay(Collider col)
    {
        if((this.gameObject.tag == "Player") && (isObjectStillInsideColider == true) && (col.gameObject.tag == "walls"))
            mySound.loop = true;   
    }
    void OnTriggerExit(Collider col)
    {
        if((this.gameObject.tag == "Player") && (isObjectStillInsideColider == true) && (col.gameObject.tag == "walls"))
        {
            mySound.loop = false;
        }
        isObjectStillInsideColider = false;


    }
}
