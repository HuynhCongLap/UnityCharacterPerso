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
    }
}
