//Script written by Jorge Blanco 
//www.youtube.com/watch?v=wBFsA7rzNMQ&t=79s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using Helpers;
using UIElements;

namespace Dialogue
{
    public class DialogueHandler : MonoBehaviour
    {
        [SerializeField] private DialogueTreeObject DialogueTree;
        [SerializeField] private DialogueUI DialogueUI;
        [SerializeField] private UnityEvent onDialogueEnd;
        [SerializeField] private ScriptableEvent[] scriptableEvents;
        // Start is called before the first frame update
        void Start()
        {
            DialogueTree.ResetCallbacks();
            foreach(var scriptableEvent in scriptableEvents)
            {
                DialogueTree.RegisterScriptableCallback(
                    scriptableEvent.eventname,
                    () => scriptableEvent.unityEvent.Invoke());
            }

            DialogueTree.SetUpDialogueUnitsDict();
            DialogueTree.continueCallback += DialogueUI.ContinueDialogue;
            DialogueTree.continueCallback += ContinueDialogue;
            DialogueTree.endDialogueCallback += DialogueUI.EndDialogue;
            DialogueTree.endDialogueCallback += EndDialogue;

        }

        public void OnInteract(GameObject player)
        {
            var DialogueState = player.GetComponent<DialogueState>();
            if (DialogueState == null) return;

            DialogueTree.SetUpDialogueState(DialogueState);
            ContinueDialogue();

        }


        public void ContinueDialogue()
        {
            HandleDialogue(DialogueTree.GetNextDialogueUnit());
        }

        public void EndDialogue()
        {
            onDialogueEnd.Invoke();
        }

        public void HandleDialogue(DialogueUnit DialogueUnit)
        {
            //Get the UI fro mthe UI provider
            //Populate it

            DialogueUI.SetNpcName(DialogueTree.npcName);
            DialogueUI.SetSentences(DialogueUnit.sentences);
            DialogueUI.SetDialogueOptions(DialogueUnit.options, DialogueTree.defaultOption);
            DialogueUI.ContinueDialogue();
        }
    }
}
