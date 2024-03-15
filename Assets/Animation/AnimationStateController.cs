using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{

    Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey("g"))
        {
            animator.SetBool("isTalking", true);
        }

        if (!Input.GetKey("g"))
        {
            animator.SetBool("isTalking", false);
        }
    }
}
