using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCAnimationController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {

    }

    public void StartNodding(GameObject g)
    {
        Animator anim;
        anim = g.GetComponent<Animator>();
        anim.Play("Nodding");
    }
}