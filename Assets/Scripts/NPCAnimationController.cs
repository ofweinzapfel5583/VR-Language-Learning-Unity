using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationController : MonoBehaviour
{
    public Animator animator; // Drag the Animator component reference here in the Inspector

    // Method to trigger the animation
    public void PlayThoughtfulHeadNodAnimation()
    {
        animator.SetTrigger("ThoughtfulHeadNod"); // Assuming "ThoughtfulHeadNod" is the animation trigger name
    }
}
