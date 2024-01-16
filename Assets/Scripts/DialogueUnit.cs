//Script written by Jorge Blanco 
//www.youtube.com/watch?v=wBFsA7rzNMQ&t=79s

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Dialogue
{
    [Serializable]
    public class DialogueUnit
    {
        //controls the state of the Dialogue. So a welcome message doesn't play next
        public string requiredStateKey;
        // The sentences available as part of this unity
        [TextArea(2, 5)]
        public string[] sentences;
        //The button options
        public DialogueOption[] options;
    }
}
