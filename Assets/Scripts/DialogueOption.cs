//Script written by Jorge Blanco 
//www.youtube.com/watch?v=wBFsA7rzNMQ&t=79s

using System;
using System.Collections;
using UnityEngine.Events;


namespace Dialogue
{
    [Serializable]
    public class DialogueOption
    {
        public string buttonText;
        public UnityEvent actionTrigger;
    }
}
