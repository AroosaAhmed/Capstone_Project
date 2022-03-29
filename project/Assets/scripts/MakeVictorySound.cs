using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakeVictorySound : MonoBehaviour
{
     AudioSource VictorySound;
    void OnTriggerEnter(Collider col)
    {
        if((col.gameObject.tag == "Player") && (this.gameObject.tag == "Finish"))
        {
            VictorySound = transform.GetComponent<AudioSource>();
            VictorySound.Play();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
    }
}
