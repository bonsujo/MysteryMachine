using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateConroller : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forwardPressed = Input.GetKey("w");
        bool jumpPressed = Input.GetKey("j");
        bool isRunning = anim.GetBool("isRunning");
        bool isJumping = anim.GetBool("isJumping");
        //if player presses key
        if (!isRunning && forwardPressed)
        {
            anim.SetBool("isRunning", true);
        }

        if (isRunning && !forwardPressed)
        {
            anim.SetBool("isRunning", false);
        }

        if (!isJumping && (forwardPressed && jumpPressed))
        {
            anim.SetBool("isJumping", true);
        }
        if (isJumping && (!forwardPressed || !jumpPressed))
        {
            anim.SetBool("isJumping", false);
        }
    }

    
}
