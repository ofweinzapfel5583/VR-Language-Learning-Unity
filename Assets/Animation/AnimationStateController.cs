using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }

    public void StartTalking(GameObject g)
    {
        Animator anim;
        anim = g.GetComponent<Animator>();
        anim.Play("Talking");
    }
}
