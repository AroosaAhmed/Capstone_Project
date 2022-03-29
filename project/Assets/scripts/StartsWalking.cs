using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartsWalking : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            animator.SetTrigger("stillWalking");
        }
        if(Input.GetKey(KeyCode.A))
        {
            animator.SetTrigger("stillWalking");
        }
        if(Input.GetKey(KeyCode.D))
        {
            animator.SetTrigger("stillWalking");
        }
        if(Input.GetKey(KeyCode.S))
        {
            animator.SetTrigger("stillWalking");
        }
        else
        {
            animator.SetTrigger("stopWalking");
        }
        
    }
}
