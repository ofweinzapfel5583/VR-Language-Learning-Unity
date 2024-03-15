using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationController : MonoBehaviour
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
            animator.SetBool("isNodding", true);
        }

        if (!Input.GetKey("g"))
        {
            animator.SetBool("isNodding", false);
        }
    }
}
