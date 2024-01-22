using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour
{
    public DialogueHandler dialogueHandler;
    public Animator animator;
    public GameStateObject gameStateObject;

    // Start is called before the first frame update
    public void OnInteract()
    {
        dialogueHandler.OnInteract();

        animator.SetTrigger("Sarcastic Head Nod");

        gameStateObject.SetState("InteractingWithNPC", true);
    }
}
