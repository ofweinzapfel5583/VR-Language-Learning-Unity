//Script written by Jorge Blanco 
//www.youtube.com/watch?v=wBFsA7rzNMQ&t=79s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Dialogue
{
    [CreateAssetMenu(fileName ="DialogueTree", menuName ="ScriptableObjects/Dialogue Tree")]

    public class DialogueTreeObject : ScriptableObject
    {
        public string npcName;
        //The first time we interact with the NPC
        public string defaultState;
        //Default option
        public DialogueOption defaultOption;
        //Array of strings for callabck
        public string[] scriptableCallbackNames;
        public DialogueUnit[] DialogueUnits;

        //Non-editor class members
        public DialogueState DialogueState;
        public Action continueCallback;
        public Action endDialogueCallback;
        public Dictionary<string, DialogueUnit> DialogueUnitDictionary;
        public Dictionary<string, Action> scriptableCallbacks = new Dictionary<string, Action>();

        public void AddToState(string stateToAdd)
        {
            DialogueState.stateDictionary[npcName] += stateToAdd;
        }

        public void RemoveState(int length = 1)
        {
            if (DialogueState.stateDictionary[npcName].Length < length)
            {
                return;
            }
            DialogueState.stateDictionary[npcName] = DialogueState.stateDictionary[npcName].Remove(
                DialogueState.stateDictionary[npcName].Length - length);
        }

        public void ResetState(string newState)
        {
            DialogueState.stateDictionary[npcName] = newState;
        }

        //This handles all of the actions.
        public void CallScriptableAction(string actionName)
        {
            scriptableCallbacks[actionName]();
        }

        public void Continue()
        {
            continueCallback();
        }

        public void EndDialogue()
        {
            endDialogueCallback();
        }

        public void RegisterScriptableCallback(string callbackName, Action action)
        {
            scriptableCallbacks[callbackName] = action;
        }

        public void SetUpDialogueUnitsDict()
        {
            DialogueUnitDictionary = new Dictionary<string, DialogueUnit>();
            foreach(var DialogueUnit in DialogueUnits)
            {
                DialogueUnitDictionary[DialogueUnit.requiredStateKey] = DialogueUnit;
            }
        }

        public void SetUpDialogueState(DialogueState state)
        {
            DialogueState = state;
            if (!DialogueState.stateDictionary.ContainsKey(npcName))
            {
                DialogueState.stateDictionary[npcName] = defaultState;
            }

        }

        public void ResetCallbacks()
        {
            continueCallback = () => { };
            endDialogueCallback = () => { };
            scriptableCallbacks.Clear();
        }

        public DialogueUnit GetNextDialogueUnit()
        {
            return DialogueUnitDictionary.TryGetValue(DialogueState.stateDictionary[npcName], out var value) ? value : null;
        }
    }
}


