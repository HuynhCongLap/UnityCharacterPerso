using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeController : MonoBehaviour
{
    Animator myAnimator;

    void Start()
    {
        myAnimator = GetComponent<Animator>();
        Debug.Log("MyAniConScript: start => Animator");
    }

    // Update is called once per frame
    void Update()
    {
        
        myAnimator.SetFloat("VSpeed", Input.GetAxis("Vertical"));
        myAnimator.SetFloat("HSpeed", Input.GetAxis("Horizontal"));

        if (Input.GetKeyDown(KeyCode.J)) myAnimator.SetTrigger("isJumping"); // Press J to jump

        if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) // is moving
        {
            myAnimator.SetBool("isMoving", true);
        }
        else
        {
            myAnimator.SetBool("isMoving", false);
        }
  
    }
}
